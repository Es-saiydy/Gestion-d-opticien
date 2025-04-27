<?php

@include 'config.php';

session_start();

if(isset($_POST['submit'])){

   $email = mysqli_real_escape_string($conn, $_POST['email']);
   $mot_de_passe = md5($_POST['mot_de_passe']);

   $selection = " SELECT * FROM client WHERE email = '$email' AND mot_de_passe = '$mot_de_passe' ";

   $resultat = mysqli_query($conn, $selection);

   if(mysqli_num_rows($resultat) > 0){

      $ligne = mysqli_fetch_array($resultat);

      if($ligne['email'] == $email){

         $_SESSION['user_name'] = $ligne['nom'];
         header('location:user_page.php');
      }
   } else {
      $erreur[] = 'Email ou mot de passe incorrect !';
   }

};

?>

<!DOCTYPE html>
<html lang="fr">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Formulaire de connexion</title>

   <!-- lien vers le fichier css personnalisé -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<div class="form-container">

   <form action="" method="post">
      <h3>Connectez-vous maintenant</h3>
      <?php
      if(isset($erreur)){
         foreach($erreur as $err){
            echo '<span class="error-msg">'.$err.'</span>';
         };
      };
      ?>
      <input type="email" name="email" required placeholder="Entrez votre email">
      <input type="password" name="mot_de_passe" required placeholder="Entrez votre mot de passe">
      <input type="submit" name="submit" value="Se connecter" class="form-btn">
      <p>Vous n'avez pas de compte ? <a href="register_form.php">Inscrivez-vous maintenant</a></p>
   </form>

</div>

</body>
</html>
