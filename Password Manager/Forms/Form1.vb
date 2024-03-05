Public Class FormMain
   Friend WithEvents MasterPasswordExpire As New AOA_Timer(60)
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
         ShowInTaskbar = meVisible
         If value Then
            Me.Show()
         Else
            Me.Hide()
         End If
         If meVisible Then
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
Enter_Master_Password:
               Dim m As New Enter_Master_Password
               If m.ShowDialog = DialogResult.OK Then
                  Dim p As String = m.TextBox1.Text
                  If pass.masterPassword = p Then
                     'do nothing kase valid ang password
                  Else
                     ErrMsg("Wrong password")
                     GoTo Enter_Master_Password
                  End If
               Else
                     FormVisible = False
               End If
            End If
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
      End If
   End Sub

   Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      FormVisible = False
   End Sub
End Class
