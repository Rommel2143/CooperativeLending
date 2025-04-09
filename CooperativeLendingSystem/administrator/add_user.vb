Imports MySql.Data.MySqlClient
Public Class add_user

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            con.Close()
            con.Open()
            Dim query As String = "INSERT INTO `user`(`id`, `account_no`, `username`, `initials`, `pass`, `admin`, `loan_apply`, `loan_approve`, `loan_release`, `loan_collection`, `add_member`, `print_savings`, `print_sharecap`, `savings`, `sharecap`, `dashboard`) 
                                        VALUES (NULL,'" & txt_account.Text.Trim & "','" & txt_username.Text.Trim & "','" & txt_initials.Text.Trim & "','" & txt_password.Text & "','0','0','0','0','0','0','0','0','0','0','0')"
            Dim cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("New user has been added.")
            Me.Close()
        Catch ex As MySqlException When ex.Number = 1062
            ' Handle duplicate entry error
            show_error("Record duplicate. Please review Account no. or Initials")
        Catch ex As Exception
            show_error("Something went wrong. Please try again later.")
        End Try
    End Sub

End Class