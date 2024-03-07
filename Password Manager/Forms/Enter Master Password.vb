Public Class Enter_Master_Password
    Enum EnumResponse As Integer
        NONE = 0
        Enter = 1
        Escape = 2
    End Enum
    Public Response As EnumResponse = Enter_Master_Password.EnumResponse.NONE
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim aa As String = e.KeyChar
        If aa = vbCr Then
            Response = EnumResponse.Enter
            DialogResult = DialogResult.OK
        ElseIf aa = ChrW(27) Then
            Response = EnumResponse.Escape
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class