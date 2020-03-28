Imports System
Imports System.Threading

Public Class Form1
    Dim boolAFKRunning As Boolean = False
    Dim boolWowRunning As Boolean = False
    Dim Current As Integer = 300
    Dim p() As Process
    Dim thrd As Thread

    Private Sub WOWCheckIfRunning()
        p = Process.GetProcessesByName("WowClassic")
        If p.Count > 0 Then
            ' Process is running
            boolWowRunning = True
            lblGameRunning.Text = "Running"
            lblGameRunning.BackColor = Color.PaleGreen
        Else
            ' Process is not running
            boolWowRunning = False
            lblGameRunning.Text = "Not Running"
            lblGameRunning.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub TurnAFKOn()
        'UI Stuff
        boolAFKRunning = True
        Me.TopMost = True
        lblAFKStatus.Text = "On"
        lblAFKStatus.BackColor = Color.PaleGreen
        NotifyIcon1.ShowBalloonTip(1000, "Anti-AFK WoW Classic", "AFK Mode Turned On, AFK模式已开启", ToolTipIcon.Info)
        SetWoWFocus()

        'First Press to Show AFK Mode Is Working
        SendKeys.SendWait("{W}")
    End Sub
    Private Sub TurnAFKOff()
        'UI Stuff
        boolAFKRunning = False
        Me.TopMost = False
        lblAFKStatus.Text = "Off"
        lblAFKStatus.BackColor = Color.LightCoral
        NotifyIcon1.ShowBalloonTip(1000, "Anti-AFK WoW Classic", "AFK Mode Turned Off, AFK模式已关闭", ToolTipIcon.Info)
    End Sub

    Private Sub SetWoWFocus()
        Dim App As Process() = Process.GetProcessesByName("WowClassic")
        If App.Length > 0 Then
            AppActivate(App(0).Id)
        End If
    End Sub



    Private Sub btnAFKOn_Click(sender As Object, e As EventArgs) Handles btnAFKOn.Click
        ''Sets AFK Mode On
        If boolAFKRunning = False Then
            TurnAFKOn()
        Else
            MessageBox.Show("AFK Mode already Running")
        End If
    End Sub

    Private Sub btnAFKOff_Click(sender As Object, e As EventArgs) Handles btnAFKOff.Click
        ''Sets AFK Mode Off
        If boolAFKRunning = True Then
            TurnAFKOff()
        Else
            MessageBox.Show("AFK Mode already Stopped")
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Check if Wow is running on load if not load timer for check after load
        WOWCheckIfRunning()
        Timer1.Enabled = True
    End Sub

    Private Sub tsAFKOn_Click(sender As Object, e As EventArgs) Handles tsAFKOn.Click
        TurnAFKOn()
    End Sub

    Private Sub tsAFKOff_Click(sender As Object, e As EventArgs) Handles tsAFKOff.Click
        TurnAFKOff()
    End Sub

    Private Sub tsQuit_Click(sender As Object, e As EventArgs) Handles tsQuit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''Check if Wow is running after load
        WOWCheckIfRunning()
        If boolWowRunning = True And boolAFKRunning = True Then
            'UI Stuff
            btnAFKOff.Enabled = True
            btnAFKOn.Enabled = False
            tsAFKOff.Enabled = True
            tsAFKOn.Enabled = False
            ToolTip1.SetToolTip(btnAFKOff, "Stops AFK Mode")
            ToolTip1.SetToolTip(btnAFKOn, "Cannot Restart AFK Mode When Running")
            'Enable Game AFK Timer
            'AFKOnTimer.Enabled = True
            CountdownTimer.Enabled = True
        ElseIf boolWowRunning = True And boolAFKRunning = False Then
            'UI Stuff
            btnAFKOff.Enabled = False
            btnAFKOn.Enabled = True
            tsAFKOff.Enabled = False
            tsAFKOn.Enabled = True
            ToolTip1.SetToolTip(btnAFKOff, "Start AFK To Stop")
            ToolTip1.SetToolTip(btnAFKOn, "Starts AFK Mode")
            'Disable Game AFK Timer
            'AFKOnTimer.Enabled = False
            CountdownTimer.Enabled = False
        ElseIf boolWowRunning = False And boolAFKRunning = False Then
            'UI Stuff
            btnAFKOff.Enabled = False
            btnAFKOn.Enabled = False
            tsAFKOff.Enabled = False
            tsAFKOn.Enabled = False
            ToolTip1.SetToolTip(btnAFKOff, "Please Start Wow Classic First")
            ToolTip1.SetToolTip(btnAFKOn, "Please Start Wow Classic First")
        Else
            MessageBox.Show("Error Occured Please Reload Program")
        End If
    End Sub

    Private Sub AFKOnTimer_Tick(sender As Object, e As EventArgs) Handles AFKOnTimer.Tick
        If boolAFKRunning = True Then
            Thread.Sleep(100)
            SendKeys.SendWait("{W}")
            Thread.Sleep(500)
            SendKeys.SendWait("{A}")
            Thread.Sleep(500)
            SendKeys.SendWait("{S}")
            Thread.Sleep(500)
            SendKeys.SendWait("{D}")
            Thread.Sleep(500)
            SendKeys.SendWait("{M}")
            Thread.Sleep(5000)
            SendKeys.SendWait("{M}")
        ElseIf boolAFKRunning = False Then
            MessageBox.Show("Error Occured Please Relaod Program")
        End If
    End Sub

    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        If boolAFKRunning = True Then
            Current = Current - 1
            lblTimetoAction.Text = Current.ToString + "/s"
            If Current = 0 Then
                SendKeys.SendWait("{W}")
                Thread.Sleep(100)
                SendKeys.SendWait("{A}")
                Thread.Sleep(100)
                SendKeys.SendWait("{S}")
                Thread.Sleep(100)
                SendKeys.SendWait("{D}")
                Thread.Sleep(100)
                SendKeys.SendWait("{M}")
                Thread.Sleep(1000)
                SendKeys.SendWait("{M}")
                Current = nudActionCD.Value
                NotifyIcon1.ShowBalloonTip(1000, "Anti-AFK WoW Classic", "AFK Mode Action Taken, AFK模式采取的措施", ToolTipIcon.Info)
            End If
        ElseIf boolAFKRunning = False Then
            MessageBox.Show("Error Occured Please Relaod Program")
        End If
    End Sub

    Private Sub nudActionCD_ValueChanged(sender As Object, e As EventArgs) Handles nudActionCD.ValueChanged
        'Set ActionCD Timer & Label
        Current = nudActionCD.Value
        lblTimetoAction.Text = Current.ToString + "/s"
    End Sub
End Class



