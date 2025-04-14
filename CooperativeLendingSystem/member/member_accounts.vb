Imports MySql.Data.MySqlClient
Public Class member_accounts
    Private Sub member_accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Load and display data in DataGridView based on search query
    Public Sub LoadData(queryCondition As String)
        Try
            Dim query As String = "
            SELECT 
                mp.account_no AS 'Account no.',
                CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname,
                DATE_FORMAT(mp.birthdate, '%M %d, %Y') AS Birthday,
                TIMESTAMPDIFF(YEAR, mp.birthdate, CURDATE()) AS Age,
                mp.contact1 AS 'Primary Contact',
                mp.place_birth AS 'Address'
            FROM member_profile mp
            WHERE " & queryCondition & "
            ORDER BY mp.lastname ASC"

            reload(query, datagrid1)

        Catch ex As Exception
            show_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Perform live search as user types
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim searchText As String = txt_search.Text.Trim()

        If searchText = "" Then
            LoadData("1") ' Load all data
        Else
            ' Make the search case-insensitive
            Dim condition As String = "
            LOWER(mp.account_no) REGEXP LOWER('" & searchText & "') OR
            LOWER(mp.lastname) REGEXP LOWER('" & searchText & "') OR
            LOWER(CONCAT(mp.lastname, ' ', mp.firstname)) REGEXP LOWER('" & searchText & "')"
            LoadData(condition)
        End If
    End Sub


    Private Sub datagrid1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid1.CellMouseClick
        Try
            ' Ensure that a valid row is clicked and the cells contain data
            If e.RowIndex >= 0 AndAlso e.RowIndex < datagrid1.Rows.Count Then
                'Dim accountNo As String = If(datagrid1.Rows(e.RowIndex).Cells("Account no.").Value IsNot Nothing, datagrid1.Rows(e.RowIndex).Cells("Account no.").Value.ToString(), String.Empty)

                getClient(datagrid1.Rows(e.RowIndex).Cells("Account no.").Value.ToString())

                member_options.ShowDialog()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If isAccess("add_member") = True Then
            display_inSub(add_member)
        Else
            show_error("You need permission to access this content.")
        End If
    End Sub
End Class