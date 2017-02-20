<html>
    <head>
        <script src="../jquery/jquery-1.11.1.js"></script>
        <script src="../bootstrap/js/bootstrap.js"></script>
        <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" />
    </head>
<body>
    <div class="jumbotron" style="text-align:center;">
        <h1>Log uit Succesvol!</h1>
        <?php
        session_start();
        session_destroy();
        echo 'U bent uitgelogd. U word nu doorverwezen naar de login pagina.';
        header( "Refresh:3; url=main_login.php");
        ?>
    </div>
</body>
</html>