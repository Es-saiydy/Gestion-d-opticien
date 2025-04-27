<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accessoire
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
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.prix_unitaire = New System.Windows.Forms.TextBox()
        Me.couleur = New System.Windows.Forms.TextBox()
        Me.designation = New System.Windows.Forms.TextBox()
        Me.quantite = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.id_produit = New System.Windows.Forms.TextBox()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.Color.Blue
        Me.TextBox12.Location = New System.Drawing.Point(365, 387)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(222, 28)
        Me.TextBox12.TabIndex = 635
        '
        'prix_unitaire
        '
        Me.prix_unitaire.BackColor = System.Drawing.Color.White
        Me.prix_unitaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prix_unitaire.ForeColor = System.Drawing.Color.Blue
        Me.prix_unitaire.Location = New System.Drawing.Point(611, 223)
        Me.prix_unitaire.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.prix_unitaire.Multiline = True
        Me.prix_unitaire.Name = "prix_unitaire"
        Me.prix_unitaire.Size = New System.Drawing.Size(199, 28)
        Me.prix_unitaire.TabIndex = 634
        '
        'couleur
        '
        Me.couleur.BackColor = System.Drawing.Color.White
        Me.couleur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.couleur.ForeColor = System.Drawing.Color.Blue
        Me.couleur.Location = New System.Drawing.Point(611, 182)
        Me.couleur.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.couleur.Multiline = True
        Me.couleur.Name = "couleur"
        Me.couleur.Size = New System.Drawing.Size(199, 28)
        Me.couleur.TabIndex = 633
        '
        'designation
        '
        Me.designation.BackColor = System.Drawing.Color.White
        Me.designation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.designation.ForeColor = System.Drawing.Color.Blue
        Me.designation.Location = New System.Drawing.Point(611, 144)
        Me.designation.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.designation.Multiline = True
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(199, 28)
        Me.designation.TabIndex = 632
        '
        'quantite
        '
        Me.quantite.BackColor = System.Drawing.Color.White
        Me.quantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quantite.ForeColor = System.Drawing.Color.Blue
        Me.quantite.Location = New System.Drawing.Point(146, 220)
        Me.quantite.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.quantite.Multiline = True
        Me.quantite.Name = "quantite"
        Me.quantite.Size = New System.Drawing.Size(199, 28)
        Me.quantite.TabIndex = 625
        '
        'type
        '
        Me.type.BackColor = System.Drawing.Color.White
        Me.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.type.ForeColor = System.Drawing.Color.Blue
        Me.type.Location = New System.Drawing.Point(146, 182)
        Me.type.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.type.Multiline = True
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(199, 28)
        Me.type.TabIndex = 624
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"id_produit", "type", "quantite", "designation", "couleur", "prix_unitaire"})
        Me.ComboBox1.Location = New System.Drawing.Point(171, 387)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 24)
        Me.ComboBox1.TabIndex = 623
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lavender
        Me.Label13.Location = New System.Drawing.Point(4, 386)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 25)
        Me.Label13.TabIndex = 621
        Me.Label13.Text = "Rechercher par :"
        '
        'id_produit
        '
        Me.id_produit.BackColor = System.Drawing.Color.White
        Me.id_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_produit.ForeColor = System.Drawing.Color.Blue
        Me.id_produit.Location = New System.Drawing.Point(146, 144)
        Me.id_produit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.id_produit.Multiline = True
        Me.id_produit.Name = "id_produit"
        Me.id_produit.Size = New System.Drawing.Size(199, 28)
        Me.id_produit.TabIndex = 620
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(235, 299)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 58)
        Me.Button3.TabIndex = 619
        Me.Button3.Text = "supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(415, 299)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 60)
        Me.Button1.TabIndex = 618
        Me.Button1.Text = "enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(595, 301)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 58)
        Me.Button4.TabIndex = 617
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'combo
        '
        Me.combo.BackColor = System.Drawing.Color.White
        Me.combo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.combo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader1})
        Me.combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FullRowSelect = True
        Me.combo.GridLines = True
        Me.combo.HideSelection = False
        Me.combo.Location = New System.Drawing.Point(9, 422)
        Me.combo.Margin = New System.Windows.Forms.Padding(4)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(967, 259)
        Me.combo.TabIndex = 616
        Me.combo.UseCompatibleStateImageBehavior = False
        Me.combo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "id_produit"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "type"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 109
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "quantite"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 114
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "designation"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 198
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "couleur"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 209
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "prix_unitaire"
        Me.ColumnHeader1.Width = 101
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.g_opticien1.My.Resources.Resources.retirer
        Me.PictureBox1.Location = New System.Drawing.Point(862, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 636
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = Global.g_opticien1.My.Resources.Resources.ajouter
        Me.PictureBox2.Location = New System.Drawing.Point(596, 380)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 622
        Me.PictureBox2.TabStop = False
        '
        'Button7
        '
        Me.Button7.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.g_opticien1.My.Resources.Resources.accessoire
        Me.Button7.Location = New System.Drawing.Point(12, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(71, 95)
        Me.Button7.TabIndex = 638
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Brown
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.Location = New System.Drawing.Point(9, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 95)
        Me.Button2.TabIndex = 637
        Me.Button2.Text = "         Accessoire"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 639
        Me.Label1.Text = "Designation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 640
        Me.Label2.Text = "Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 641
        Me.Label3.Text = "Prix_unitaire"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 642
        Me.Label4.Text = "id_produit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 643
        Me.Label5.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 644
        Me.Label6.Text = "Quantite"
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.DarkGray
        Me.Admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Admin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Admin.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.ForeColor = System.Drawing.Color.Black
        Me.Admin.Location = New System.Drawing.Point(789, 301)
        Me.Admin.Margin = New System.Windows.Forms.Padding(4)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(162, 58)
        Me.Admin.TabIndex = 658
        Me.Admin.Text = "Stock"
        Me.Admin.UseVisualStyleBackColor = False
        '
        'accessoire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(993, 690)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.prix_unitaire)
        Me.Controls.Add(Me.couleur)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.quantite)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.id_produit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.combo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "accessoire"
        Me.Text = "accessoire"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents prix_unitaire As TextBox
    Friend WithEvents couleur As TextBox
    Friend WithEvents designation As TextBox
    Friend WithEvents quantite As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents id_produit As TextBox
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
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Admin As Button
End Class
