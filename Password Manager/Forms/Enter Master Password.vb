Public Class Enter_Master_Password
   Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
      Select Case e.KeyCode
         Case Keys.Enter
            DialogResult = DialogResult.OK
         Case Keys.Escape
            DialogResult = DialogResult.Cancel
      End Select
   End Sub
End Class