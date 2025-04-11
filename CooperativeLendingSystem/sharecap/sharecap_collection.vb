Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class sharecap_collection

    Private Sub sharecap_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub


    Public Sub loaddata()
        lbl_balance.Text = String.Format("₱{0:N2}", checksharecap(client_accountno))
        lbl_accountname.Text = client_firstname.ToUpper & " " & client_lastname.ToUpper
        lbl_acc.Text = "Acc# : " & client_accountno



        reload("SELECT sharecap.id,
            `date_transac`, 
        CASE 
            WHEN `status` IN ('ID' ,'CM','CD','ISC' ,'IPR' ,'C','CASHDEP','BEGBAL','CMEMO','CHKDEP','CSHAD1','INT') 
            THEN `amount` ELSE 0 END AS `Deposit`,
        CASE 
            WHEN `status` IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') 
            THEN `amount` ELSE 0 END AS `Withdrawal`,
     SUM(
            CASE 
                WHEN `status` IN ('ID' ,'CM','CD','ISC' ,'IPR' ,'C','CASHDEP','BEGBAL','CMEMO','CHKDEP','CSHAD1','INT') 
                THEN `amount` 
                WHEN `status` IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') 
                THEN -`amount`
                ELSE 0 
            END
        ) OVER (PARTITION BY sharecap.account_no ORDER BY sharecap.id) AS `Balance`,

    status AS 'Transaction',
    initials as 'Teller'
    FROM `sharecap`
     LEFT JOIN user ON sharecap.teller=user.account_no
    WHERE sharecap.account_no='" & client_accountno & "'
    ORDER BY id DESC;
    ", datagrid1)




        ' Check if "ActionImage" column already exists
        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In datagrid1.Columns
            If column.Name = "ActionImage" Then
                columnExists = True
                Exit For
            End If
        Next

        ' Add an image column if not already added
        If Not columnExists Then
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionImage"
            imgColumn.HeaderText = ""
            imgColumn.Image = My.Resources.print ' Replace with your actual resource

            datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
            datagrid1.Columns(0).Width = 30

        End If
    End Sub


    Private Sub insertshare()
        Try

            If user_Password = txt_password.Text Then


                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO sharecap ( `account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                    VALUES ('" & client_accountno & "',
                                                                            @amount,
                                                                          CURDATE(),
                                                                          CURTIME(),
                                                                           '" & get_trans() & "',
                                                                           '" & user_IDno & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountdeposit.Text))
                cmdinsert.ExecuteNonQuery()

                MessageBox.Show("Record saved successfully.")
                txt_amountdeposit.Clear()
                txt_password.Clear()
                Call loaddata()
            Else
                show_error("Invalid Password!")
            End If
        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function get_trans() As String
        Select Case cmb_transaction.Text.Trim()
            Case "Initial Deposit"
                Return "ID"
            Case "Cash Deposit"
                Return "CD"
            Case "Credit Memo"
                Return "CM"
            Case "Interest on Sharecapital"
                Return "ISC"
            Case "Patronage Refund"
                Return "IPR"
            Case "Debit Memo"
                Return "DM"
            Case "Closed account"
                Return "CA"
            Case Else
                Return "Unknown" ' Optional: Add default return value for unexpected cases
        End Select
    End Function


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        insertshare()
    End Sub


    Private Sub txt_amountdeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amountdeposit.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True ' Ignore the input
        End If
    End Sub



    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If isAccess("print_sharecap") = True Then


            If e.ColumnIndex = datagrid1.Columns("ActionImage").Index AndAlso e.RowIndex >= 0 Then
                Dim status As String = datagrid1.Rows(e.RowIndex).Cells("Transaction").Value.ToString()
                Dim withdraw As String = datagrid1.Rows(e.RowIndex).Cells("withdrawal").Value.ToString()
                Dim deposit As String = datagrid1.Rows(e.RowIndex).Cells("deposit").Value.ToString()
                Dim balance As String = datagrid1.Rows(e.RowIndex).Cells("balance").Value.ToString()
                Dim teller As String = datagrid1.Rows(e.RowIndex).Cells("Teller").Value.ToString()
                Dim date_transac As String = datagrid1.Rows(e.RowIndex).Cells("date_transac").Value.ToString()

                Dim printpass As New print_passbook
                printpass.loaddata(status, withdraw, deposit, balance, teller, date_transac, client_accountno, Regex.Replace(lbl_accountname.Text, "\(\d+\)", "").Trim())
                printpass.ShowDialog()
            End If


        End If

    End Sub
End Class