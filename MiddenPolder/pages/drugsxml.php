<?php
    header('Content-Type: application/xml');
    header('Content-Disposition: attachment; filename=drugs.xml');
    include 'components/sql.php';
    // SAMPLE URL:
    // http://localhost/MiddenPolder/pages/drugsxml.php?count=3&order=id
    
    // create a query
    $query = "SELECT * FROM medicijnen";
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
    echo "<drugs>\n";
    // For each retrieved product ...
    while($row = mysqli_fetch_array($result)) {
        // ... create <drug> node with all the fields
        echo "  <drug>\n";
        AddField("id", $row['id']);
        AddField("Naam", $row['Naam']);
        AddField("GeregistreerdOfGeneriek", $row['GeregistreerdOfGeneriek']);
        AddField("ReceptOfZelfzorg", $row['ReceptOfZelfzorg']);
        AddField("BCGofEU", $row['BCGofEU']);
        AddField("Homeopatisch", $row['Homeopatisch']);
        AddField("FNA", $row['FNA']);
        AddField("Toedieningsvorm", $row['Toedieningsvorm']);
        AddField("Bestelgrootte", $row['Bestelgrootte']);
        AddField("Bestelniveau", $row['Bestelniveau']);
        AddField("Doelvoorraad", $row['Doelvoorraad']);
        AddField("Schapcode", $row['Schapcode']);
        AddField("Verrekenprijs", $row['Verrekenprijs']);
        AddField("Prijs", $row['Prijs']);
        AddField("Voorraad", $row['Voorraad']);
        echo "  </drug>\n";
    }
    // close the XML document
    echo "</drugs>\n";

    // Disconnect from the database
    mysqli_close($con);
 ?>
