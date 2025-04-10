
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class member_options

    Private Sub member_options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub
    Private Sub load_data()

        lbl_fullname.Text = client_firstname.ToUpper & " " & client_lastname.ToUpper
        lbl_accountno.Text = "Acc# : " & client_accountno
        Try
            con.Close()
            con.Open()

            ' Prepare the query to retrieve member details based on account_no
            Dim query As String = "SELECT `image` FROM `member_profile` WHERE `account_no` = @accountno"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@accountno", client_accountno)

            ' Execute the command and retrieve the data
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    ' Check if image column is not DBNull before attempting to read
                    If Not IsDBNull(dr("image")) Then
                        Dim imageData As Byte() = CType(dr("image"), Byte())

                        ' Convert the byte array back to an image
                        Using ms As New MemoryStream(imageData)
                            pic_user.Image = Image.FromStream(ms)
                        End Using
                    Else
                        ' Set default image if no image found in the database
                        pic_user.Image = My.Resources.default1
                    End If
                Else
                    show_error("Account not found.")
                End If
            End Using

        Catch ex As Exception
            show_error("Oops! Something Went Wrong")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click

        display_inSub(New savings)
        Me.Close()
    End Sub


End Class