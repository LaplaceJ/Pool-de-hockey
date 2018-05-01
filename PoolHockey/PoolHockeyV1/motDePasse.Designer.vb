<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class motDePasse
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
        Me.labelTextCouriel = New System.Windows.Forms.Label()
        Me.LabelMPD = New System.Windows.Forms.Label()
        Me.TBCouriel = New System.Windows.Forms.TextBox()
        Me.TBMPD = New System.Windows.Forms.TextBox()
        Me.bouttonConexion = New System.Windows.Forms.Button()
        Me.resetMPD = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'labelTextCouriel
        '
        Me.labelTextCouriel.AutoSize = True
        Me.labelTextCouriel.Location = New System.Drawing.Point(1, 19)
        Me.labelTextCouriel.Name = "labelTextCouriel"
        Me.labelTextCouriel.Size = New System.Drawing.Size(85, 13)
        Me.labelTextCouriel.TabIndex = 0
        Me.labelTextCouriel.Text = "Adresse couriel: "
        '
        'LabelMPD
        '
        Me.LabelMPD.AutoSize = True
        Me.LabelMPD.Location = New System.Drawing.Point(12, 59)
        Me.LabelMPD.Name = "LabelMPD"
        Me.LabelMPD.Size = New System.Drawing.Size(74, 13)
        Me.LabelMPD.TabIndex = 1
        Me.LabelMPD.Text = "Mot de passe:"
        '
        'TBCouriel
        '
        Me.TBCouriel.Location = New System.Drawing.Point(92, 19)
        Me.TBCouriel.MaxLength = 40
        Me.TBCouriel.Name = "TBCouriel"
        Me.TBCouriel.Size = New System.Drawing.Size(177, 20)
        Me.TBCouriel.TabIndex = 2
        '
        'TBMPD
        '
        Me.TBMPD.Location = New System.Drawing.Point(92, 59)
        Me.TBMPD.MaxLength = 40
        Me.TBMPD.Name = "TBMPD"
        Me.TBMPD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBMPD.Size = New System.Drawing.Size(177, 20)
        Me.TBMPD.TabIndex = 3
        '
        'bouttonConexion
        '
        Me.bouttonConexion.Location = New System.Drawing.Point(15, 85)
        Me.bouttonConexion.Name = "bouttonConexion"
        Me.bouttonConexion.Size = New System.Drawing.Size(254, 23)
        Me.bouttonConexion.TabIndex = 4
        Me.bouttonConexion.Text = "Se connecter"
        Me.bouttonConexion.UseVisualStyleBackColor = True
        '
        'resetMPD
        '
        Me.resetMPD.AutoSize = True
        Me.resetMPD.Location = New System.Drawing.Point(120, 111)
        Me.resetMPD.Name = "resetMPD"
        Me.resetMPD.Size = New System.Drawing.Size(149, 13)
        Me.resetMPD.TabIndex = 5
        Me.resetMPD.TabStop = True
        Me.resetMPD.Text = "Réinitialiser mon mot de passe"
        '
        'motDePasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 135)
        Me.Controls.Add(Me.resetMPD)
        Me.Controls.Add(Me.bouttonConexion)
        Me.Controls.Add(Me.TBMPD)
        Me.Controls.Add(Me.TBCouriel)
        Me.Controls.Add(Me.LabelMPD)
        Me.Controls.Add(Me.labelTextCouriel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "motDePasse"
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelTextCouriel As System.Windows.Forms.Label
    Friend WithEvents LabelMPD As System.Windows.Forms.Label
    Friend WithEvents TBCouriel As System.Windows.Forms.TextBox
    Friend WithEvents TBMPD As System.Windows.Forms.TextBox
    Friend WithEvents bouttonConexion As System.Windows.Forms.Button
    Friend WithEvents resetMPD As System.Windows.Forms.LinkLabel
End Class
