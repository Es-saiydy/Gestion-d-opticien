Imports MySql.Data.MySqlClient

Public Class Form1

    Public connectionString As String = "server=localhost;user id=root;password=root;database=optique1"
    Public cn As New MySqlConnection(connectionString)
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand

    Private Sub Afficher(cn As MySqlConnection)
        cn.Open()

        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM client"

        cmd = New MySqlCommand(str, cn)
        dr = cmd.ExecuteReader()

        combo.Items.Clear()

        While (dr.Read())
            listems = New ListViewItem()
            listems.Text = dr("id_client").ToString()
            listems.SubItems.Add(dr("nom").ToString())
            listems.SubItems.Add(dr("adresse").ToString())
            listems.SubItems.Add(dr("email").ToString())
            listems.SubItems.Add(dr("date_naissance").ToString())
            listems.SubItems.Add(dr("genre").ToString())
            listems.SubItems.Add(dr("profession").ToString())
            listems.SubItems.Add(dr("statut_marital").ToString())

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
                cmd.CommandText = "SELECT * FROM client WHERE id_client = '" & combo.SelectedItems(0).Text.ToString & "'"
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    Me.id.Text = dr.Item(0).ToString
                    Me.nom_c.Text = dr.Item(1).ToString
                    Me.adresse_c.Text = dr.Item(3).ToString
                    Me.email_c.Text = dr.Item(4).ToString
                    Me.datenaiss.Text = dr.Item(5).ToString
                    Me.genre_c.Text = dr.Item(6).ToString
                    Me.prof.Text = dr.Item(7).ToString
                    Me.statut.Text = dr.Item(8).ToString
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
            If nom_c.Text = Nothing Or adresse_c.Text = Nothing Or email_c.Text = Nothing Or datenaiss.Text = Nothing Or genre_c.Text = Nothing Or prof.Text = Nothing Then
                MsgBox("Remplissez tous les champs pour ajouter !")
            Else
                If MsgBox("Voulez-vous vraiment ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cn.Open()
                    cmd.CommandText = "INSERT INTO client (nom, adresse, email, date_naissance, genre, profession, statut_marital) VALUES('" & nom_c.Text & "','" & prenom_c.Text & "','" & adresse_c.Text & "','" & email_c.Text & "','" & datenaiss.Value.ToString("yyyy-MM-dd") & "','" & genre_c.Text & "','" & prof.Text & "','" & statut.Text & "')"
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

    ' Les autres méthodes Button4_Click, Button3_Click, etc. peuvent être ajustées de manière similaire.

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "SELECT * FROM client WHERE " & ComboBox1.Text & " LIKE '%' + @1 + '%' "
        cmd = New MySqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", TextBox1.Text)
        dr = cmd.ExecuteReader()
        ComboBox1.Items.Clear()
        While (dr.Read())
            listems = Me.combo.Items.Add(dr("id_client"))
            listems.SubItems.Add(dr("nom"))
            listems.SubItems.Add(dr("adresse"))
            listems.SubItems.Add(dr("email"))
            listems.SubItems.Add(dr("date_naissance"))
            listems.SubItems.Add(dr("genre"))
            listems.SubItems.Add(dr("profession"))
            listems.SubItems.Add(dr("statut_marital"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        visite_client.Show()

    End Sub

    Private Sub Admin_Click(sender As Object, e As EventArgs) Handles Admin.Click
        Me.Hide()
        Admin.Show()

    End Sub
End Class
