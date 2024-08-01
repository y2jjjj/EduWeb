<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem, ToolsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(690, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, ExitToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(46, 20)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(180, 22)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(690, 399)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem

End Class
