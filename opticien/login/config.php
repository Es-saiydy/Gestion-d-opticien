<?php

$server = "localhost"; // ou votre serveur MySQL
$username = "root"; // ou votre nom d'utilisateur MySQL
$password = ""; // ou votre mot de passe MySQL
$database = "optique1"; // Remplacez par le nom de votre base de données

$conn = mysqli_connect($server, $username, $password, $database);

if (!$conn) {
    die("Échec de la connexion : " . mysqli_connect_error());
}

?>
