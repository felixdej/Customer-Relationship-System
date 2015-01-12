Public Class Contact_Form

    Private customer(99) As Customer
    Private count As Integer

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click

        customer(count) = New Customer(txt_firstName.Text, txt_middleName.Text, txt_lastName.Text, Val(txt_phoneNumber.Text), txt_email.Text)
        lbl_test.Text = customer(count).MiddleName
        count = 1 + count

    End Sub
End Class