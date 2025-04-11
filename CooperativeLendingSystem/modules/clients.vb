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




    Public Function checksavings(accountno As String) As Decimal
        Try
            ' Ensure the connection is closed before opening it
            con.Close()
            con.Open()

            ' Define the SQL command to check balance
            Dim check As New MySqlCommand("SELECT 
            SUM(CASE WHEN `status` = 'ID'
                        or status='CHKD'
                        or status='CD' 
                        or status='CM'
                      or status='CSHDEP'
                      or status='BEGBAL'
                      or status='TIMDEP'
                      or status='CMEMO'
                      or status='CHKDEP'
                      or status='CSHADJ'
                      or status='CSHAD1'
                      or status='INT'
THEN `amount` ELSE 0 END) 
                    - 
            SUM(CASE WHEN `status` = 'CW'
                        or status = 'CHKW' 
                        or status = 'DM'
  or status='DAMAY'
  or status='DMEMO'
  or status='DEDB'
  or status='CSHWIT'
  or status='CHKBON'
  or status='TAXWIT'
  or status='CHKWIT'
                     THEN `amount` ELSE 0 END) AS balance
            FROM `savings`
            WHERE `account_no` = @accountno", con)

            ' Add the parameter for account number
            check.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the balance
            Dim balance As Object = check.ExecuteScalar()

            ' Check if the result is not null and return the balance as Decimal
            If balance IsNot DBNull.Value Then
                Return Convert.ToDecimal(balance)
            Else
                Return 0 ' Return 0 if no balance is found
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the execution
            MessageBox.Show("Error: " & ex.Message)
            Return 0 ' Return 0 in case of an error
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Function


    Public Function checksharecap(accountno As String) As Decimal
        Try
            ' Ensure the connection is closed before opening it
            con.Close()
            con.Open()

            ' Define the SQL command to check balance
            Dim check As New MySqlCommand("SELECT 
            SUM(CASE WHEN `status` = 'ID' 
or status='CM'
or status='CD'
or status='ISC' 
or status='IPR' 
or status='C'
or status='CASHDEP'
or status='BEGBAL'
or status='CMEMO'
or status='CHKDEP'
or status='CSHAD1'
or status='INT'

THEN `amount` ELSE 0 END) - 

            SUM(CASE WHEN `status` = 'DM' 
or status = 'CA' 
or status='D'
or status='DMEMO'
or status='CHKWID'
or status='CSHWIT'
or status='CHKWIT'

THEN `amount` ELSE 0 END) AS balance
            FROM `sharecap`
            WHERE `account_no` = @accountno", con)

            ' Add the parameter for account number
            check.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the balance
            Dim balance As Object = check.ExecuteScalar()

            ' Check if the result is not null and return the balance as Decimal
            If balance IsNot DBNull.Value Then
                Return Convert.ToDecimal(balance)
            Else
                Return 0 ' Return 0 if no balance is found
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the execution
            MessageBox.Show("Error: " & ex.Message)
            Return 0 ' Return 0 in case of an error
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Function

End Module
