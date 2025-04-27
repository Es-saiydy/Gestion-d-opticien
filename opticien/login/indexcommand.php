<?php
@include 'config.php';

if (!$conn) {
    die("La connexion a échoué: " . mysqli_connect_error());
}

// Initialiser les erreurs
$errors = [];
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nom_client = isset($_POST['nom_client']) ? $_POST['nom_client'] : null;
    $date_commande = isset($_POST['date_commande']) ? $_POST['date_commande'] : null;
    $num_serie_article = isset($_POST['num_serie_article']) ? $_POST['num_serie_article'] : null;
    $num_serie_article2 = isset($_POST['num_serie_article2']) ? $_POST['num_serie_article2'] : null;
    $marque_générique = isset($_POST['marque_générique']) ? $_POST['marque_générique'] : null;
    $marque_verres_lunettes = isset($_POST['marque_verres_lunettes']) ? $_POST['marque_verres_lunettes'] : null;
    $marque_monture_lunettes = isset($_POST['marque_monture_lunettes']) ? $_POST['marque_monture_lunettes'] : null;
    $quantite_commande = isset($_POST['quantite_commande']) ? $_POST['quantite_commande'] : null;
    $avance = isset($_POST['avance']) ? $_POST['avance'] : null;
    $remise_totale = isset($_POST['remise_totale']) ? $_POST['remise_totale'] : null; // Remplacement de $_POST['0'] par $_POST['remise_totale']
    $mode_paiement = isset($_POST['mode_paiement']) ? $_POST['mode_paiement'] : null;
    $statut_paiement = isset($_POST['statut_paiement']) ? $_POST['statut_paiement'] : null; // Remplacement de $_POST['null'] par $_POST['statut_paiement']
    $statut_livraison = isset($_POST['statut_livraison']) ? $_POST['statut_livraison'] : null; // Remplacement de $_POST['null'] par $_POST['statut_livraison']
    $adresse_livraison = isset($_POST['adresse_livraison']) ? $_POST['adresse_livraison'] : null;
    $montant_total = isset($_POST['montant_total']) ? $_POST['montant_total'] : null;
    $montant_paye = isset($_POST['montant_paye']) ? $_POST['montant_paye'] : null;

    // Ajoutez ici le code pour traiter et enregistrer les données dans la base de données




    // Gestion du fichier ordonnance
    if (isset($_FILES['ordonnance']) && $_FILES['ordonnance']['error'] == UPLOAD_ERR_OK) {
        $ordonnance = $_FILES['ordonnance']['tmp_name'];
        $ordonnance_content = file_get_contents($ordonnance);
        $ordonnance_base64 = base64_encode($ordonnance_content);
    } else {
        $errors[] = "Erreur lors du téléchargement de l'ordonnance.";
    }

    if (empty($errors)) {
        $sql = "INSERT INTO commande (nom_client, Date_Commande, Num_Serie_article, num_serie_article2, Marque_Generique, Marque_Verres_Lunettes, Marque_Monture_Lunettes, Quantite_Commande, Avance, Remise_Totale, Mode_Paiement, Statut_Paiement, Statut_Livraison, Adresse_Livraison, Montant_Total, Montant_Paye, ordonnance) 
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

        $stmt = $conn->prepare($sql);

        if ($stmt === false) {
            die("Erreur de préparation de la requête: " . $conn->error);
        }

        $bind = $stmt->bind_param("ssssssssddssssdds", 
            $nom_client, $date_commande, $num_serie_article, $num_serie_article2, $marque_generique, $marque_verres_lunettes, 
            $marque_monture_lunettes, $quantite_commande, $avance, $remise_totale, $mode_paiement, $statut_paiement, 
            $statut_livraison, $adresse_livraison, $montant_total, $montant_paye, $ordonnance_base64
        );

        if ($bind === false) {
            die("Erreur de liaison des paramètres: " . $stmt->error);
        }

        if ($stmt->execute()) {
            echo "Nouvelle commande ajoutée avec succès";
        } else {
            echo "Erreur lors de l'exécution de la requête: " . $stmt->error;
        }

        $stmt->close();
    }
}


$conn->close();
?>



<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulaire de commande</title>
    <link rel="stylesheet" href="css/style.css"> <!-- Lien vers votre fichier CSS personnalisé -->
    <style>
        .form-container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
        }
        .form-group {
            margin-bottom: 10px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input[type="text"],
        .form-group input[type="number"],
        .form-group textarea,
        .form-group select {
            width: 100%;
            padding: 8px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .form-group textarea {
            resize: vertical;
        }
        .form-group.full-width {
            width: 100%;
        }
        .form-btn-container {
            margin-top: 20px;
            text-align: center;
        }
        .form-btn {
            padding: 10px 20px;
            font-size: 16px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .form-btn:hover {
            background-color: #45a049;
        }
        .error-msg {
            background-color: #f2dede;
            color: #a94442;
            padding: 10px;
            border-radius: 4px;
            margin-bottom: 10px;
        }
        .error-msg ul {
            list-style-type: none;
            padding: 0;
        }
        .error-msg ul li {
            margin-bottom: 5px;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            function updatePrices() {
                var numSerie1 = $('#num_serie_article').val();
                var numSerie2 = $('#num_serie_article2').val();
                var quantite = parseFloat($('#quantite_commande').val()) || 1;
                var remiseTotale = parseFloat($('#remise_totale').val()) || 0;
                var avance = parseFloat($('#avance').val()) || 0;

                var prix1 = 0;
                var prix2 = 0;

                if (numSerie1) {
                    $.post('get_price.php', {num_serie: numSerie1}, function(data) {
                        if (data.success) {
                            prix1 = parseFloat(data.prix);
                            calculateTotal(prix1, prix2, quantite, remiseTotale, avance);
                        }
                    }, 'json');
                }

                if (numSerie2) {
                    $.post('get_price.php', {num_serie: numSerie2}, function(data) {
                        if (data.success) {
                            prix2 = parseFloat(data.prix);
                            calculateTotal(prix1, prix2, quantite, remiseTotale, avance);
                        }
                    }, 'json');
                }
            }

            function calculateTotal(prix1, prix2, quantite, remiseTotale, avance) {
                var montantTotal = (prix1 + prix2) * quantite - remiseTotale;
                var montantPaye = montantTotal - avance;

                $('#montant_total').val(montantTotal.toFixed(2));
                $('#montant_paye').val(montantPaye.toFixed(2));
            }

            $('#num_serie_article, #num_serie_article2, #quantite_commande, #remise_totale, #avance').on('input', updatePrices);
        });
    </script>
</head>
<body>
<div class="form-container">
    <form action="" method="post" enctype="multipart/form-data">
        <h3>Nouvelle Commande</h3>
        <?php if (!empty($errors)): ?>
            <div class="error-msg">
                <ul>
                    <?php foreach ($errors as $error): ?>
                        <li><?php echo $error; ?></li>
                    <?php endforeach; ?>
                </ul>
            </div>
        <?php endif; ?>
        <div class="form-group">
            <label for="nom_client">Nom du client</label>
            <input type="text" id="nom_client" name="nom_client" required placeholder="Nom du client">
        </div>
        <div class="form-group">
            <label for="date_commande">Date de commande</label>
            <input type="date" id="date_commande" name="date_commande" required>
        </div>
        <div class="form-group">
            <label for="num_serie_article">Numéro de série de l'article essentielle</label>
            <input type="text" id="num_serie_article" name="num_serie_article" required placeholder="Numéro de série de l'article 1">
        </div>
        <div class="form-group">
            <label for="num_serie_article2">Numéro de série de l'article supplimentaire</label>
            <input type="text" id="num_serie_article2" name="num_serie_article2" required placeholder="Numéro de série de l'article 2">
        </div>
        <div class="form-group">
            <label for="marque_generique">Marque essentielle</label>
            <input type="text" id="marque_generique" name="marque_generique" required placeholder="Marque Générique">
        </div>
        <div class="form-group">
            <label for="marque_verres_lunettes">Marque des Verres de Lunettes</label>
            <input type="text" id="marque_verres_lunettes" name="marque_verres_lunettes" required placeholder="Marque des Verres de Lunettes">
        </div>
        <div class="form-group">
            <label for="marque_monture_lunettes">Marque de la Monture de Lunettes</label>
            <input type="text" id="marque_monture_lunettes" name="marque_monture_lunettes" required placeholder="Marque de la Monture de Lunettes">
        </div>
        <div class="form-group">
            <label for="quantite_commande">Quantité commandée</label>
            <input type="number" id="quantite_commande" name="quantite_commande" required placeholder="Quantité commandée">
        </div>
        <div class="form-group">
            <label for="avance">Avance</label>
            <input type="number" id="avance" name="avance" required placeholder="Avance">
        </div>
        
        <div class="form-group">
            <label for="mode_paiement">Mode de Paiement</label>
            <select id="mode_paiement" name="mode_paiement" required>
                <option value="">Sélectionner le mode de paiement</option>
                <option value="Carte">Carte</option>
                <option value="Chèque">Chèque</option>
                <option value="Espèces">Espèces</option>
            </select>
        </div>
       
        <div class="form-group">
            <label for="adresse_livraison">Adresse de Livraison</label>
            <textarea id="adresse_livraison" name="adresse_livraison" rows="3" required placeholder="Adresse de Livraison"></textarea>
        </div>
        <div class="form-group full-width">
            <label for="ordonnance">Ordonnance (photo)</label>
            <input type="file" id="ordonnance" name="ordonnance" required>
        </div>
        <div class="form-group">
            <label for="montant_total">Montant Total</label>
            <input type="text" id="montant_total" name="montant_total" readonly>
        </div>
        <div class="form-group">
            <label for="montant_paye">Montant Payé</label>
            <input type="text" id="montant_paye" name="montant_paye" readonly>
        </div>
        <div class="form-btn-container">
            <button type="submit" name="submit" class="form-btn">Soumettre</button>
        </div>
    </form>
</div>
</body>
</html>
