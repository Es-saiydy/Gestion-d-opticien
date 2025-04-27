
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
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link
      href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@500;700&family=Roboto:wght@400;500;700&display=swap"
      rel="stylesheet">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" integrity="sha512-RwNvBHwJxm8rF2dnGzS1EZZJYICjwp8bW7iy1L/ue16tYNLx0Ly0ssu8J1HJGWCtnl9KlKqNQUTwj//Oa1h6Jw==" crossorigin="anonymous" referrerpolicy="no-referrer" />

  </head>

  <body id="top">

    <?php
    include("php.php");
    ?>
  
  <!-- 
    - #PRODUCTS
  -->

  <section class="section products" id="products" aria-label="products">
  <div class="container">

    <h2 class="h2 section-title">Nos Produits Disponibles</h2>

    <p class="section-text">
      Découvrez notre gamme de produits d'optique, divisée en quatre catégories : lentilles, verres, montures et accessoires.
    </p>

    <ul class="grid-list">

      <li>
        <div class="product-card">
          <figure class="card-banner img-holder" style="--width: 510; --height: 700;">
            <img src="./assets/images/lentille2.jpg" width="510" height="700" loading="lazy" alt="Lentilles" class="img-cover">
          </figure>
          <div class="card-content">
            <p class="card-subtitle">Lentilles</p>
            <h3 class="h3">
              <a href="indexproduit.php?category=lentilles" class="card-title">Voir le catalogue de lentilles</a>
            </h3>
            <a href="indexproduit.php?category=lentilles" class="btn btn-primary">Voir Détails</a>
          </div>
        </div>
      </li>

      <li>
        <div class="product-card">
          <figure class="card-banner img-holder" style="--width: 510; --height: 700;">
            <img src="./assets/images/verre1.jpg" width="510" height="700" loading="lazy" alt="Verres" class="img-cover">
          </figure>
          <div class="card-content">
            <p class="card-subtitle">Verres</p>
            <h3 class="h3">
              <a href="indexproduit.php?category=verres" class="card-title">Voir le catalogue de verres</a>
            </h3>
            <a href="indexproduit.php?category=verres" class="btn btn-primary">Voir Détails</a>
          </div>
        </div>
      </li>

      <li>
        <div class="product-card">
          <figure class="card-banner img-holder" style="--width: 510; --height: 700;">
            <img src="./assets/images/montures.jpg" width="510" height="700" loading="lazy" alt="Montures" class="img-cover">
          </figure>
          <div class="card-content">
            <p class="card-subtitle">Montures</p>
            <h3 class="h3">
              <a href="indexproduit.php?category=montures" class="card-title">Voir le catalogue de montures</a>
            </h3>
            <a href="indexproduit.php?category=montures" class="btn btn-primary">Voir Détails</a>
          </div>
        </div>
      </li>

      <li>
        <div class="product-card">
          <figure class="card-banner img-holder" style="--width: 510; --height: 700;">
            <img src="./assets/images/accessoires1.jpeg" width="510" height="700" loading="lazy" alt="Accessoires" class="img-cover">
          </figure>
          <div class="card-content">
            <p class="card-subtitle">Accessoires</p>
            <h3 class="h3">
              <a href="indexproduit.php?category=accessoires" class="card-title">Voir le catalogue d'accessoires</a>
            </h3>
            <a href="indexproduit.php?category=accessoires" class="btn btn-primary">Voir Détails</a>
          </div>
        </div>
      </li>

      <!-- Nouvelle section pour les lunettes -->
      <li>
        <div class="product-card">
          <figure class="card-banner img-holder" style="--width: 510; --height: 700;">
            <img src="./assets/images/glasse2.png" width="510" height="700" loading="lazy" alt="Lunettes" class="img-cover">
          </figure>
          <div class="card-content">
            <p class="card-subtitle">Lunettes</p>
            <h3 class="h3">
              <a href="indexproduit.php?category=lunettes" class="card-title">Voir le catalogue de lunettes</a>
            </h3>
            <a href="indexproduit.php?category=lunettes" class="btn btn-primary">Voir Détails</a>
          </div>
        </div>
      </li>
    </ul>

  </div>
</section>

 


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