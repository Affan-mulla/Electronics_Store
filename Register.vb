Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        login_form.Show()
        Me.Hide()
    End Sub
End Class