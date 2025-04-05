Imports MySql.Data.MySqlClient
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class add_member
    Private videoSource As VideoCaptureDevice
    Private isCameraOpen As Boolean = False

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Try


            con.Close()
            con.Open()

            ' Prepare the query to include the image parameter
            Dim query As String = "INSERT INTO `member_profile` ( `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`,`email`, `emp_status`, `idtype`, `idtype_no`, `image`, `status`) 
                               VALUES (@account_no, @firstname, @middlename, @lastname, @birthdate, @civilstatus, @gender, @place_birth, @present_address, @contact1, @contact2, @email, @emp_status, @idtype, @idtype_no, @image, 1)"

            Dim insertaccount As New MySqlCommand(query, con)

            ' Add the parameters for the other fields
            insertaccount.Parameters.AddWithValue("@account_no", txt_account.Text)
            insertaccount.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            insertaccount.Parameters.AddWithValue("@middlename", txt_midlename.Text)
            insertaccount.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            insertaccount.Parameters.AddWithValue("@birthdate", dtpicker1.Value.ToString("yyyy-MM-dd"))
            insertaccount.Parameters.AddWithValue("@civilstatus", cmb_civil.Text.Substring(0, 1))
            insertaccount.Parameters.AddWithValue("@gender", cmb_gender.Text.Substring(0, 1))
            insertaccount.Parameters.AddWithValue("@place_birth", txt_birthplace.Text)
            insertaccount.Parameters.AddWithValue("@present_address", txt_presentadd.Text)
            insertaccount.Parameters.AddWithValue("@contact1", txt_contact1.Text)
            insertaccount.Parameters.AddWithValue("@contact2", txt_contact2.Text)
            insertaccount.Parameters.AddWithValue("@email", txt_email.Text)
            insertaccount.Parameters.AddWithValue("@emp_status", cmb_empstatus.Text)
            insertaccount.Parameters.AddWithValue("@idtype", cmb_idtype.Text)
            insertaccount.Parameters.AddWithValue("@idtype_no", txt_id.Text)

            ' Convert the image in the PictureBox to a byte array and add it as a parameter
            insertaccount.Parameters.AddWithValue("@image", ImageToByteArray(pic_user.Image))

            ' Execute the query
            insertaccount.ExecuteNonQuery()
            MessageBox.Show("The new member has been added successfully.", "Account Created!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()


        Catch ex As MySqlException When ex.Number = 1062
            ' Handle duplicate entry error
            show_error("A record with this information already exists. No changes were made.")
        Catch ex As Exception
            ' Handle other errors
            show_error("Something went wrong, Please review input.")

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

            ChangeBackgroundToWhite(Image.FromFile(openFileDialog.FileName))



        End If
    End Sub

    Private Sub add_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getAccountno()
    End Sub


    Sub getAccountno()
        Dim nextID As Integer = 1 ' Default to 1 in case table is empty

        Try
            con.Close()
            con.Open()
            Dim query As String = "SELECT IFNULL(MAX(id), 0) + 1 FROM member_profile"
            Dim cmd As New MySqlCommand(query, con)

            If con.State = ConnectionState.Closed Then con.Open()
            nextID = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            ' Now you can use nextID (e.g., assign to a label or textbox)
            txt_account.Text = nextID.ToString()

        Catch ex As Exception
            MessageBox.Show("Error getting next ID: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        txt_presentadd.Text = txt_birthplace.Text
    End Sub
End Class