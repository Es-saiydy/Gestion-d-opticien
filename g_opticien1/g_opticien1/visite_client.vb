Imports MySql.Data.MySqlClient

Public Class visite_client
    Public connectionString As String = "server=localhost;user id=root;password=root;database=optique1"
    Public cn As New MySqlConnection(connectionString) ' Correction: Ajout de la connexion MySQL
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand

    Private Sub afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM visite"
        cmd = New MySqlCommand(str, cn)
        dr = cmd.ExecuteReader
        combo.Items.Clear()
        While (dr.Read)
            listems = Me.combo.Items.Add(dr("id_visite"))
            listems.SubItems.Add(dr("nom_client")) ' Ajout du nom_client après id_visite
            listems.SubItems.Add(dr("vision_loin_gauche"))
            listems.SubItems.Add(dr("vision_loin_droite"))
            listems.SubItems.Add(dr("vision_pres_gauche"))
            listems.SubItems.Add(dr("vision_pres_droite"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub visite_client_Load(sender As Object, e As EventArgs)
        ' Code de chargement initial ici
        afficher()
        combo.Visible = False
        Button4.Visible = False
        Button3.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox12_KeyUp(sender As Object, e As KeyEventArgs)
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM visite WHERE " & ComboBox1.Text & " LIKE '%' + @1 + '%' "
        cmd = New MySqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", TextBox1.Text)
        dr = cmd.ExecuteReader
        combo.Items.Clear()
        While (dr.Read)
            listems = Me.combo.Items.Add(dr("id_visite"))
            listems.SubItems.Add(dr("vision_loin_gauche"))
            listems.SubItems.Add(dr("vision_loin_droite"))
            listems.SubItems.Add(dr("vision_pres_gauche"))
            listems.SubItems.Add(dr("vision_pres_droite"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            If id.Text = Nothing OrElse loin_gauche.Text = Nothing OrElse pres_gauche.Text = Nothing OrElse loin_droite.Text = Nothing OrElse pres_droite.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour modifier !")
            Else
                If MsgBox("Voulez-vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "UPDATE visite SET vision_loin_gauche='" & loin_gauche.Text & "',vision_pres_gauche='" & pres_gauche.Text & "',vision_loin_droite='" & loin_droite.Text & "',vision_pres_droite='" & pres_droite.Text & "' WHERE id_visite ='" & id.Text & "'"
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifié avec succès :)")
                    cn.Close()
                    afficher()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            If id.Text = Nothing OrElse loin_gauche.Text = Nothing OrElse pres_gauche.Text = Nothing OrElse loin_droite.Text = Nothing OrElse pres_droite.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour ajouter !")
            Else
                If MsgBox("Voulez-vous vraiment ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "INSERT INTO visite (id_visite, nom_client, vision_loin_gauche, vision_pres_gauche, vision_loin_droite, vision_pres_droite) VALUES ('" & id.Text & "','" & nom_client.Text & "','" & loin_gauche.Text & "','" & pres_gauche.Text & "','" & loin_droite.Text & "','" & pres_droite.Text & "')"
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    MsgBox("Ajouté avec succès :)")
                    cn.Close()
                    afficher()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub combo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            If id.Text = Nothing Then
                MsgBox("Sélectionnez un produit à supprimer !")
            Else
                If MsgBox("Voulez-vous vraiment supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "DELETE FROM visite WHERE id_visite = '" & id.Text & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("Suppression avec succès :)")
                    cn.Close()
                    afficher()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub visite_client_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
