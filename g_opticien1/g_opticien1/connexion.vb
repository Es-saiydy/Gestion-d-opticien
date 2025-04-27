Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module Connexion

    ' Chaîne de connexion à la base de données MySQL
    Dim connectionString As String = "server=localhost;user id=root;password=root;database=optique1"

    ' Créer une instance de connexion
    Public cn As New MySqlConnection(connectionString)

    ' Fonction pour ouvrir la connexion à la base de données
    Public Sub OpenConnection()
        Try
            ' Ouvrir la connexion
            cn.Open()
            Console.WriteLine("Connexion à la base de données MySQL réussie.")
        Catch ex As Exception
            Console.WriteLine("Échec de la connexion à la base de données MySQL : " & ex.Message)
        End Try
    End Sub

    ' Fonction pour fermer la connexion à la base de données
    Public Sub CloseConnection()
        Try
            ' Fermer la connexion
            cn.Close()
            Console.WriteLine("Connexion à la base de données MySQL fermée.")
        Catch ex As Exception
            Console.WriteLine("Erreur lors de la fermeture de la connexion à la base de données MySQL : " & ex.Message)
        End Try
    End Sub

End Module
