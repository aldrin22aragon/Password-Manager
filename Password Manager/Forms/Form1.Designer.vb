<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
      Me.ToolStripTop = New System.Windows.Forms.ToolStrip()
      Me.DataGridView1 = New System.Windows.Forms.DataGridView()
      Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
      Me.ToolStripFooter = New System.Windows.Forms.ToolStrip()
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ToolStripFooter.SuspendLayout()
      Me.SuspendLayout()
      '
      'ToolStripTop
      '
      Me.ToolStripTop.Location = New System.Drawing.Point(0, 0)
      Me.ToolStripTop.Name = "ToolStripTop"
      Me.ToolStripTop.Size = New System.Drawing.Size(519, 25)
      Me.ToolStripTop.TabIndex = 2
      Me.ToolStripTop.Text = "ToolStrip1"
      '
      'DataGridView1
      '
      Me.DataGridView1.AllowUserToAddRows = False
      Me.DataGridView1.AllowUserToDeleteRows = False
      Me.DataGridView1.AllowUserToResizeColumns = False
      Me.DataGridView1.AllowUserToResizeRows = False
      Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnName, Me.Column1, Me.Column2, Me.Column3})
      Me.DataGridView1.Location = New System.Drawing.Point(23, 45)
      Me.DataGridView1.Name = "DataGridView1"
      Me.DataGridView1.ReadOnly = True
      Me.DataGridView1.Size = New System.Drawing.Size(455, 210)
      Me.DataGridView1.TabIndex = 3
      '
      'ColumnName
      '
      Me.ColumnName.HeaderText = "Name"
      Me.ColumnName.Name = "ColumnName"
      Me.ColumnName.ReadOnly = True
      '
      'Column1
      '
      Me.Column1.HeaderText = "Password"
      Me.Column1.Name = "Column1"
      Me.Column1.ReadOnly = True
      '
      'Column2
      '
      Me.Column2.HeaderText = "Copied"
      Me.Column2.Name = "Column2"
      Me.Column2.ReadOnly = True
      '
      'Column3
      '
      Me.Column3.HeaderText = "Actions"
      Me.Column3.Name = "Column3"
      Me.Column3.ReadOnly = True
      '
      'NotifyIcon1
      '
      Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
      Me.NotifyIcon1.BalloonTipText = "Running in background"
      Me.NotifyIcon1.BalloonTipTitle = "Password Manager"
      Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
      Me.NotifyIcon1.Text = "Password Manager"
      Me.NotifyIcon1.Visible = True
      '
      'ToolStripFooter
      '
      Me.ToolStripFooter.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.ToolStripFooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
      Me.ToolStripFooter.Location = New System.Drawing.Point(0, 313)
      Me.ToolStripFooter.Name = "ToolStripFooter"
      Me.ToolStripFooter.Size = New System.Drawing.Size(519, 25)
      Me.ToolStripFooter.TabIndex = 4
      Me.ToolStripFooter.Text = "ToolStrip2"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(140, 22)
      Me.ToolStripLabel1.Text = "Master Password: Expired"
      '
      'FormMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(519, 338)
      Me.Controls.Add(Me.ToolStripFooter)
      Me.Controls.Add(Me.DataGridView1)
      Me.Controls.Add(Me.ToolStripTop)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "FormMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Main"
      CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ToolStripFooter.ResumeLayout(False)
      Me.ToolStripFooter.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ToolStripTop As ToolStrip
   Friend WithEvents DataGridView1 As DataGridView
   Friend WithEvents NotifyIcon1 As NotifyIcon
   Friend WithEvents ColumnName As DataGridViewTextBoxColumn
   Friend WithEvents Column1 As DataGridViewTextBoxColumn
   Friend WithEvents Column2 As DataGridViewTextBoxColumn
   Friend WithEvents Column3 As DataGridViewTextBoxColumn
   Friend WithEvents ToolStripFooter As ToolStrip
   Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
