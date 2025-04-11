
Imports MySql.Data.MySqlClient
    Imports System.IO
    Imports AForge.Video
    Imports AForge.Video.DirectShow
Public Class update_member
    Private videoSource As VideoCaptureDevice
    Private isCameraOpen As Boolean = False

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If isAccess("update_member") = True Then
            updatemember()
        Else
            show_error("You need permission to access this feature.")
        End If
    End Sub

    Private Sub updatemember()
        Try
            con.Close()
            con.Open()

            ' Prepare the UPDATE query
            Dim query As String = "UPDATE `member_profile` SET " &
                          "`firstname` = @firstname, " &
                          "`middlename` = @middlename, " &
                          "`lastname` = @lastname, " &
                          "`birthdate` = @birthdate, " &
                          "`civilstatus` = @civilstatus, " &
                          "`gender` = @gender, " &
                          "`place_birth` = @place_birth, " &
                          "`present_address` = @present_address, " &
                          "`contact1` = @contact1, " &
                          "`contact2` = @contact2, " &
                          "`email` = @email, " &
                          "`emp_status` = @emp_status, " &
                          "`idtype` = @idtype, " &
                          "`idtype_no` = @idtype_no, " &
                          "`image` = @image " &
                          "WHERE `account_no` = @account_no"

            Dim updateMember As New MySqlCommand(query, con)

            ' Convert image to byte array safely
            Dim imgBytes As Byte() = Nothing
            If pic_user.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    Using bmp As New Bitmap(pic_user.Image) ' Clone to prevent lock
                        bmp.Save(ms, Imaging.ImageFormat.Jpeg)
                    End Using
                    imgBytes = ms.ToArray()
                End Using
            End If

            ' Add parameters
            updateMember.Parameters.AddWithValue("@account_no", txt_account.Text)
            updateMember.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            updateMember.Parameters.AddWithValue("@middlename", txt_midlename.Text)
            updateMember.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            updateMember.Parameters.AddWithValue("@birthdate", dtpicker1.Value.ToString("yyyy-MM-dd"))
            updateMember.Parameters.AddWithValue("@civilstatus", cmb_civil.Text.Substring(0, 1))
            updateMember.Parameters.AddWithValue("@gender", cmb_gender.Text.Substring(0, 1))
            updateMember.Parameters.AddWithValue("@place_birth", txt_birthplace.Text)
            updateMember.Parameters.AddWithValue("@present_address", txt_presentadd.Text)
            updateMember.Parameters.AddWithValue("@contact1", txt_contact1.Text)
            updateMember.Parameters.AddWithValue("@contact2", txt_contact2.Text)
            updateMember.Parameters.AddWithValue("@email", txt_email.Text)
            updateMember.Parameters.AddWithValue("@emp_status", cmb_empstatus.Text)
            updateMember.Parameters.AddWithValue("@idtype", cmb_idtype.Text)
            updateMember.Parameters.AddWithValue("@idtype_no", txt_id.Text)
            updateMember.Parameters.AddWithValue("@image", imgBytes)

            updateMember.ExecuteNonQuery()
            MessageBox.Show("Member details updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            show_error("Failed to update member: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function ImageToByteArray(image As Image) As Byte()
        If image Is Nothing Then Return Nothing
        Using ms As New MemoryStream()
            image.Save(ms, Imaging.ImageFormat.Jpeg) ' You can change the format if needed
            Return ms.ToArray()
        End Using
    End Function

    Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Capture the current frame from the camera
        Dim frame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Display the captured frame in pic_user PictureBox
        pic_user.Image = frame
    End Sub
    Private Sub open_cam_Click(sender As Object, e As EventArgs) Handles open_cam.Click
        If Not isCameraOpen Then
            Try
                ' Select the video device (camera)
                Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
                If videoDevices.Count = 0 Then
                    MessageBox.Show("No camera detected. Please check your camera connection.")
                    Exit Sub
                End If

                ' Use the first available camera
                videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)

                ' Handle the NewFrame event to get the image from the camera
                AddHandler videoSource.NewFrame, AddressOf Video_NewFrame

                ' Start the video capture
                videoSource.Start()
                isCameraOpen = True
                open_cam.Image = My.Resources.lens
                open_cam.Text = "Capture"
            Catch ex As Exception
                show_error("Error opening camera: " & ex.Message)
            End Try
        Else



            ' Capture the image and close the camera
            If pic_user.Image IsNot Nothing Then
                ' Create a new bitmap from the current image in the PictureBox
                Dim capturedImage As Bitmap = DirectCast(pic_user.Image.Clone(), Bitmap)


                ChangeBackgroundToWhite(capturedImage)

                ' Display the captured image in the previously opened add_member form's pic_user PictureBox

                isCameraOpen = False
                open_cam.Image = My.Resources.camera

                open_cam.Text = "Open Camera"
            Else
                show_error("No image available to capture.")
            End If

            ' Stop the camera
            If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
                videoSource.SignalToStop()
                videoSource.WaitForStop()
            End If


        End If
    End Sub

    Private Sub ChangeBackgroundToWhite(originalImage As Bitmap)
        Dim width As Integer = originalImage.Width
        Dim height As Integer = originalImage.Height
        Dim newImage As New Bitmap(width, height)

        For x As Integer = 0 To width - 1
            For y As Integer = 0 To height - 1
                Dim pixelColor As Color = originalImage.GetPixel(x, y)

                ' Assuming the background is a certain color (e.g., close to white)
                ' You can adjust the RGB values based on your background color
                If pixelColor.A > 0 AndAlso (pixelColor.R < 200 Or pixelColor.G < 200 Or pixelColor.B < 200) Then
                    ' If the pixel is not close to white, retain its color
                    newImage.SetPixel(x, y, pixelColor)
                Else
                    ' Change the background to white
                    newImage.SetPixel(x, y, Color.White)
                End If
            Next
        Next

        pic_user.Image = newImage
    End Sub

    Private Sub upload_pic_Click(sender As Object, e As EventArgs) Handles upload_pic.Click
        ' Create and configure OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" ' Filter to only allow image files
        openFileDialog.Title = "Select an Image"

        ' Show the dialog and if the user selects a file, display it in the PictureBox
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox

            pic_user.Image = Image.FromFile(openFileDialog.FileName)



        End If
    End Sub

    Private Sub add_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getAccountno()
    End Sub


    Sub getAccountno()
        Try
            con.Close()
            con.Open()

            Dim query As String = "SELECT * FROM member_profile WHERE account_no = @account_no"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@account_no", client_accountno)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_account.Text = reader("account_no").ToString()
                txt_firstname.Text = reader("firstname").ToString()
                txt_midlename.Text = reader("middlename").ToString()
                txt_lastname.Text = reader("lastname").ToString()
                dtpicker1.Value = Convert.ToDateTime(reader("birthdate"))
                Select Case reader("civilstatus").ToString()
                    Case "S"
                        cmb_civil.Text = "Single"
                    Case "M"
                        cmb_civil.Text = "Married"
                    Case "D"
                        cmb_civil.Text = "Divorced"
                    Case "W"
                        cmb_civil.Text = "Widowed"
                    Case "O"
                        cmb_civil.Text = "Other"
                    Case Else
                        cmb_civil.SelectedIndex = -1
                End Select

                Select Case reader("gender").ToString()
                    Case "M"
                        cmb_gender.Text = "Male"
                    Case "F"
                        cmb_gender.Text = "Female"
                    Case "O"
                        cmb_gender.Text = "Other"
                    Case Else
                        cmb_gender.SelectedIndex = -1 ' Clear selection if unknown
                End Select

                txt_birthplace.Text = reader("place_birth").ToString()
                txt_presentadd.Text = reader("present_address").ToString()
                txt_contact1.Text = reader("contact1").ToString()
                txt_contact2.Text = reader("contact2").ToString()
                txt_email.Text = reader("email").ToString()
                cmb_empstatus.Text = reader("emp_status").ToString()
                cmb_idtype.Text = reader("idtype").ToString()
                txt_id.Text = reader("idtype_no").ToString()

                ' Load image if available
                If Not IsDBNull(reader("image")) Then
                    Dim imgBytes() As Byte = DirectCast(reader("image"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        pic_user.Image = Image.FromStream(ms)
                    End Using
                End If
            Else
                MessageBox.Show("No member found with this account number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading member data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        txt_presentadd.Text = txt_birthplace.Text
    End Sub
End Class