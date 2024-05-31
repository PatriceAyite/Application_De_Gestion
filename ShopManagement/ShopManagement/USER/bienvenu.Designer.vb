<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bienvenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Guna2CircleProgressBar1
        ' 
        Guna2CircleProgressBar1.Animated = True
        Guna2CircleProgressBar1.AnimationSpeed = 2F
        Guna2CircleProgressBar1.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Guna2CircleProgressBar1.Font = New Font("Segoe UI", 12F)
        Guna2CircleProgressBar1.ForeColor = Color.White
        Guna2CircleProgressBar1.Location = New Point(98, 42)
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Guna2CircleProgressBar1.ProgressColor = SystemColors.Highlight
        Guna2CircleProgressBar1.ProgressColor2 = SystemColors.HotTrack
        Guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar1.ShowText = True
        Guna2CircleProgressBar1.Size = New Size(277, 277)
        Guna2CircleProgressBar1.TabIndex = 0
        Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2782612F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(98, 377)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 36)
        Label1.TabIndex = 1
        Label1.Text = "loading..."
        ' 
        ' Timer1
        ' 
        ' 
        ' bienvenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(490, 436)
        Controls.Add(Label1)
        Controls.Add(Guna2CircleProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "bienvenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "bienvenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
