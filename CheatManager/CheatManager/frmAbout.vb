Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lblAbout.Text = "Program Written By: Gavin_Darkglider" & vbCrLf & vbCrLf & "Database By: Gavin_Darkglider" & vbCrLf & vbCrLf & "Tested By: Gavin_Darkglider & Felida & Swizzy" & vbCrLf & vbCrLf & "Rebuild and mod by: mLoaD" & vbCrLf & vbCrLf & "Special Thanks To:" & vbCrLf & "Maester Rowen and Swizzy for fixing Retroarch for xbox 360," & vbCrLf & "And all the other work they do for the xbox scene."
        'lblAbout.Text = lblAbout.Text & vbCrLf & vbCrLf & "Special Thanks To:" & vbCrLf & "Retroarch Devs for making Retroarch 360 Port"
        'lblAbout.Text = lblAbout.Text & vbCrLf & vbCrLf & "This works for all versions of Retroarch"
        'lblAbout.Text = lblAbout.Text & vbCrLf & vbCrLf & "This update is a quality of life improvement from of the original 0.4b"
        'lblAbout.Text = lblAbout.Text & vbCrLf & "and is not supported by Gavin_Darkglider"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("https://github.com/mLoaDs?tab=repositories")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("https://www.realmodscene.com/index.php?/topic/5032-cheat-manager-for-emulators/&tab=comments#comment-40404")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("")
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.realmodscene.com/index.php?/topic/5032-cheat-manager-for-emulators/&tab=comments#comment-40404")
    End Sub
End Class