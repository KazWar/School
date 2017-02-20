<?php
    header('Content-Type: application/xml');
    header('Content-Disposition: attachment; filename=product.xml');
    include 'components/sql.php';
    // SAMPLE URL:
    // http://localhost/MiddenPolder/pages/drugsxml.php?count=3&order=id
    
    // create a query
    $query = "SELECT * FROM overigeproducten";
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
        // ... create <product> node with all the fields
        echo "  <product>\n";
        AddField("artnr", $row['artnr']);
        AddField("omschrijving", $row['omschrijving']);
        AddField("verstreenheid", $row['verstreenheid']);
        AddField("besteleenheid", $row['besteleenheid']);
        AddField("crednr", $row['crednr']);
        AddField("serieletter", $row['serieletter']);
        AddField("systeemdeelletter", $row['systeemdeelletter']);
        AddField("gewenstevoorraad", $row['gewenstevoorraad']);
        AddField("verpakkingsfactor", $row['verpakkingsfactor']);
        AddField("bestelniveau", $row['bestelniveau']);
        AddField("wekenvoorraad", $row['wekenvoorraad']);
        AddField("brutoprijs", $row['brutoprijs']);
        AddField("schapcode", $row['schapcode']);
        AddField("lopendevoorraad", $row['lopendevoorraad']);
        echo "  </product>\n";

    }
    // close the XML document
    echo "</producten>\n";

    // Disconnect from the database
    mysqli_close($con);
 ?>
