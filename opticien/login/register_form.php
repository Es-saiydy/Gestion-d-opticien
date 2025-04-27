<?php

@include 'config.php';

if(isset($_POST['submit'])){

   $nom = mysqli_real_escape_string($conn, $_POST['nom']);
   $genre = mysqli_real_escape_string($conn, $_POST['genre']);
   $date_naissance = mysqli_real_escape_string($conn, $_POST['date_naissance']);
   $profession = mysqli_real_escape_string($conn, $_POST['profession']);
   $statut_marital = mysqli_real_escape_string($conn, $_POST['statut_marital']);
   $adresse = mysqli_real_escape_string($conn, $_POST['adresse']);
   $email = mysqli_real_escape_string($conn, $_POST['email']);
   $mdp = md5($_POST['mot_de_passe']);
   $cmdp = md5($_POST['cmot_de_passe']);

   $selection = " SELECT * FROM client WHERE email = '$email' && mot_de_passe = '$mdp' ";

   $resultat = mysqli_query($conn, $selection);

   if(mysqli_num_rows($resultat) > 0){

      $erreur[] = 'Utilisateur déjà existant !';

   }else{

      if($mdp != $cmdp){
         $erreur[] = 'Les mots de passe ne correspondent pas !';
      }else{
         $insertion = "INSERT INTO client(nom, genre, date_naissance, profession, statut_marital, adresse, email, mot_de_passe) VALUES('$nom', '$genre', '$date_naissance', '$profession', '$statut_marital', '$adresse', '$email', '$mdp')";
         mysqli_query($conn, $insertion);
         header('location:login_form.php');
      }
   }

};

?>

<!DOCTYPE html>
<html lang="fr">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Formulaire d'inscription</title>

   <!-- lien vers le fichier css personnalisé -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<div class="form-container">

   <form action="" method="post">
      <h3>Inscrivez-vous maintenant</h3>
      <?php
      if(isset($erreur)){
         foreach($erreur as $erreur){
            echo '<span class="error-msg">'.$erreur.'</span>';
         };
      };
      ?>
      <input type="text" name="nom" required placeholder="Entrez votre nom">
      <select name="genre" required>
         <option value="">Sélectionnez votre genre</option>
         <option value="Masculin">Masculin</option>
         <option value="Féminin">Féminin</option>
         <option value="Autre">Autre</option>
      </select>
      <input type="date" name="date_naissance" placeholder="Entrez votre date de naissance">
      <input type="text" name="profession" placeholder="Entrez votre profession">
      <select name="statut_marital">
         <option value="">Sélectionnez votre statut marital</option>
         <option value="Célibataire">Célibataire</option>
         <option value="Marié">Marié</option>
         <option value="Divorcé">Divorcé</option>
         <option value="Veuf">Veuf</option>
      </select>
      <textarea name="adresse" placeholder="Entrez votre adresse"></textarea>
      <input type="email" name="email" required placeholder="Entrez votre email">
      <input type="password" name="mot_de_passe" required placeholder="Entrez votre mot de passe">
      <input type="password" name="cmot_de_passe" required placeholder="Confirmez votre mot de passe">
      <input type="submit" name="submit" value="S'inscrire maintenant" class="form-btn">
      <p>Vous avez déjà un compte ? <a href="login_form.php">Connectez-vous maintenant</a></p>
   </form>

</div>

</body>
</html>
