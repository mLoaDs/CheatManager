Public Class FrmGame

    Private Sub FrmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modDB.LoadCheatList(frmMain.Game)
        cboSystem.Items.Clear()
        cboSystem.Items.Add("Unknown")
        cboSystem.Items.Add("Nintendo")
        cboSystem.Items.Add("Super Nintendo")
        cboSystem.Items.Add("Game Boy Game Boy Color")
        cboSystem.Items.Add("Game Boy Advanced")
        cboSystem.Items.Add("Sega Genesis")
        cboSystem.Items.Add("Sega Game Gear")
        cboSystem.Items.Add("TyrQuake")
        cboSystem.Items.Add("PRBoom")
        cboSystem.SelectedIndex = modDB.GetGame(3, frmMain.Game) - 1
        If modDB.GetGame(1, frmMain.Game) = "0" Then
            txtGameName.Text = "New Game"
        Else
            txtGameName.Text = modDB.GetGame(1, frmMain.Game)
            lblSHA256.MaximumSize = New Size(100, 0)
            lblSHA256.Text = modDB.GetGame(4, frmMain.Game)
            chkHasRom.Checked = modDB.GetGame(2, frmMain.Game)
            UpdateCheatCountLabel()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MsgBox("Are you sure you want to save modifications to Game?", vbYesNo) = vbYes Then
            modDB.ChangeGame(cboSystem.SelectedIndex, 3, frmMain.Game)
            modDB.ChangeGame(txtGameName.Text, 1, frmMain.Game)
            modDB.ChangeGame(chkHasRom.Checked, 2, frmMain.Game)
            modDB.ChangeGame(lblSHA256.Text, 4, frmMain.Game)
            LoadGameList(frmMain.CboSort.SelectedIndex, frmMain.txtSearch.Text)
        End If
    End Sub

    Private Sub LstCheat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCheat.SelectedIndexChanged
        frmCheat.cheat = LstCheat.SelectedValue
        UpdateCheatCountLabel()
    End Sub

    Private Sub btnModCheat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModCheat.Click
        frmCheat.Show()
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        modDB.CreateCheat(frmMain.Game)
        UpdateCheatCountLabel()
    End Sub

    Private Sub btnDeleteCheat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCheat.Click
        'added MessageBox
        If MsgBox("delete Cheat from the database?", vbYesNo) = vbYes Then
            modDB.DeleteCheat(frmCheat.cheat)
            UpdateCheatCountLabel()
        End If
    End Sub

    Private Sub UpdateCheatCountLabel()
        lblCheatCount.Text = "Cheats: " & LstCheat.Items.Count.ToString()
    End Sub

    Private Sub lblSHA256_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSHA256.Click
        OpenFileDialog.ShowDialog()
        If Not OpenFileDialog.FileName = "" Then
            lblSHA256.Text = sha_256_Gen(OpenFileDialog.FileName)
        End If
    End Sub
    '----- Load the Console System Logo-----
    Private Sub cboSystem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSystem.SelectedIndexChanged
        Dim pic = CType(My.Resources.ResourceManager.GetObject(CStr(cboSystem.SelectedItem)), Image)
        PictureBox1.Image = pic
        '---------------------------------------
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class