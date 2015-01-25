<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PotentialClient
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.txt_middleName = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_NewContact = New System.Windows.Forms.Button()
        Me.cb_1 = New System.Windows.Forms.CheckBox()
        Me.cb_2 = New System.Windows.Forms.CheckBox()
        Me.cb_3 = New System.Windows.Forms.CheckBox()
        Me.lbl_ContactAttempts = New System.Windows.Forms.Label()
        Me.mtxt_phoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(119, 139)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(192, 20)
        Me.txt_email.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Phone Number:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Location = New System.Drawing.Point(119, 87)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(192, 20)
        Me.txt_lastName.TabIndex = 15
        '
        'txt_middleName
        '
        Me.txt_middleName.Location = New System.Drawing.Point(119, 61)
        Me.txt_middleName.Name = "txt_middleName"
        Me.txt_middleName.Size = New System.Drawing.Size(192, 20)
        Me.txt_middleName.TabIndex = 13
        '
        'txt_firstName
        '
        Me.txt_firstName.Location = New System.Drawing.Point(119, 35)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(192, 20)
        Me.txt_firstName.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Middle Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First Name:"
        '
        'btn_Back
        '
        Me.btn_Back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(226, 162)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(207, 63)
        Me.btn_Back.TabIndex = 21
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'btn_NewContact
        '
        Me.btn_NewContact.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewContact.Location = New System.Drawing.Point(12, 162)
        Me.btn_NewContact.Name = "btn_NewContact"
        Me.btn_NewContact.Size = New System.Drawing.Size(207, 63)
        Me.btn_NewContact.TabIndex = 20
        Me.btn_NewContact.Text = "Update"
        Me.btn_NewContact.UseVisualStyleBackColor = True
        '
        'cb_1
        '
        Me.cb_1.AutoSize = True
        Me.cb_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_1.Location = New System.Drawing.Point(317, 60)
        Me.cb_1.Name = "cb_1"
        Me.cb_1.Size = New System.Drawing.Size(107, 23)
        Me.cb_1.TabIndex = 23
        Me.cb_1.Text = "First Attempt"
        Me.cb_1.UseVisualStyleBackColor = True
        '
        'cb_2
        '
        Me.cb_2.AutoSize = True
        Me.cb_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_2.Location = New System.Drawing.Point(317, 86)
        Me.cb_2.Name = "cb_2"
        Me.cb_2.Size = New System.Drawing.Size(126, 23)
        Me.cb_2.TabIndex = 24
        Me.cb_2.Text = "Second Attempt"
        Me.cb_2.UseVisualStyleBackColor = True
        '
        'cb_3
        '
        Me.cb_3.AutoSize = True
        Me.cb_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_3.Location = New System.Drawing.Point(317, 112)
        Me.cb_3.Name = "cb_3"
        Me.cb_3.Size = New System.Drawing.Size(112, 23)
        Me.cb_3.TabIndex = 25
        Me.cb_3.Text = "Third Attempt"
        Me.cb_3.UseVisualStyleBackColor = True
        '
        'lbl_ContactAttempts
        '
        Me.lbl_ContactAttempts.AutoSize = True
        Me.lbl_ContactAttempts.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ContactAttempts.Location = New System.Drawing.Point(318, 34)
        Me.lbl_ContactAttempts.Name = "lbl_ContactAttempts"
        Me.lbl_ContactAttempts.Size = New System.Drawing.Size(115, 19)
        Me.lbl_ContactAttempts.TabIndex = 26
        Me.lbl_ContactAttempts.Text = "Contact Attempts"
        '
        'mtxt_phoneNumber
        '
        Me.mtxt_phoneNumber.Location = New System.Drawing.Point(119, 113)
        Me.mtxt_phoneNumber.Name = "mtxt_phoneNumber"
        Me.mtxt_phoneNumber.Size = New System.Drawing.Size(192, 20)
        Me.mtxt_phoneNumber.TabIndex = 27
        '
        'PotentialClient
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 248)
        Me.Controls.Add(Me.mtxt_phoneNumber)
        Me.Controls.Add(Me.lbl_ContactAttempts)
        Me.Controls.Add(Me.cb_3)
        Me.Controls.Add(Me.cb_2)
        Me.Controls.Add(Me.cb_1)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_NewContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.txt_middleName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PotentialClient"
        Me.RightToLeftLayout = True
        Me.Text = "Customer Relationship System - Potential Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_lastName As System.Windows.Forms.TextBox
    Friend WithEvents txt_middleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_NewContact As System.Windows.Forms.Button
    Friend WithEvents cb_1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb_3 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ContactAttempts As System.Windows.Forms.Label
    Friend WithEvents mtxt_phoneNumber As System.Windows.Forms.MaskedTextBox
End Class
