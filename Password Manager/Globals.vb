Module Globals
   Public s As String = IO.Path.Combine(Application.StartupPath, "settings")
   Public passwordsFilePath As String = IO.Path.Combine(s, "masterpassword.drihnz")
   Public fscPasswords As New FileSettingsCreator2(Of Passwords)(passwordsFilePath, New Passwords())
End Module
