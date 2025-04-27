Imports MySql.Data.MySqlClient

Public Class Fournisseur

    Public connectionString As String = "server=localhost;user id=root;password=root;database=optique1"
    Public cn As New MySqlConnection(connectionString) ' Correction: Ajout de la connexion MySQL
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand

    Private Sub Afficher(cn As MySqlConnection)
        cn.Open()

        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM Admin"

        cmd = New MySqlCommand(str, cn)
        dr = cmd.ExecuteReader()

        combo.Items.Clear()

        While (dr.Read())
            listems = New ListViewItem()
            listems.Text = dr("id_admin").ToString()
            listems.SubItems.Add(dr("nom").ToString())
            listems.SubItems.Add(dr("prenom").ToString())
            listems.SubItems.Add(dr("email").ToString())

            combo.Items.Add(listems)
        End While

        dr.Close()
        cn.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher(cn)
        Panel1.Visible = False
    End Sub

    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo.SelectedIndexChanged
        Try
            cn.Close()
            If combo.SelectedItems.Count = 0 Then
                MsgBox("Sélectionnez un produit!")
            Else
                cn.Open()
                cmd.CommandText = "SELECT * FROM client WHERE id_admin= '" & combo.SelectedItems(0).Text.ToString & "'"
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    Me.id.Text = dr.Item(0).ToString
                    Me.nom_c.Text = dr.Item(1).ToString
                    Me.prenom_c.Text = dr.Item(2).ToString
                    Me.adresse_c.Text = dr.Item(3).ToString

                Else
                    MsgBox("Aucun enregistrement trouvé avec cet ID.")
                End If
                dr.Close()
                cn.Close()
            End If
            cn.Close()
            Panel1.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = Not Panel1.Visible
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If id.Text = Nothing Or nom_c.Text = Nothing Or prenom_c.Text = Nothing Or adresse_c.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour ajouter !")
            Else
                If MsgBox("Voulez-vous vraiment ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "INSERT INTO admin VALUES('" & id.Text & "','" & nom_c.Text & "','" & prenom_c.Text & "','" & adresse_c.Text & "')"
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    MsgBox("Ajouté avec succès :)")
                    cn.Close()
                    Afficher(cn)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If id.Text = Nothing Or nom_c.Text = Nothing Or prenom_c.Text = Nothing Or adresse_c.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour modifier !")
            Else
                If MsgBox("Voulez-vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "UPDATE Admin SET nom='" & nom_c.Text & "', prenom='" & prenom_c.Text & "', email='" & adresse_c.Text & "'WHERE id_Admin='" & id.Text & "'"
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifié avec succès :)")
                    cn.Close()
                    Afficher(cn)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If id.Text = Nothing Then
                MsgBox("Sélectionnez un Adminà supprimer !")
            Else
                If MsgBox("Voulez-vous vraiment supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "DELETE FROM adminWHERE id_Admin = '" & id.Text & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("Suppression avec succès :)")
                    cn.Close()
                    Afficher(cn)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM Admin WHERE " & ComboBox1.Text & " LIKE '%' + @1 + '%' "
        cmd = New MySqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", TextBox1.Text)
        dr = cmd.ExecuteReader()
        ComboBox1.Items.Clear()
        While (dr.Read())
            listems = Me.combo.Items.Add(dr("id_Admin"))
            listems.SubItems.Add(dr("nom"))
            listems.SubItems.Add(dr("prenom"))
            listems.SubItems.Add(dr("email"))
        End While
        dr.Close()
        cn.Close()
    End Sub

End Class

