<?php
    header('Content-Type: application/xml');
    header('Content-Disposition: attachment; filename=aankoopproducten.xml');
    include 'components/sql.php';
    // SAMPLE URL:
    // http://localhost/MiddenPolder/pages/drugsxml.php?count=3&order=id
    
    // create a query
    $query = "SELECT *, `gewenstevoorraad` - `lopendevoorraad` as `TeBestellen` FROM `middenpolder voorrraadbeheer`.overigeproducten
where `gewenstevoorraad` - `lopendevoorraad` > 0";
    // check if order specified
    $order = $_GET["order"];
    if ($order != "")
        $query = $query . " order by " . "`" . $order . "`";
    // if maximal amount specified, add to the query
    $count = $_GET["count"];
    if ($count != "")
        $query = $query . " limit " . $count;

    // run the query
    $result = mysqli_query($con, $query);

    // Helper function that outputs a record field as XML node
    function AddField($field, $value)
    {
        echo "    <" . $field . ">";
        echo $value;
        echo "</" . $field . ">\n";
    }
    
    // Create the XML document
    echo "<?xml version='1.0'?>\n";
    echo "<producten>\n";
    // For each retrieved product ...
    while($row = mysqli_fetch_array($result)) {
        // ... create <drug> node with all the fields
        echo "  <product>\n";
        AddField("Artikkelnummer", $row['artnr']);
        AddField("Omschrijving", $row['omschrijving']);
        AddField("Verstreenheid", $row['verstreenheid']);
        AddField("Besteleenheid", $row['besteleenheid']);
        AddField("Creditnummer", $row['crednr']);
        AddField("Gewenstevoorraad", $row['gewenstevoorrad']);
        AddField("Lopendevoorraad", $row['lopendevoorraad']);
        AddField("Verschil", $row['TeBestellen']);
        AddField("Verpakkingsfactor", $row['verpakkingsfactor']);
        AddField("Bestelniveau", $row['bestelniveau']);
        AddField("Wekenvoorraad", $row['wekenvoorraad']);
        AddField("Schapcode", $row['schapcode']);
        echo "  </product>\n";
        
    }
    // close the XML document
    echo "</producten>\n";

    // Disconnect from the database
    mysqli_close($con);
 ?>
