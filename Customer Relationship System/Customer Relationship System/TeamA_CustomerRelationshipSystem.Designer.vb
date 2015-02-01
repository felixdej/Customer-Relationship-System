<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRelationshipSystem
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_NewContact = New System.Windows.Forms.Button()
        Me.btn_PotentialClient = New System.Windows.Forms.Button()
        Me.btn_CurrentClients = New System.Windows.Forms.Button()
        Me.btn_Sales = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer Relationship System"
        '
        'btn_NewContact
        '
        Me.btn_NewContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewContact.Location = New System.Drawing.Point(12, 93)
        Me.btn_NewContact.Name = "btn_NewContact"
        Me.btn_NewContact.Size = New System.Drawing.Size(195, 63)
        Me.btn_NewContact.TabIndex = 6
        Me.btn_NewContact.Text = "New Contact"
        Me.btn_NewContact.UseVisualStyleBackColor = True
        '
        'btn_PotentialClient
        '
        Me.btn_PotentialClient.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PotentialClient.Location = New System.Drawing.Point(213, 93)
        Me.btn_PotentialClient.Name = "btn_PotentialClient"
        Me.btn_PotentialClient.Size = New System.Drawing.Size(195, 63)
        Me.btn_PotentialClient.TabIndex = 7
        Me.btn_PotentialClient.Text = "Potential Client"
        Me.btn_PotentialClient.UseVisualStyleBackColor = True
        '
        'btn_CurrentClients
        '
        Me.btn_CurrentClients.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CurrentClients.Location = New System.Drawing.Point(213, 173)
        Me.btn_CurrentClients.Name = "btn_CurrentClients"
        Me.btn_CurrentClients.Size = New System.Drawing.Size(195, 63)
        Me.btn_CurrentClients.TabIndex = 8
        Me.btn_CurrentClients.Text = "Current Clients"
        Me.btn_CurrentClients.UseVisualStyleBackColor = True
        '
        'btn_Sales
        '
        Me.btn_Sales.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sales.Location = New System.Drawing.Point(12, 173)
        Me.btn_Sales.Name = "btn_Sales"
        Me.btn_Sales.Size = New System.Drawing.Size(195, 63)
        Me.btn_Sales.TabIndex = 9
        Me.btn_Sales.Text = "Sales"
        Me.btn_Sales.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CustomerRelationshipSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 248)
        Me.Controls.Add(Me.btn_Sales)
        Me.Controls.Add(Me.btn_CurrentClients)
        Me.Controls.Add(Me.btn_PotentialClient)
        Me.Controls.Add(Me.btn_NewContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CustomerRelationshipSystem"
        Me.Text = "Customer Relationship Program"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_NewContact As System.Windows.Forms.Button
    Friend WithEvents btn_PotentialClient As System.Windows.Forms.Button
    Friend WithEvents btn_CurrentClients As System.Windows.Forms.Button
    Friend WithEvents btn_Sales As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
