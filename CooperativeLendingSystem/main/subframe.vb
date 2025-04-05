Public Class subframe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If btn_menu.ContextMenuStrip IsNot Nothing Then
            btn_menu.ContextMenuStrip.Show(btn_menu, 0, btn_menu.Height)

        End If
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        btn_user.Text = "Hi, " & user_Username
        btn_administrator.Visible = isAccess("admin")
        If btn_profile.ContextMenuStrip IsNot Nothing Then
            btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)

        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        display_inMain(Login)
        Me.Close()
    End Sub

    Private Sub RecievingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RecievingToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeliveryOUTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        If isAccess("add_member") = True Then
            display_inSub(add_member)
        Else
            show_error("You need permission to access this content.")
        End If
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        display_inSub(member_accounts)
    End Sub
End Class