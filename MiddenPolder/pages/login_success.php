<?php
// Check if session is not registered, redirect back to main page.
session_start();
if(!isset($_SESSION['username'])){
    header("location:main_login.php");
}
else {
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <script src="../jquery/jquery-1.11.1.js"></script>
    <script src="../bootstrap/js/bootstrap.js"></script>
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="jumbotron" style="text-align:center;">
        <h1>Log in Succesvol!</h1>
        U bent nu ingelogd. U word nu doorverwezen naar de home pagina.
        <?php
        header( "Refresh:2; url=home.php");
        ?>
    </div>
</body>
</html>
<?php
}
?>