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
      - #HEADER
    -->
    <header class="header" data-header>
    <div class="container">

      <a href="#" class="nav__logo">
        <div class="main__logo">
          <i class="fas fa-eye"></i> OPTISTYLE
        </div>
        <div class="sub-text">[AB] Opticien</div>
      </a>

      <nav class="navbar container" data-navbar>
      <ul class="navbar-list">

          <li>
              <a href="#home" class="navbar-link" data-nav-link>Accueil</a>
          </li>

          <li>
              <a href="#service" class="navbar-link" data-nav-link>Services</a>
          </li>

          <li>
              <a href="#products" class="navbar-link" data-nav-link>Produits</a>
          </li>

          <li>
              <a href="#about" class="navbar-link" data-nav-link>À propos</a>
          </li>

          <li>
              <a href="#contact" class="navbar-link" data-nav-link>Contact</a>
          </li>

          <li>
              <input type="text" placeholder="Rechercher...">
              <img src="magnifying-glass-solid.svg" alt="Loupe">
          </li>
          <li>
            <a href="#login" class="navbar-link login-button" data-nav-link>Commander</a>
        </li>

      </ul>
  </nav>


      <div class="nav-action">
        <i class="ri-service-line"></i>
        <i class="ri-shopping-cart-line"></i>
      </div>

      <button class="nav-toggle-btn" aria-label="Toggle menu" data-nav-toggler>
        <ion-icon name="menu-outline" class="open"></ion-icon>
        <ion-icon name="close-outline" class="close"></ion-icon>
      </button>

    </div>
  </header>
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