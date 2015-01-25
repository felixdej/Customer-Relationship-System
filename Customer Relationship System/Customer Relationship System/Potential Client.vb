Imports System.Text.RegularExpressions

Public Class PotentialClient

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        CustomerRelationshipSystem.Show()
    End Sub

    Private Sub txt_firstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_firstName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_middleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_middleName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
        End If
    End Sub

    Private Sub txt_lastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lastName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only enter letters.")
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
            MessageBox.Show("Success", "Checking")
        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txt_email.Clear()
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

    Private Sub PotentialClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mtxt_phoneNumber.Mask = "(000) 000-0000"
    End Sub
End Class