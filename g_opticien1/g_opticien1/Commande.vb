Imports MySql.Data.MySqlClient

Public Class Commande

    ' Déclaration de la chaîne de connexion et des objets nécessaires
    Public connectionString As String = "server=localhost;user id=root;password=root;database=optique"
    Public cn As New MySqlConnection(connectionString)
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand

    ' Méthode pour afficher les commandes dans la liste
    Private Sub Afficher(cn As MySqlConnection)
        Try
            cn.Open()
            Dim listems As ListViewItem
            Dim str As String = "SELECT id_commande, nom_client, date_commande, article, montant_total, avance, remise, total_a_payer, description FROM commande"
            cmd = New MySqlCommand(str, cn)
            dr = cmd.ExecuteReader()

            combo.Items.Clear()

            While dr.Read()
                listems = New ListViewItem()
                listems.Text = dr("id_commande").ToString() ' Ajout de l'ID de commande
                listems.SubItems.Add(dr("nom_client").ToString()) ' Adapté au nouveau nom de champ
                listems.SubItems.Add(dr("date_commande").ToString())
                listems.SubItems.Add(dr("article").ToString())
                listems.SubItems.Add(dr("montant_total").ToString())
                listems.SubItems.Add(dr("avance").ToString())
                listems.SubItems.Add(dr("remise").ToString())
                listems.SubItems.Add(dr("total_a_payer").ToString())
                listems.SubItems.Add(dr("description").ToString())
                combo.Items.Add(listems)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cn.Close()
        End Try
    End Sub

    ' Méthode appelée lors du chargement du formulaire
    Private Sub Commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher(cn)
    End Sub

    ' Méthode pour fermer le formulaire
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    ' Méthode pour ajouter une commande
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Vérifie si le nom_client existe dans la table client
            Dim nomClientExists As Boolean = CheckIfNomClientExists(nom_client.Text)

            If Not nomClientExists Then
                MsgBox("Le nom_client n'existe pas dans la table client.")
                Return
            End If

            If String.IsNullOrEmpty(nom_client.Text) OrElse String.IsNullOrEmpty(date_commande.Text) OrElse String.IsNullOrEmpty(Article.Text) OrElse String.IsNullOrEmpty(man_Totale.Text) OrElse String.IsNullOrEmpty(Totale_A_payer.Text) Then
                MsgBox("Remplissez tous les champs pour ajouter !")
            Else
                If MsgBox("Voulez-vous vraiment ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd = New MySqlCommand("INSERT INTO commande (nom_client, date_commande, article, montant_total, avance, remise, total_a_payer, description) VALUES (@nom_client, @date_commande, @article, @montant_total, @avance, @remise, @total_a_payer, @description)", cn)
                    cmd.Parameters.AddWithValue("@nom_client", nom_client.Text)
                    cmd.Parameters.AddWithValue("@date_commande", Date_command.Value.Date)
                    cmd.Parameters.AddWithValue("@article", Article.Text)
                    cmd.Parameters.AddWithValue("@montant_total", man_Totale.Text)
                    cmd.Parameters.AddWithValue("@avance", Avance.Text)
                    cmd.Parameters.AddWithValue("@remise", Remise.Text)
                    cmd.Parameters.AddWithValue("@total_a_payer", Totale_A_payer.Text)
                    cmd.Parameters.AddWithValue("@description", description.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Ajouté avec succès :)")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            Afficher(cn)
        End Try
    End Sub

    ' Méthode pour vérifier si le nom_client existe dans la table client
    Private Function CheckIfNomClientExists(nomClient As String) As Boolean
        Dim nomClientExists As Boolean = False

        Try
            cn.Open()
            Dim query As String = "SELECT COUNT(*) FROM client WHERE nom = @nomClient"
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@nomClient", nomClient)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                nomClientExists = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

        Return nomClientExists
    End Function

    ' Méthode pour modifier une commande
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Vérifie si le nom_client existe dans la table client
            Dim nomClientExists As Boolean = CheckIfNomClientExists(nom_client.Text)

            If Not nomClientExists Then
                MsgBox("Le nouveau nom_client n'existe pas dans la table client.")
                Return
            End If

            If String.IsNullOrEmpty(nom_client.Text) OrElse String.IsNullOrEmpty(date_commande.Text) OrElse String.IsNullOrEmpty(Article.Text) OrElse String.IsNullOrEmpty(man_Totale.Text) OrElse String.IsNullOrEmpty(Totale_A_payer.Text) Then
                MsgBox("Remplissez tous les champs pour modifier !")
            Else
                If MsgBox("Voulez-vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd = New MySqlCommand("UPDATE commande SET date_commande=@date_commande, article=@article, montant_total=@montant_total, avance=@avance, remise=@remise, total_a_payer=@total_a_payer, description=@description WHERE nom_client=@nom_client", cn)
                    cmd.Parameters.AddWithValue("@nom_client", nom_client.Text)
                    cmd.Parameters.AddWithValue("@date_commande", Date_command.Value.Date)
                    cmd.Parameters.AddWithValue("@article", Article.Text)
                    cmd.Parameters.AddWithValue("@montant_total", man_Totale.Text)
                    cmd.Parameters.AddWithValue("@avance", Avance.Text)
                    cmd.Parameters.AddWithValue("@remise", Remise.Text)
                    cmd.Parameters.AddWithValue("@total_a_payer", Totale_A_payer.Text)
                    cmd.Parameters.AddWithValue("@description", description.Text)

                    cmd.ExecuteNonQuery()
                    MsgBox("Modifié avec succès :)")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            Afficher(cn)
        End Try
    End Sub

    ' Méthode pour supprimer une commande
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Vérifie si le nom_client de la commande à supprimer existe toujours dans la table client
            Dim nomClientExists As Boolean = CheckIfNomClientExists(nom_client.Text)

            If Not nomClientExists Then
                MsgBox("Le nom_client de cette commande n'existe plus dans la table client.")
                Return
            End If

            If String.IsNullOrEmpty(nom_client.Text) Then
                MsgBox("Sélectionnez une commande à supprimer !")
            Else
                If MsgBox("Voulez-vous vraiment supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd = New MySqlCommand("DELETE FROM commande WHERE nom_client = @nom_client", cn)
                    cmd.Parameters.AddWithValue("@nom_client", nom_client.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Suppression avec succès :)")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            Afficher(cn)
        End Try
    End Sub
End Class