Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "KDG Software (MOGNORI BCP)"
    End Sub

    Private Sub APPROVALSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APPROVALSToolStripMenuItem.Click
        APPROVALS.Show()
    End Sub

    Private Sub NEWUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWUSERToolStripMenuItem.Click
        signIn.Show()
    End Sub

    Private Sub APPLICATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APPLICATIONSToolStripMenuItem.Click
        otherApplication.Show()
    End Sub

    Private Sub RESETPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESETPASSWORDToolStripMenuItem.Click
        passwordReset.Show()
    End Sub
End Class