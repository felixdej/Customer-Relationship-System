<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCustomerNumber = New System.Windows.Forms.ComboBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_LastName = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtxt_phoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Number:"
        '
        'CboCustomerNumber
        '
        Me.CboCustomerNumber.FormattingEnabled = True
        Me.CboCustomerNumber.Location = New System.Drawing.Point(114, 24)
        Me.CboCustomerNumber.Name = "CboCustomerNumber"
        Me.CboCustomerNumber.Size = New System.Drawing.Size(100, 21)
        Me.CboCustomerNumber.TabIndex = 1
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(17, 101)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 2
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Control
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(114, 124)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 13)
        Me.txt_email.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "First Name:"
        '
        'txt_LastName
        '
        Me.txt_LastName.BackColor = System.Drawing.SystemColors.Control
        Me.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_LastName.Enabled = False
        Me.txt_LastName.HideSelection = False
        Me.txt_LastName.Location = New System.Drawing.Point(114, 77)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.Size = New System.Drawing.Size(100, 13)
        Me.txt_LastName.TabIndex = 8
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.SystemColors.Control
        Me.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_FirstName.Enabled = False
        Me.txt_FirstName.Location = New System.Drawing.Point(114, 51)
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(100, 13)
        Me.txt_FirstName.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxt_phoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_FirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_LastName)
        Me.GroupBox1.Controls.Add(Me.CboCustomerNumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 158)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recent Sales"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(113, 24)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(113, 50)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Montly Sales Avg:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Annual Sales:"
        '
        'mtxt_phoneNumber
        '
        Me.mtxt_phoneNumber.BackColor = System.Drawing.SystemColors.Control
        Me.mtxt_phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxt_phoneNumber.Enabled = False
        Me.mtxt_phoneNumber.Location = New System.Drawing.Point(114, 101)
        Me.mtxt_phoneNumber.Name = "mtxt_phoneNumber"
        Me.mtxt_phoneNumber.Size = New System.Drawing.Size(100, 13)
        Me.mtxt_phoneNumber.TabIndex = 10
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 189)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCustomerNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_LastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtxt_phoneNumber As System.Windows.Forms.MaskedTextBox
End Class
