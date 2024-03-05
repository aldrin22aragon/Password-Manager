Public Class Generate_New_Password
   Private Sub Generate_New_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp, TextBox1.KeyUp
      Select Case e.KeyCode
         Case Keys.Enter
            Dim _1 As String = TextBox1.Text
            Dim _2 As String = TextBox2.Text
            If _1 = _2 Then
               Me.DialogResult = DialogResult.OK
            Else
               ErrMsg("Passwords do not matched each other.")
            End If
         Case Keys.Escape
            Me.DialogResult = DialogResult.Cancel
      End Select
   End Sub
End Class