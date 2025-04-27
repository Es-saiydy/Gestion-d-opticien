<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class monture
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.combo = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prix = New System.Windows.Forms.TextBox()
        Me.quantite = New System.Windows.Forms.TextBox()
        Me.num_serie = New System.Windows.Forms.TextBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.id_produit = New System.Windows.Forms.TextBox()
        Me.Admin = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Brown
        Me.Button5.Location = New System.Drawing.Point(98, 2)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(265, 95)
        Me.Button5.TabIndex = 591
        Me.Button5.Text = "          Monture"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'combo
        '
        Me.combo.BackColor = System.Drawing.Color.White
        Me.combo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.combo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.combo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FullRowSelect = True
        Me.combo.GridLines = True
        Me.combo.HideSelection = False
        Me.combo.Location = New System.Drawing.Point(13, 424)
        Me.combo.Margin = New System.Windows.Forms.Padding(4)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(967, 259)
        Me.combo.TabIndex = 593
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
        Me.ColumnHeader7.Text = "description"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 114
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "num_serie"
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
        Me.ColumnHeader1.Text = "quantite"
        Me.ColumnHeader1.Width = 101
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
        Me.Button3.Location = New System.Drawing.Point(305, 301)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 58)
        Me.Button3.TabIndex = 596
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
        Me.Button1.Location = New System.Drawing.Point(485, 301)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 60)
        Me.Button1.TabIndex = 595
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
        Me.Button4.Location = New System.Drawing.Point(665, 303)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 58)
        Me.Button4.TabIndex = 594
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"id_produit", "type", "description", "num_serie", "prix", ""})
        Me.ComboBox1.Location = New System.Drawing.Point(175, 379)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 24)
        Me.ComboBox1.TabIndex = 600
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lavender
        Me.Label13.Location = New System.Drawing.Point(8, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 25)
        Me.Label13.TabIndex = 598
        Me.Label13.Text = "Rechercher par :"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.ForeColor = System.Drawing.Color.Blue
        Me.TextBox12.Location = New System.Drawing.Point(369, 377)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(222, 28)
        Me.TextBox12.TabIndex = 612
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 25)
        Me.Label6.TabIndex = 656
        Me.Label6.Text = "description" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 655
        Me.Label5.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 654
        Me.Label4.Text = "id_produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 25)
        Me.Label3.TabIndex = 653
        Me.Label3.Text = "Prix"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(405, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 652
        Me.Label2.Text = "quantite"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 651
        Me.Label1.Text = "num_serie"
        '
        'prix
        '
        Me.prix.BackColor = System.Drawing.Color.White
        Me.prix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prix.ForeColor = System.Drawing.Color.Blue
        Me.prix.Location = New System.Drawing.Point(615, 224)
        Me.prix.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.prix.Multiline = True
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(199, 28)
        Me.prix.TabIndex = 650
        '
        'quantite
        '
        Me.quantite.BackColor = System.Drawing.Color.White
        Me.quantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quantite.ForeColor = System.Drawing.Color.Blue
        Me.quantite.Location = New System.Drawing.Point(615, 183)
        Me.quantite.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.quantite.Multiline = True
        Me.quantite.Name = "quantite"
        Me.quantite.Size = New System.Drawing.Size(199, 28)
        Me.quantite.TabIndex = 649
        '
        'num_serie
        '
        Me.num_serie.BackColor = System.Drawing.Color.White
        Me.num_serie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_serie.ForeColor = System.Drawing.Color.Blue
        Me.num_serie.Location = New System.Drawing.Point(615, 145)
        Me.num_serie.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.num_serie.Multiline = True
        Me.num_serie.Name = "num_serie"
        Me.num_serie.Size = New System.Drawing.Size(199, 28)
        Me.num_serie.TabIndex = 648
        '
        'description
        '
        Me.description.BackColor = System.Drawing.Color.White
        Me.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.description.ForeColor = System.Drawing.Color.Blue
        Me.description.Location = New System.Drawing.Point(150, 221)
        Me.description.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(199, 28)
        Me.description.TabIndex = 647
        '
        'id_produit
        '
        Me.id_produit.BackColor = System.Drawing.Color.White
        Me.id_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_produit.ForeColor = System.Drawing.Color.Blue
        Me.id_produit.Location = New System.Drawing.Point(150, 145)
        Me.id_produit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.id_produit.Multiline = True
        Me.id_produit.Name = "id_produit"
        Me.id_produit.Size = New System.Drawing.Size(199, 28)
        Me.id_produit.TabIndex = 645
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
        Me.Admin.Location = New System.Drawing.Point(845, 303)
        Me.Admin.Margin = New System.Windows.Forms.Padding(4)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(162, 58)
        Me.Admin.TabIndex = 657
        Me.Admin.Text = "Stock"
        Me.Admin.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"verre ", "monture", "lentille", "accessoire"})
        Me.ComboBox2.Location = New System.Drawing.Point(150, 186)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(188, 24)
        Me.ComboBox2.TabIndex = 658
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "prix"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.g_opticien1.My.Resources.Resources.retirer
        Me.PictureBox1.Location = New System.Drawing.Point(924, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 613
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = Global.g_opticien1.My.Resources.Resources.ajouter
        Me.PictureBox2.Location = New System.Drawing.Point(600, 370)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 599
        Me.PictureBox2.TabStop = False
        '
        'Button9
        '
        Me.Button9.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.g_opticien1.My.Resources.Resources.lunettes__3_
        Me.Button9.Location = New System.Drawing.Point(0, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 93)
        Me.Button9.TabIndex = 592
        Me.Button9.UseVisualStyleBackColor = False
        '
        'monture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1013, 705)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prix)
        Me.Controls.Add(Me.quantite)
        Me.Controls.Add(Me.num_serie)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.id_produit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "monture"
        Me.Text = "Monture"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents combo As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents prix As TextBox
    Friend WithEvents quantite As TextBox
    Friend WithEvents num_serie As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents id_produit As TextBox
    Friend WithEvents Admin As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
