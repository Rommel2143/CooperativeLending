Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class savings
    Dim account_no As String
    Private Sub savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(account As String, fname As String)
        account_no = account
        lbl_balance.Text = String.Format("₱{0:N2}", checksavings(account))
        lbl_accountname.Text = fname

        'reload("SELECT savings.id,`referenceno`, `amount` AS 'Amount', DATE_FORMAT(date_transac, '%M %d, %Y') AS Date,`status` AS 'Type', initials AS 'Teller' FROM `savings` 
        '        LEFT JOIN user ON savings.teller=user.account_no
        '        WHERE savings.account_no='" & account & "' 
        '        ORDER BY date_transac DESC ", datagrid1)

        reload("SELECT savings.id,
    `referenceno` AS `Reference no`, 
    `date_transac`, 
    CASE 
        WHEN `status` IN ('ID', 'CHKD', 'CD', 'CM', 'CSHDEP', 'BEGBAL', 'TIMDEP', 'CMEMO', 'CHKDEP', 'CSHADJ', 'CSHAD1', 'INT') 
        THEN `amount` ELSE 0 END AS `Deposit`,
    CASE 
        WHEN `status` IN ('CW', 'CHKW', 'DM', 'DAMAY', 'DMEMO', 'DEDB', 'CSHWIT', 'CHKBON', 'TAXWIT', 'CHKWIT') 
        THEN `amount` ELSE 0 END AS `Withdrawal`,
 SUM(
        CASE 
            WHEN `status` IN ('ID', 'CHKD', 'CD', 'CM', 'CSHDEP', 'BEGBAL', 'TIMDEP', 'CMEMO', 'CHKDEP', 'CSHADJ', 'CSHAD1', 'INT') 
            THEN `amount` 
            WHEN `status` IN ('CW', 'CHKW', 'DM', 'DAMAY', 'DMEMO', 'DEDB', 'CSHWIT', 'CHKBON', 'TAXWIT', 'CHKWIT') 
            THEN -`amount`
            ELSE 0 
        END
    ) OVER (PARTITION BY savings.account_no ORDER BY savings.id) AS `Balance`,

status AS 'Transaction',
initials as 'Teller'
FROM `savings`
 LEFT JOIN user ON savings.teller=user.account_no
WHERE savings.account_no='" & account & "'
ORDER BY id DESC;
", datagrid1)







        'datagrid1.Columns("deposit").DefaultCellStyle.Format = "₱#,##0.00"
        'datagrid1.Columns("withdraw").DefaultCellStyle.Format = "₱#,##0.00"

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
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.print ' Replace with your actual resource

            datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
            datagrid1.Columns(0).Width = 30
            datagrid1.Columns("id").Visible = False
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            If user_Password = txt_password.Text Then

                Dim trans As String = Nothing
                Select Case cmb_deptrans.Text
                    Case "Cash"
                        trans = "CD"
                    Case "Check"
                        trans = "CHKD"
                    Case "Initial"
                        trans = "ID"
                    Case "Credit"
                        trans = "CM"
                End Select

                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & account_no & "',
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
                loaddata(account_no, lbl_accountname.Text)
            Else
                show_error("Invalid Password!")
            End If
        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Try

            If user_Password = txt_passwithdraw.Text Then

                Dim trans As String = Nothing
                Select Case cmb_withtrans.Text
                    Case "Cash"
                        trans = "CW"
                    Case "Check"
                        trans = "CHKW"
                    Case "Debit"
                        trans = "DM"
                    Case "Interest"
                        trans = "INT"
                End Select

                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & account_no & "',
                                                                        @amount,
                                                                       CURDATE(),
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       '" & trans & "',
                                                                       '" & user_IDno & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountwithdraw.Text))
                cmdinsert.ExecuteNonQuery()
                MessageBox.Show("Record saved successfully.")
                txt_amountwithdraw.Clear()
                txt_passwithdraw.Clear()
                loaddata(account_no, lbl_accountname.Text)
            Else
                show_error("Invalid Password!")
            End If
        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amountdeposit.TextChanged, txt_amountwithdraw.TextChanged

    '    Dim textBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)


    '    Dim numericText As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c) Or c = "."c).ToArray())

    '    ' Remove existing event handler to prevent infinite loop
    '    RemoveHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

    '    ' Format the numeric text as currency
    '    If Decimal.TryParse(numericText, NumberStyles.Any, CultureInfo.InvariantCulture, Nothing) Then
    '        Dim formattedText As String = String.Format(CultureInfo.CurrentCulture, "{0:N0}", Convert.ToDecimal(numericText))
    '        textBox.Text = formattedText
    '        ' Move the cursor to the end of the text
    '        textBox.SelectionStart = textBox.Text.Length
    '    End If

    '    ' Re-add the event handler
    '    AddHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

    'End Sub
    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amountwithdraw.KeyPress, txt_amountdeposit.KeyPress
        ' Allow only numbers, one decimal point, and control keys (Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True ' Ignore the input
        End If


    End Sub


    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub cmb_purpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_deptrans.SelectedIndexChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub



    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If isAccess("print_savings") = True Then

            If e.ColumnIndex = datagrid1.Columns("ActionImage").Index AndAlso e.RowIndex >= 0 Then
                Dim status As String = datagrid1.Rows(e.RowIndex).Cells("Transaction").Value.ToString()
                Dim withdraw As String = datagrid1.Rows(e.RowIndex).Cells("withdrawal").Value.ToString()
                Dim deposit As String = datagrid1.Rows(e.RowIndex).Cells("deposit").Value.ToString()
                Dim balance As String = datagrid1.Rows(e.RowIndex).Cells("balance").Value.ToString()
                Dim teller As String = datagrid1.Rows(e.RowIndex).Cells("Teller").Value.ToString()
                Dim date_transac As String = datagrid1.Rows(e.RowIndex).Cells("date_transac").Value.ToString()

                Dim printpass As New print_savings
                printpass.loaddata(status, withdraw, deposit, balance, teller, date_transac, account_no, Regex.Replace(lbl_accountname.Text, "\(\d+\)", "").Trim())
                printpass.ShowDialog()
            End If

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub cmb_withtrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_withtrans.SelectedIndexChanged

    End Sub
End Class