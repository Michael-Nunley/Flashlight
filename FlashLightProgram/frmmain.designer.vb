<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHelp = New System.Windows.Forms.ToolStripButton()
        Me.picboxBase = New System.Windows.Forms.PictureBox()
        Me.picboxLight = New System.Windows.Forms.PictureBox()
        Me.tmrLive = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.mainMenu.SuspendLayout()
        CType(Me.picboxBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdHelp})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mainMenu.Size = New System.Drawing.Size(207, 27)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "mainMenu"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 23)
        Me.cmdFile.Text = "File"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdHelp
        '
        Me.cmdHelp.CheckOnClick = True
        Me.cmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmdHelp.Text = "Help"
        '
        'picboxBase
        '
        Me.picboxBase.Image = Global.FlashLightProgram.My.Resources.Resources.off
        Me.picboxBase.Location = New System.Drawing.Point(12, 290)
        Me.picboxBase.Name = "picboxBase"
        Me.picboxBase.Size = New System.Drawing.Size(184, 271)
        Me.picboxBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxBase.TabIndex = 2
        Me.picboxBase.TabStop = False
        '
        'picboxLight
        '
        Me.picboxLight.Image = Global.FlashLightProgram.My.Resources.Resources.lightOn
        Me.picboxLight.Location = New System.Drawing.Point(12, 30)
        Me.picboxLight.Name = "picboxLight"
        Me.picboxLight.Size = New System.Drawing.Size(184, 271)
        Me.picboxLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxLight.TabIndex = 3
        Me.picboxLight.TabStop = False
        Me.picboxLight.Visible = False
        '
        'tmrLive
        '
        Me.tmrLive.Enabled = True
        Me.tmrLive.Interval = 10
        '
        'tmrDelay
        '
        Me.tmrDelay.Enabled = True
        Me.tmrDelay.Interval = 500
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(207, 573)
        Me.Controls.Add(Me.picboxBase)
        Me.Controls.Add(Me.picboxLight)
        Me.Controls.Add(Me.mainMenu)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mainMenu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(223, 611)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(223, 611)
        Me.Name = "frmMain"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flashlight!"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        CType(Me.picboxBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrShake As System.Windows.Forms.Timer
    Friend WithEvents tmrPosition As System.Windows.Forms.Timer
    Friend WithEvents picboxBase As System.Windows.Forms.PictureBox
    Friend WithEvents picboxLight As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLive As System.Windows.Forms.Timer
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer

End Class
