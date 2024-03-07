Public Class FormMain
    Friend WithEvents MasterPasswordExpire As New AOA_Timer(10)
    Friend WithEvents ClipboardExpire As New AOA_Timer(30)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.Directory.CreateDirectory(s)
    End Sub
    Dim meVisible As Boolean = False
    Property FormVisible As Boolean
        Get
            Return meVisible
        End Get
        Set(value As Boolean)
            meVisible = value
            ShowInTaskbar = value
            If value Then
                Me.Show()
            Else
                Me.Hide()
            End If
        End Set
    End Property
    Dim forceClose As Boolean = False
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not forceClose Then
            e.Cancel = True
            FormVisible = False
            NotifyIcon1.ShowBalloonTip(50000)
        End If

    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If FormVisible Then
            FormVisible = False
        Else
            FormVisible = True
            AskMasterPassword()
        End If
    End Sub

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FormVisible = False
    End Sub

    Private Sub MasterPasswordExpire_Tick(e As AOA_Timer.TickEventInfo) Handles MasterPasswordExpire.Tick
        If e.IsTimeReached Then
            ToolStripLabel1.Text = "Master Password: Expired"
            FormVisible = True
            AskMasterPassword()
        Else
            ToolStripLabel1.Text = "Master Password: Expires in " & e.Span.TotalSeconds
        End If
    End Sub
    Sub AskMasterPassword()
        Dim pass As Passwords = fscPasswords.GetSettings()
        If pass Is Nothing Then
            Dim g As New Generate_New_Password
            If g.ShowDialog() = DialogResult.OK Then
                Dim aa As New Passwords() With {.masterPassword = g.TextBox1.Text}
                fscPasswords.SetSettings(aa)
            Else
                FormVisible = False
            End If
        Else
            Dim m As New Enter_Master_Password
Show:
            Dim dRes As DialogResult = m.ShowDialog()
            If dRes = DialogResult.OK Then
                Select Case m.Response
                    Case Enter_Master_Password.EnumResponse.Enter
                        If m.TextBox1.Text = pass.masterPassword Then
                            'do nothing entered passworod is valid
                            MasterPasswordExpire.RestartTimer()
                        Else
                            ErrMsg("Invalid password. Please try again.")
                            GoTo Show ' Ask again for the password
                        End If
                    Case Enter_Master_Password.EnumResponse.Escape
                        FormVisible = False
                End Select
            Else
                FormVisible = False
            End If
        End If
    End Sub
End Class
