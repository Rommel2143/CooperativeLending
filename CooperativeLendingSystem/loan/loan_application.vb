Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class loan_application
    Dim monthly_ammo As Decimal
    Dim interest_amount As Decimal
    Dim interestDecimal As Decimal
    Private Sub loan_application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        cmb_display("SELECT CONCAT(type,'  (',interest,'%)') FROM loan_types", cmb_purpose)

    End Sub

    Private Sub loaddata()
        lbl_balance.Text = String.Format("₱{0:N2}", checksharecap(client_accountno))
        lbl_accountname.Text = client_firstname.ToUpper & " " & client_lastname.ToUpper
        lbl_acc.Text = "Acc# : " & client_accountno
    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amount.TextChanged
        cleartext()
    End Sub

    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress, txt_insurance.KeyPress, txt_collavalue.KeyPress
        Dim txtBox As Guna2TextBox = CType(sender, Guna2TextBox)

        ' Allow control keys like Backspace
        If Char.IsControl(e.KeyChar) Then
            Exit Sub
        End If

        ' Allow digits
        If Char.IsDigit(e.KeyChar) Then
            Exit Sub
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c Then
            If txtBox.Text.Contains(".") Then
                e.Handled = True ' Already has a decimal point
            End If
            Exit Sub
        End If

        ' Block all other characters
        e.Handled = True




    End Sub

    Sub cleartext()
        lbl_loanamount.Text = ""
        lbl_ma.Text = ""
        lbl_processfee.Text = ""
        cmb_purpose.SelectedIndex = -1
    End Sub
    Private Sub txt_terms_TextChanged(sender As Object, e As EventArgs) Handles txt_terms.TextChanged
        cleartext()


    End Sub

    Private Sub txt_terms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_terms.KeyPress
        ' Allow only numbers, one decimal point, and control keys (Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the input

            cleartext()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try

            Dim interest As Decimal = Convert.ToDecimal((monthly_ammo * Convert.ToInt32(txt_terms.Text) - Convert.ToDecimal(txt_amount.Text)))

            con.Close()
            con.Open()

            ' Use parameterized query
            Dim cmdinsert As New MySqlCommand("INSERT INTO `loan_app` ( `account_no`,
                                                                        `amount`,
                                                                        `ammortization`,
                                                                        `date_apply`,
                                                                        `date_approved`,
                                                                        `date_start`,
                                                                        `months_count`,
                                                                        `teller`,
                                                                        `teller_approved`,
                                                                         `teller_release`, 
                                                                        `mode`,
                                                                        `purpose`,
                                                                        `comaker_1`,
                                                                        `comaker_2`,
                                                                        `interest_rate`,
                                                                        `service_fee`,
                                                                        `insurance_fee`,
                                                                        `interest`,
                                                                        `collateral`,
                                                                        `collateral_value`,
                                                                        `status`)
                                                                VALUES ( @account_no,
                                                                        @amount,
                                                                        @ammortization,
                                                                       CURDATE(),
                                                                        @date_approved,
                                                                        @date_start,
                                                                        @months_count,
                                                                        @teller,
                                                                        @teller_approved,
                                                                        @teller_release,
                                                                        @mode, @purpose,
                                                                        @comaker_1,
                                                                        @comaker_2,
                                                                        @interest_rate,
                                                                        @service_fee,
                                                                        @insurance_fee,
                                                                        @interest,
                                                                        @collateral,
                                                                        @collateral_value,
                                                                        @status)", con)

            ' Add parameters

            cmdinsert.Parameters.AddWithValue("@account_no", client_accountno)
            cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amount.Text))
            cmdinsert.Parameters.AddWithValue("@ammortization", monthly_ammo)

            cmdinsert.Parameters.AddWithValue("@date_approved", DBNull.Value)
            cmdinsert.Parameters.AddWithValue("@date_start", DBNull.Value)
            cmdinsert.Parameters.AddWithValue("@months_count", Convert.ToInt32(txt_terms.Text))
            cmdinsert.Parameters.AddWithValue("@teller", user_IDno)
            cmdinsert.Parameters.AddWithValue("@teller_approved", String.Empty)
            cmdinsert.Parameters.AddWithValue("@teller_release", String.Empty)
            cmdinsert.Parameters.AddWithValue("@mode", cmb_mode.Text)
            cmdinsert.Parameters.AddWithValue("@purpose", cmb_purpose.Text.Split("("c)(0).Trim())
            cmdinsert.Parameters.AddWithValue("@comaker_1", "")
            cmdinsert.Parameters.AddWithValue("@comaker_2", "")
            cmdinsert.Parameters.AddWithValue("@interest_rate", interestDecimal * 100D)
            cmdinsert.Parameters.AddWithValue("@service_fee", Convert.ToDecimal(lbl_processfee.Text))
            cmdinsert.Parameters.AddWithValue("@insurance_fee", Convert.ToDecimal(txt_insurance.Text))
            cmdinsert.Parameters.AddWithValue("@interest", interest)
            cmdinsert.Parameters.AddWithValue("@collateral", cmb_collateral.Text)
            cmdinsert.Parameters.AddWithValue("@collateral_value", Convert.ToDecimal(Val(txt_collavalue.Text)))
            cmdinsert.Parameters.AddWithValue("@status", 0)
            cmdinsert.ExecuteNonQuery()

            'If MessageBox.Show("Application saved. Do you want to print info?", "Print info?", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            '    Dim print As New print_loanapp
            '    print.printapplication(lbl_reference.Text)
            '    print.ShowDialog()

            'End If


            Me.Close()
        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cmb_purpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_purpose.SelectedIndexChanged
        If cmb_purpose.SelectedIndex = -1 Then
            Exit Sub
        End If

        If txt_amount.Text.Trim = "" Or txt_terms.Text.Trim = "" Then
            show_error("Please input Amount or Terms.")
            cmb_purpose.SelectedIndex = -1
            Exit Sub
        End If




        Dim item As String = cmb_purpose.SelectedItem.ToString()

        ' Get index of the opening parenthesis
        Dim openParen As Integer = item.IndexOf("(")
        Dim closeParen As Integer = item.IndexOf("%")

        If openParen > -1 AndAlso closeParen > openParen Then
            Dim loanType As String = item.Substring(0, openParen).Trim()
            Dim interestStr As String = item.Substring(openParen + 1, closeParen - openParen - 1)

            If Decimal.TryParse(interestStr, interestDecimal) Then
                interestDecimal /= 100D
            End If

            Dim monthly_interest_rate As Decimal = interestDecimal / 12D
            Dim loan_amount As Decimal = Convert.ToDecimal(txt_amount.Text)


            ' Calculate monthly amortization
            monthly_ammo = Math.Round((loan_amount * monthly_interest_rate) / (1 - (1 + monthly_interest_rate) ^ -Convert.ToInt32(txt_terms.Text)), 2)

            'service fee
            If Convert.ToInt32(txt_terms.Text) <= 6 Then
                lbl_processfee.Text = loan_amount * 0.015
            Else
                lbl_processfee.Text = loan_amount * 0.03
            End If



            lbl_purpose.Text = loanType
            lbl_ma.Text = monthly_ammo.ToString("N2")
            lbl_loanamount.Text = loan_amount.ToString("N2")
            lbl_term.Text = txt_terms.Text & " months"
            lbl_rate.Text = interestStr & "%"
            interest_amount = Convert.ToDecimal((monthly_ammo * Convert.ToInt32(txt_terms.Text)) - loan_amount)


            'lbl_loanamount.Text = loan_amount.ToString("N0")
            'lbl_processfee.Text = "-" & Convert.ToDecimal(lbl_servicefee.Text).ToString("N0")
            'lbl_purpose.Text = cmb_purpose.Text

            'lbl_disbursement.Text = (loan_amount - (Convert.ToDecimal(lbl_servicefee.Text) + Convert.ToDecimal(txt_insurance.Text) + Convert.ToDecimal(txt_otheramount1.Text) + Convert.ToDecimal(txt_otheramount2.Text))).ToString("N0")
            'lbl_term.Text = month_count & " months"
            'lbl_ma.Text = txt_ma.Text



        End If
    End Sub



    Private Sub cmb_purpose_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_purpose.MouseClick
    End Sub

    Private Sub txt_insurance_TextChanged(sender As Object, e As EventArgs) Handles txt_insurance.TextChanged
        Dim insuranceValue As Decimal

        If Decimal.TryParse(txt_insurance.Text, insuranceValue) AndAlso insuranceValue > 0 Then
            lbl_insurancefee.Text = insuranceValue.ToString("N2")
        Else
            lbl_insurancefee.Text = ""
        End If
    End Sub

    Private Sub cmb_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mode.SelectedIndexChanged
        lbl_transfer.Text = cmb_mode.Text
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        search_name.comaker = 0
        search_name.ShowDialog()
        search_name.BringToFront()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        search_name.comaker = 1
        search_name.ShowDialog()
        search_name.BringToFront()
    End Sub
End Class