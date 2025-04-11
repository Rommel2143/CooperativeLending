Imports MySql.Data.MySqlClient

Module userModules
    Public user_IDno As String
    Public user_Username As String
    Public user_Password As String
    Public user_pc As String

    Public Function isLogin(IDno As String, pass As String) As Boolean
        Try


            Dim query As String = "SELECT account_no,username,pass FROM user WHERE (account_no = @account_no OR username=@account_no) AND pass = @pass"


            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@account_no", IDno)
                cmd.Parameters.AddWithValue("@pass", pass)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read = True Then

                    user_IDno = dr.GetString("account_no")
                    user_Username = dr.GetString("username")
                    user_Password = dr.GetString("pass")
                    user_pc = Environment.MachineName
                    Return 1
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            show_error("Something went wrong. Please try again.")
            Return 0
        End Try
    End Function



    Public Function isAccess(column As String) As Boolean
        Dim query As String = "SELECT  " & column & " FROM user WHERE account_no = @account_no"

        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@account_no", user_IDno)

            con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return dr.GetBoolean(0)
            Else
                Return 0
            End If
        End Using

    End Function



End Module
