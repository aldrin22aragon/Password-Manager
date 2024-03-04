Public Class Generate_New_Password
   Private Sub Generate_New_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp, TextBox1.KeyUp
      Select Case e.KeyCode
         Case Keys.Enter
            Me.DialogResult = DialogResult.OK
         Case Keys.Escape
            Me.DialogResult = DialogResult.Cancel
      End Select
   End Sub
End Class