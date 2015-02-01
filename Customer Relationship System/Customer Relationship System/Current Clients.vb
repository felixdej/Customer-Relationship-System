Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Current_Clients

    Private Sub Current_Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.Customer_Info' table. You can move, or remove it, as needed.
        Me.Customer_InfoTableAdapter.Fill(Me.CustomersDataSet.Customer_Info)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CustomerRelationshipSystem.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)() _
                    Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("Contacts.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("Contacts.txt")
    End Sub
End Class