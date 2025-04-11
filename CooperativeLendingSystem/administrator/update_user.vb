Imports MySql.Data.MySqlClient
Public Class update_user
    Dim query As String = "SELECT `id`, `account_no`, `username`, `initials`, `pass`, `admin`,update_member, `loan_apply`, `loan_approve`, `loan_release`, `loan_collection`, `add_member`, `print_savings`, `print_sharecap`, `savings`, `sharecap`, `dashboard` FROM `user` WHERE account_no != 'lcpmpc@'"
    Private Sub update_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload(query, datagrid1)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            con.Close()
            con.Open()

            For Each row As DataGridViewRow In datagrid1.Rows
                If Not row.IsNewRow Then
                    Dim cmd As New MySqlCommand("UPDATE `user` SET " &
                                                "`account_no`=@account_no, `username`=@username, `initials`=@initials, `pass`=@pass, " &
                                                "`admin`=@admin, `update_member`=@update_member, `loan_apply`=@loan_apply, " &
                                                "`loan_approve`=@loan_approve, `loan_release`=@loan_release, `loan_collection`=@loan_collection, " &
                                                "`add_member`=@add_member, `print_savings`=@print_savings, `print_sharecap`=@print_sharecap, " &
                                                "`savings`=@savings, `sharecap`=@sharecap, `dashboard`=@dashboard " &
                                                "WHERE `id`=@id", con)

                    With cmd.Parameters
                        .AddWithValue("@id", row.Cells("id").Value)
                        .AddWithValue("@account_no", row.Cells("account_no").Value)
                        .AddWithValue("@username", row.Cells("username").Value)
                        .AddWithValue("@initials", row.Cells("initials").Value)
                        .AddWithValue("@pass", row.Cells("pass").Value)
                        .AddWithValue("@admin", row.Cells("admin").Value)
                        .AddWithValue("@update_member", row.Cells("update_member").Value)
                        .AddWithValue("@loan_apply", row.Cells("loan_apply").Value)
                        .AddWithValue("@loan_approve", row.Cells("loan_approve").Value)
                        .AddWithValue("@loan_release", row.Cells("loan_release").Value)
                        .AddWithValue("@loan_collection", row.Cells("loan_collection").Value)
                        .AddWithValue("@add_member", row.Cells("add_member").Value)
                        .AddWithValue("@print_savings", row.Cells("print_savings").Value)
                        .AddWithValue("@print_sharecap", row.Cells("print_sharecap").Value)
                        .AddWithValue("@savings", row.Cells("savings").Value)
                        .AddWithValue("@sharecap", row.Cells("sharecap").Value)
                        .AddWithValue("@dashboard", row.Cells("dashboard").Value)
                    End With

                    cmd.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Users updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reload(query, datagrid1)
        Catch ex As Exception
            MessageBox.Show("Error while updating: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class