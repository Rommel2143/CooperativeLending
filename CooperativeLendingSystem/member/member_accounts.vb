Imports MySql.Data.MySqlClient
Public Class member_accounts
    Private Sub member_accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LoadData(query As String)
        Try
            ' Load the data into the DataGridView
            reload("SELECT mp.account_no AS 'Account no.', CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, DATE_FORMAT(mp.birthdate, '%M %d, %Y') AS Birthday, TIMESTAMPDIFF(Year, mp.birthdate, CURDATE()) AS Age, mp.contact1 AS 'Primary Contact',place_birth AS 'Address' FROM `member_profile` mp WHERE " & query, datagrid1)



        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged


        If txt_search.Text = "" Then
                LoadData("1")
            Else

                LoadData(" account_no REGEXP '" & txt_search.Text & "' or lastname REGEXP '" & txt_search.Text & "'")

            End If

    End Sub

    Private Sub datagrid1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid1.CellMouseClick
        Try
            ' Ensure that a valid row is clicked and the cells contain data
            If e.RowIndex >= 0 AndAlso e.RowIndex < datagrid1.Rows.Count Then
                'Dim accountNo As String = If(datagrid1.Rows(e.RowIndex).Cells("Account no.").Value IsNot Nothing, datagrid1.Rows(e.RowIndex).Cells("Account no.").Value.ToString(), String.Empty)

                getClient(datagrid1.Rows(e.RowIndex).Cells("Account no.").Value.ToString())

                member_options.Show()
                    member_options.BringToFront()

            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub
End Class