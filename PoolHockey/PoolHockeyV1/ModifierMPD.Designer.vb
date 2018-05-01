<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierMPD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBAncienMDP = New System.Windows.Forms.TextBox()
        Me.TBNewMPD = New System.Windows.Forms.TextBox()
        Me.TBConfirmerNewMPD = New System.Windows.Forms.TextBox()
        Me.ButModifierMDP = New System.Windows.Forms.Button()
        Me.ButAnnulerMDP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancien mot de passe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nouveau mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmer le nouveau mot de passe"
        '
        'TBAncienMDP
        '
        Me.TBAncienMDP.Location = New System.Drawing.Point(209, 25)
        Me.TBAncienMDP.MaxLength = 40
        Me.TBAncienMDP.Name = "TBAncienMDP"
        Me.TBAncienMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBAncienMDP.Size = New System.Drawing.Size(100, 20)
        Me.TBAncienMDP.TabIndex = 3
        '
        'TBNewMPD
        '
        Me.TBNewMPD.Location = New System.Drawing.Point(209, 56)
        Me.TBNewMPD.MaxLength = 40
        Me.TBNewMPD.Name = "TBNewMPD"
        Me.TBNewMPD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBNewMPD.Size = New System.Drawing.Size(100, 20)
        Me.TBNewMPD.TabIndex = 4
        '
        'TBConfirmerNewMPD
        '
        Me.TBConfirmerNewMPD.Location = New System.Drawing.Point(209, 82)
        Me.TBConfirmerNewMPD.MaxLength = 40
        Me.TBConfirmerNewMPD.Name = "TBConfirmerNewMPD"
        Me.TBConfirmerNewMPD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBConfirmerNewMPD.Size = New System.Drawing.Size(100, 20)
        Me.TBConfirmerNewMPD.TabIndex = 5
        '
        'ButModifierMDP
        '
        Me.ButModifierMDP.Location = New System.Drawing.Point(63, 140)
        Me.ButModifierMDP.Name = "ButModifierMDP"
        Me.ButModifierMDP.Size = New System.Drawing.Size(99, 23)
        Me.ButModifierMDP.TabIndex = 6
        Me.ButModifierMDP.Text = "Modifier"
        Me.ButModifierMDP.UseVisualStyleBackColor = True
        '
        'ButAnnulerMDP
        '
        Me.ButAnnulerMDP.Location = New System.Drawing.Point(238, 140)
        Me.ButAnnulerMDP.Name = "ButAnnulerMDP"
        Me.ButAnnulerMDP.Size = New System.Drawing.Size(98, 23)
        Me.ButAnnulerMDP.TabIndex = 7
        Me.ButAnnulerMDP.Text = "Annuler"
        Me.ButAnnulerMDP.UseVisualStyleBackColor = True
        '
        'ModifierMPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 186)
        Me.Controls.Add(Me.ButAnnulerMDP)
        Me.Controls.Add(Me.ButModifierMDP)
        Me.Controls.Add(Me.TBConfirmerNewMPD)
        Me.Controls.Add(Me.TBNewMPD)
        Me.Controls.Add(Me.TBAncienMDP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModifierMPD"
        Me.Text = "Modification mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBAncienMDP As System.Windows.Forms.TextBox
    Friend WithEvents TBNewMPD As System.Windows.Forms.TextBox
    Friend WithEvents TBConfirmerNewMPD As System.Windows.Forms.TextBox
    Friend WithEvents ButModifierMDP As System.Windows.Forms.Button
    Friend WithEvents ButAnnulerMDP As System.Windows.Forms.Button
End Class
