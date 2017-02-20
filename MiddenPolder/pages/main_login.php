<?php
session_start();
if(isset($_SESSION['username'])){
    header("location:main_login.php");
}
else {
?>
<html>
    <head>
        <title>Inloggen Voorraadbeheer Middenpolder</title>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
        <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    </head>
    <body>
        
        <div class="container" style="margin-top:20px;">
            <div class="col-xs-6 col-md-4">&nbsp;</div>
            <div class="col-xs-6 col-md-4">
            <form role="form" name="form1" method="post" action="checklogin.php" autocomplete="off">
                <br>
                <fieldset>
                    <legend>Log in Middenpolder Noord</legend>
                    <div class="form-group">
                        <label for="myusername">Gebruikersnaam:</label>
                        <input type="text" id="username" name="username" class="form-control" placeholder="Typ hier uw gebruikersnaam">
                    </div>
                    <div class="form-group">
                        <label for="mypassword">Wachtwoord:</label>
                        <input type="password" id="password" name="password" class="form-control" placeholder="Typ hier uw wachtwoord">
                    </div>
                    <input type="submit" name="Submit" value="Inloggen" class="btn btn-primary">
                </fieldset>
            </form>
            </div>
        </div>
         

    </body>
</html>
<?php
}
?>