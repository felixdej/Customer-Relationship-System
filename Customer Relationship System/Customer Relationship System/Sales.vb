Imports System.Data.SqlClient

Public Class Sales

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connstring As String = ("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bryan\Documents\Customers.mdf;Integrated Security=True;Connect Timeout=30")
        Dim conn As New SqlConnection(connstring)
        Dim cmd As New SqlCommand("SELECT * FROM Customer_Info", conn)
        Dim fnames As New List(Of String)
        Dim mnames As New List(Of String)
        Dim lnames As New List(Of String)
        Dim pnumber As New List(Of String)
        Dim email As New List(Of String)


        '******Retreives First Name only from the database to populate the combobox
        Try
            conn.Open()
            Dim rd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While rd.Read()
                fnames.Add(rd("firstName").ToString)
                mnames.Add(rd("middleName").ToString)
                lnames.Add(rd("lastName").ToString)
                pnumber.Add(rd("phoneNumber").ToString)
                email.Add(rd("email").ToString)
            End While
            rd.Close()
            conn.Close()

            Me.ComboBox1.Items.Clear()
            Me.ComboBox1.Items.AddRange(fnames.ToArray)

        Catch ex As Exception
            MessageBox.Show(e.ToString)
        End Try


    End Sub
End Class