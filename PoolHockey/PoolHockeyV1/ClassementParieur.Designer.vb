<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassementParieur
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
        Me.components = New System.ComponentModel.Container()
        Me.CBClassementParieurs = New System.Windows.Forms.ComboBox()
        Me.PSELECTANNEEFORDGVCHOIXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet = New PoolHockeyV1.ALHDataSet()
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butAnnuler = New System.Windows.Forms.Button()
        Me.butGeneration = New System.Windows.Forms.Button()
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBClassementParieurs
        '
        Me.CBClassementParieurs.DataSource = Me.PSELECTANNEEFORDGVCHOIXBindingSource
        Me.CBClassementParieurs.DisplayMember = "descriptionAnnee"
        Me.CBClassementParieurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBClassementParieurs.FormattingEnabled = True
        Me.CBClassementParieurs.Location = New System.Drawing.Point(275, 26)
        Me.CBClassementParieurs.Name = "CBClassementParieurs"
        Me.CBClassementParieurs.Size = New System.Drawing.Size(121, 21)
        Me.CBClassementParieurs.TabIndex = 2
        Me.CBClassementParieurs.ValueMember = "idAnnee"
        '
        'PSELECTANNEEFORDGVCHOIXBindingSource
        '
        Me.PSELECTANNEEFORDGVCHOIXBindingSource.DataMember = "P_SELECT_ANNEE_FOR_DGV_CHOIX"
        Me.PSELECTANNEEFORDGVCHOIXBindingSource.DataSource = Me.ALHDataSet
        '
        'ALHDataSet
        '
        Me.ALHDataSet.DataSetName = "ALHDataSet"
        Me.ALHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter
        '
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Année pour laquelle vous désirez générer le fichier : "
        '
        'butAnnuler
        '
        Me.butAnnuler.Location = New System.Drawing.Point(213, 62)
        Me.butAnnuler.Name = "butAnnuler"
        Me.butAnnuler.Size = New System.Drawing.Size(96, 23)
        Me.butAnnuler.TabIndex = 4
        Me.butAnnuler.Text = "Annuler"
        Me.butAnnuler.UseVisualStyleBackColor = True
        '
        'butGeneration
        '
        Me.butGeneration.Location = New System.Drawing.Point(111, 62)
        Me.butGeneration.Name = "butGeneration"
        Me.butGeneration.Size = New System.Drawing.Size(96, 23)
        Me.butGeneration.TabIndex = 5
        Me.butGeneration.Text = "Générer"
        Me.butGeneration.UseVisualStyleBackColor = True
        '
        'ClassementParieur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 103)
        Me.Controls.Add(Me.butGeneration)
        Me.Controls.Add(Me.butAnnuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBClassementParieurs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClassementParieur"
        Me.Text = "Classement des parieurs"
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBClassementParieurs As System.Windows.Forms.ComboBox
    Friend WithEvents ALHDataSet As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTANNEEFORDGVCHOIXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butAnnuler As System.Windows.Forms.Button
    Friend WithEvents butGeneration As System.Windows.Forms.Button
End Class
