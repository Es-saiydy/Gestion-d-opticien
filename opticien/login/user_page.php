<?php

@include 'config.php';

session_start();

if(!isset($_SESSION['user_name'])){
   header('location:login_form.php');
}

?>

<!DOCTYPE html>
<html lang="fr">
<head>
   <meta charset="UTF-8">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Page utilisateur</title>

   <!-- lien vers le fichier css personnalisé -->
   <link rel="stylesheet" href="css/style.css">

</head>
<body>
   
<div class="container">

   <div class="content">
      <h3>Bonjour, <span>utilisateur</span></h3>
      <h1>Bienvenue <span><?php echo $_SESSION['user_name'] ?></span></h1>
      <p>Ceci est une page utilisateur</p>
      <a href="login_form.php" class="btn">Connexion</a>
      <a href="register_form.php" class="btn">Inscription</a>
      <a href="indexcommand.php" class="btn">commender</a>
   </div>

</div>

</body>
</html>
