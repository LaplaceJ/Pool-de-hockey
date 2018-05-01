<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.tableauControl1 = New System.Windows.Forms.TabControl()
        Me.TextASetMesChoix = New System.Windows.Forms.TabPage()
        Me.SauvegarderLesModifications = New System.Windows.Forms.Button()
        Me.DGVMesChoix = New System.Windows.Forms.DataGridView()
        Me.JoueurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idJoueur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTJOUEURDGVCHOIXBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet = New PoolHockeyV1.ALHDataSet()
        Me.testASet = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCSeclectMesChoix = New System.Windows.Forms.TextBox()
        Me.TBJSelectMesChoix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxMesChoixJoueurSeulement = New System.Windows.Forms.CheckBox()
        Me.ComboBoxMesChoix = New System.Windows.Forms.ComboBox()
        Me.PSELECTANNEEFORDGVCHOIXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.textP1Annee = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.boutonModifierDGVJoueur = New System.Windows.Forms.Button()
        Me.boutonSupprimerDGVJoueur = New System.Windows.Forms.Button()
        Me.BouttonAjouterDGVJoueur = New System.Windows.Forms.Button()
        Me.DGVGestionJoueur = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxGestionJoueur = New System.Windows.Forms.GroupBox()
        Me.boutonAnnulerDGVJoueur = New System.Windows.Forms.Button()
        Me.boutonSauvegarderDGVJoueur = New System.Windows.Forms.Button()
        Me.ComboBoxGestionJoueurEquipe = New System.Windows.Forms.ComboBox()
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet3 = New PoolHockeyV1.ALHDataSet()
        Me.ComboBoxGestionJoueurPosition = New System.Windows.Forms.ComboBox()
        Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxGestionJoueurPasses = New System.Windows.Forms.TextBox()
        Me.TextBoxGestionJoueurButs = New System.Windows.Forms.TextBox()
        Me.TextBoxGestionJoueurCote = New System.Windows.Forms.TextBox()
        Me.TextBoxGestionJoueurPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxGestionJoueurNom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxGestionJoueur = New System.Windows.Forms.ComboBox()
        Me.textAnnee = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.boutonModifierDGVParieur = New System.Windows.Forms.Button()
        Me.boutonSupprimerDGVParieur = New System.Windows.Forms.Button()
        Me.boutonAjouterDGVParieur = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.boutonAnnulerDGVParieur = New System.Windows.Forms.Button()
        Me.boutonSauvegarderDGVParieur = New System.Windows.Forms.Button()
        Me.ComboBoxTypesGestionParieurs = New System.Windows.Forms.ComboBox()
        Me.PSELECTREFPARIEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxCourielleGestionParieurs = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomGestionParieurs = New System.Windows.Forms.TextBox()
        Me.TextBoxNomGestionParieur = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewGestionParieurs = New System.Windows.Forms.DataGridView()
        Me.ParieurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourrielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdParDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTPARIEURDGVBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBAnnee = New System.Windows.Forms.TextBox()
        Me.CBSaisieEnCours = New System.Windows.Forms.CheckBox()
        Me.CBImportJoueur = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.boutonAjouterAnnee = New System.Windows.Forms.Button()
        Me.boutonModifierAnnee = New System.Windows.Forms.Button()
        Me.boutonSupprimerAnnee = New System.Windows.Forms.Button()
        Me.boutonAnnulerAnnee = New System.Windows.Forms.Button()
        Me.boutonSauvegarderAnnee = New System.Windows.Forms.Button()
        Me.DGVAnnee = New System.Windows.Forms.DataGridView()
        Me.DescriptionAnneeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdAnneeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTANNEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet4 = New PoolHockeyV1.ALHDataSet()
        Me.GroupBoxGestionParametres = New System.Windows.Forms.GroupBox()
        Me.TBMAXCote = New System.Windows.Forms.TextBox()
        Me.TBMAXJoueur = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SauvegarderParametre = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ALHDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTPARIEURDGVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTJOUEURDGVCHOIXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter()
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter()
        Me.P_SELECT_PARIEUR_DGVTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_PARIEUR_DGVTableAdapter()
        Me.ALHDataSet1 = New PoolHockeyV1.ALHDataSet()
        Me.ALHDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTPARIEURDGVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALHDataSet2 = New PoolHockeyV1.ALHDataSet()
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter()
        Me.P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter()
        Me.P_SELECT_REF_PARIEURTableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_REF_PARIEURTableAdapter()
        Me.PSELECTJOUEURDGVCHOIXBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMotDePasseMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALHDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSELECTJOUEURDGVCHOIXBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_ANNEETableAdapter = New PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEETableAdapter()
        Me.tableauControl1.SuspendLayout()
        Me.TextASetMesChoix.SuspendLayout()
        CType(Me.DGVMesChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVGestionJoueur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionJoueur.SuspendLayout()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PSELECTREFPARIEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewGestionParieurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTPARIEURDGVBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTANNEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionParametres.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTPARIEURDGVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTPARIEURDGVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALHDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ALHDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'tableauControl1
        '
        Me.tableauControl1.Controls.Add(Me.TextASetMesChoix)
        Me.tableauControl1.Controls.Add(Me.TabPage2)
        Me.tableauControl1.Controls.Add(Me.TabPage3)
        Me.tableauControl1.Controls.Add(Me.TabPage4)
        Me.tableauControl1.Controls.Add(Me.TabPage5)
        Me.tableauControl1.Location = New System.Drawing.Point(15, 27)
        Me.tableauControl1.Name = "tableauControl1"
        Me.tableauControl1.SelectedIndex = 0
        Me.tableauControl1.Size = New System.Drawing.Size(747, 612)
        Me.tableauControl1.TabIndex = 0
        Me.tableauControl1.TabStop = False
        '
        'TextASetMesChoix
        '
        Me.TextASetMesChoix.Controls.Add(Me.SauvegarderLesModifications)
        Me.TextASetMesChoix.Controls.Add(Me.DGVMesChoix)
        Me.TextASetMesChoix.Controls.Add(Me.testASet)
        Me.TextASetMesChoix.Controls.Add(Me.Label2)
        Me.TextASetMesChoix.Controls.Add(Me.TBCSeclectMesChoix)
        Me.TextASetMesChoix.Controls.Add(Me.TBJSelectMesChoix)
        Me.TextASetMesChoix.Controls.Add(Me.Label1)
        Me.TextASetMesChoix.Controls.Add(Me.CheckBoxMesChoixJoueurSeulement)
        Me.TextASetMesChoix.Controls.Add(Me.ComboBoxMesChoix)
        Me.TextASetMesChoix.Controls.Add(Me.textP1Annee)
        Me.TextASetMesChoix.Location = New System.Drawing.Point(4, 22)
        Me.TextASetMesChoix.Name = "TextASetMesChoix"
        Me.TextASetMesChoix.Padding = New System.Windows.Forms.Padding(3)
        Me.TextASetMesChoix.Size = New System.Drawing.Size(739, 586)
        Me.TextASetMesChoix.TabIndex = 0
        Me.TextASetMesChoix.Text = "Mes choix"
        Me.TextASetMesChoix.UseVisualStyleBackColor = True
        '
        'SauvegarderLesModifications
        '
        Me.SauvegarderLesModifications.Location = New System.Drawing.Point(506, 19)
        Me.SauvegarderLesModifications.Name = "SauvegarderLesModifications"
        Me.SauvegarderLesModifications.Size = New System.Drawing.Size(205, 23)
        Me.SauvegarderLesModifications.TabIndex = 12
        Me.SauvegarderLesModifications.Text = "Sauvegarder les modifications "
        Me.SauvegarderLesModifications.UseVisualStyleBackColor = True
        '
        'DGVMesChoix
        '
        Me.DGVMesChoix.AllowUserToAddRows = False
        Me.DGVMesChoix.AllowUserToDeleteRows = False
        Me.DGVMesChoix.AllowUserToResizeColumns = False
        Me.DGVMesChoix.AllowUserToResizeRows = False
        Me.DGVMesChoix.AutoGenerateColumns = False
        Me.DGVMesChoix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMesChoix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JoueurDataGridViewTextBoxColumn, Me.EquipeDataGridViewTextBoxColumn, Me.PosDataGridViewTextBoxColumn, Me.CoteDataGridViewTextBoxColumn, Me.ButsDataGridViewTextBoxColumn, Me.PassesDataGridViewTextBoxColumn, Me.PtsDataGridViewTextBoxColumn, Me.idJoueur})
        Me.DGVMesChoix.DataSource = Me.PSELECTJOUEURDGVCHOIXBindingSource1
        Me.DGVMesChoix.Location = New System.Drawing.Point(19, 84)
        Me.DGVMesChoix.Name = "DGVMesChoix"
        Me.DGVMesChoix.ReadOnly = True
        Me.DGVMesChoix.RowHeadersVisible = False
        Me.DGVMesChoix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMesChoix.Size = New System.Drawing.Size(700, 330)
        Me.DGVMesChoix.TabIndex = 11
        '
        'JoueurDataGridViewTextBoxColumn
        '
        Me.JoueurDataGridViewTextBoxColumn.DataPropertyName = "Joueur"
        Me.JoueurDataGridViewTextBoxColumn.HeaderText = "Joueur"
        Me.JoueurDataGridViewTextBoxColumn.Name = "JoueurDataGridViewTextBoxColumn"
        Me.JoueurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EquipeDataGridViewTextBoxColumn
        '
        Me.EquipeDataGridViewTextBoxColumn.DataPropertyName = "Equipe"
        Me.EquipeDataGridViewTextBoxColumn.HeaderText = "Equipe"
        Me.EquipeDataGridViewTextBoxColumn.Name = "EquipeDataGridViewTextBoxColumn"
        Me.EquipeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PosDataGridViewTextBoxColumn
        '
        Me.PosDataGridViewTextBoxColumn.DataPropertyName = "Pos"
        Me.PosDataGridViewTextBoxColumn.HeaderText = "Pos"
        Me.PosDataGridViewTextBoxColumn.Name = "PosDataGridViewTextBoxColumn"
        Me.PosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoteDataGridViewTextBoxColumn
        '
        Me.CoteDataGridViewTextBoxColumn.DataPropertyName = "Cote"
        Me.CoteDataGridViewTextBoxColumn.HeaderText = "Cote"
        Me.CoteDataGridViewTextBoxColumn.Name = "CoteDataGridViewTextBoxColumn"
        Me.CoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ButsDataGridViewTextBoxColumn
        '
        Me.ButsDataGridViewTextBoxColumn.DataPropertyName = "Buts"
        Me.ButsDataGridViewTextBoxColumn.HeaderText = "Buts"
        Me.ButsDataGridViewTextBoxColumn.Name = "ButsDataGridViewTextBoxColumn"
        Me.ButsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PassesDataGridViewTextBoxColumn
        '
        Me.PassesDataGridViewTextBoxColumn.DataPropertyName = "Passes"
        Me.PassesDataGridViewTextBoxColumn.HeaderText = "Passes"
        Me.PassesDataGridViewTextBoxColumn.Name = "PassesDataGridViewTextBoxColumn"
        Me.PassesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PtsDataGridViewTextBoxColumn
        '
        Me.PtsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PtsDataGridViewTextBoxColumn.DataPropertyName = "Pts"
        Me.PtsDataGridViewTextBoxColumn.HeaderText = "Pts"
        Me.PtsDataGridViewTextBoxColumn.Name = "PtsDataGridViewTextBoxColumn"
        Me.PtsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'idJoueur
        '
        Me.idJoueur.DataPropertyName = "idJoueur"
        Me.idJoueur.HeaderText = "idJoueur"
        Me.idJoueur.Name = "idJoueur"
        Me.idJoueur.ReadOnly = True
        Me.idJoueur.Visible = False
        '
        'PSELECTJOUEURDGVCHOIXBindingSource1
        '
        Me.PSELECTJOUEURDGVCHOIXBindingSource1.DataMember = "P_SELECT_JOUEUR_DGV_CHOIX"
        Me.PSELECTJOUEURDGVCHOIXBindingSource1.DataSource = Me.ALHDataSet
        '
        'ALHDataSet
        '
        Me.ALHDataSet.DataSetName = "ALHDataSet"
        Me.ALHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'testASet
        '
        Me.testASet.AutoSize = True
        Me.testASet.Location = New System.Drawing.Point(16, 68)
        Me.testASet.Name = "testASet"
        Me.testASet.Size = New System.Drawing.Size(50, 13)
        Me.testASet.TabIndex = 9
        Me.testASet.Text = "text a set"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cote totale: "
        '
        'TBCSeclectMesChoix
        '
        Me.TBCSeclectMesChoix.Location = New System.Drawing.Point(354, 423)
        Me.TBCSeclectMesChoix.Name = "TBCSeclectMesChoix"
        Me.TBCSeclectMesChoix.Size = New System.Drawing.Size(22, 20)
        Me.TBCSeclectMesChoix.TabIndex = 7
        '
        'TBJSelectMesChoix
        '
        Me.TBJSelectMesChoix.Location = New System.Drawing.Point(146, 420)
        Me.TBJSelectMesChoix.Name = "TBJSelectMesChoix"
        Me.TBJSelectMesChoix.Size = New System.Drawing.Size(22, 20)
        Me.TBJSelectMesChoix.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Joeur(s) sélectionnée(s):"
        '
        'CheckBoxMesChoixJoueurSeulement
        '
        Me.CheckBoxMesChoixJoueurSeulement.AutoSize = True
        Me.CheckBoxMesChoixJoueurSeulement.Location = New System.Drawing.Point(214, 19)
        Me.CheckBoxMesChoixJoueurSeulement.Name = "CheckBoxMesChoixJoueurSeulement"
        Me.CheckBoxMesChoixJoueurSeulement.Size = New System.Drawing.Size(134, 17)
        Me.CheckBoxMesChoixJoueurSeulement.TabIndex = 2
        Me.CheckBoxMesChoixJoueurSeulement.Text = "Mes joueurs seulement"
        Me.CheckBoxMesChoixJoueurSeulement.UseVisualStyleBackColor = True
        '
        'ComboBoxMesChoix
        '
        Me.ComboBoxMesChoix.DataSource = Me.PSELECTANNEEFORDGVCHOIXBindingSource
        Me.ComboBoxMesChoix.DisplayMember = "descriptionAnnee"
        Me.ComboBoxMesChoix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMesChoix.FormattingEnabled = True
        Me.ComboBoxMesChoix.Location = New System.Drawing.Point(63, 15)
        Me.ComboBoxMesChoix.Name = "ComboBoxMesChoix"
        Me.ComboBoxMesChoix.Size = New System.Drawing.Size(105, 21)
        Me.ComboBoxMesChoix.TabIndex = 1
        Me.ComboBoxMesChoix.ValueMember = "idAnnee"
        '
        'PSELECTANNEEFORDGVCHOIXBindingSource
        '
        Me.PSELECTANNEEFORDGVCHOIXBindingSource.DataMember = "P_SELECT_ANNEE_FOR_DGV_CHOIX"
        Me.PSELECTANNEEFORDGVCHOIXBindingSource.DataSource = Me.ALHDataSet
        '
        'textP1Annee
        '
        Me.textP1Annee.AutoSize = True
        Me.textP1Annee.Location = New System.Drawing.Point(16, 18)
        Me.textP1Annee.Name = "textP1Annee"
        Me.textP1Annee.Size = New System.Drawing.Size(41, 13)
        Me.textP1Annee.TabIndex = 0
        Me.textP1Annee.Text = "Année:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.boutonModifierDGVJoueur)
        Me.TabPage2.Controls.Add(Me.boutonSupprimerDGVJoueur)
        Me.TabPage2.Controls.Add(Me.BouttonAjouterDGVJoueur)
        Me.TabPage2.Controls.Add(Me.DGVGestionJoueur)
        Me.TabPage2.Controls.Add(Me.GroupBoxGestionJoueur)
        Me.TabPage2.Controls.Add(Me.ComboBoxGestionJoueur)
        Me.TabPage2.Controls.Add(Me.textAnnee)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(739, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestion des joueurs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'boutonModifierDGVJoueur
        '
        Me.boutonModifierDGVJoueur.Location = New System.Drawing.Point(636, 104)
        Me.boutonModifierDGVJoueur.Name = "boutonModifierDGVJoueur"
        Me.boutonModifierDGVJoueur.Size = New System.Drawing.Size(90, 23)
        Me.boutonModifierDGVJoueur.TabIndex = 15
        Me.boutonModifierDGVJoueur.Text = "Modifier"
        Me.boutonModifierDGVJoueur.UseVisualStyleBackColor = True
        '
        'boutonSupprimerDGVJoueur
        '
        Me.boutonSupprimerDGVJoueur.Location = New System.Drawing.Point(636, 133)
        Me.boutonSupprimerDGVJoueur.Name = "boutonSupprimerDGVJoueur"
        Me.boutonSupprimerDGVJoueur.Size = New System.Drawing.Size(90, 23)
        Me.boutonSupprimerDGVJoueur.TabIndex = 14
        Me.boutonSupprimerDGVJoueur.Text = "Supprimer"
        Me.boutonSupprimerDGVJoueur.UseVisualStyleBackColor = True
        '
        'BouttonAjouterDGVJoueur
        '
        Me.BouttonAjouterDGVJoueur.Location = New System.Drawing.Point(636, 75)
        Me.BouttonAjouterDGVJoueur.Name = "BouttonAjouterDGVJoueur"
        Me.BouttonAjouterDGVJoueur.Size = New System.Drawing.Size(90, 23)
        Me.BouttonAjouterDGVJoueur.TabIndex = 13
        Me.BouttonAjouterDGVJoueur.Text = "Ajouter"
        Me.BouttonAjouterDGVJoueur.UseVisualStyleBackColor = True
        '
        'DGVGestionJoueur
        '
        Me.DGVGestionJoueur.AllowUserToAddRows = False
        Me.DGVGestionJoueur.AllowUserToDeleteRows = False
        Me.DGVGestionJoueur.AllowUserToResizeColumns = False
        Me.DGVGestionJoueur.AllowUserToResizeRows = False
        Me.DGVGestionJoueur.AutoGenerateColumns = False
        Me.DGVGestionJoueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGestionJoueur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DGVGestionJoueur.DataSource = Me.PSELECTJOUEURDGVCHOIXBindingSource1
        Me.DGVGestionJoueur.Location = New System.Drawing.Point(19, 61)
        Me.DGVGestionJoueur.MultiSelect = False
        Me.DGVGestionJoueur.Name = "DGVGestionJoueur"
        Me.DGVGestionJoueur.ReadOnly = True
        Me.DGVGestionJoueur.RowHeadersVisible = False
        Me.DGVGestionJoueur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGestionJoueur.Size = New System.Drawing.Size(611, 330)
        Me.DGVGestionJoueur.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Joueur"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Joueur"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Equipe"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Equipe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Pos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cote"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cote"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Buts"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Buts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Passes"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Passes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pts"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pts"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idJoueur"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idJoueur"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'GroupBoxGestionJoueur
        '
        Me.GroupBoxGestionJoueur.Controls.Add(Me.boutonAnnulerDGVJoueur)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.boutonSauvegarderDGVJoueur)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.ComboBoxGestionJoueurEquipe)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.ComboBoxGestionJoueurPosition)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.TextBoxGestionJoueurPasses)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.TextBoxGestionJoueurButs)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.TextBoxGestionJoueurCote)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.TextBoxGestionJoueurPrenom)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.TextBoxGestionJoueurNom)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label11)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label10)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label9)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label8)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label7)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label6)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label5)
        Me.GroupBoxGestionJoueur.Controls.Add(Me.Label4)
        Me.GroupBoxGestionJoueur.Location = New System.Drawing.Point(19, 407)
        Me.GroupBoxGestionJoueur.Name = "GroupBoxGestionJoueur"
        Me.GroupBoxGestionJoueur.Size = New System.Drawing.Size(707, 173)
        Me.GroupBoxGestionJoueur.TabIndex = 3
        Me.GroupBoxGestionJoueur.TabStop = False
        Me.GroupBoxGestionJoueur.Text = "Détails du joueur sélectionné"
        '
        'boutonAnnulerDGVJoueur
        '
        Me.boutonAnnulerDGVJoueur.Location = New System.Drawing.Point(617, 48)
        Me.boutonAnnulerDGVJoueur.Name = "boutonAnnulerDGVJoueur"
        Me.boutonAnnulerDGVJoueur.Size = New System.Drawing.Size(84, 23)
        Me.boutonAnnulerDGVJoueur.TabIndex = 16
        Me.boutonAnnulerDGVJoueur.Text = "Annuler"
        Me.boutonAnnulerDGVJoueur.UseVisualStyleBackColor = True
        '
        'boutonSauvegarderDGVJoueur
        '
        Me.boutonSauvegarderDGVJoueur.Location = New System.Drawing.Point(617, 19)
        Me.boutonSauvegarderDGVJoueur.Name = "boutonSauvegarderDGVJoueur"
        Me.boutonSauvegarderDGVJoueur.Size = New System.Drawing.Size(84, 23)
        Me.boutonSauvegarderDGVJoueur.TabIndex = 17
        Me.boutonSauvegarderDGVJoueur.Text = "Sauvegarder"
        Me.boutonSauvegarderDGVJoueur.UseVisualStyleBackColor = True
        '
        'ComboBoxGestionJoueurEquipe
        '
        Me.ComboBoxGestionJoueurEquipe.DataSource = Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3
        Me.ComboBoxGestionJoueurEquipe.DisplayMember = "Equipe"
        Me.ComboBoxGestionJoueurEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGestionJoueurEquipe.FormattingEnabled = True
        Me.ComboBoxGestionJoueurEquipe.Location = New System.Drawing.Point(93, 96)
        Me.ComboBoxGestionJoueurEquipe.Name = "ComboBoxGestionJoueurEquipe"
        Me.ComboBoxGestionJoueurEquipe.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGestionJoueurEquipe.TabIndex = 15
        Me.ComboBoxGestionJoueurEquipe.ValueMember = "idEquipe"
        '
        'PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3
        '
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3.DataMember = "P_SELECT_EQUIPE_MODIFICATION_JOUEUR"
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3.DataSource = Me.ALHDataSet3
        '
        'ALHDataSet3
        '
        Me.ALHDataSet3.DataSetName = "ALHDataSet"
        Me.ALHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxGestionJoueurPosition
        '
        Me.ComboBoxGestionJoueurPosition.DataSource = Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource
        Me.ComboBoxGestionJoueurPosition.DisplayMember = "Pos"
        Me.ComboBoxGestionJoueurPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGestionJoueurPosition.FormattingEnabled = True
        Me.ComboBoxGestionJoueurPosition.Location = New System.Drawing.Point(93, 127)
        Me.ComboBoxGestionJoueurPosition.Name = "ComboBoxGestionJoueurPosition"
        Me.ComboBoxGestionJoueurPosition.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGestionJoueurPosition.TabIndex = 14
        Me.ComboBoxGestionJoueurPosition.ValueMember = "Pos"
        '
        'PSELECTPOSITIONMODIFICATIONJOUEURBindingSource
        '
        Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource.DataMember = "P_SELECT_POSITION_MODIFICATION_JOUEUR"
        Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource.DataSource = Me.ALHDataSet
        '
        'TextBoxGestionJoueurPasses
        '
        Me.TextBoxGestionJoueurPasses.Location = New System.Drawing.Point(267, 96)
        Me.TextBoxGestionJoueurPasses.MaxLength = 40
        Me.TextBoxGestionJoueurPasses.Name = "TextBoxGestionJoueurPasses"
        Me.TextBoxGestionJoueurPasses.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGestionJoueurPasses.TabIndex = 12
        '
        'TextBoxGestionJoueurButs
        '
        Me.TextBoxGestionJoueurButs.Location = New System.Drawing.Point(267, 69)
        Me.TextBoxGestionJoueurButs.MaxLength = 40
        Me.TextBoxGestionJoueurButs.Name = "TextBoxGestionJoueurButs"
        Me.TextBoxGestionJoueurButs.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGestionJoueurButs.TabIndex = 11
        '
        'TextBoxGestionJoueurCote
        '
        Me.TextBoxGestionJoueurCote.Location = New System.Drawing.Point(267, 41)
        Me.TextBoxGestionJoueurCote.MaxLength = 40
        Me.TextBoxGestionJoueurCote.Name = "TextBoxGestionJoueurCote"
        Me.TextBoxGestionJoueurCote.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGestionJoueurCote.TabIndex = 10
        '
        'TextBoxGestionJoueurPrenom
        '
        Me.TextBoxGestionJoueurPrenom.Location = New System.Drawing.Point(93, 69)
        Me.TextBoxGestionJoueurPrenom.MaxLength = 40
        Me.TextBoxGestionJoueurPrenom.Name = "TextBoxGestionJoueurPrenom"
        Me.TextBoxGestionJoueurPrenom.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGestionJoueurPrenom.TabIndex = 9
        '
        'TextBoxGestionJoueurNom
        '
        Me.TextBoxGestionJoueurNom.Location = New System.Drawing.Point(94, 41)
        Me.TextBoxGestionJoueurNom.MaxLength = 40
        Me.TextBoxGestionJoueurNom.Name = "TextBoxGestionJoueurNom"
        Me.TextBoxGestionJoueurNom.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGestionJoueurNom.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Passes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(229, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Buts:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(229, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cote:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Position:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Équipe:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Prénom:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nom:"
        '
        'ComboBoxGestionJoueur
        '
        Me.ComboBoxGestionJoueur.DataSource = Me.PSELECTANNEEFORDGVCHOIXBindingSource
        Me.ComboBoxGestionJoueur.DisplayMember = "descriptionAnnee"
        Me.ComboBoxGestionJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGestionJoueur.FormattingEnabled = True
        Me.ComboBoxGestionJoueur.Location = New System.Drawing.Point(63, 15)
        Me.ComboBoxGestionJoueur.Name = "ComboBoxGestionJoueur"
        Me.ComboBoxGestionJoueur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGestionJoueur.TabIndex = 1
        Me.ComboBoxGestionJoueur.ValueMember = "idAnnee"
        '
        'textAnnee
        '
        Me.textAnnee.AutoSize = True
        Me.textAnnee.Location = New System.Drawing.Point(16, 18)
        Me.textAnnee.Name = "textAnnee"
        Me.textAnnee.Size = New System.Drawing.Size(41, 13)
        Me.textAnnee.TabIndex = 0
        Me.textAnnee.Text = "Année:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.boutonModifierDGVParieur)
        Me.TabPage3.Controls.Add(Me.boutonSupprimerDGVParieur)
        Me.TabPage3.Controls.Add(Me.boutonAjouterDGVParieur)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.DataGridViewGestionParieurs)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(739, 586)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gestion des parieurs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'boutonModifierDGVParieur
        '
        Me.boutonModifierDGVParieur.Location = New System.Drawing.Point(637, 46)
        Me.boutonModifierDGVParieur.Name = "boutonModifierDGVParieur"
        Me.boutonModifierDGVParieur.Size = New System.Drawing.Size(91, 23)
        Me.boutonModifierDGVParieur.TabIndex = 4
        Me.boutonModifierDGVParieur.Text = "Modifier"
        Me.boutonModifierDGVParieur.UseVisualStyleBackColor = True
        '
        'boutonSupprimerDGVParieur
        '
        Me.boutonSupprimerDGVParieur.Location = New System.Drawing.Point(637, 75)
        Me.boutonSupprimerDGVParieur.Name = "boutonSupprimerDGVParieur"
        Me.boutonSupprimerDGVParieur.Size = New System.Drawing.Size(91, 23)
        Me.boutonSupprimerDGVParieur.TabIndex = 3
        Me.boutonSupprimerDGVParieur.Text = "Supprimer"
        Me.boutonSupprimerDGVParieur.UseVisualStyleBackColor = True
        '
        'boutonAjouterDGVParieur
        '
        Me.boutonAjouterDGVParieur.Location = New System.Drawing.Point(637, 17)
        Me.boutonAjouterDGVParieur.Name = "boutonAjouterDGVParieur"
        Me.boutonAjouterDGVParieur.Size = New System.Drawing.Size(91, 23)
        Me.boutonAjouterDGVParieur.TabIndex = 2
        Me.boutonAjouterDGVParieur.Text = "Ajouter"
        Me.boutonAjouterDGVParieur.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.boutonAnnulerDGVParieur)
        Me.GroupBox1.Controls.Add(Me.boutonSauvegarderDGVParieur)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTypesGestionParieurs)
        Me.GroupBox1.Controls.Add(Me.TextBoxCourielleGestionParieurs)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrenomGestionParieurs)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomGestionParieur)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "détails du parieur sélectionné"
        '
        'boutonAnnulerDGVParieur
        '
        Me.boutonAnnulerDGVParieur.Location = New System.Drawing.Point(618, 48)
        Me.boutonAnnulerDGVParieur.Name = "boutonAnnulerDGVParieur"
        Me.boutonAnnulerDGVParieur.Size = New System.Drawing.Size(91, 23)
        Me.boutonAnnulerDGVParieur.TabIndex = 8
        Me.boutonAnnulerDGVParieur.Text = "Annuler"
        Me.boutonAnnulerDGVParieur.UseVisualStyleBackColor = True
        '
        'boutonSauvegarderDGVParieur
        '
        Me.boutonSauvegarderDGVParieur.Location = New System.Drawing.Point(618, 19)
        Me.boutonSauvegarderDGVParieur.Name = "boutonSauvegarderDGVParieur"
        Me.boutonSauvegarderDGVParieur.Size = New System.Drawing.Size(91, 23)
        Me.boutonSauvegarderDGVParieur.TabIndex = 6
        Me.boutonSauvegarderDGVParieur.Text = "Sauvegarder"
        Me.boutonSauvegarderDGVParieur.UseVisualStyleBackColor = True
        '
        'ComboBoxTypesGestionParieurs
        '
        Me.ComboBoxTypesGestionParieurs.DataSource = Me.PSELECTREFPARIEURBindingSource
        Me.ComboBoxTypesGestionParieurs.DisplayMember = "defRef"
        Me.ComboBoxTypesGestionParieurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTypesGestionParieurs.FormattingEnabled = True
        Me.ComboBoxTypesGestionParieurs.Location = New System.Drawing.Point(291, 58)
        Me.ComboBoxTypesGestionParieurs.Name = "ComboBoxTypesGestionParieurs"
        Me.ComboBoxTypesGestionParieurs.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTypesGestionParieurs.TabIndex = 7
        Me.ComboBoxTypesGestionParieurs.ValueMember = "typePar"
        '
        'PSELECTREFPARIEURBindingSource
        '
        Me.PSELECTREFPARIEURBindingSource.DataMember = "P_SELECT_REF_PARIEUR"
        Me.PSELECTREFPARIEURBindingSource.DataSource = Me.ALHDataSet
        '
        'TextBoxCourielleGestionParieurs
        '
        Me.TextBoxCourielleGestionParieurs.Location = New System.Drawing.Point(291, 27)
        Me.TextBoxCourielleGestionParieurs.MaxLength = 40
        Me.TextBoxCourielleGestionParieurs.Name = "TextBoxCourielleGestionParieurs"
        Me.TextBoxCourielleGestionParieurs.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxCourielleGestionParieurs.TabIndex = 6
        '
        'TextBoxPrenomGestionParieurs
        '
        Me.TextBoxPrenomGestionParieurs.Location = New System.Drawing.Point(88, 59)
        Me.TextBoxPrenomGestionParieurs.MaxLength = 40
        Me.TextBoxPrenomGestionParieurs.Name = "TextBoxPrenomGestionParieurs"
        Me.TextBoxPrenomGestionParieurs.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrenomGestionParieurs.TabIndex = 5
        '
        'TextBoxNomGestionParieur
        '
        Me.TextBoxNomGestionParieur.Location = New System.Drawing.Point(88, 27)
        Me.TextBoxNomGestionParieur.MaxLength = 40
        Me.TextBoxNomGestionParieur.Name = "TextBoxNomGestionParieur"
        Me.TextBoxNomGestionParieur.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNomGestionParieur.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(230, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Couriel:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(230, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Type:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Prénom:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom:"
        '
        'DataGridViewGestionParieurs
        '
        Me.DataGridViewGestionParieurs.AllowUserToAddRows = False
        Me.DataGridViewGestionParieurs.AllowUserToDeleteRows = False
        Me.DataGridViewGestionParieurs.AllowUserToResizeColumns = False
        Me.DataGridViewGestionParieurs.AllowUserToResizeRows = False
        Me.DataGridViewGestionParieurs.AutoGenerateColumns = False
        Me.DataGridViewGestionParieurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGestionParieurs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParieurDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CourrielDataGridViewTextBoxColumn, Me.IdParDataGridViewTextBoxColumn})
        Me.DataGridViewGestionParieurs.DataSource = Me.PSELECTPARIEURDGVBindingSource2
        Me.DataGridViewGestionParieurs.Location = New System.Drawing.Point(10, 17)
        Me.DataGridViewGestionParieurs.MultiSelect = False
        Me.DataGridViewGestionParieurs.Name = "DataGridViewGestionParieurs"
        Me.DataGridViewGestionParieurs.ReadOnly = True
        Me.DataGridViewGestionParieurs.RowHeadersVisible = False
        Me.DataGridViewGestionParieurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewGestionParieurs.Size = New System.Drawing.Size(621, 302)
        Me.DataGridViewGestionParieurs.TabIndex = 0
        '
        'ParieurDataGridViewTextBoxColumn
        '
        Me.ParieurDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ParieurDataGridViewTextBoxColumn.DataPropertyName = "Parieur"
        Me.ParieurDataGridViewTextBoxColumn.HeaderText = "Parieur"
        Me.ParieurDataGridViewTextBoxColumn.Name = "ParieurDataGridViewTextBoxColumn"
        Me.ParieurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourrielDataGridViewTextBoxColumn
        '
        Me.CourrielDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CourrielDataGridViewTextBoxColumn.DataPropertyName = "Courriel"
        Me.CourrielDataGridViewTextBoxColumn.HeaderText = "Courriel"
        Me.CourrielDataGridViewTextBoxColumn.Name = "CourrielDataGridViewTextBoxColumn"
        Me.CourrielDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdParDataGridViewTextBoxColumn
        '
        Me.IdParDataGridViewTextBoxColumn.DataPropertyName = "idPar"
        Me.IdParDataGridViewTextBoxColumn.HeaderText = "idPar"
        Me.IdParDataGridViewTextBoxColumn.Name = "IdParDataGridViewTextBoxColumn"
        Me.IdParDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdParDataGridViewTextBoxColumn.Visible = False
        '
        'PSELECTPARIEURDGVBindingSource2
        '
        Me.PSELECTPARIEURDGVBindingSource2.DataMember = "P_SELECT_PARIEUR_DGV"
        Me.PSELECTPARIEURDGVBindingSource2.DataSource = Me.ALHDataSet
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBoxGestionParametres)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(739, 586)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Gestion des paramètres"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBAnnee)
        Me.GroupBox2.Controls.Add(Me.CBSaisieEnCours)
        Me.GroupBox2.Controls.Add(Me.CBImportJoueur)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.boutonAjouterAnnee)
        Me.GroupBox2.Controls.Add(Me.boutonModifierAnnee)
        Me.GroupBox2.Controls.Add(Me.boutonSupprimerAnnee)
        Me.GroupBox2.Controls.Add(Me.boutonAnnulerAnnee)
        Me.GroupBox2.Controls.Add(Me.boutonSauvegarderAnnee)
        Me.GroupBox2.Controls.Add(Me.DGVAnnee)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(716, 285)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion des années"
        '
        'TBAnnee
        '
        Me.TBAnnee.Location = New System.Drawing.Point(65, 205)
        Me.TBAnnee.MaxLength = 9
        Me.TBAnnee.Name = "TBAnnee"
        Me.TBAnnee.Size = New System.Drawing.Size(100, 20)
        Me.TBAnnee.TabIndex = 12
        '
        'CBSaisieEnCours
        '
        Me.CBSaisieEnCours.AutoSize = True
        Me.CBSaisieEnCours.Location = New System.Drawing.Point(21, 231)
        Me.CBSaisieEnCours.Name = "CBSaisieEnCours"
        Me.CBSaisieEnCours.Size = New System.Drawing.Size(98, 17)
        Me.CBSaisieEnCours.TabIndex = 11
        Me.CBSaisieEnCours.Text = "Saisie en cours"
        Me.CBSaisieEnCours.UseVisualStyleBackColor = True
        '
        'CBImportJoueur
        '
        Me.CBImportJoueur.AutoSize = True
        Me.CBImportJoueur.Location = New System.Drawing.Point(21, 254)
        Me.CBImportJoueur.Name = "CBImportJoueur"
        Me.CBImportJoueur.Size = New System.Drawing.Size(218, 17)
        Me.CBImportJoueur.TabIndex = 10
        Me.CBImportJoueur.Text = "Copier les joueurs de l'année précédente"
        Me.CBImportJoueur.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 205)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Année:"
        '
        'boutonAjouterAnnee
        '
        Me.boutonAjouterAnnee.Location = New System.Drawing.Point(276, 19)
        Me.boutonAjouterAnnee.Name = "boutonAjouterAnnee"
        Me.boutonAjouterAnnee.Size = New System.Drawing.Size(75, 23)
        Me.boutonAjouterAnnee.TabIndex = 8
        Me.boutonAjouterAnnee.Text = "Ajouter"
        Me.boutonAjouterAnnee.UseVisualStyleBackColor = True
        '
        'boutonModifierAnnee
        '
        Me.boutonModifierAnnee.Location = New System.Drawing.Point(276, 48)
        Me.boutonModifierAnnee.Name = "boutonModifierAnnee"
        Me.boutonModifierAnnee.Size = New System.Drawing.Size(75, 23)
        Me.boutonModifierAnnee.TabIndex = 7
        Me.boutonModifierAnnee.Text = "Modifier"
        Me.boutonModifierAnnee.UseVisualStyleBackColor = True
        '
        'boutonSupprimerAnnee
        '
        Me.boutonSupprimerAnnee.Location = New System.Drawing.Point(276, 77)
        Me.boutonSupprimerAnnee.Name = "boutonSupprimerAnnee"
        Me.boutonSupprimerAnnee.Size = New System.Drawing.Size(75, 23)
        Me.boutonSupprimerAnnee.TabIndex = 6
        Me.boutonSupprimerAnnee.Text = "Supprimer"
        Me.boutonSupprimerAnnee.UseVisualStyleBackColor = True
        '
        'boutonAnnulerAnnee
        '
        Me.boutonAnnulerAnnee.Location = New System.Drawing.Point(276, 234)
        Me.boutonAnnulerAnnee.Name = "boutonAnnulerAnnee"
        Me.boutonAnnulerAnnee.Size = New System.Drawing.Size(75, 23)
        Me.boutonAnnulerAnnee.TabIndex = 4
        Me.boutonAnnulerAnnee.Text = "Annuler"
        Me.boutonAnnulerAnnee.UseVisualStyleBackColor = True
        '
        'boutonSauvegarderAnnee
        '
        Me.boutonSauvegarderAnnee.Location = New System.Drawing.Point(276, 205)
        Me.boutonSauvegarderAnnee.Name = "boutonSauvegarderAnnee"
        Me.boutonSauvegarderAnnee.Size = New System.Drawing.Size(75, 23)
        Me.boutonSauvegarderAnnee.TabIndex = 3
        Me.boutonSauvegarderAnnee.Text = "Sauvegarder"
        Me.boutonSauvegarderAnnee.UseVisualStyleBackColor = True
        '
        'DGVAnnee
        '
        Me.DGVAnnee.AllowUserToAddRows = False
        Me.DGVAnnee.AllowUserToDeleteRows = False
        Me.DGVAnnee.AllowUserToResizeColumns = False
        Me.DGVAnnee.AllowUserToResizeRows = False
        Me.DGVAnnee.AutoGenerateColumns = False
        Me.DGVAnnee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnnee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescriptionAnneeDataGridViewTextBoxColumn, Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn, Me.IdAnneeDataGridViewTextBoxColumn})
        Me.DGVAnnee.DataSource = Me.PSELECTANNEEBindingSource
        Me.DGVAnnee.Location = New System.Drawing.Point(6, 19)
        Me.DGVAnnee.MultiSelect = False
        Me.DGVAnnee.Name = "DGVAnnee"
        Me.DGVAnnee.ReadOnly = True
        Me.DGVAnnee.RowHeadersVisible = False
        Me.DGVAnnee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAnnee.Size = New System.Drawing.Size(264, 156)
        Me.DGVAnnee.TabIndex = 1
        '
        'DescriptionAnneeDataGridViewTextBoxColumn
        '
        Me.DescriptionAnneeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionAnneeDataGridViewTextBoxColumn.DataPropertyName = "descriptionAnnee"
        Me.DescriptionAnneeDataGridViewTextBoxColumn.HeaderText = "Année"
        Me.DescriptionAnneeDataGridViewTextBoxColumn.Name = "DescriptionAnneeDataGridViewTextBoxColumn"
        Me.DescriptionAnneeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaisiEnCoursAnneeDataGridViewCheckBoxColumn
        '
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn.DataPropertyName = "SaisiEnCoursAnnee"
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn.HeaderText = "Saisie en cours"
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn.Name = "SaisiEnCoursAnneeDataGridViewCheckBoxColumn"
        Me.SaisiEnCoursAnneeDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IdAnneeDataGridViewTextBoxColumn
        '
        Me.IdAnneeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdAnneeDataGridViewTextBoxColumn.DataPropertyName = "idAnnee"
        Me.IdAnneeDataGridViewTextBoxColumn.HeaderText = "idAnnee"
        Me.IdAnneeDataGridViewTextBoxColumn.Name = "IdAnneeDataGridViewTextBoxColumn"
        Me.IdAnneeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAnneeDataGridViewTextBoxColumn.Visible = False
        '
        'PSELECTANNEEBindingSource
        '
        Me.PSELECTANNEEBindingSource.DataMember = "P_SELECT_ANNEE"
        Me.PSELECTANNEEBindingSource.DataSource = Me.ALHDataSet4
        '
        'ALHDataSet4
        '
        Me.ALHDataSet4.DataSetName = "ALHDataSet"
        Me.ALHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxGestionParametres
        '
        Me.GroupBoxGestionParametres.Controls.Add(Me.TBMAXCote)
        Me.GroupBoxGestionParametres.Controls.Add(Me.TBMAXJoueur)
        Me.GroupBoxGestionParametres.Controls.Add(Me.Label13)
        Me.GroupBoxGestionParametres.Controls.Add(Me.Label12)
        Me.GroupBoxGestionParametres.Controls.Add(Me.SauvegarderParametre)
        Me.GroupBoxGestionParametres.Location = New System.Drawing.Point(12, 25)
        Me.GroupBoxGestionParametres.Name = "GroupBoxGestionParametres"
        Me.GroupBoxGestionParametres.Size = New System.Drawing.Size(717, 160)
        Me.GroupBoxGestionParametres.TabIndex = 0
        Me.GroupBoxGestionParametres.TabStop = False
        Me.GroupBoxGestionParametres.Text = "Paramètres utilisés pour valider les choix des parieurs"
        '
        'TBMAXCote
        '
        Me.TBMAXCote.Location = New System.Drawing.Point(206, 85)
        Me.TBMAXCote.MaxLength = 40
        Me.TBMAXCote.Name = "TBMAXCote"
        Me.TBMAXCote.Size = New System.Drawing.Size(100, 20)
        Me.TBMAXCote.TabIndex = 3
        '
        'TBMAXJoueur
        '
        Me.TBMAXJoueur.Location = New System.Drawing.Point(206, 47)
        Me.TBMAXJoueur.MaxLength = 40
        Me.TBMAXJoueur.Name = "TBMAXJoueur"
        Me.TBMAXJoueur.Size = New System.Drawing.Size(100, 20)
        Me.TBMAXJoueur.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cote totale à ne pas dépasser"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nombre maximun de joueurs"
        '
        'SauvegarderParametre
        '
        Me.SauvegarderParametre.Location = New System.Drawing.Point(432, 47)
        Me.SauvegarderParametre.Name = "SauvegarderParametre"
        Me.SauvegarderParametre.Size = New System.Drawing.Size(96, 23)
        Me.SauvegarderParametre.TabIndex = 2
        Me.SauvegarderParametre.Text = "Sauvegarder"
        Me.SauvegarderParametre.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.PictureBox2)
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(739, 586)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "A propos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PoolHockeyV1.My.Resources.Resources.lescegeps
        Me.PictureBox2.Location = New System.Drawing.Point(39, 290)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(581, 267)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PoolHockeyV1.My.Resources.Resources.totototoototot
        Me.PictureBox1.Location = New System.Drawing.Point(544, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 196)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(36, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(391, 91)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cette application incroyable à été réalisée par un Shaman nommé Laplace Jordan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cours 420-524-MT Bases de données client-serveur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cégep de Matane" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Automne " & _
    "2016" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ALHDataSetBindingSource1
        '
        Me.ALHDataSetBindingSource1.DataSource = Me.ALHDataSet
        Me.ALHDataSetBindingSource1.Position = 0
        '
        'PSELECTPARIEURDGVBindingSource
        '
        Me.PSELECTPARIEURDGVBindingSource.DataMember = "P_SELECT_PARIEUR_DGV"
        Me.PSELECTPARIEURDGVBindingSource.DataSource = Me.ALHDataSet
        '
        'PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1
        '
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1.DataMember = "P_SELECT_EQUIPE_MODIFICATION_JOUEUR"
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1.DataSource = Me.ALHDataSet
        '
        'PSELECTJOUEURDGVCHOIXBindingSource
        '
        Me.PSELECTJOUEURDGVCHOIXBindingSource.DataMember = "P_SELECT_JOUEUR_DGV_CHOIX"
        Me.PSELECTJOUEURDGVCHOIXBindingSource.DataSource = Me.ALHDataSet
        '
        'P_SELECT_JOUEUR_DGV_CHOIXTableAdapter
        '
        Me.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter
        '
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_PARIEUR_DGVTableAdapter
        '
        Me.P_SELECT_PARIEUR_DGVTableAdapter.ClearBeforeFill = True
        '
        'ALHDataSet1
        '
        Me.ALHDataSet1.DataSetName = "ALHDataSet"
        Me.ALHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALHDataSet1BindingSource
        '
        Me.ALHDataSet1BindingSource.DataSource = Me.ALHDataSet1
        Me.ALHDataSet1BindingSource.Position = 0
        '
        'PSELECTPARIEURDGVBindingSource1
        '
        Me.PSELECTPARIEURDGVBindingSource1.DataMember = "P_SELECT_PARIEUR_DGV"
        Me.PSELECTPARIEURDGVBindingSource1.DataSource = Me.ALHDataSet1
        '
        'ALHDataSet2
        '
        Me.ALHDataSet2.DataSetName = "ALHDataSet"
        Me.ALHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PSELECTEQUIPEMODIFICATIONJOUEURBindingSource
        '
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource.DataMember = "P_SELECT_EQUIPE_MODIFICATION_JOUEUR"
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource.DataSource = Me.ALHDataSet2
        '
        'P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter
        '
        Me.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter
        '
        Me.P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_REF_PARIEURTableAdapter
        '
        Me.P_SELECT_REF_PARIEURTableAdapter.ClearBeforeFill = True
        '
        'PSELECTJOUEURDGVCHOIXBindingSource2
        '
        Me.PSELECTJOUEURDGVCHOIXBindingSource2.DataMember = "P_SELECT_JOUEUR_DGV_CHOIX"
        Me.PSELECTJOUEURDGVCHOIXBindingSource2.DataSource = Me.ALHDataSet
        '
        'PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2
        '
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2.DataMember = "P_SELECT_EQUIPE_MODIFICATION_JOUEUR"
        Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2.DataSource = Me.ALHDataSet1BindingSource
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ModifierMotDePasseMenuStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 20)
        Me.ToolStripMenuItem1.Text = "Classement des parieurs"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 20)
        Me.ToolStripMenuItem2.Text = "Classement des parieurs (détaillé)"
        '
        'ModifierMotDePasseMenuStrip
        '
        Me.ModifierMotDePasseMenuStrip.Name = "ModifierMotDePasseMenuStrip"
        Me.ModifierMotDePasseMenuStrip.Size = New System.Drawing.Size(165, 20)
        Me.ModifierMotDePasseMenuStrip.Text = "Modifier mon mot de passe"
        '
        'ALHDataSetBindingSource
        '
        Me.ALHDataSetBindingSource.DataSource = Me.ALHDataSet
        Me.ALHDataSetBindingSource.Position = 0
        '
        'PSELECTJOUEURDGVCHOIXBindingSource3
        '
        Me.PSELECTJOUEURDGVCHOIXBindingSource3.DataMember = "P_SELECT_JOUEUR_DGV_CHOIX"
        Me.PSELECTJOUEURDGVCHOIXBindingSource3.DataSource = Me.ALHDataSet
        '
        'P_SELECT_ANNEETableAdapter
        '
        Me.P_SELECT_ANNEETableAdapter.ClearBeforeFill = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 653)
        Me.Controls.Add(Me.tableauControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Pool de Hockey"
        Me.tableauControl1.ResumeLayout(False)
        Me.TextASetMesChoix.ResumeLayout(False)
        Me.TextASetMesChoix.PerformLayout()
        CType(Me.DGVMesChoix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTANNEEFORDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVGestionJoueur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionJoueur.ResumeLayout(False)
        Me.GroupBoxGestionJoueur.PerformLayout()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTPOSITIONMODIFICATIONJOUEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PSELECTREFPARIEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewGestionParieurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTPARIEURDGVBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTANNEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionParametres.ResumeLayout(False)
        Me.GroupBoxGestionParametres.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTPARIEURDGVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTPARIEURDGVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALHDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ALHDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTJOUEURDGVCHOIXBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents tableauControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TextASetMesChoix As System.Windows.Forms.TabPage
    Friend WithEvents textP1Annee As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBoxMesChoix As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxMesChoixJoueurSeulement As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ALHDataSet As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTJOUEURDGVCHOIXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_JOUEUR_DGV_CHOIXTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter
    Friend WithEvents PSELECTJOUEURDGVCHOIXBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PSELECTANNEEFORDGVCHOIXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBCSeclectMesChoix As System.Windows.Forms.TextBox
    Friend WithEvents TBJSelectMesChoix As System.Windows.Forms.TextBox
    Friend WithEvents testASet As System.Windows.Forms.Label
    Friend WithEvents textAnnee As System.Windows.Forms.Label
    Friend WithEvents GroupBoxGestionJoueur As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxGestionJoueurPosition As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxGestionJoueurPasses As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGestionJoueurButs As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGestionJoueurCote As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGestionJoueurPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGestionJoueurNom As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGestionJoueur As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxGestionParametres As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBMAXCote As System.Windows.Forms.TextBox
    Friend WithEvents TBMAXJoueur As System.Windows.Forms.TextBox
    Friend WithEvents PSELECTPARIEURDGVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_PARIEUR_DGVTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_PARIEUR_DGVTableAdapter
    Friend WithEvents ALHDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALHDataSet1 As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTPARIEURDGVBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewGestionParieurs As System.Windows.Forms.DataGridView
    Friend WithEvents ALHDataSet2 As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTEQUIPEMODIFICATIONJOUEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter
    Friend WithEvents PSELECTEQUIPEMODIFICATIONJOUEURBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PSELECTPOSITIONMODIFICATIONJOUEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNomGestionParieur As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTypesGestionParieurs As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxCourielleGestionParieurs As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrenomGestionParieurs As System.Windows.Forms.TextBox
    Friend WithEvents PSELECTREFPARIEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_REF_PARIEURTableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_REF_PARIEURTableAdapter
    Friend WithEvents DGVMesChoix As System.Windows.Forms.DataGridView
    Friend WithEvents JoueurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PtsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVGestionJoueur As System.Windows.Forms.DataGridView
    Friend WithEvents PSELECTJOUEURDGVCHOIXBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents idJoueur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PSELECTEQUIPEMODIFICATIONJOUEURBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBoxGestionJoueurEquipe As System.Windows.Forms.ComboBox
    Friend WithEvents ALHDataSet3 As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTEQUIPEMODIFICATIONJOUEURBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SauvegarderLesModifications As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierMotDePasseMenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents boutonModifierDGVJoueur As System.Windows.Forms.Button
    Friend WithEvents boutonSupprimerDGVJoueur As System.Windows.Forms.Button
    Friend WithEvents BouttonAjouterDGVJoueur As System.Windows.Forms.Button
    Friend WithEvents boutonAnnulerDGVJoueur As System.Windows.Forms.Button
    Friend WithEvents boutonSauvegarderDGVJoueur As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALHDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ALHDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents boutonModifierDGVParieur As System.Windows.Forms.Button
    Friend WithEvents boutonSupprimerDGVParieur As System.Windows.Forms.Button
    Friend WithEvents boutonAjouterDGVParieur As System.Windows.Forms.Button
    Friend WithEvents boutonAnnulerDGVParieur As System.Windows.Forms.Button
    Friend WithEvents boutonSauvegarderDGVParieur As System.Windows.Forms.Button
    Friend WithEvents ParieurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourrielDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdParDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTPARIEURDGVBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PSELECTJOUEURDGVCHOIXBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVAnnee As System.Windows.Forms.DataGridView
    Friend WithEvents ALHDataSet4 As PoolHockeyV1.ALHDataSet
    Friend WithEvents PSELECTANNEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ANNEETableAdapter As PoolHockeyV1.ALHDataSetTableAdapters.P_SELECT_ANNEETableAdapter
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents boutonAjouterAnnee As System.Windows.Forms.Button
    Friend WithEvents boutonModifierAnnee As System.Windows.Forms.Button
    Friend WithEvents boutonSupprimerAnnee As System.Windows.Forms.Button
    Friend WithEvents boutonAnnulerAnnee As System.Windows.Forms.Button
    Friend WithEvents boutonSauvegarderAnnee As System.Windows.Forms.Button
    Friend WithEvents DescriptionAnneeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaisiEnCoursAnneeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdAnneeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SauvegarderParametre As System.Windows.Forms.Button
    Friend WithEvents TBAnnee As System.Windows.Forms.TextBox
    Friend WithEvents CBSaisieEnCours As System.Windows.Forms.CheckBox
    Friend WithEvents CBImportJoueur As System.Windows.Forms.CheckBox

End Class
