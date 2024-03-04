Public Class FormMain
   Friend WithEvents MasterPasswordExpire As New AOA_Timer(60)
   Friend WithEvents ClipboardExpire As New AOA_Timer(30)
   Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      IO.Directory.CreateDirectory(s)
   End Sub
   Dim aa As Boolean = False
   Property FormVisible As Boolean
      Get
         Return aa
      End Get
      Set(value As Boolean)
         aa = value
         ShowInTaskbar = aa
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
      End If
   End Sub

   Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      FormVisible = False
   End Sub
End Class
