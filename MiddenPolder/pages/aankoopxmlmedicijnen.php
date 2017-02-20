<?php
    header('Content-Type: application/xml');
    header('Content-Disposition: attachment; filename=aankoopmedicijnen.xml');
    include 'components/sql.php';
    // SAMPLE URL:
    // http://localhost/MiddenPolder/pages/drugsxml.php?count=3&order=id
    
    // create a query
    $query = "SELECT *, `doelvoorraad` - `voorraad` as `TeBestellen` FROM `middenpolder voorrraadbeheer`.medicijnen
where `doelvoorraad` - `voorraad` > 0";
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
        AddField("Bestelgrootte", $row['Bestelgrootte']);
        AddField("Bestelniveau", $row['Bestelniveau']);
        AddField("Doelvoorraad", $row['Doelvoorraad']);
        AddField("Voorraad", $row['Voorraad']);
        AddField("Verschil", $row['TeBestellen']);
        AddField("Schapcode", $row['Schapcode']);
        AddField("Verrekenprijs", $row['Verrekenprijs']);
        AddField("Prijs", $row['Prijs']);
        echo "  </drug>\n";
    }
    // close the XML document
    echo "</drugs>\n";

    // Disconnect from the database
    mysqli_close($con);
 ?>
