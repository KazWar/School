<?php

function Get($request, $field)
{
    if (isset($request[$field]))
        return $request[$field];
    else
        return '';
}

include 'components/sql.php';  
// Retrieve values to save from query string
$Operation = mysqli_real_escape_string($con, Get($_GET, 'operation'));
$Id = mysqli_real_escape_string($con, Get($_GET, 'id'));
$Naam = mysqli_real_escape_string($con, Get($_GET, 'Naam'));
$GeregistreerdOfGeneriek = mysqli_real_escape_string($con, Get($_GET, 'GeregistreerdOfGeneriek'));
$BCGofEU = mysqli_real_escape_string($con, Get($_GET, 'BCGofEU'));
$ReceptOfZelfzorg = mysqli_real_escape_string($con, Get($_GET, 'ReceptOfZelfzorg'));
$Homeopatisch = mysqli_real_escape_string($con, Get($_GET, 'Homeopatisch'));
$FNA = mysqli_real_escape_string($con, Get($_GET, 'FNA'));
$Toedieningsvorm = mysqli_real_escape_string($con, Get($_GET, 'Toedieningsvorm'));
$Bestelgrootte = mysqli_real_escape_string($con, Get($_GET, 'Bestelgrootte'));
$Bestelniveau = mysqli_real_escape_string($con, Get($_GET, 'Bestelniveau'));
$Doelvoorraad = mysqli_real_escape_string($con, Get($_GET, 'Doelvoorraad'));
$Schapcode = mysqli_real_escape_string($con, Get($_GET, 'Schapcode'));
$Verrekenprijs = mysqli_real_escape_string($con, Get($_GET, 'Verrekenprijs'));
$Prijs = mysqli_real_escape_string($con, Get($_GET, 'Prijs'));
$Voorraad = mysqli_real_escape_string($con, Get($_GET, 'Voorraad'));

// INSERT NEW RECORD
if ($Operation=="insert") {
    $sql = "insert into `middenpolder voorrraadbeheer`.`medicijnen` (`Naam`, `GeregistreerdOfGeneriek`, `ReceptOfZelfzorg`, `BCGofEU`, `Homeopatisch`,`FNA`,`Toedieningsvorm`,
    `Bestelgrootte`,`Bestelniveau`,`Doelvoorraad`,`Schapcode`,`Prijs`,`Voorraad`, `Datum`) VALUES
          ('$Naam', '$GeregistreerdOfGeneriek', '$ReceptOfZelfzorg','$BCGofEU', '$Homeopatisch', '$FNA', '$Toedieningsvorm', '$Bestelgrootte'
          , '$Bestelniveau', '$Doelvoorraad', '$Schapcode', '$Prijs', '$Voorraad', now())";
    if (!mysqli_query($con, $sql)) {
        die('Error: ' . mysqli_error($con));
    } else 
    {
        echo $sql;
    }
}

// UPDATE EXISTING RECORD
if ($Operation=="update") {
    $sql = "update `middenpolder voorrraadbeheer`.`medicijnen` 
            set `Naam`='$Naam', 
                `GeregistreerdOfGeneriek`='$GeregistreerdOfGeneriek', 
                `ReceptOfZelfzorg`='$ReceptOfZelfzorg', 
                `BCGofEU`='$BCGofEU',
                `Homeopatisch`='$Homeopatisch', 
                `FNA`='$FNA', 
                `Toedieningsvorm`='$Toedieningsvorm', 
                `Bestelgrootte`='$Bestelgrootte', 
                `Bestelniveau`='$Bestelniveau', 
                `Doelvoorraad`='$Doelvoorraad', 
                `Schapcode`='$Schapcode', 
                `Prijs`='$Prijs', 
                `Voorraad`='$Voorraad'
            where `id`='$Id'";
    if (!mysqli_query($con, $sql)) {
        die('Error: ' . mysqli_error($con));
    } else 
    {
        echo $sql;
    }
}


 mysqli_close($con);
?>
