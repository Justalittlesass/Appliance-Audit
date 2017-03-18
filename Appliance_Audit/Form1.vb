
'Appliance Audit Program
'Calculates the amount of power and water used by specific appliances in daily, monthly, and yearly use
'Stores and exports the cost of the list of appliances to a text file
'Can import appliance power requirements
Imports System.IO

Public Class Appliance_Audit
    Dim Total As Single
    Dim PowerReq As Single
    Dim PwrReq As Single
    Dim PwrCst As Single
    Dim Input1 As String
    Dim Input2 As String
    Dim Input3 As String
    Dim App As String
    Dim AppIn As Integer
    Dim WtrHrs As Single
    Dim WtrCst As Single
    Dim Monthly As Single
    Dim Yearly As Single

    'Sets default KiloWatts per hour
    Dim Values() As String = {"0.51", "1.3", "1.75", "2.0", "3.5", "4.75", "5.2", "4.6"}
    'Sets appliance names
    Dim Applyances() As String = {"Refrigerator", "Television", "Space Heater", "Fan", "Dryer", "Oven", "Washing Machine", "Dishwasher"}
    Dim result As New ArrayList()

    Public Class Appliance
        Public Property Hours As Single
        Public Property Name As String
        Public Property Cost As Single
        Public Property Month As Single
        Public Property Year As Single

        Public Overrides Function ToString() As String

            Return String.Format("{0, -18}   -   {1,6}   -   {2,-18:C}   -   {3,15:C}   -   {4,-15:C}", Name, Hours, Cost, Month, Year)
        End Function
    End Class

    'Deals with the dropdown list of appliances
    Public Sub Appliances_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Appliances.SelectedIndexChanged
        App = Appliances.SelectedItem
        Appliance_Nm.Text = "For " & App
        AppIn = Appliances.SelectedIndex

        'If the appliance is a water based appliance, displays water options
        If AppIn > 5 Then
            Wtr.Show()
            Wtr_Cst.Show()
            Wtr_Hrs.Show()
            Wtr_Cts.Show()
            Wtr_Hr.Show()
        End If

        'If water options are displayed, hides for non-water based options
        If AppIn < 5 Then
            Wtr.Hide()
            Wtr_Cst.Hide()
            Wtr_Hrs.Hide()
            Wtr_Cts.Hide()
            Wtr_Hr.Hide()
        End If

        'Calculates the cost based on the changed appliance information
        If AppIn >= 0 And AppIn < 9 Then
            Pwr_Req.Text = Values(AppIn)
            PowerReq = Values(AppIn)
            Total = (PowerReq * PwrReq * PwrCst)
            Monthly = Total * 30
            Yearly = Total * 365
            App_Cst.Text = "is " & Format(Total, "C")
            Mnthly_Cst.Text = "is " & Format(Monthly, "C")
            Yrly_Cst.Text = "is " & Format(Yearly, "C")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    'When a file is dragged into the window, reads from the file and copies the information in the file
    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop


        Try
            'Takes the information from the file and reads them into a string array
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
                For Each path In files
                    Dim lovely As String = path
                    Dim SR As StreamReader = New StreamReader(lovely)
                    Dim lime As String
                    Dim i As Integer = 0
                    Dim alllines As String() = File.ReadAllLines(lovely)
                    Dim j As Integer = 0





                    'Separates the string array and feeds each entry into a value place
                    While i < 8 And j < 8
                        Dim linetwo As String = alllines(j)
                        lime = SR.ReadLine
                        Console.WriteLine(lime)
                        Values.SetValue(linetwo, i)
                        i = i + 1
                        j = j + 1
                    End While
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    'Only allows numerics and decimals in the textbox
    Private Sub Pwr_Req_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pwr_Req.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 47 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Calculates the cost once the text has been changed for the power required in KiloWatts per hour
    Private Sub Pwr_Req_TextChanged(sender As Object, e As EventArgs) Handles Pwr_Req.TextChanged
        Total = (PowerReq * PwrReq * PwrCst)
        Monthly = Total * 30
        Yearly = Total * 365
        Input1 = Pwr_Req.Text
        If Not Single.TryParse(Input1, PowerReq) Then
            App_Cst.Text = "Please Enter Power Requirements"
        End If
        App_Cst.Text = "is " & Format(Total, "C")
        Mnthly_Cst.Text = "is " & Format(Monthly, "C")
        Yrly_Cst.Text = "is " & Format(Yearly, "C")



    End Sub


    Private Sub Pwr_Cst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pwr_Cst.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 47 And Asc(e.KeyChar) <> 47 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Calculates the cost once the text has been changed for the Cost ($/KwH)
    Private Sub Pwr_Cst_TextChanged(sender As Object, e As EventArgs) Handles Pwr_Cst.TextChanged
        Input3 = Pwr_Cst.Text
        Total = (PowerReq * PwrReq * PwrCst)
        Monthly = Total * 30
        Yearly = Total * 365
        If Not Single.TryParse(Input3, PwrCst) Then
            App_Cst.Text = "Please Enter Power Cost"
        End If
        App_Cst.Text = "is " & Format(Total, "C")
        Mnthly_Cst.Text = "is " & Format(Monthly, "C")
        Yrly_Cst.Text = "is " & Format(Yearly, "C")
    End Sub

    Private Sub Hrs_Use_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Hrs_Use.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 47 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Calculates the cost once the text has been changes for the Hours Used
    Private Sub Hrs_Use_TextChanged(sender As Object, e As EventArgs) Handles Hrs_Use.TextChanged

        Input2 = Hrs_Use.Text

        If Not Single.TryParse(Input2, PwrReq) Then
            App_Cst.Text = "Please Enter Number of Hours Used"
        End If

        Total = (PowerReq * PwrReq * PwrCst)
        Monthly = Total * 30
        Yearly = Total * 365
        If PwrReq <= 24 Then
            App_Cst.Text = "is " & Format(Total, "C")
            Mnthly_Cst.Text = "is " & Format(Monthly, "C")
            Yrly_Cst.Text = "is " & Format(Yearly, "C")
        ElseIf PwrReq >= 24 Then
            App_Cst.Text = "Hours must be less than 24"
        End If


    End Sub

    'Resets all of the values to the defaults
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Pwr_Req.Text = "0"
        Hrs_Use.Text = "0"
        App_Cst.Text = ""
        Appliances.SelectedIndex = -1
        Appliance_Nm.Text = ""
        Pwr_Cst.Text = "0"
        Wtr_Hr.Text = "0"
        Wtr_Cts.Text = "0"
        Sum_Ttl.Items.Clear()
        Wtr.Hide()
        Wtr_Cst.Hide()
        Wtr_Hrs.Hide()
        Wtr_Cts.Hide()
        Wtr_Hr.Hide()
        Dim Values() As String = {"0.51", "1.3", "1.75", "2.0", "3.5", "4.75", "5.2", "4.6"}

    End Sub

    'Adds the information to the listbox
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim Entry = New Appliance With {.Name = App, .Cost = Total, .Hours = PwrReq, .Month = Monthly, .Year = Yearly}
        Sum_Ttl.Items.Add(Entry)
    End Sub

    Private Sub Wtr_Hr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Wtr_Hr.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 47 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Calculates the total when the hours used changes in the water based appliance section
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Wtr_Hr.TextChanged
        WtrHrs = Wtr_Hr.Text

        Total = Total + (WtrHrs * WtrCst)
        App_Cst.Text = "is " & Format(Total, "C")
        Mnthly_Cst.Text = "is " & Format(Monthly, "C")
        Yrly_Cst.Text = "is " & Format(Yearly, "C")
    End Sub
    Private Sub Wtr_Cts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Wtr_Cts.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 57 And Asc(e.KeyChar) <> 47 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Calculates the cost once the Cost per Gallon is changed in the water section
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Wtr_Cts.TextChanged
        WtrCst = Wtr_Cts.Text

        Total = Total + (WtrHrs * WtrCst * PwrReq)
        Monthly = Total * 30
        Yearly = Total * 365
        App_Cst.Text = "is " & Format(Total, "C")
        Mnthly_Cst.Text = "is " & Format(Monthly, "C")
        Yrly_Cst.Text = "is " & Format(Yearly, "C")
    End Sub

    Private Sub Sum_Ttl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sum_Ttl.SelectedIndexChanged

    End Sub


    'Exports the listbox information to a text file
    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim saveFileDialog1 As New SaveFileDialog()



        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = "Last_First.txt"



        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim Streamy As StreamWriter = New StreamWriter(saveFileDialog1.FileName)

            For Each o As Object In Sum_Ttl.Items
                Streamy.WriteLine(o.ToString())
            Next
            Streamy.Flush()
            Streamy.Close()
        End If

    End Sub

    'Creates a message box displaying the default values for each appliance
    Private Sub View_Pwr_Click(sender As Object, e As EventArgs) Handles View_Pwr.Click
        Dim Mssg As String
        Dim Mewmew As String = " "
        Dim i As Integer = 0

        While i < 8
            Mssg = Applyances(i) & "=" & Values(i) & Environment.NewLine
            i = i + 1
            Mewmew = Mewmew.Insert(0, Mssg)

        End While


        MsgBox(Mewmew)

    End Sub




End Class
