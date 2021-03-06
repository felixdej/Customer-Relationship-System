﻿Imports System.Data.SqlClient

Public Class Sales
    Dim id As New List(Of String)
    Dim fnames As New List(Of String)
    Dim mnames As New List(Of String)
    Dim lnames As New List(Of String)
    Dim pnumber As New List(Of String)
    Dim email As New List(Of String)
    Dim asales As New List(Of String)
    Dim msales As New List(Of String)



    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connstring As String = ("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bryan\Source\Repos\Customer-Relationship-System\Customer Relationship System\Customer Relationship System\Customers.mdf;Integrated Security=True;Connect Timeout=30")
        Dim conn As New SqlConnection(connstring)
        Dim cmd As New SqlCommand("SELECT * FROM Customer_Info", conn)
        Dim cmd2 As New SqlCommand("SELECT * FROM Sales", conn)

        Me.mtxt_phoneNumber.Mask = "(000) 000-0000"

        '******Retreives First Name only from the database to populate the combobox
        Try
            conn.Open()
            Dim rd As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While rd.Read()
                id.Add(rd("Id").ToString)
                fnames.Add(rd("firstName").ToString)
                mnames.Add(rd("middleName").ToString)
                lnames.Add(rd("lastName").ToString)
                pnumber.Add(rd("phoneNumber").ToString)
                email.Add(rd("email").ToString)
            End While
            rd.Close()
            conn.Close()

            conn.Open()
            Dim rd2 As SqlDataReader = cmd2.ExecuteReader(CommandBehavior.CloseConnection)
            While rd2.Read()
                msales.Add(rd2("Monthly_Sales").ToString)
                asales.Add(rd2("Annual_Sales").ToString)
            End While
            rd2.Close()
            conn.Close()

            Me.CboCustomerNumber.Items.Clear()
            Me.CboCustomerNumber.Items.AddRange(id.ToArray)

        Catch ex As Exception
            MessageBox.Show(e.ToString)
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCustomerNumber.SelectedIndexChanged

        Dim combobox As ComboBox = CType(sender, ComboBox)

        If combobox.SelectedItem IsNot Nothing Then
            Dim curValue = CType(combobox.SelectedIndex, String)

            mtxt_phoneNumber.Text = pnumber(curValue)
            txt_email.Text = email(curValue)
            txt_FirstName.Text = fnames(curValue)
            txt_LastName.Text = lnames(curValue)
            TextBox6.Text = FormatCurrency(asales(curValue))
            TextBox5.Text = FormatCurrency(msales(curValue))
        End If

    End Sub
End Class