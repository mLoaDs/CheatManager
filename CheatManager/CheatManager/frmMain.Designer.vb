<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstGame = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGameType = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGamesHad = New System.Windows.Forms.Label()
        Me.CboSort = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGG2Hex = New System.Windows.Forms.Button()
        Me.btnCompareAgainstRoms = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModGame = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dlc = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblCheatNum = New System.Windows.Forms.Label()
        Me.lblGameNum = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.IstGame = New System.Windows.Forms.ListBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GameList = New System.Windows.Forms.ToolTip(Me.components)
        Me.GG2Hex = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheatRoms = New System.Windows.Forms.ToolTip(Me.components)
        Me.Export = New System.Windows.Forms.ToolTip(Me.components)
        Me.UploadFTP = New System.Windows.Forms.ToolTip(Me.components)
        Me.CodeandCht = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddGame = New System.Windows.Forms.ToolTip(Me.components)
        Me.ModGame = New System.Windows.Forms.ToolTip(Me.components)
        Me.RemoveGameCheats = New System.Windows.Forms.ToolTip(Me.components)
        Me.SettPathFTP = New System.Windows.Forms.ToolTip(Me.components)
        Me.About = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.github = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstGame
        '
        Me.lstGame.BackColor = System.Drawing.SystemColors.Window
        Me.lstGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGame.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstGame.FormattingEnabled = True
        Me.lstGame.Location = New System.Drawing.Point(6, 16)
        Me.lstGame.Name = "lstGame"
        Me.lstGame.Size = New System.Drawing.Size(539, 485)
        Me.lstGame.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Games In DataBase:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Games You Have:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cheats In Database:"
        '
        'lblGameType
        '
        Me.lblGameType.AutoSize = True
        Me.lblGameType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameType.Location = New System.Drawing.Point(116, 2)
        Me.lblGameType.Name = "lblGameType"
        Me.lblGameType.Size = New System.Drawing.Size(39, 13)
        Me.lblGameType.TabIndex = 5
        Me.lblGameType.Text = "Lable2"
        Me.lblGameType.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblGamesHad)
        Me.GroupBox1.Controls.Add(Me.CboSort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(570, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(9, 85)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(191, 20)
        Me.txtSearch.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Search:"
        '
        'lblGamesHad
        '
        Me.lblGamesHad.AutoSize = True
        Me.lblGamesHad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblGamesHad.Location = New System.Drawing.Point(130, 56)
        Me.lblGamesHad.Name = "lblGamesHad"
        Me.lblGamesHad.Size = New System.Drawing.Size(14, 13)
        Me.lblGamesHad.TabIndex = 17
        Me.lblGamesHad.Text = "0"
        '
        'CboSort
        '
        Me.CboSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSort.FormattingEnabled = True
        Me.CboSort.Location = New System.Drawing.Point(9, 32)
        Me.CboSort.Name = "CboSort"
        Me.CboSort.Size = New System.Drawing.Size(191, 21)
        Me.CboSort.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sort List:"
        '
        'btnGG2Hex
        '
        Me.btnGG2Hex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGG2Hex.Location = New System.Drawing.Point(22, 19)
        Me.btnGG2Hex.Name = "btnGG2Hex"
        Me.btnGG2Hex.Size = New System.Drawing.Size(163, 23)
        Me.btnGG2Hex.TabIndex = 4
        Me.btnGG2Hex.Text = "GG to Hex Converter"
        Me.GG2Hex.SetToolTip(Me.btnGG2Hex, "Convert Game Genie code to Hex code.")
        Me.btnGG2Hex.UseVisualStyleBackColor = True
        '
        'btnCompareAgainstRoms
        '
        Me.btnCompareAgainstRoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompareAgainstRoms.Location = New System.Drawing.Point(22, 48)
        Me.btnCompareAgainstRoms.Name = "btnCompareAgainstRoms"
        Me.btnCompareAgainstRoms.Size = New System.Drawing.Size(163, 23)
        Me.btnCompareAgainstRoms.TabIndex = 5
        Me.btnCompareAgainstRoms.Text = "Compare Cheats Against Roms"
        Me.CheatRoms.SetToolTip(Me.btnCompareAgainstRoms, "Compare the cheats with the Roms.")
        Me.btnCompareAgainstRoms.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(22, 77)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(163, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import Cheats From File"
        Me.btnImport.UseVisualStyleBackColor = True
        Me.btnImport.Visible = False
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(22, 106)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(163, 23)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Export Cheats to File"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Export.SetToolTip(Me.btnExport, "Export Cheats from Database")
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.Location = New System.Drawing.Point(22, 135)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(163, 23)
        Me.btnUpload.TabIndex = 8
        Me.btnUpload.Text = "Upload via FTP"
        Me.UploadFTP.SetToolTip(Me.btnUpload, "Cheat files are uploaded to the FTP server.")
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSettings.Location = New System.Drawing.Point(22, 19)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(163, 23)
        Me.btnSettings.TabIndex = 9
        Me.btnSettings.Text = "Settings"
        Me.SettPathFTP.SetToolTip(Me.btnSettings, "Settings for Rom paths and FTP.")
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(317, 613)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.lblGameType)
        Me.GroupBox2.Controls.Add(Me.lstGame)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 512)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Games:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(54, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        Me.GameList.SetToolTip(Me.PictureBox4, "Displays all games in the database.")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 76)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Game System:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(199, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.Location = New System.Drawing.Point(22, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(163, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Game"
        Me.AddGame.SetToolTip(Me.btnAdd, "Add game and cheats to database.")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnModGame
        '
        Me.btnModGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnModGame.Location = New System.Drawing.Point(22, 48)
        Me.btnModGame.Name = "btnModGame"
        Me.btnModGame.Size = New System.Drawing.Size(163, 23)
        Me.btnModGame.TabIndex = 12
        Me.btnModGame.Text = "&Modify Game"
        Me.ModGame.SetToolTip(Me.btnModGame, "Edit game and cheats in the database.")
        Me.btnModGame.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRemove.Location = New System.Drawing.Point(22, 77)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(163, 23)
        Me.btnRemove.TabIndex = 13
        Me.btnRemove.Text = "Remove Game"
        Me.RemoveGameCheats.SetToolTip(Me.btnRemove, "Deleting games and the associated cheats in the database.")
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dlc)
        Me.GroupBox4.Controls.Add(Me.btnGG2Hex)
        Me.GroupBox4.Controls.Add(Me.btnUpload)
        Me.GroupBox4.Controls.Add(Me.btnExport)
        Me.GroupBox4.Controls.Add(Me.btnImport)
        Me.GroupBox4.Controls.Add(Me.btnCompareAgainstRoms)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(570, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(211, 201)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cheat Options:"
        '
        'dlc
        '
        Me.dlc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlc.Location = New System.Drawing.Point(22, 164)
        Me.dlc.Name = "dlc"
        Me.dlc.Size = New System.Drawing.Size(163, 23)
        Me.dlc.TabIndex = 9
        Me.dlc.Text = "Download Cheats"
        Me.dlc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CodeandCht.SetToolTip(Me.dlc, "Websites for cheat codes and .cht files.")
        Me.dlc.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSettings)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(570, 550)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(211, 57)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Scan Path:"
        '
        'LblCheatNum
        '
        Me.LblCheatNum.AutoSize = True
        Me.LblCheatNum.ForeColor = System.Drawing.Color.Magenta
        Me.LblCheatNum.Location = New System.Drawing.Point(117, 50)
        Me.LblCheatNum.Name = "LblCheatNum"
        Me.LblCheatNum.Size = New System.Drawing.Size(14, 13)
        Me.LblCheatNum.TabIndex = 16
        Me.LblCheatNum.Text = "0"
        '
        'lblGameNum
        '
        Me.lblGameNum.AutoSize = True
        Me.lblGameNum.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblGameNum.Location = New System.Drawing.Point(117, 23)
        Me.lblGameNum.Name = "lblGameNum"
        Me.lblGameNum.Size = New System.Drawing.Size(14, 13)
        Me.lblGameNum.TabIndex = 18
        Me.lblGameNum.Text = "0"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnAdd)
        Me.GroupBox6.Controls.Add(Me.btnModGame)
        Me.GroupBox6.Controls.Add(Me.btnRemove)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(570, 432)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(211, 112)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Options:"
        '
        'IstGame
        '
        Me.IstGame.FormattingEnabled = True
        Me.IstGame.Location = New System.Drawing.Point(6, 19)
        Me.IstGame.Name = "IstGame"
        Me.IstGame.Size = New System.Drawing.Size(539, 472)
        Me.IstGame.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.lblGameNum)
        Me.GroupBox7.Controls.Add(Me.LblCheatNum)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(570, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(211, 77)
        Me.GroupBox7.TabIndex = 21
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DataBase"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(229, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(748, 608)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        Me.About.SetToolTip(Me.PictureBox2, "click me" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Show About")
        '
        'GameList
        '
        Me.GameList.IsBalloon = True
        Me.GameList.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.GameList.ToolTipTitle = "Game List"
        '
        'GG2Hex
        '
        Me.GG2Hex.IsBalloon = True
        Me.GG2Hex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.GG2Hex.ToolTipTitle = "Game Genie 2 Hex"
        '
        'CheatRoms
        '
        Me.CheatRoms.IsBalloon = True
        Me.CheatRoms.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.CheatRoms.ToolTipTitle = "Compare Cheats"
        '
        'Export
        '
        Me.Export.IsBalloon = True
        Me.Export.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Export.ToolTipTitle = "Export Cheats"
        '
        'UploadFTP
        '
        Me.UploadFTP.IsBalloon = True
        Me.UploadFTP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.UploadFTP.ToolTipTitle = "FTP"
        '
        'CodeandCht
        '
        Me.CodeandCht.IsBalloon = True
        Me.CodeandCht.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.CodeandCht.ToolTipTitle = "Cheat codes and .Cht files."
        '
        'AddGame
        '
        Me.AddGame.IsBalloon = True
        Me.AddGame.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.AddGame.ToolTipTitle = "Add Game"
        '
        'ModGame
        '
        Me.ModGame.IsBalloon = True
        Me.ModGame.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ModGame.ToolTipTitle = "Modify Game"
        '
        'RemoveGameCheats
        '
        Me.RemoveGameCheats.IsBalloon = True
        Me.RemoveGameCheats.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.RemoveGameCheats.ToolTipTitle = "Remove Game"
        '
        'SettPathFTP
        '
        Me.SettPathFTP.IsBalloon = True
        Me.SettPathFTP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.SettPathFTP.ToolTipTitle = "Settings"
        '
        'About
        '
        Me.About.IsBalloon = True
        Me.About.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.About.ToolTipTitle = "CheatManager"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(703, 608)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        Me.github.SetToolTip(Me.PictureBox5, "click me " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Show Repositories on GitHub")
        '
        'github
        '
        Me.github.IsBalloon = True
        Me.github.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.github.ToolTipTitle = "GitHub "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(796, 639)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheat Manager Reloaded 0.5b"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstGame As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGameType As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnCompareAgainstRoms As System.Windows.Forms.Button
    Friend WithEvents btnGG2Hex As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnModGame As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCheatNum As System.Windows.Forms.Label
    Friend WithEvents lblGamesHad As System.Windows.Forms.Label
    Friend WithEvents lblGameNum As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents IstGame As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents dlc As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GameList As System.Windows.Forms.ToolTip
    Friend WithEvents GG2Hex As System.Windows.Forms.ToolTip
    Friend WithEvents CheatRoms As System.Windows.Forms.ToolTip
    Friend WithEvents Export As System.Windows.Forms.ToolTip
    Friend WithEvents UploadFTP As System.Windows.Forms.ToolTip
    Friend WithEvents CodeandCht As System.Windows.Forms.ToolTip
    Friend WithEvents AddGame As System.Windows.Forms.ToolTip
    Friend WithEvents ModGame As System.Windows.Forms.ToolTip
    Friend WithEvents RemoveGameCheats As System.Windows.Forms.ToolTip
    Friend WithEvents SettPathFTP As System.Windows.Forms.ToolTip
    Friend WithEvents About As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents github As System.Windows.Forms.ToolTip
End Class
