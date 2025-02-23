Imports System.Data.OleDb
Public Class Register
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand



    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROGRAMMING\.Net\Electronics_Store\affan.accdb")
        cn.Open()
    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If Not IsValidEmailFormat(GunaTextBox1.Text) Then
            MessageBox.Show("Email not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If GunaTextBox3.Text.Count < 10 Then
            MessageBox.Show("Phone Number not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into users values (@username,@email,@phoneno,@password)", cn)
        cmd.Parameters.AddWithValue("@username", GunaTextBox2.Text)
        cmd.Parameters.AddWithValue("@email", GunaTextBox1.Text)
        cmd.Parameters.AddWithValue("@phoneno", GunaTextBox3.Text)
        cmd.Parameters.AddWithValue("@password", GunaTextBox4.Text)
        cmd.ExecuteNonQuery()
        cn.Close()
        login_form.Show()
        Me.Close()
    End Sub
End Class