Public Class CustomerRelationshipSystem

    Private Sub btn_NewContact_Click(sender As Object, e As EventArgs) Handles btn_NewContact.Click
        Me.Hide()
        Contact.Show()
    End Sub

    Private Sub btn_PotentialClient_Click(sender As Object, e As EventArgs) Handles btn_PotentialClient.Click
        Me.Hide()
        PotentialClient.Show()
    End Sub

    Private Sub btn_Sales_Click(sender As Object, e As EventArgs) Handles btn_Sales.Click
        Me.Hide()
        Sales.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_CurrentClients_Click(sender As Object, e As EventArgs) Handles btn_CurrentClients.Click
        Me.Hide()
        Current_Clients.Show()
    End Sub
End Class
