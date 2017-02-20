<?php
//Done
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
$Artnr = mysqli_real_escape_string($con, Get($_GET, 'artnr'));
$Omschrijving = mysqli_real_escape_string($con, Get($_GET, 'omschrijving'));
$Verstreenheid = mysqli_real_escape_string($con, Get($_GET, 'verstreenheid'));
$Besteleenheid = mysqli_real_escape_string($con, Get($_GET, 'besteleenheid'));
$Crednr = mysqli_real_escape_string($con, Get($_GET, 'crednr'));
$Serieletter = mysqli_real_escape_string($con, Get($_GET, 'serieletter'));
$Systeemdeelletter = mysqli_real_escape_string($con, Get($_GET,'systeemdeelletter'));
$GewensteVoorraad = mysqli_real_escape_string($con, Get($_GET, 'gewenstevoorraad'));
$Verpakkingsfactor = mysqli_real_escape_string($con, Get($_GET, 'verpakkingsfactor'));
$Bestelniveau = mysqli_real_escape_string($con, Get($_GET, 'bestelniveau'));
$Wekenvoorraad = mysqli_real_escape_string($con, Get($_GET, 'wekenvoorraad'));
$Brutoprijs= mysqli_real_escape_string($con, Get($_GET, 'brutoprijs'));
$Lopendevoorraad = mysqli_real_escape_string($con, Get($_GET, 'lopendevoorraad'));

// INSERT NEW RECORD
if ($Operation=="insert") {
    $sql = "insert into `middenpolder voorrraadbeheer`.`overigeproducten`(`omschrijving`, `verstreenheid`, `besteleenheid`, `crednr`
    , `serieletter`, `systeemdeelletter`, `gewenstevoorraad`, `verpakkingsfactor`, `bestelniveau`, `wekenvoorraad`, `brutoprijs`,`lopendevoorraad`,`datum`) VALUES
          ('$Omschrijving', '$Verstreenheid', '$Besteleenheid', '$Crednr', '$Serieletter', '$Systeemdeelletter', '$GewensteVoorraad'
          , '$Verpakkingsfactor', '$Bestelniveau', '$Wekenvoorraad', '$Brutoprijs', '$Lopendevoorraad',now())";
    if (!mysqli_query($con, $sql)) {
        die('Error: ' . mysqli_error($con));
    } else 
    {
        echo $sql;
    }
}

// UPDATE EXISTING RECORD
if ($Operation=="update") {
    $sql = "update `middenpolder voorrraadbeheer`.`overigeproducten` 
            set `omschrijving`='$Omschrijving', 
                `verstreenheid`='$Verstreenheid', 
                `besteleenheid`='$Besteleenheid', 
                `crednr`='$Crednr', 
                `serieletter`='$Serieletter', 
                `systeemdeelletter`='$Systeemdeelletter', 
                `gewenstevoorraad`='$GewensteVoorraad', 
                `verpakkingsfactor`='$Verpakkingsfactor', 
                `bestelniveau`='$Bestelniveau', 
                `wekenvoorraad`='$Wekenvoorraad', 
                `brutoprijs`='$Brutoprijs', 
                `lopendevoorraad`='$Lopendevoorraad'
            where `artnr`='$Artnr'";
    if (!mysqli_query($con, $sql)) {
        //echo $sql;
        die('Error: ' . mysqli_error($con));
    } else 
    {
        echo $sql;
    }
}


 mysqli_close($con);
?>
