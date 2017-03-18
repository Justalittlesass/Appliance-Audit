<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appliance_Audit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Appliances = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pwr_Req = New System.Windows.Forms.TextBox()
        Me.Hrs_Use = New System.Windows.Forms.TextBox()
        Me.App_Cst = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Pwr_Cst = New System.Windows.Forms.TextBox()
        Me.Sum_Ttl = New System.Windows.Forms.ListBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Appl_Cst_Bx = New System.Windows.Forms.GroupBox()
        Me.Wtr_Cst = New System.Windows.Forms.Label()
        Me.Wtr_Hrs = New System.Windows.Forms.Label()
        Me.Wtr_Cts = New System.Windows.Forms.TextBox()
        Me.Wtr_Hr = New System.Windows.Forms.TextBox()
        Me.Wtr = New System.Windows.Forms.Label()
        Me.Export = New System.Windows.Forms.Button()
        Me.View_Pwr = New System.Windows.Forms.Button()
        Me.Appliance_Nm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Yrly_Cst = New System.Windows.Forms.Label()
        Me.Mnthly_Cst = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Appl_Cst_Bx.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Appliances
        '
        Me.Appliances.AllowDrop = True
        Me.Appliances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Appliances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Appliances.FormattingEnabled = True
        Me.Appliances.Items.AddRange(New Object() {"Refrigerator", "Television", "Space Heater", "Fan", "Dryer", "Oven", "Washing Machine", "Dishwasher"})
        Me.Appliances.Location = New System.Drawing.Point(81, 22)
        Me.Appliances.Name = "Appliances"
        Me.Appliances.Size = New System.Drawing.Size(181, 21)
        Me.Appliances.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Appliances:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Power Required (kW/H):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hours Used Per Day:"
        '
        'Pwr_Req
        '
        Me.Pwr_Req.Location = New System.Drawing.Point(211, 51)
        Me.Pwr_Req.Name = "Pwr_Req"
        Me.Pwr_Req.Size = New System.Drawing.Size(51, 20)
        Me.Pwr_Req.TabIndex = 4
        Me.Pwr_Req.Text = "0"
        '
        'Hrs_Use
        '
        Me.Hrs_Use.Location = New System.Drawing.Point(211, 123)
        Me.Hrs_Use.Name = "Hrs_Use"
        Me.Hrs_Use.Size = New System.Drawing.Size(51, 20)
        Me.Hrs_Use.TabIndex = 5
        Me.Hrs_Use.Text = "0"
        '
        'App_Cst
        '
        Me.App_Cst.AutoSize = True
        Me.App_Cst.Location = New System.Drawing.Point(84, 46)
        Me.App_Cst.Name = "App_Cst"
        Me.App_Cst.Size = New System.Drawing.Size(37, 13)
        Me.App_Cst.TabIndex = 7
        Me.App_Cst.Text = " $0.00"
        '
        'Reset
        '
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Reset.Location = New System.Drawing.Point(220, 349)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cost ($/KwH)"
        '
        'Pwr_Cst
        '
        Me.Pwr_Cst.Location = New System.Drawing.Point(211, 88)
        Me.Pwr_Cst.Name = "Pwr_Cst"
        Me.Pwr_Cst.Size = New System.Drawing.Size(51, 20)
        Me.Pwr_Cst.TabIndex = 11
        Me.Pwr_Cst.Text = "0"
        '
        'Sum_Ttl
        '
        Me.Sum_Ttl.FormattingEnabled = True
        Me.Sum_Ttl.Location = New System.Drawing.Point(342, 38)
        Me.Sum_Ttl.Name = "Sum_Ttl"
        Me.Sum_Ttl.Size = New System.Drawing.Size(430, 407)
        Me.Sum_Ttl.TabIndex = 12
        '
        'Add
        '
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add.Location = New System.Drawing.Point(220, 320)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 13
        Me.Add.Text = "Add to List"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Appl_Cst_Bx
        '
        Me.Appl_Cst_Bx.Controls.Add(Me.Wtr_Cst)
        Me.Appl_Cst_Bx.Controls.Add(Me.Wtr_Hrs)
        Me.Appl_Cst_Bx.Controls.Add(Me.Wtr_Cts)
        Me.Appl_Cst_Bx.Controls.Add(Me.Wtr_Hr)
        Me.Appl_Cst_Bx.Controls.Add(Me.Wtr)
        Me.Appl_Cst_Bx.Controls.Add(Me.Label1)
        Me.Appl_Cst_Bx.Controls.Add(Me.Appliances)
        Me.Appl_Cst_Bx.Controls.Add(Me.Pwr_Cst)
        Me.Appl_Cst_Bx.Controls.Add(Me.Label2)
        Me.Appl_Cst_Bx.Controls.Add(Me.Label7)
        Me.Appl_Cst_Bx.Controls.Add(Me.Label3)
        Me.Appl_Cst_Bx.Controls.Add(Me.Pwr_Req)
        Me.Appl_Cst_Bx.Controls.Add(Me.Hrs_Use)
        Me.Appl_Cst_Bx.Location = New System.Drawing.Point(12, 12)
        Me.Appl_Cst_Bx.Name = "Appl_Cst_Bx"
        Me.Appl_Cst_Bx.Size = New System.Drawing.Size(283, 289)
        Me.Appl_Cst_Bx.TabIndex = 14
        Me.Appl_Cst_Bx.TabStop = False
        Me.Appl_Cst_Bx.Text = "Appliance Costs"
        '
        'Wtr_Cst
        '
        Me.Wtr_Cst.AutoSize = True
        Me.Wtr_Cst.Location = New System.Drawing.Point(25, 262)
        Me.Wtr_Cst.Name = "Wtr_Cst"
        Me.Wtr_Cst.Size = New System.Drawing.Size(80, 13)
        Me.Wtr_Cst.TabIndex = 16
        Me.Wtr_Cst.Text = "Cost Per Gallon"
        Me.Wtr_Cst.Visible = False
        '
        'Wtr_Hrs
        '
        Me.Wtr_Hrs.AutoSize = True
        Me.Wtr_Hrs.Location = New System.Drawing.Point(22, 214)
        Me.Wtr_Hrs.Name = "Wtr_Hrs"
        Me.Wtr_Hrs.Size = New System.Drawing.Size(80, 13)
        Me.Wtr_Hrs.TabIndex = 15
        Me.Wtr_Hrs.Text = "Water per Hour"
        Me.Wtr_Hrs.Visible = False
        '
        'Wtr_Cts
        '
        Me.Wtr_Cts.Location = New System.Drawing.Point(211, 255)
        Me.Wtr_Cts.Name = "Wtr_Cts"
        Me.Wtr_Cts.Size = New System.Drawing.Size(51, 20)
        Me.Wtr_Cts.TabIndex = 14
        Me.Wtr_Cts.Text = "0"
        Me.Wtr_Cts.Visible = False
        '
        'Wtr_Hr
        '
        Me.Wtr_Hr.Location = New System.Drawing.Point(211, 213)
        Me.Wtr_Hr.Name = "Wtr_Hr"
        Me.Wtr_Hr.Size = New System.Drawing.Size(51, 20)
        Me.Wtr_Hr.TabIndex = 13
        Me.Wtr_Hr.Text = "0"
        Me.Wtr_Hr.Visible = False
        '
        'Wtr
        '
        Me.Wtr.AutoSize = True
        Me.Wtr.Enabled = False
        Me.Wtr.Location = New System.Drawing.Point(19, 173)
        Me.Wtr.Name = "Wtr"
        Me.Wtr.Size = New System.Drawing.Size(158, 13)
        Me.Wtr.TabIndex = 12
        Me.Wtr.Text = "Water Based Appliance Options"
        Me.Wtr.Visible = False
        '
        'Export
        '
        Me.Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Export.Location = New System.Drawing.Point(220, 422)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(75, 23)
        Me.Export.TabIndex = 15
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'View_Pwr
        '
        Me.View_Pwr.Location = New System.Drawing.Point(220, 393)
        Me.View_Pwr.Name = "View_Pwr"
        Me.View_Pwr.Size = New System.Drawing.Size(75, 23)
        Me.View_Pwr.TabIndex = 16
        Me.View_Pwr.Text = "View kW/h"
        Me.View_Pwr.UseVisualStyleBackColor = True
        '
        'Appliance_Nm
        '
        Me.Appliance_Nm.AutoSize = True
        Me.Appliance_Nm.Location = New System.Drawing.Point(14, 20)
        Me.Appliance_Nm.Name = "Appliance_Nm"
        Me.Appliance_Nm.Size = New System.Drawing.Size(25, 13)
        Me.Appliance_Nm.TabIndex = 8
        Me.Appliance_Nm.Text = " For"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Daily Cost:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Yrly_Cst)
        Me.GroupBox1.Controls.Add(Me.Mnthly_Cst)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.App_Cst)
        Me.GroupBox1.Controls.Add(Me.Appliance_Nm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costs"
        '
        'Yrly_Cst
        '
        Me.Yrly_Cst.AutoSize = True
        Me.Yrly_Cst.Location = New System.Drawing.Point(87, 95)
        Me.Yrly_Cst.Name = "Yrly_Cst"
        Me.Yrly_Cst.Size = New System.Drawing.Size(34, 13)
        Me.Yrly_Cst.TabIndex = 14
        Me.Yrly_Cst.Text = "$0.00"
        '
        'Mnthly_Cst
        '
        Me.Mnthly_Cst.AutoSize = True
        Me.Mnthly_Cst.Location = New System.Drawing.Point(87, 69)
        Me.Mnthly_Cst.Name = "Mnthly_Cst"
        Me.Mnthly_Cst.Size = New System.Drawing.Size(34, 13)
        Me.Mnthly_Cst.TabIndex = 13
        Me.Mnthly_Cst.Text = "$0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Yearly Cost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Monthly Cost:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(382, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Appliance Name    -    Hours    -    Daily Cost    -    Monthly Cost    -    Year" & _
    "ly Cost"
        '
        'Appliance_Audit
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 463)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.View_Pwr)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Sum_Ttl)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Appl_Cst_Bx)
        Me.Name = "Appliance_Audit"
        Me.ShowIcon = False
        Me.Text = "Appliance Audit "
        Me.Appl_Cst_Bx.ResumeLayout(False)
        Me.Appl_Cst_Bx.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Appliances As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pwr_Req As System.Windows.Forms.TextBox
    Friend WithEvents Hrs_Use As System.Windows.Forms.TextBox
    Friend WithEvents App_Cst As System.Windows.Forms.Label
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Pwr_Cst As System.Windows.Forms.TextBox
    Friend WithEvents Sum_Ttl As System.Windows.Forms.ListBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Appl_Cst_Bx As System.Windows.Forms.GroupBox
    Friend WithEvents Wtr As System.Windows.Forms.Label
    Friend WithEvents Wtr_Cst As System.Windows.Forms.Label
    Friend WithEvents Wtr_Hrs As System.Windows.Forms.Label
    Friend WithEvents Wtr_Cts As System.Windows.Forms.TextBox
    Friend WithEvents Wtr_Hr As System.Windows.Forms.TextBox
    Friend WithEvents Export As System.Windows.Forms.Button
    Friend WithEvents View_Pwr As System.Windows.Forms.Button
    Friend WithEvents Appliance_Nm As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Yrly_Cst As System.Windows.Forms.Label
    Friend WithEvents Mnthly_Cst As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
