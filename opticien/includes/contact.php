<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>InnoHub - We're available for marketing</title>

    <!-- favicon -->
    <link rel="shortcut icon" href="./favicon.svg" type="image/svg+xml">

    <!-- custom css link -->
    <link rel="stylesheet" href="./assets/css/style.css">

    <!-- google font link -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@500;700&family=Roboto:wght@400;500;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" integrity="sha512-RwNvBHwJxm8rF2dnGzS1EZZJYICjwp8bW7iy1L/ue16tYNLx0Ly0ssu8J1HJGWCtnl9KlKqNQUTwj//Oa1h6Jw==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>

<body id="top">

    <?php include("php.php"); ?>

    <!-- Contact Form Section -->
    <section class="section contact" id="contact" aria-label="contact">
        <div class="container">
            <h2 class="h2 section-title">Contactez-nous</h2>
            <p class="section-text">
                Vous avez des questions ou souhaitez prendre rendez-vous ? Remplissez le formulaire ci-dessous et nous vous répondrons dans les plus brefs délais.
            </p>

            <form action="php.php" method="post" class="contact-form">
                <div class="input-wrapper">
                    <input type="text" name="name" aria-label="name" placeholder="Votre nom*" required class="input-field">
                    <input type="email" name="email_address" aria-label="email" placeholder="Adresse e-mail*" required class="input-field">
                </div>
                <div class="input-wrapper">
                    <input type="text" name="subject" aria-label="subject" placeholder="Sujet*" required class="input-field">
                    <input type="tel" name="phone" aria-label="phone" placeholder="Numéro de téléphone*" required class="input-field">
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

    <!-- custom js link -->
    <script src="./assets/js/script.js" defer></script>

    <!-- ionicon link -->
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</body>
</html>
