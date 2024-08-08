Imports System.Windows.Forms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Imaging

Public Class cameraLoadForm
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice
    Private currentFrame As Bitmap

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
        ' Display the video frame (for example, in a PictureBox control)
        PictureBox1.Image = CType(eventArgs.Frame.Clone(), Drawing.Bitmap)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop the video source when the form is closing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        ' Save the current frame to a file
        If currentFrame IsNot Nothing Then
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png"
            saveFileDialog.Title = "Save an Image File"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                currentFrame.Save(filePath, ImageFormat.Jpeg)
            End If
        Else
            MessageBox.Show("No image to save.")
        End If

        Me.Close()
        dashboard.Show()

    End Sub


End Class