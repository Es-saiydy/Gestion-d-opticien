<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commande
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nom_client = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_commande = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mantant_totale = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Avance = New System.Windows.Forms.TextBox()
        Me.man_Totale = New System.Windows.Forms.TextBox()
        Me.id_comande = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Remise = New System.Windows.Forms.TextBox()
        Me.nom_cl = New System.Windows.Forms.TextBox()
        Me.date_commande = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Totale_A_payer = New System.Windows.Forms.TextBox()
        Me.Article = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.combo = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Admin = New System.Windows.Forms.Button()
        Me.Date_command = New System.Windows.Forms.DateTimePicker()
        Me.description = New System.Windows.Forms.Label()
        Me.descrip = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.g_opticien1.My.Resources.Resources.retirer
        Me.PictureBox1.Location = New System.Drawing.Point(961, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 636
        Me.PictureBox1.TabStop = False
        '
        'nom_client
        '
        Me.nom_client.AutoSize = True
        Me.nom_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_client.Location = New System.Drawing.Point(27, 151)
        Me.nom_client.Name = "nom_client"
        Me.nom_client.Size = New System.Drawing.Size(116, 25)
        Me.nom_client.TabIndex = 656
        Me.nom_client.Text = "nom_client"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 655
        '
        'id_commande
        '
        Me.id_commande.AutoSize = True
        Me.id_commande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_commande.Location = New System.Drawing.Point(26, 107)
        Me.id_commande.Name = "id_commande"
        Me.id_commande.Size = New System.Drawing.Size(146, 25)
        Me.id_commande.TabIndex = 654
        Me.id_commande.Text = "id_commande"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 653
        Me.Label3.Text = "Remise"
        '
        'mantant_totale
        '
        Me.mantant_totale.AutoSize = True
        Me.mantant_totale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mantant_totale.Location = New System.Drawing.Point(440, 99)
        Me.mantant_totale.Name = "mantant_totale"
        Me.mantant_totale.Size = New System.Drawing.Size(154, 25)
        Me.mantant_totale.TabIndex = 652
        Me.mantant_totale.Text = "mantant_totale"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 651
        '
        'Avance
        '
        Me.Avance.BackColor = System.Drawing.Color.White
        Me.Avance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Avance.ForeColor = System.Drawing.Color.Blue
        Me.Avance.Location = New System.Drawing.Point(650, 166)
        Me.Avance.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Avance.Multiline = True
        Me.Avance.Name = "Avance"
        Me.Avance.Size = New System.Drawing.Size(199, 28)
        Me.Avance.TabIndex = 650
        '
        'man_Totale
        '
        Me.man_Totale.BackColor = System.Drawing.Color.White
        Me.man_Totale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.man_Totale.ForeColor = System.Drawing.Color.Blue
        Me.man_Totale.Location = New System.Drawing.Point(650, 104)
        Me.man_Totale.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.man_Totale.Multiline = True
        Me.man_Totale.Name = "man_Totale"
        Me.man_Totale.Size = New System.Drawing.Size(199, 28)
        Me.man_Totale.TabIndex = 649
        '
        'id_comande
        '
        Me.id_comande.BackColor = System.Drawing.Color.White
        Me.id_comande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_comande.Enabled = False
        Me.id_comande.ForeColor = System.Drawing.Color.Blue
        Me.id_comande.Location = New System.Drawing.Point(176, 107)
        Me.id_comande.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.id_comande.Multiline = True
        Me.id_comande.Name = "id_comande"
        Me.id_comande.Size = New System.Drawing.Size(199, 28)
        Me.id_comande.TabIndex = 645
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 660
        Me.Label7.Text = "Avance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 25)
        Me.Label8.TabIndex = 659
        Me.Label8.Text = "Totale A payer"
        '
        'Remise
        '
        Me.Remise.BackColor = System.Drawing.Color.White
        Me.Remise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Remise.ForeColor = System.Drawing.Color.Blue
        Me.Remise.Location = New System.Drawing.Point(650, 216)
        Me.Remise.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Remise.Multiline = True
        Me.Remise.Name = "Remise"
        Me.Remise.Size = New System.Drawing.Size(199, 28)
        Me.Remise.TabIndex = 658
        '
        'nom_cl
        '
        Me.nom_cl.BackColor = System.Drawing.Color.White
        Me.nom_cl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nom_cl.ForeColor = System.Drawing.Color.Blue
        Me.nom_cl.Location = New System.Drawing.Point(176, 148)
        Me.nom_cl.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.nom_cl.Multiline = True
        Me.nom_cl.Name = "nom_cl"
        Me.nom_cl.Size = New System.Drawing.Size(199, 28)
        Me.nom_cl.TabIndex = 657
        '
        'date_commande
        '
        Me.date_commande.AutoSize = True
        Me.date_commande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_commande.Location = New System.Drawing.Point(26, 213)
        Me.date_commande.Name = "date_commande"
        Me.date_commande.Size = New System.Drawing.Size(171, 25)
        Me.date_commande.TabIndex = 664
        Me.date_commande.Text = "date_commande"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 25)
        Me.Label10.TabIndex = 663
        Me.Label10.Text = "Article"
        '
        'Totale_A_payer
        '
        Me.Totale_A_payer.BackColor = System.Drawing.Color.White
        Me.Totale_A_payer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Totale_A_payer.ForeColor = System.Drawing.Color.Blue
        Me.Totale_A_payer.Location = New System.Drawing.Point(650, 278)
        Me.Totale_A_payer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Totale_A_payer.Multiline = True
        Me.Totale_A_payer.Name = "Totale_A_payer"
        Me.Totale_A_payer.Size = New System.Drawing.Size(199, 28)
        Me.Totale_A_payer.TabIndex = 662
        '
        'Article
        '
        Me.Article.BackColor = System.Drawing.Color.White
        Me.Article.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Article.ForeColor = System.Drawing.Color.Blue
        Me.Article.Location = New System.Drawing.Point(165, 274)
        Me.Article.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Article.Multiline = True
        Me.Article.Name = "Article"
        Me.Article.Size = New System.Drawing.Size(199, 28)
        Me.Article.TabIndex = 661
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.Control
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(353, 0)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(363, 69)
        Me.Button13.TabIndex = 665
        Me.Button13.Text = "    Commande"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Image = Global.g_opticien1.My.Resources.Resources.verifier
        Me.Button15.Location = New System.Drawing.Point(353, 2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(77, 67)
        Me.Button15.TabIndex = 666
        Me.Button15.UseVisualStyleBackColor = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.Color.Blue
        Me.TextBox12.Location = New System.Drawing.Point(372, 392)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(222, 28)
        Me.TextBox12.TabIndex = 670
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = Global.g_opticien1.My.Resources.Resources.ajouter
        Me.PictureBox2.Location = New System.Drawing.Point(603, 385)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 668
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"id_produit", "type", "quantite", "designation", "couleur", "prix_unitaire"})
        Me.ComboBox1.Location = New System.Drawing.Point(178, 392)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 24)
        Me.ComboBox1.TabIndex = 669
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lavender
        Me.Label13.Location = New System.Drawing.Point(11, 391)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 25)
        Me.Label13.TabIndex = 667
        Me.Label13.Text = "Rechercher par :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(924, 512)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 58)
        Me.Button3.TabIndex = 673
        Me.Button3.Text = "supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(924, 447)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 60)
        Me.Button1.TabIndex = 672
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(924, 387)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 58)
        Me.Button4.TabIndex = 671
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'combo
        '
        Me.combo.BackColor = System.Drawing.Color.White
        Me.combo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.combo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FullRowSelect = True
        Me.combo.GridLines = True
        Me.combo.HideSelection = False
        Me.combo.Location = New System.Drawing.Point(13, 425)
        Me.combo.Margin = New System.Windows.Forms.Padding(4)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(885, 259)
        Me.combo.TabIndex = 674
        Me.combo.UseCompatibleStateImageBehavior = False
        Me.combo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "id_commande"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "nom_client"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 109
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date_commande"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 114
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "article"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "mantant_totale"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 126
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Avance"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Remise"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Totale A payer"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "description"
        Me.ColumnHeader5.Width = 85
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.Silver
        Me.Admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Admin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Admin.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.ForeColor = System.Drawing.Color.Black
        Me.Admin.Location = New System.Drawing.Point(924, 592)
        Me.Admin.Margin = New System.Windows.Forms.Padding(4)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(172, 58)
        Me.Admin.TabIndex = 675
        Me.Admin.Text = "Admin"
        Me.Admin.UseVisualStyleBackColor = False
        '
        'Date_command
        '
        Me.Date_command.Location = New System.Drawing.Point(203, 216)
        Me.Date_command.Name = "Date_command"
        Me.Date_command.Size = New System.Drawing.Size(200, 22)
        Me.Date_command.TabIndex = 676
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.Location = New System.Drawing.Point(452, 329)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(117, 25)
        Me.description.TabIndex = 677
        Me.description.Text = "description"
        '
        'descrip
        '
        Me.descrip.BackColor = System.Drawing.Color.White
        Me.descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descrip.ForeColor = System.Drawing.Color.Blue
        Me.descrip.Location = New System.Drawing.Point(650, 334)
        Me.descrip.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.descrip.Multiline = True
        Me.descrip.Name = "descrip"
        Me.descrip.Size = New System.Drawing.Size(199, 28)
        Me.descrip.TabIndex = 678
        '
        'Commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 690)
        Me.Controls.Add(Me.descrip)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.Date_command)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.date_commande)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Totale_A_payer)
        Me.Controls.Add(Me.Article)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Remise)
        Me.Controls.Add(Me.nom_cl)
        Me.Controls.Add(Me.nom_client)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id_commande)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mantant_totale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Avance)
        Me.Controls.Add(Me.man_Totale)
        Me.Controls.Add(Me.id_comande)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Commande"
        Me.Text = "Commande"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nom_client As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents id_commande As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mantant_totale As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Avance As TextBox
    Friend WithEvents man_Totale As TextBox
    Friend WithEvents id_comande As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Remise As TextBox
    Friend WithEvents nom_cl As TextBox
    Friend WithEvents date_commande As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Totale_A_payer As TextBox
    Friend WithEvents Article As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents combo As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Admin As Button
    Friend WithEvents Date_command As DateTimePicker
    Friend WithEvents description As Label
    Friend WithEvents descrip As TextBox
End Class
