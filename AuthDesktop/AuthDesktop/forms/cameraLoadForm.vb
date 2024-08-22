Imports System.Windows.Forms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Imaging
Imports System.IO

Public Class cameraLoadForm
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice
    Private currentFrame As Bitmap
    Private isSaving As Boolean = False ' Flag to prevent multiple saves
    Private imagesFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SavedImagesAuth") ' Path to the folder containing saved images

    Public Sub New()
        InitializeComponent()
        InitializeWebcam()
    End Sub

    Private Sub InitializeWebcam()
        ' Get the available video devices
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count = 0 Then
            MessageBox.Show("No video devices found.")
            Return
        End If

        ' Create a video capture device
        videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
        videoSource.Start()
    End Sub

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Get the current frame
        currentFrame = CType(eventArgs.Frame.Clone(), Bitmap)

        ' Simple brightness-based check for centered face simulation
        Dim frameCenterX As Integer = currentFrame.Width \ 2
        Dim frameCenterY As Integer = currentFrame.Height \ 2

        Dim captureThreshold As Integer = 50
        Dim brightnessSum As Integer = 0
        Dim pixelCount As Integer = 0

        For x As Integer = frameCenterX - 10 To frameCenterX + 10
            For y As Integer = frameCenterY - 10 To frameCenterY + 10
                Dim pixelColor As Color = currentFrame.GetPixel(x, y)
                Dim brightness As Integer = (CInt(pixelColor.R) + CInt(pixelColor.G) + CInt(pixelColor.B)) \ 3
                brightnessSum += brightness
                pixelCount += 1
            Next
        Next

        Dim averageBrightness As Integer = brightnessSum \ pixelCount

        If averageBrightness > 100 AndAlso averageBrightness < 200 AndAlso Not isSaving Then
            ' Set the flag to true to prevent multiple dialog boxes
            isSaving = True
            Me.BeginInvoke(New Action(AddressOf SaveCapturedImage))
        End If

        PictureBox1.Image = currentFrame
    End Sub

    Private Sub SaveCapturedImage()
        If currentFrame IsNot Nothing Then
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png"
            saveFileDialog.Title = "Save an Image File"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                currentFrame.Save(filePath, ImageFormat.Jpeg)
                MessageBox.Show("Image captured and saved successfully.")
            End If

            Me.Close()
            'dashboard.Show()
            CompareCapturedImage()

        Else
            MessageBox.Show("No image to save.")
        End If

        ' Reset the flag after the save operation
        isSaving = False
    End Sub

    Private Sub CompareCapturedImage()
        If currentFrame IsNot Nothing Then
            ' Get all image files in the folder
            Dim imageFiles As String() = Directory.GetFiles(imagesFolderPath, "*.jpg")

            If imageFiles.Length = 0 Then
                MessageBox.Show("No images found in the folder.")
                isSaving = False
                Return
            End If

            ' Iterate through the saved images and compare each one
            For Each imageFile In imageFiles
                Dim savedImage As Bitmap = CType(Image.FromFile(imageFile), Bitmap)
                If CompareImages(savedImage, currentFrame) Then
                    MessageBox.Show("The captured image matches: " & Path.GetFileName(imageFile))
                    savedImage.Dispose()
                    isSaving = False
                    Return
                End If
                savedImage.Dispose()
            Next

            ' If no match is found
            MessageBox.Show("No image found for this person.")
        Else
            MessageBox.Show("No image to compare.")
        End If

        ' Reset the flag after comparison
        isSaving = False
    End Sub

    Private Function CompareImages(ByVal img1 As Bitmap, ByVal img2 As Bitmap) As Boolean
        ' Basic check: Are the dimensions the same?
        If img1.Width <> img2.Width OrElse img1.Height <> img2.Height Then
            Return False
        End If

        ' Compare pixel-by-pixel (this is a simple and not very robust approach)
        For x As Integer = 0 To img1.Width - 1
            For y As Integer = 0 To img1.Height - 1
                If img1.GetPixel(x, y) <> img2.GetPixel(x, y) Then
                    Return False
                End If
            Next
        Next

        ' If we reach here, the images are considered similar
        Return True
    End Function


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop the video source when the form is closing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
    End Sub
End Class
