Imports MySql.Data.MySqlClient
Public Class collection
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            If user_Password = txt_password.Text Then

                Dim transid As String = Nothing
                Select Case cmb_deptrans.Text
                    Case "Cash Deposit"
                        transid = "CD"
                    Case "Check Deposit"
                        transid = "CHKD"
                    Case "Initial Deposit"
                        transid = "ID"
                    Case "Credit Memo"
                        transid = "CM"
                    Case "Interest"
                        transid = "INT"
                    Case "Patronage Refund"
                        transid = "IPR"

                End Select

                Dim transtype As String = Nothing
                Select Case cmb_type.Text
                    Case "Loan"
                        transtype = "L"
                    Case "Savings"
                        transtype = "S"
                    Case "Share Capital"
                        transtype = "SC"
                End Select



                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`id`, `account_no`, `amount`, `date_transac`, `time`, `type`, `transaction_id`, `teller`)
                                   VALUES (NULL, '" & client_accountno & "', '" & Convert.ToDecimal(txt_amountdeposit.Text) & "', CURDATE(), CURTIME(), '" & transtype & "', '" & transid & "', '" & user_IDno & "')", con)


                cmdinsert.ExecuteNonQuery()
                MessageBox.Show("Record saved successfully.")
                txt_amountdeposit.Clear()
                txt_password.Clear()
                reload("SELECT `id`, `account_no`, `amount`, `type`, `transaction_id`, `date_transac` FROM `collection` WHERE date_transac =CURDATE()", datagrid1)
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
        reload("SELECT `id`, `account_no`, `amount`, `type`, `transaction_id`, `date_transac` FROM `collection` WHERE date_transac =CURDATE()", datagrid1)
    End Sub

End Class