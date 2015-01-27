Public Class CustomerRelationshipSystem

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click
        Me.Hide()
        Contact.Show()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub btn_PotentialClient_Click(sender As Object, e As EventArgs) Handles btn_PotentialClient.Click
        Me.Hide()
        PotentialClient.Show()
    End Sub

    Private Sub btn_Sales_Click(sender As Object, e As EventArgs) Handles btn_Sales.Click
        Me.Hide()
        Sales.Show()
    End Sub
End Class
