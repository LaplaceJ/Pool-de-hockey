<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassementDesParieursDetaille
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butGenerationDetaille = New System.Windows.Forms.Button()
        Me.butAnnulerDetaille = New System.Windows.Forms.Button()
        Me.CBClassementParieursDetaille = New System.Windows.Forms.ComboBox()
        Me.PSELECTANNEEFORDGVCHOIXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet = New PoolHockeyV1.ALHDataSet()
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter()
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Année pour laquelle vous désirez générer le fichier : "
        '
        'butGenerationDetaille
        '
        Me.butGenerationDetaille.Location = New System.Drawing.Point(99, 66)
        Me.butGenerationDetaille.Name = "butGenerationDetaille"
        Me.butGenerationDetaille.Size = New System.Drawing.Size(75, 23)
        Me.butGenerationDetaille.TabIndex = 8
        Me.butGenerationDetaille.Text = "Générer"
        Me.butGenerationDetaille.UseVisualStyleBackColor = True
        '
        'butAnnulerDetaille
        '
        Me.butAnnulerDetaille.Location = New System.Drawing.Point(206, 66)
        Me.butAnnulerDetaille.Name = "butAnnulerDetaille"
        Me.butAnnulerDetaille.Size = New System.Drawing.Size(75, 23)
        Me.butAnnulerDetaille.TabIndex = 9
        Me.butAnnulerDetaille.Text = "Annuler"
        Me.butAnnulerDetaille.UseVisualStyleBackColor = True
        '
        'CBClassementParieursDetaille
        '
        Me.CBClassementParieursDetaille.DataSource = Me.PSELECTANNEEFORDGVCHOIXBindingSource
        Me.CBClassementParieursDetaille.DisplayMember = "descriptionAnnee"
        Me.CBClassementParieursDetaille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBClassementParieursDetaille.FormattingEnabled = True
        Me.CBClassementParieursDetaille.Location = New System.Drawing.Point(283, 23)
        Me.CBClassementParieursDetaille.Name = "CBClassementParieursDetaille"
        Me.CBClassementParieursDetaille.Size = New System.Drawing.Size(121, 21)
        Me.CBClassementParieursDetaille.TabIndex = 10
        Me.CBClassementParieursDetaille.ValueMember = "idAnnee"
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
        'ClassementDesParieursDetaille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 101)
        Me.Controls.Add(Me.CBClassementParieursDetaille)
        Me.Controls.Add(Me.butAnnulerDetaille)
        Me.Controls.Add(Me.butGenerationDetaille)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClassementDesParieursDetaille"
        Me.Text = "Classement des parieurs (détaillé)"
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butGenerationDetaille As System.Windows.Forms.Button
    Friend WithEvents butAnnulerDetaille As System.Windows.Forms.Button
    Friend WithEvents CBClassementParieursDetaille As System.Windows.Forms.ComboBox
    Friend WithEvents ALHDataSet As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTANNEEFORDGVCHOIXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter
End Class
