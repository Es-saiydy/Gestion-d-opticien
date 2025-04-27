
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