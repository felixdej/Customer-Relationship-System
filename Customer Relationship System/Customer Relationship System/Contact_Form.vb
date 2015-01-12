Public Class Contact_Form
    'Var
    Private customer(99) As Customer
    Private count As Integer

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click
        If (txt_firstName.Text <> "" And txt_middleName.Text <> "" And txt_lastName.Text <> "" And Val(txt_phoneNumber.Text) <> 0 And txt_email.Text <> "") Then
            customer(count) = New Customer(txt_firstName.Text, txt_middleName.Text,
                                           txt_lastName.Text, Val(txt_phoneNumber.Text), txt_email.Text)
            lbl_test.Text = customer(count).MiddleName
            count = 1 + count
        Else
            lbl_test.Text = "Empty Field"
        End If
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        CustomerRelationshipSystem.Show()
    End Sub

End Class