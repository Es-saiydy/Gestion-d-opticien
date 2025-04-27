Imports MySql.Data.MySqlClient

Public Class Stockvb
    Private connectionString As String = "server=localhost;user id=root;password=root;database=optique1"
    Private cn As New MySqlConnection(connectionString)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' À compléter - Ajouter le code pour gérer l'action du bouton
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        monture.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        verre.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        accessoire.Show()
    End Sub

    Private Sub Stockvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Vous pouvez ajouter du code d'initialisation ici si nécessaire
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        accessoire.Show()
    End Sub

    Private Sub Afficher_Click(sender As Object, e As EventArgs) Handles Afficher.Click
        Try
            ' Assurez-vous que la connexion est fermée avant de l'ouvrir
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            ' Effacez d'abord les données actuelles dans la DataGridView
            DataGridView1.Rows.Clear()

            ' Définissez votre requête SQL pour sélectionner tous les produits
            Dim query As String = "SELECT id_produit, type_article, description, num_serie, quantite, prix FROM produit"

            ' Créez une commande MySQL pour exécuter la requête
            Dim command As New MySqlCommand(query, cn)

            ' Exécutez la commande et obtenez un lecteur de données
            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Parcourez les résultats et ajoutez chaque produit à la DataGridView
                While reader.Read()
                    Dim row As String() = {reader("id_produit").ToString(), reader("type_article").ToString(), reader("description").ToString(), reader("num_serie").ToString(), reader("quantite").ToString(), reader("prix").ToString()}
                    DataGridView1.Rows.Add(row)
                End While
            End Using
        Catch ex As Exception
            MsgBox("Une erreur s'est produite : " & ex.Message)
        Finally
            ' Assurez-vous de fermer la connexion même en cas d'exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class
