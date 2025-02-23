Imports System.Data.OleDb
Public Class login_form
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If Not IsValidEmailFormat(GunaTextBox1.Text) Then
            MessageBox.Show("Email not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROGRAMMING\.Net\Electronics_Store\affan.accdb")
        cn.Open()
        da = New OleDbDataAdapter("select * from users where email=?", cn)
        da.SelectCommand.Parameters.AddWithValue("@email", GunaTextBox1.Text)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("User does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If dt.Rows(0)("password").ToString() = GunaTextBox2.Text Then
            Me.Hide()
            Product.Show()
        Else
            MsgBox("password incorrect!")
            Exit Sub
        End If



    End Sub
End Class