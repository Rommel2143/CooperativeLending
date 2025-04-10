Imports MySql.Data.MySqlClient
Module clients
    Public client_accountno As String
    Public client_firstname As String
    Public client_middle As String
    Public client_lastname As String

    Public Sub getClient(accountno As String)
        Dim query As String = "SELECT `id`, `account_no`, `firstname`, `middlename`, `lastname` FROM `member_profile`
                                WHERE account_no = @account_no "


        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@account_no", accountno)

            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cleardata()
                client_accountno = dr.GetString("account_no")
                client_firstname = dr.GetString("firstname")
                client_middle = dr.GetString("middlename")
                client_lastname = dr.GetString("lastname")

            Else
                MessageBox.Show("negative")
            End If
        End Using

    End Sub

    Private Sub cleardata()
        client_accountno = ""
        client_firstname = ""
        client_middle = ""
        client_lastname = ""
    End Sub








End Module
