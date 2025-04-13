Imports MySql.Data.MySqlClient
Public Class search_name
    Public comaker As Boolean
    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub reloadgrid(search As String)
        Dim query As String = "
        SELECT 
            mp.account_no AS Account_no, 
            CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, 
            COALESCE(
                SUM(CASE WHEN sc.status IN ( 'ID' ,'CM','CD','ISC' ,'IPR' ,'C','CASHDEP','BEGBAL','CMEMO','CHKDEP','CSHAD1','INT') THEN sc.amount ELSE 0 END) - 
                SUM(CASE WHEN sc.status IN ('DM' ,'CA' ,'D','DMEMO','CHKWID','CSHWIT','CHKWIT') THEN sc.amount ELSE 0 END), 
                0
            ) AS Sharecap,  
            COUNT(DISTINCT CASE WHEN EXISTS (
            SELECT 1 
            FROM loan_collection lc_sub 
            WHERE lc_sub.referenceno = lc.referenceno AND lc_sub.status = 0
        ) THEN lc.referenceno END) AS Pending_Loans
        FROM 
            member_profile mp
        LEFT JOIN 
            sharecap sc ON sc.account_no = mp.account_no
        LEFT JOIN 
            loan_collection lc ON lc.account_no = mp.account_no
        WHERE 
          " & search & " 
        GROUP BY 
            mp.account_no"

        ' Reload the DataGridView with the query
        reload(query, datagrid1)

        ' Format the Sharecap column as currency

    End Sub






    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txt_search.Text = "" Then

                    datagrid1.DataSource = Nothing
                Else
                    reloadgrid("mp.account_no REGEXP '" & txt_search.Text & "' OR firstname REGEXP '" & txt_search.Text & "'  OR lastname REGEXP '" & txt_search.Text & "'")

                End If
            Catch ex As Exception
                ' Handle the exception, e.g., display a custom message or log the error
                MessageBox.Show("An error occurred while searching. Please try again.")
            End Try
        End If
    End Sub

    Private Sub datagrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim accountno As String = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()

            Dim fname As String = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()





            With loan_application
                Select Case comaker

                    Case 0
                        .lbl_cm1.Text = accountno & ":" & fname

                    Case 1
                        .lbl_cm2.Text = accountno & ":" & fname
                End Select
                Me.Close()
            End With
        End If
    End Sub
End Class