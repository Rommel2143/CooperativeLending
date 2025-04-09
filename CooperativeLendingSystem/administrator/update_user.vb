Public Class update_user
    Private Sub update_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT `id`, `account_no`, `username`, `initials`, `pass`, `admin`, `loan_apply`, `loan_approve`, `loan_release`, `loan_collection`, `add_member`, `print_savings`, `print_sharecap`, `savings`, `sharecap`, `dashboard` FROM `user` ", datagrid1)
    End Sub
End Class