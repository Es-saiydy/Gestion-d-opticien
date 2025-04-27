<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    if (isset($_POST['name'], $_POST['email_address'], $_POST['subject'], $_POST['phone'], $_POST['message'], $_POST['terms_and_policy'])) {
        $name = $_POST['name'];
        $email = $_POST['email_address'];
        $subject = $_POST['subject'];
        $phone = $_POST['phone'];
        $message = $_POST['message'];

        if (!empty($name) && !empty($email) && !empty($subject) && !empty($phone) && !empty($message)) {
            $conn = new mysqli('localhost', 'root', '', 'marketing');
            if ($conn->connect_error) {
                die('Connection Failed : ' . $conn->connect_error);
            } else {
                $stmt = $conn->prepare("INSERT INTO contact (name, email, subject, phone, message) VALUES (?, ?, ?, ?, ?)");
                $stmt->bind_param("sssis", $name, $email, $subject, $phone, $message);
                $stmt->execute();
                echo "Thank you for contacting us.";
                echo '<a href="index.php" class="navbar-link" data-nav-link>Go Back</a>'; // Replace "index.php" with the actual home page URL
                $stmt->close();
                $conn->close();
            }
        } else {
            echo "Please fill in all the required fields.";
        }
    } else {
        echo "Please submit the form with all the required fields.";
    }
} else {
    echo "Invalid request method.";
}
?>
