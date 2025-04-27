<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>InnoHub - We're available for marketing</title>

    <!-- 
      - favicon
    -->
    <link rel="shortcut icon" href="./favicon.svg" type="image/svg+xml">

    <!-- 
      - custom css link
    -->
    <link rel="stylesheet" href="./assets/css/style.css">

    <!-- 
      - google font link
    -->
    <link rel="preconnect" href="https://fonts.g    oogleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@500;700&family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" integrity="sha512-RwNvBHwJxm8rF2dnGzS1EZZJYICjwp8bW7iy1L/ue16tYNLx0Ly0ssu8J1HJGWCtnl9KlKqNQUTwj//Oa1h6Jw==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link href="https://cdn.jsdelivr.net/npm/remixicon/fonts/remixicon.css" rel="stylesheet">


</head>

<body>

    <?php
    include("php.php");
    ?>

 


    <!-- Votre code HTML existant -->
    <main>
        <!-- Paragraphe décrivant le premier produit (lentilles) -->
       

        <!-- Catalogue des autres produits -->
        <section class="section products" id="products" aria-label="products">
  <div class="container">
    <h2 class="h2 section-title">Nos Produits Disponibles</h2>
    <p class="section-text">
      Découvrez notre gamme de produits d'optique, divisée en quatre catégories : lentilles, verres, montures et accessoires.
    </p>
    <ul class="grid-list">
      <!-- Ajoutez ici les catalogues des autres produits (verres, montures, accessoires) -->
    </ul>
  </div>
</section>

<section class="produit-section">
  <div class="container">
    <div class="produit-content">
        <h1> lunettes de vue </h1>
      <p class="produit-paragraph">
     
        Sélection de plusieurs centaines de montures de lunettes de vue pour femme à prix doux.
      </p>
    </div>
    <div class="produit-image">
      <img src="assets/images/prodfemme1.png" alt="Montures de lunettes de vue femme">
    </div>
  </div>
</section>

        <!-- Autres sections de votre page -->
    </main>
    <!-- Votre code HTML existant -->

    <!-- 
      - #FOOTER
    -->

    <footer class="footer">
        <div class="container">
            <p class="copyright">
                &copy; 2022 All Rights Reserved by <a href="#" class="copyright-link">codewithsadee</a>
            </p>
        </div>
    </footer>

    <!-- 
      - #BACK TO TOP
    -->

    <a href="#top" aria-label="back to top" data-back-top-btn class="back-top-btn">
        <ion-icon name="chevron-up" aria-hidden="true"></ion-icon>
    </a>

    <!-- 
      - custom js link
    -->
    <script src="./assets/js/script.js" defer></script>

    <!-- 
      - ionicon link
    -->
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</body>

</html>
