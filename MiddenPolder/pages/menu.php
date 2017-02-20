<?php
session_start();
if(!isset($_SESSION['username'])){
    header("location:main_login.php");
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>MiddenPolder Web Application</title>

    <script src="../jquery/jquery-1.11.1.js"></script>
    <script src="../jquery/jquery.datatables.js"></script>
    <script src="../jquery/jquery.validator.js"></script>
    <script src="../jquery/tabletools.js"></script>
    <script src="../bootstrap/js/bootstrap.js"></script>
    <link href="../jquery/tabletools.css" rel="stylesheet" />
    <link href="../jquery/jquery.datatables.css" rel="stylesheet" />
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../bootstrap/css/spacelab.css" rel="stylesheet" />
    <link href="../styles/styles.css" rel="stylesheet">
    <script src="../scripts/scriptsdrugs.js"></script>
    <script src="../scripts/scriptsproducts.js"></script>
    <script src="../scripts/scriptssuggestions.js"></script>
    <script src="../scripts/scriptsorders.js"></script>

</head>

<body>
    <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <span class="navbar-brand">MiddenPolder Voorraadbeheer |</span>
            </div>
            <ul class="nav navbar-nav">
                <li><a href="home.php">Home</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        Producten <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="drugs.php">Medicijnen</a></li>
                        <li><a href="producten.php">Overige producten</a></li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        Aankoopvoorstellen <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="aankoopvoorstelmedicijnen.php">Medicijnen</a></li>
                        <li><a href="aankoopvoorsteloverige.php">Overige Producten</a></li>
                        <li><a href="orders.php">Bestellingen</a></li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        Afdeling Managment <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="noEditProducts.php">Producten</a></li>
                        <li><a href="noEditDrugs.php">Medicijnen</a></li>
                        <li><a href="afdelingorders.php">Orders</a></li>
                    </ul>
                </li>
                <li><a href="logout.php"> Uitloggen</a></li>
            </ul>
        </div>
    </div>

    <div class="container">
        <div class="view">

