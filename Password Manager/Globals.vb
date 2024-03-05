﻿Module Globals
   Public s As String = IO.Path.Combine(Application.StartupPath, "settings")
   Public passwordsFilePath As String = IO.Path.Combine(s, "masterpassword.drihnz")
   Public fscPasswords As New FileSettingsCreator2(Of Passwords)(passwordsFilePath, New Passwords)
   Public Sub ErrMsg(msg As String)
      MessageBox.Show(msg, "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
   End Sub
End Module
