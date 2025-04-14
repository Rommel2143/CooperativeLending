Imports MySql.Data.MySqlClient
Public Class collection
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            If user_Password = txt_password.Text Then

                Dim trans As String = Nothing
                Select Case cmb_deptrans.Text
                    Case "Cash Deposit"
                        trans = "CD"
                    Case "Check Deposit"
                        trans = "CHKD"
                    Case "Initial Deposit"
                        trans = "ID"
                    Case "Credit Memo"
                        trans = "CM"
                    Case "Interest"
                        trans = "INT"
                    Case "Patronage Refund"
                        trans = "IPR"
                    Case "Debit Memo"
                        trans = "DMEMO"
                    Case "Closed Account"
                        trans = "CA"
                End Select

                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & client_accountno & "',
                                                                        @amount,
                                                                       CURDATE(),
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       '" & trans & "',
                                                                       '" & user_IDno & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountdeposit.Text))
                cmdinsert.ExecuteNonQuery()
                MessageBox.Show("Record saved successfully.")
                txt_amountdeposit.Clear()
                txt_password.Clear()
                reload("SELECT SELECT `id`, `account_no`, `amount`, `tag`, `transaction_id`, `datein` FROM `collection` WHERE datein =CURDATE()", datagrid1)
            Else
                show_error("Invalid Password!")
            End If
        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT SELECT `id`, `account_no`, `amount`, `tag`, `transaction_id`, `datein` FROM `collection` WHERE datein =CURDATE()", datagrid1)
    End Sub
End Class