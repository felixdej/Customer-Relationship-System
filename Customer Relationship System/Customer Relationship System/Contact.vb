Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.IO

Public Class Contact
    'Var
    Public customer(99) As Customer
    Private count As Integer
    Private newContact As Array = {"firstName", "middleName", "lastName", "phoneNumber", "email"}

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click
        If (txt_firstName.Text <> "" And txt_middleName.Text <> "" And txt_lastName.Text <> "" And Val(mtxt_phoneNumber.Text) <> 0 And txt_email.Text <> "") Then
            customer(count) = New Customer(txt_firstName.Text, txt_middleName.Text,
                                           txt_lastName.Text, Val(mtxt_phoneNumber.Text), txt_email.Text)
            lbl_test.Text = customer(count).MiddleName
            count = 1 + count
        Else
            lbl_test.Text = "Empty Field"
        End If

        '***************************DATABASE CONNECTION INFORMATION*******************************
        Dim con As New SqlClient.SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bryan\Source\Repos\Customer-Relationship-System\Customer Relationship System\Customer Relationship System\Customers.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "INSERT INTO Customer_Info values(@firstName, @middleName, @lastName, @phoneNumber, @email)"

        cmd.Parameters.Add(New SqlParameter("@firstName", SqlDbType.VarChar, 50))
        cmd.Parameters("@firstName").Value = txt_firstName.Text


        cmd.Parameters.Add(New SqlParameter("@middleName", SqlDbType.VarChar, 50))
        cmd.Parameters("@middleName").Value = txt_middleName.Text


        cmd.Parameters.Add(New SqlParameter("@lastName", SqlDbType.VarChar, 50))
        cmd.Parameters("@lastName").Value = txt_lastName.Text


        cmd.Parameters.Add(New SqlParameter("@phoneNumber", SqlDbType.VarChar, 50))
        cmd.Parameters("@phoneNumber").Value = mtxt_phoneNumber.Text


        cmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50))
        cmd.Parameters("@email").Value = txt_email.Text
        '**************************END DATABASE INFORMATION**********************************************

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful Database Insert")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        clearFields()
        Me.Close()

    End Sub

    Private Sub clearFields()
        txt_firstName.Text = ""
        txt_middleName.Text = ""
        txt_lastName.Text = ""
        mtxt_phoneNumber.Text = ""
        txt_email.Text = ""
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        CustomerRelationshipSystem.Show()
    End Sub

    Private Sub txt_firstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_firstName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_middleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_middleName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_lastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lastName.KeyPress
        'TODO add code to verify that only alphabetical characters are entered
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress
        Dim sign As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If sign.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txt_email.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txt_phoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_email.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txt_email.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txt_email.Clear()
        End If
    End Sub

    Private Sub Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mtxt_phoneNumber.Mask = "(000) 000-0000"

        Me.AllowDrop = True


    End Sub

    Private Sub Contact_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim inputFile As StreamReader
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim j As Integer
        Try
            inputFile = File.OpenText(files(j))
            j = j + 1
            Dim i As Integer
            For i = 0 To (newContact.Length - 1)
                newContact(i) = CStr(inputFile.ReadLine)
            Next

            txt_firstName.Text = newContact(0)
            txt_middleName.Text = newContact(1)
            txt_lastName.Text = newContact(2)
            mtxt_phoneNumber.Text = newContact(3)
            txt_email.Text = newContact(4)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Contact_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class