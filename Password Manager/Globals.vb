Module Globals
   Public s As String = IO.Path.Combine(Application.StartupPath, "settings")
   Public masterPasswordFilePath As String = IO.Path.Combine(s, "masterpassword.drihnz")
   Public passwordsFilePath As String = IO.Path.Combine(s, "masterpassword.drihnz")
   Public fscMasterPassword As New FileSettingsCreator2(Of String)(masterPasswordFilePath, "")
   Public fscPasswords As New FileSettingsCreator2(Of String())(passwordsFilePath, {})
End Module
