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
    <script src="./assets/js/script.js" defer></script>
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
          <a href="login/admin_page.php" class="navbar-link login-button" data-nav-link>Commander</a>
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

  <main>
    <article>


  <!-- 
    - #HERO
  -->

  <section class="section hero" id="home" aria-label="hero">
    <div class="container">

      <div class="hero-content">

        <p class="hero-subtitle">Bienvenue chez OPTISTYLE opticien</p>

        <p class="hero-text">
          Depuis notre fondation en 2023, OPTISTYLE s'est engagé à offrir une expérience exceptionnelle en matière de soins oculaires et de lunetterie. Fondée par Abir Es-saiydy, notre entreprise a évolué pour devenir un pilier de la communauté, offrant des produits de qualité et un service personnalisé. Nous sommes fiers de notre héritage et de notre engagement envers la santé visuelle, et nous continuons à placer nos clients au cœur de tout ce que nous faisons.
        </p>

        <a href="#" class="btn btn-primary">Get Started</a>

      </div>

      <figure class="hero-banner">
        <img src="./assets/images/feme glasse6.png" width="720" height="673" alt="hero banner" class="w-100">
      </figure>

      <div style="margin-top: 50px; margin-bottom: 50px; text-align: center;">
    <h2 style="font-size: 24px; font-weight: bold; margin-bottom: 20px;">LUNETTES DE QUALITÉ AVEC OPTISTYLE</h2>
    <p>LUNETTES PAS CHER AVEC OPTISTYLE VOTRE OPTICIEN EN LIGNE OPTISTYLE est le premier opticien en ligne . Depuis 2023, nous vous proposons des lunettes de vue aux meilleurs prix, aussi bien sur internet qu'en magasins. Nous proposons aussi des services tels que le changement de verres correcteurs sur votre monture, la garantie satisfait .</p>
</div>

    <div class="card-container">
    <div class="card card-1">
        <div>
            <h1>Lunettes en ligne de qualité !</h1>
        </div>
        <ul>
            <li>- Montures et verres conformes aux normes CE.</li>
            <li>- Verres traités anti-reflets et anti-rayures gratuitement.</li>
            <li>- Gamme de verres variée adaptée à votre budget.</li>
            <li>- Agrément sécurité sociale et mutuelles.</li>
        </ul>
     
    </div>
    <div class="card card-2">
        <div>
            <h1>Équipe d'opticiens à votre écoute</h1>
        </div>
        <ul>
            <li>- Conseils par téléphone, email ou chat lors de l'achat en ligne.</li>
            <li>- Vérification de l'ordonnance et aide pour la mesure de l'écart pupillaire.</li>
            <li>- Commande des verres correcteurs et montage dans les ateliers.</li>
            <li>- Assistance même après l'achat en ligne.</li>
        </ul>
  
    </div>
    <div class="card card-3">
        <div>
            <h1>Opticien en ligne et en magasin</h1>
        </div>
        <ul>
            <li>- Disponibilité des mêmes produits et prix en ligne et en magasin.</li>
            <li>- Service après-vente disponible en magasin pour ajustages et réglages.</li>
            <li>- Possibilité d'achat en magasin aux mêmes prix qu'en ligne.</li>
            <li>- Flexibilité pour les clients avec une offre cohérente en ligne et hors ligne.</li>
        </ul>

    </div>
</div>

  </section>
  

  <!-- 
    - #SERVICE
  -->

  <section class="section service" id="service" aria-label="service">
    <div class="container">

      <h2 class="h2 section-title">Services que nous proposons</h2>

      <p class="section-text">
        Depuis notre fondation, nous avons élargi notre gamme de services pour répondre à tous vos besoins en matière de soins oculaires.
      </p>

      <ul class="grid-list">

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #13c4a1">
              <ion-icon name="chatbox"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Consultation Optométrique</a>
            </h3>

            <p class="card-text">
              Nos optométristes qualifiés offrent des consultations complètes pour évaluer et suivre votre santé visuelle.
            </p>

          </div>
        </li>

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #6610f2">
              <ion-icon name="desktop"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Montures et Verres</a>
            </h3>

            <p class="card-text">
              Nous offrons une large sélection de montures et de verres pour répondre à tous les styles et besoins visuels.
            </p>

          </div>
        </li>

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #ffb700">
              <ion-icon name="bulb"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Lentilles de Contact</a>
            </h3>

            <p class="card-text">
              Nous proposons une variété de lentilles de contact pour corriger votre vision tout en assurant votre confort.
            </p>

          </div>
        </li>

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #fc3549">
              <ion-icon name="phone-portrait"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Réparation et Ajustement</a>
            </h3>

            <p class="card-text">
              Nos experts sont disponibles pour réparer et ajuster vos lunettes pour un confort optimal.
            </p>

          </div>
        </li>

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #00d280">
              <ion-icon name="archive"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Examens de la Vue</a>
            </h3>

            <p class="card-text">
              Des examens de la vue réguliers pour garantir que votre prescription est toujours à jour.
            </p>

          </div>
        </li>

        <li>
          <div class="service-card">

            <div class="card-icon" style="background-color: #ff612f">
              <ion-icon name="build"></ion-icon>
            </div>

            <h3 class="h3">
              <a href="#" class="card-title">Conseils Personnalisés</a>
            </h3>

            <p class="card-text">
              Des conseils personnalisés pour choisir les meilleures solutions visuelles adaptées à vos besoins.
            </p>

          </div>
        </li>

      </ul>

    </div>
  </section>
  
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
    - #a propos
  -->
  

    <section class="section about" id="about" aria-label="about">
      <div class="container">

        <div class="about-banner img-holder" style="--width: 720; --height: 960;">
          <img src="./assets/images/opticien.jpeg" width="720" height="960" loading="lazy" alt="about banner"
            class="img-cover">

          <button class="play-btn" aria-label="Play video">
            <ion-icon name="play" aria-hidden="true"></ion-icon>
          </button>
        </div>

        <div class="about-content">

          <h2 class="h2 section-title">À Propos de Nous</h2>

          <p class="section-text">
            Chez OPTISTYLE, nous sommes passionnés par la santé visuelle et votre bien-être. Notre équipe
            d'opticiens expérimentés est là pour vous offrir des solutions personnalisées pour vos besoins en matière de
            vision.
          </p>

          <h3 class="h3">Qui Sommes-Nous</h3>

          <p class="section-text">
            OPTISTYLE est né de la vision de [Nom du fondateur/fondatrice], un(e) passionné(e) de la
            santé visuelle avec une expérience de [nombre] années dans le domaine de l'optique. Notre objectif est de
            fournir des services de haute qualité et des produits optiques de pointe pour tous nos clients.
          </p>

          <h3 class="h3">Notre Engagement</h3>

          <ul class="about-list">

            <li class="about-item">
              <ion-icon name="checkmark-circle" aria-hidden="true"></ion-icon>

              <p class="section-text">
                Nous nous engageons à offrir à nos clients une expérience exceptionnelle à chaque visite, en mettant
                l'accent sur la qualité, le service et la satisfaction.
              </p>
            </li>

            <li class="about-item">
              <ion-icon name="checkmark-circle" aria-hidden="true"></ion-icon>

              <p class="section-text">
                Notre équipe d'opticiens qualifiés est dédiée à vous fournir des conseils professionnels et des
                solutions personnalisées pour répondre à vos besoins uniques en matière de vision.
              </p>
            </li>

            <li class="about-item">
              <ion-icon name="checkmark-circle" aria-hidden="true"></ion-icon>

              <p class="section-text">
                Nous croyons en l'importance de la prévention et de l'éducation en matière de santé visuelle, et nous
                nous efforçons d'informer nos clients sur les meilleures pratiques pour maintenir une vision saine.
              </p>
            </li>

          </ul>

          <h3 class="h3">Notre Mission</h3>

          <p class="section-text">
            Chez OPTISTYLE, notre mission est de vous offrir une vision claire et confortable, pour que
            vous puissiez profiter pleinement de la vie. Nous sommes là pour vous accompagner à chaque étape de votre
            parcours visuel.
          </p>

        </div>

      </div>
    </section>

    <section class="section cta" aria-label="cta" style="background-image: url('./assets/images/cta-bg.jpg')">
      <div class="container">

        <p class="cta-subtitle">Quelle est la prochaine étape ?</p>

        <h2 class="h2 section-title">Êtes-vous prêt(e) ? Passons à l'action !</h2>

        <a href="#" class="btn btn-secondary">Commencer</a>

      </div>
    </section>


        <!-- 
          - #CONTACT
        -->
        <form action="php.php" method="post">
  <section class="section contact" id="contact" aria-label="contact">
    <div class="container">

      <h2 class="h2 section-title">Contactez-nous</h2>

      <p class="section-text">
        Vous avez des questions ou souhaitez prendre rendez-vous ? Remplissez le formulaire ci-dessous et nous vous répondrons dans les plus brefs délais.
      </p>

      <form action="" class="contact-form">

        <div class="input-wrapper">
          <input type="text" name="name" aria-label="name" placeholder="Votre nom*" required class="input-field">
          <input type="email" name="email_address" aria-label="email" placeholder="Adresse e-mail*" required class="input-field">
        </div>

        <div class="input-wrapper">
          <input type="text" name="subject" aria-label="subject" placeholder="Sujet" class="input-field">
          <input type="tel" name="phone" aria-label="phone" placeholder="Numéro de téléphone" class="input-field">
        </div>

        <textarea name="message" aria-label="message" placeholder="Votre message...*" required class="input-field"></textarea>

        <div class="checkbox-wrapper">
          <input type="checkbox" name="terms_and_policy" id="terms" required class="checkbox">
          <label for="terms" class="label">
            J'accepte les <a href="#" class="label-link">Conditions d'utilisation</a> et la <a href="#" class="label-link">Politique de confidentialité</a>
          </label>
        </div>

        <button type="submit" class="btn btn-primary">Envoyer le message</button>

      </form>

      <ul class="contact-list">

        <li class="contact-item">
          <div class="contact-card">
            <div class="card-icon">
              <ion-icon name="mail-outline" aria-hidden="true"></ion-icon>
            </div>
            <div class="card-content">
              <h3 class="h3 card-title">Envoyer ici</h3>
              <a href="mailto:hello@luaz.com" class="card-link">Abiressaiydy1@gmail.com</a>
              <a href="mailto:info@luaz.com" class="card-link">info@OPTISTYLE.com</a>
            </div>
          </div>
        </li>

        <li class="contact-item">
          <div class="contact-card">
            <div class="card-icon">
              <ion-icon name="map-outline" aria-hidden="true"></ion-icon>
            </div>
            <div class="card-content">
              <h3 class="h3 card-title">Visitez-nous</h3>
              <address class="card-address">
                27 hay Iris, OUJDA,<br>
                NY 600000, MAROC
              </address>
            </div>
          </div>
        </li>

        <li class="contact-item">
          <div class="contact-card">
            <div class="card-icon">
              <ion-icon name="headset-outline" aria-hidden="true"></ion-icon>
            </div>
            <div class="card-content">
              <h3 class="h3 card-title">Appelez-nous</h3>
              <a href="tel:+1234567890" class="card-link">+123 456 7890</a>
              <a href="tel:+2414524526" class="card-link">+241 452 4526</a>
            </div>
          </div>
        </li>

      </ul>

    </div>
  </section>
</form>



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