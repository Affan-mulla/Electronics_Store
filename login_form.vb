Imports System.Data.OleDb
Public Class login_form
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROGRAMMING\.Net\Electronics_Store\project.accdb")
        cn.Open()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        cmd = New OleDbCommand("select * from users where email = ?", cn)
        cmd.Parameters.AddWithValue("@email", GunaTextBox1.Text)

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged
        If Not IsValidEmailFormat(GunaTextBox1.Text) Then
            MessageBox.Show("Email not valid")
            GunaButton1.Enabled = False

        Else
            GunaButton1.Enabled = True
        End If
    End Sub
End Class