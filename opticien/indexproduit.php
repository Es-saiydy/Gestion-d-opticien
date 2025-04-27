<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>InnoHub - We're available for marketing</title>

    <!-- Link CSS -->
    <link rel="stylesheet" href="./assets/css/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/lightslider/1.1.6/css/lightslider.css" integrity="sha512-+1GzNJIJQ0SwHimHEEDQ0jbyQuglxEdmQmKsu8KI7QkMPAnyDrL9TAnVyLPEttcTxlnLVzaQgxv2FpLCLtli0A==" crossorigin="anonymous" referrerpolicy="no-referrer" />

    <!-- Link JavaScript -->
    <script src="https://code.jquery.com/jquery-3.7.1.js" integrity="sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/lightslider/1.1.6/js/lightslider.min.js" integrity="sha512-Gfrxsz93rxFuB7KSYlln3wFqBaXUc1jtt3dGCp+2jTb563qYvnUBM/GP2ZUtRC27STN/zUamFtVFAIsRFoT6/w==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>

    <!-- Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@500;700&family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/remixicon/fonts/remixicon.css" rel="stylesheet">

    <!-- Favicon -->
    <link rel="shortcut icon" href="./favicon.svg" type="image/svg+xml">
</head>
<body>

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

        <nav class="navbar" data-navbar>
            <ul class="navbar-list">
                <li>
                    <a href="index.php" class="navbar-link btn-back">
                        <i class="fas fa-chevron-left"></i> Retour
                    </a>
              
                </li>
                <li class="dropdown">
                    <a href="#" class="navbar-link">Lunettes de la Vue <i class="ri-arrow-drop-down-line"></i></a>
                    <div class="sub__menu-1">
                        <ul>
                            <li class="dropdown-submenu">
                                <a href="#">Forme de Verre <i class="ri-arrow-right-s-line"></i></a>
                                <div class="sub__menu-2">
                                    <ul>
                                        <li><a href="#pilote">Lunettes pilote / aviateur</a></li>
                                        <li><a href="#ronde">Lunettes rondes</a></li>
                              
                                        
                                    </ul>
                                </div>
                            </li>
                            <li class="dropdown-submenu">
                                <a href="#">Forme de Monture <i class="ri-arrow-right-s-line"></i></a>
                                <div class="sub__menu-2">
                                    <ul>
                                        <li><a href="#">Monture cerclée</a></li>
                                        <li><a href="#">Monture demi-cerclée</a></li>
                                    </ul>
                                </div>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class="dropdown">
                    <a href="#" class="navbar-link">Lunettes de Soleil <i class="ri-arrow-drop-down-line"></i></a>
                    <div class="sub__menu-1">
                        <ul>
                            <li><a href="indexproduit.php?category=lunettes_soleil_femme">Femme</a></li>
                            <li><a href="indexproduit.php?category=lunettes_soleil_homme">Homme</a></li>
                        </ul>
                    </div>
                </li>
                <li class="dropdown">
                    <a href="#"  class="navbar-link"    >Marques de Lentilles <i class="ri-arrow-drop-down-line"></i></a>
                    <div class="sub__menu-1">
                        <ul>
                            <li><a href="#">L'éphémère d'Afflelou</a></li>
                            <li><a href="#">Acuvue</a></li>
                            <li><a href="#">Air Optix</a></li>
                            <li><a href="#">Biofinity</a></li>
                            <li><a href="#">Biomedics</a></li>
                         
                        </ul>
                    </div>
                </li>
                <li>
                    <input type="text" placeholder="Rechercher...">
                    <img src="magnifying-glass-solid.svg" alt="Loupe">
                </li>
                <li>
                    <a href="admin_page.php" class="navbar-link login-button" data-nav-link>commander</a>
                </li>
            </ul>
        </nav>

        <button class="nav-toggle-btn" aria-label="Toggle menu" data-nav-toggler>
            <ion-icon name="menu-outline" class="open"></ion-icon>
            <ion-icon name="close-outline" class="close"></ion-icon>
        </button>
    </div>
</header>

<body>

    <!-- Votre code HTML existant -->
    <main>
       

        <!-- Catalogue des autres produits -->
        <section class="section products" id="products" aria-label="products">
  <div class="container">
    <h2 class="h2 section-title">Nos Produits Disponibles</h2>
    <ul class="grid-list">

      <!-- Ajoutez ici les catalogues des autres produits (verres, montures, accessoires) -->
    </ul>
  </div>
</section>

<section class="produit-section">
  <div class="container1">
    <div class="produit-content">
      <h1>lunettes de vue</h1>
      <p class="produit-paragraph">
        Sélection de plusieurs centaines de montures de lunettes de vue pour femme à prix doux.
      </p>
    </div>
    <div class="produit-image">
      <img src="assets/images/prodfemme1.png" alt="Montures de lunettes de vue femme">
    </div>
  </div>
</section>

<section class="catalogue">
  <div class="container">
    <ul id="autowidth" class="cS-hidden">
    <li id="pilote" class="item-f">
        <div class="carte">
          <h1 class="verre">Verre</h1>
          <img src="assets/images/verre/verre11.jpeg" alt="Verre 11" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre5.jpg" alt="Verre 3" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre2.jpg" alt="Verre 12" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre4.avif" alt="Verre 8" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre7.jpg" alt="Verre 10" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre8.jpeg" alt="Verre 6" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre11.jpeg" alt="Verre 11" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre9.jpg" alt="Verre 11" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
      <li class="item-f">
        <div class="carte">
          <p class="verre">Verre</p>
          <img src="assets/images/verre/verre10.jpg" alt="Verre 11" class="modele">
          <div class="detail">
            <h1>Prix: $130</h1>
            <h2>N°: V003</h2>
            <p>marque: <strong>pilote</strong></p>
            <a href="https://wa.me/+212649314263">
              <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
            </a>
          </div>
        </div>
      </li>
    </ul>
  </div>
</section>


<section class="catalogue2">
    <ul id="autowidth2" class="cS-hidden">
        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre3.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>
        <!-- Ajouter d'autres cartes produits ici -->
        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre2.jpg" alt="Verre 2" class="modele">
            <div class="detail">
                <h1>Prix: $150</h1>
                <h2>N°: V004</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314264">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>
        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre3.jpg" alt="Verre 3" class="modele">
            <div class="detail">
                <h1>Prix: $170</h1>
                <h2>N°: V005</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314265">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>

        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre4.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>

        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre5.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>

        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre2.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>

        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre3.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>


        <li class="carte2">
            <h1 class="verre">Verre</h1>
            <img src="assets/images/verre/verrero/verre1.jpg" alt="Verre 1" class="modele">
            <div class="detail">
                <h1>Prix: $130</h1>
                <h2>N°: V003</h2>
                <p>marque: <strong>pilote</strong></p>
                <a href="https://wa.me/+212649314263">
                    <img src="assets/images/verre/wha.png" alt="WhatsApp" class="logo">
                </a>
            </div>
        </li>
    </ul>
</section>








<script>
        $(document).ready(function() {
            $('#autowidth').lightSlider({
                autoWidth:true,
                loop:true,
                onSliderLoad: function() {
                    $('#autowidth').removeClass('cS-hidden');
                } 
            });  
        });
    </script>
    <script>
        $(document).ready(function() {
            $('#autowidth2').lightSlider({
                autoWidth:true,
                loop:true,
                onSliderLoad: function() {
                    $('#autowidth2').removeClass('cS-hidden');
                } 
            });  
        });
    </script>
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
      - ionicon links
    -->

    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</body>

</html>
