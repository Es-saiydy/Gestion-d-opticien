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
                    <a href="#" class="navbar-link">Lunettes de Vue <i class="ri-arrow-drop-down-line"></i></a>
                    <div class="sub__menu-1">
                        <ul>
                            <li class="dropdown-submenu">
                                <a href="#">Forme de Verre <i class="ri-arrow-right-s-line"></i></a>
                                <div class="sub__menu-2">
                                    <ul>
                                        <li><a href="#">Lunettes pilote / aviateur</a></li>
                                        <li><a href="#">Lunettes rondes</a></li>
                                        <li><a href="#">Lunettes pantos</a></li>
                                        <li><a href="#">Lunettes carrées</a></li>
                              
                                        
                                    </ul>
                                </div>
                            </li>
                            <li class="dropdown-submenu">
                                <a href="#">Forme de Monture <i class="ri-arrow-right-s-line"></i></a>
                                <div class="sub__menu-2">
                                    <ul>
                                        <li><a href="#">Monture cerclée</a></li>
                                        <li><a href="#">Monture demi-cerclée</a></li>
                                        <li><a href="#">Monture invisible</a></li>
                                        <li><a href="#">Monture en titane</a></li>
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
                    <a href="#login" class="navbar-link login-button" data-nav-link>commander</a>
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
