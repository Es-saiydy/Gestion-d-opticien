Imports MySql.Data.MySqlClient

Public Class accessoire

    Public connectionString As String = "server=localhost;user id=root;password=root;database=g_opticien"
    Public cn As New MySqlConnection(connectionString) ' Correction: Ajout de la connexion MySQL
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand

    Private Sub Afficher(cn As MySqlConnection)
        cn.Open()

        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM produit"

        cmd = New MySqlCommand(str, cn)
        dr = cmd.ExecuteReader()

        combo.Items.Clear()

        While (dr.Read())
            listems = New ListViewItem()
            listems.Text = dr("id_produit").ToString()
            listems.SubItems.Add(dr("type").ToString())
            listems.SubItems.Add(dr("quantite").ToString())
            listems.SubItems.Add(dr("designation").ToString())
            listems.SubItems.Add(dr("couleur").ToString())
            listems.SubItems.Add(dr("prix_unitaire").ToString())

            combo.Items.Add(listems)
        End While

        dr.Close()
        cn.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher(cn)
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If id_produit.Text = Nothing Or type.Text = Nothing Or quantite.Text = Nothing Or designation.Text = Nothing Or couleur.Text = Nothing Or prix_unitaire.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour ajouter !")
            Else
                If MsgBox("Voulez-vous vraiment ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "INSERT INTO produit VALUES('" & id_produit.Text & "','" & type.Text & "','" & quantite.Text & "','" & designation.Text & "','" & couleur.Text & "','" & prix_unitaire.Text & "')"
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
            If id_produit.Text = Nothing Or type.Text = Nothing Or quantite.Text = Nothing Or designation.Text = Nothing Or couleur.Text = Nothing Or prix_unitaire.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour modifier !")
            Else
                If MsgBox("Voulez-vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "UPDATE produit SET type='" & type.Text & "', quantite='" & quantite.Text & "', designation='" & designation.Text & "', couleur='" & couleur.Text & "', prix_unitaire='" & prix_unitaire.Text & "' WHERE id_produit='" & id_produit.Text & "'"
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
            If id_produit.Text = Nothing Then
                MsgBox("Sélectionnez un produit à supprimer !")
            Else
                If MsgBox("Voulez-vous vraiment supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "DELETE FROM produit WHERE id_produit = '" & id_produit.Text & "'"
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

    Private Sub combo_Click(sender As Object, e As EventArgs) Handles combo.Click
        Try
            cn.Close()
            If combo.SelectedItems.Count = 0 Then
                MsgBox("Sélectionnez un produit!")
            Else
                cn.Open()
                cmd.CommandText = "SELECT * FROM produit WHERE id_produit= '" & combo.SelectedItems(0).Text.ToString & "'"
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    Me.id_produit.Text = dr.Item(0).ToString
                    Me.type.Text = dr.Item(1).ToString
                    Me.quantite.Text = dr.Item(2).ToString
                    Me.designation.Text = dr.Item(3).ToString
                    Me.couleur.Text = dr.Item(4).ToString
                    Me.prix_unitaire.Text = dr.Item(5).ToString
                Else
                    MsgBox("Aucun enregistrement trouvé avec cet ID.")
                End If
                dr.Close()
                cn.Close()
            End If
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox12_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM produit WHERE " & ComboBox1.Text & " LIKE '%' + @1 + '%' "
        cmd = New MySqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", type.Text)
        dr = cmd.ExecuteReader()
        ComboBox1.Items.Clear()
        While (dr.Read())
            listems = Me.combo.Items.Add(dr("id_produit"))
            listems.SubItems.Add(dr("type"))
            listems.SubItems.Add(dr("quantite"))
            listems.SubItems.Add(dr("designation"))
            listems.SubItems.Add(dr("couleur"))
            listems.SubItems.Add(dr("prix_unitaire"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo.SelectedIndexChanged

    End Sub

    Private Sub combo_KeyUp(sender As Object, e As KeyEventArgs) Handles combo.KeyUp

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
