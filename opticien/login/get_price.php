<?php
@include 'config.php';

if (isset($_POST['num_serie'])) {
    $num_serie = mysqli_real_escape_string($conn, $_POST['num_serie']);

    $query = "SELECT prix FROM stock WHERE num_serie = '$num_serie'";
    $result = mysqli_query($conn, $query);

    if (mysqli_num_rows($result) > 0) {
        $row = mysqli_fetch_assoc($result);
        echo json_encode(['success' => true, 'prix' => $row['prix']]);
    } else {
        echo json_encode(['success' => false, 'message' => 'Numéro de série invalide.']);
    }
} else {
    echo json_encode(['success' => false, 'message' => 'Numéro de série non fourni.']);
}
?>
