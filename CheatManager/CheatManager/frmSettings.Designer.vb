<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkBuildForRoms = New System.Windows.Forms.CheckBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.btnClearHR = New System.Windows.Forms.Button()
        Me.btnFTP = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGGearScanPath = New System.Windows.Forms.TextBox()
        Me.txtGenScanPath = New System.Windows.Forms.TextBox()
        Me.txtGBAScanPath = New System.Windows.Forms.TextBox()
        Me.txtGBScanPath = New System.Windows.Forms.TextBox()
        Me.txtSNESPath = New System.Windows.Forms.TextBox()
        Me.txtNESPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Save = New System.Windows.Forms.ToolTip(Me.components)
        Me.Remove = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nintendo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Super Nintendo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GameBoy/Gameboy Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gameboy Advanced:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sega Genesis:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sega GameGear:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Only Build For Roms You Have:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Only Show Roms You Have:"
        '
        'chkBuildForRoms
        '
        Me.chkBuildForRoms.AutoSize = True
        Me.chkBuildForRoms.Location = New System.Drawing.Point(168, 17)
        Me.chkBuildForRoms.Name = "chkBuildForRoms"
        Me.chkBuildForRoms.Size = New System.Drawing.Size(15, 14)
        Me.chkBuildForRoms.TabIndex = 9
        Me.chkBuildForRoms.UseVisualStyleBackColor = True
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(168, 46)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(15, 14)
        Me.chkShow.TabIndex = 10
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'btnClearHR
        '
        Me.btnClearHR.Location = New System.Drawing.Point(210, 249)
        Me.btnClearHR.Name = "btnClearHR"
        Me.btnClearHR.Size = New System.Drawing.Size(95, 23)
        Me.btnClearHR.TabIndex = 11
        Me.btnClearHR.Text = "&Remove"
        Me.Remove.SetToolTip(Me.btnClearHR, "You will need to rescan rom paths")
        Me.btnClearHR.UseVisualStyleBackColor = True
        '
        'btnFTP
        '
        Me.btnFTP.Location = New System.Drawing.Point(412, 249)
        Me.btnFTP.Name = "btnFTP"
        Me.btnFTP.Size = New System.Drawing.Size(95, 23)
        Me.btnFTP.TabIndex = 12
        Me.btnFTP.Text = "&FTP Settings"
        Me.btnFTP.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(311, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Save"
        Me.Save.SetToolTip(Me.btnClose, "Save and Close")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtGGearScanPath)
        Me.GroupBox1.Controls.Add(Me.txtGenScanPath)
        Me.GroupBox1.Controls.Add(Me.txtGBAScanPath)
        Me.GroupBox1.Controls.Add(Me.txtGBScanPath)
        Me.GroupBox1.Controls.Add(Me.txtSNESPath)
        Me.GroupBox1.Controls.Add(Me.txtNESPath)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 219)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Rom Scan Path:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        Me.Save.SetToolTip(Me.PictureBox1, "Press the text field and the Browser folder will open")
        '
        'txtGGearScanPath
        '
        Me.txtGGearScanPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGGearScanPath.Location = New System.Drawing.Point(145, 175)
        Me.txtGGearScanPath.Name = "txtGGearScanPath"
        Me.txtGGearScanPath.Size = New System.Drawing.Size(350, 20)
        Me.txtGGearScanPath.TabIndex = 12
        '
        'txtGenScanPath
        '
        Me.txtGenScanPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenScanPath.Location = New System.Drawing.Point(145, 145)
        Me.txtGenScanPath.Name = "txtGenScanPath"
        Me.txtGenScanPath.Size = New System.Drawing.Size(350, 20)
        Me.txtGenScanPath.TabIndex = 11
        '
        'txtGBAScanPath
        '
        Me.txtGBAScanPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGBAScanPath.Location = New System.Drawing.Point(145, 115)
        Me.txtGBAScanPath.Name = "txtGBAScanPath"
        Me.txtGBAScanPath.Size = New System.Drawing.Size(350, 20)
        Me.txtGBAScanPath.TabIndex = 10
        '
        'txtGBScanPath
        '
        Me.txtGBScanPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGBScanPath.Location = New System.Drawing.Point(145, 83)
        Me.txtGBScanPath.Name = "txtGBScanPath"
        Me.txtGBScanPath.Size = New System.Drawing.Size(350, 20)
        Me.txtGBScanPath.TabIndex = 9
        '
        'txtSNESPath
        '
        Me.txtSNESPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNESPath.Location = New System.Drawing.Point(145, 50)
        Me.txtSNESPath.Name = "txtSNESPath"
        Me.txtSNESPath.Size = New System.Drawing.Size(350, 20)
        Me.txtSNESPath.TabIndex = 8
        '
        'txtNESPath
        '
        Me.txtNESPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNESPath.Location = New System.Drawing.Point(145, 23)
        Me.txtNESPath.Name = "txtNESPath"
        Me.txtNESPath.Size = New System.Drawing.Size(350, 20)
        Me.txtNESPath.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkBuildForRoms)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.chkShow)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 69)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rom Settings"
        '
        'Save
        '
        Me.Save.IsBalloon = True
        Me.Save.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Save.ToolTipTitle = "Rom Path"
        '
        'Remove
        '
        Me.Remove.IsBalloon = True
        Me.Remove.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.Remove.ToolTipTitle = "Remove ?"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 324)
        Me.Controls.Add(Me.btnClearHR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnFTP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkBuildForRoms As System.Windows.Forms.CheckBox
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents btnClearHR As System.Windows.Forms.Button
    Friend WithEvents btnFTP As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGGearScanPath As System.Windows.Forms.TextBox
    Friend WithEvents txtGenScanPath As System.Windows.Forms.TextBox
    Friend WithEvents txtGBAScanPath As System.Windows.Forms.TextBox
    Friend WithEvents txtGBScanPath As System.Windows.Forms.TextBox
    Friend WithEvents txtSNESPath As System.Windows.Forms.TextBox
    Friend WithEvents txtNESPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Save As System.Windows.Forms.ToolTip
    Friend WithEvents Remove As System.Windows.Forms.ToolTip
End Class
