<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblGameRunning = New System.Windows.Forms.Label()
        Me.lblAFKStatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAFKOn = New System.Windows.Forms.Button()
        Me.btnAFKOff = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AFKOnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsAFKOn = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAFKOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTimetoAction = New System.Windows.Forms.Label()
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudActionCD = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.nudActionCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameRunning
        '
        Me.lblGameRunning.BackColor = System.Drawing.Color.White
        Me.lblGameRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGameRunning.Location = New System.Drawing.Point(83, 32)
        Me.lblGameRunning.Name = "lblGameRunning"
        Me.lblGameRunning.Size = New System.Drawing.Size(106, 20)
        Me.lblGameRunning.TabIndex = 0
        Me.lblGameRunning.Text = "Default"
        Me.lblGameRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAFKStatus
        '
        Me.lblAFKStatus.BackColor = System.Drawing.Color.LightCoral
        Me.lblAFKStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAFKStatus.Location = New System.Drawing.Point(83, 71)
        Me.lblAFKStatus.Name = "lblAFKStatus"
        Me.lblAFKStatus.Size = New System.Drawing.Size(106, 20)
        Me.lblAFKStatus.TabIndex = 0
        Me.lblAFKStatus.Text = "Off"
        Me.lblAFKStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudActionCD)
        Me.GroupBox1.Controls.Add(Me.lblTimetoAction)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblGameRunning)
        Me.GroupBox1.Controls.Add(Me.lblAFKStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AFK / 的缩写"
        Me.ToolTip1.SetToolTip(Me.Label2, "Shows AFK Mode Current Status")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WoW Classic / 魔兽世界"
        Me.ToolTip1.SetToolTip(Me.Label1, "Check if WowClassic is running")
        '
        'btnAFKOn
        '
        Me.btnAFKOn.Location = New System.Drawing.Point(12, 149)
        Me.btnAFKOn.Name = "btnAFKOn"
        Me.btnAFKOn.Size = New System.Drawing.Size(195, 23)
        Me.btnAFKOn.TabIndex = 2
        Me.btnAFKOn.Text = "AFK / 的缩写:         ON"
        Me.btnAFKOn.UseVisualStyleBackColor = True
        '
        'btnAFKOff
        '
        Me.btnAFKOff.Location = New System.Drawing.Point(12, 178)
        Me.btnAFKOff.Name = "btnAFKOff"
        Me.btnAFKOff.Size = New System.Drawing.Size(195, 23)
        Me.btnAFKOff.TabIndex = 2
        Me.btnAFKOff.Text = "AFK / 的缩写:          OFF"
        Me.btnAFKOff.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 9)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Created by FYBP"
        '
        'Timer1
        '
        '
        'AFKOnTimer
        '
        Me.AFKOnTimer.Interval = 300000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAFKOn, Me.tsAFKOff, Me.tsQuit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 70)
        '
        'tsAFKOn
        '
        Me.tsAFKOn.Name = "tsAFKOn"
        Me.tsAFKOn.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsAFKOn.Size = New System.Drawing.Size(180, 22)
        Me.tsAFKOn.Text = "AFK On"
        '
        'tsAFKOff
        '
        Me.tsAFKOff.Name = "tsAFKOff"
        Me.tsAFKOff.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsAFKOff.Size = New System.Drawing.Size(180, 22)
        Me.tsAFKOff.Text = "AFK Off"
        '
        'tsQuit
        '
        Me.tsQuit.Name = "tsQuit"
        Me.tsQuit.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.tsQuit.Size = New System.Drawing.Size(180, 22)
        Me.tsQuit.Text = "Quit"
        '
        'lblTimetoAction
        '
        Me.lblTimetoAction.BackColor = System.Drawing.Color.LightCyan
        Me.lblTimetoAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimetoAction.Location = New System.Drawing.Point(120, 113)
        Me.lblTimetoAction.Name = "lblTimetoAction"
        Me.lblTimetoAction.Size = New System.Drawing.Size(69, 20)
        Me.lblTimetoAction.TabIndex = 3
        Me.lblTimetoAction.Text = "0/s"
        Me.lblTimetoAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountdownTimer
        '
        Me.CountdownTimer.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Action CD / 动作倒计时"
        Me.ToolTip1.SetToolTip(Me.Label4, "Time Till next Auto Action")
        '
        'nudActionCD
        '
        Me.nudActionCD.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudActionCD.Location = New System.Drawing.Point(9, 113)
        Me.nudActionCD.Maximum = New Decimal(New Integer() {1800, 0, 0, 0})
        Me.nudActionCD.Name = "nudActionCD"
        Me.nudActionCD.Size = New System.Drawing.Size(71, 20)
        Me.nudActionCD.TabIndex = 4
        Me.nudActionCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nudActionCD, "Sets Action Cooldown in Seconds 1-30 Mins")
        Me.nudActionCD.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 215)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAFKOff)
        Me.Controls.Add(Me.btnAFKOn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Anti-AFK WoW Classic"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.nudActionCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGameRunning As Label
    Friend WithEvents lblAFKStatus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAFKOn As Button
    Friend WithEvents btnAFKOff As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AFKOnTimer As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsAFKOn As ToolStripMenuItem
    Friend WithEvents tsAFKOff As ToolStripMenuItem
    Friend WithEvents tsQuit As ToolStripMenuItem
    Friend WithEvents lblTimetoAction As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CountdownTimer As Timer
    Friend WithEvents nudActionCD As NumericUpDown
End Class
