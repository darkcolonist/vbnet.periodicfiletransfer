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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSrc = New System.Windows.Forms.TextBox
        Me.txtTgt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtInterval = New System.Windows.Forms.NumericUpDown
        Me.lstLog = New System.Windows.Forms.ListBox
        Me.btnToggle = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtTimer = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtMessage = New System.Windows.Forms.ToolStripStatusLabel
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.NumericUpDown
        Me.btnAbout = New System.Windows.Forms.Button
        Me.chkAutostart = New System.Windows.Forms.CheckBox
        CType(Me.txtInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.txtLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Dir"
        '
        'txtSrc
        '
        Me.txtSrc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSrc.Location = New System.Drawing.Point(76, 10)
        Me.txtSrc.Name = "txtSrc"
        Me.txtSrc.Size = New System.Drawing.Size(389, 20)
        Me.txtSrc.TabIndex = 1
        Me.txtSrc.Text = "D:\tst1"
        '
        'txtTgt
        '
        Me.txtTgt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTgt.Location = New System.Drawing.Point(76, 36)
        Me.txtTgt.Name = "txtTgt"
        Me.txtTgt.Size = New System.Drawing.Size(389, 20)
        Me.txtTgt.TabIndex = 3
        Me.txtTgt.Text = "D:\tst2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Target Dir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seconds"
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(76, 88)
        Me.txtInterval.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtInterval.TabIndex = 7
        Me.txtInterval.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lstLog
        '
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.Items.AddRange(New Object() {"123", "123", "12", "312", "312", "3", "123", "123", "12"})
        Me.lstLog.Location = New System.Drawing.Point(12, 140)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(453, 160)
        Me.lstLog.TabIndex = 10
        '
        'btnToggle
        '
        Me.btnToggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggle.Location = New System.Drawing.Point(329, 314)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(136, 23)
        Me.btnToggle.TabIndex = 13
        Me.btnToggle.Text = "start"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtStatus, Me.ToolStripStatusLabel3, Me.txtTimer, Me.ToolStripStatusLabel2, Me.txtMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(26, 17)
        Me.txtStatus.Text = "idle"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(55, 17)
        Me.ToolStripStatusLabel3.Text = "Next Run"
        '
        'txtTimer
        '
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(13, 17)
        Me.txtTimer.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel2.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(0, 17)
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Filter"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(76, 114)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtFilter.TabIndex = 9
        Me.txtFilter.Text = "*.jpg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Limit"
        '
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(76, 62)
        Me.txtLimit.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtLimit.TabIndex = 5
        Me.txtLimit.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(12, 314)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 11
        Me.btnAbout.TabStop = False
        Me.btnAbout.Text = "about"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'chkAutostart
        '
        Me.chkAutostart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutostart.AutoSize = True
        Me.chkAutostart.Location = New System.Drawing.Point(159, 318)
        Me.chkAutostart.Name = "chkAutostart"
        Me.chkAutostart.Size = New System.Drawing.Size(164, 17)
        Me.chkAutostart.TabIndex = 12
        Me.chkAutostart.Text = "Start immediately on app load"
        Me.chkAutostart.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.chkAutostart)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.lstLog)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTgt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSrc)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodic File Transfer"
        CType(Me.txtInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.txtLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSrc As System.Windows.Forms.TextBox
    Friend WithEvents txtTgt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents chkAutostart As System.Windows.Forms.CheckBox

End Class
