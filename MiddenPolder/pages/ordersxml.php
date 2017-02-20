<?php
    header('Content-Type: application/xml');
    header('Content-Disposition: attachment; filename=orders.xml');
    include 'components/sql.php';
     
    // Create the XML document
    echo "<?xml version='1.0'?>\n";
    echo "<orders>\n";
    
    $sql = "SELECT * FROM `middenpolder voorrraadbeheer`.order where id in (" . $_GET["orders"] . ")";
    $orders = mysqli_query($con, $sql);
    if (!$orders) {
        die('Error: ' . mysqli_error($con) . ", query " . $sql);
    }
    
    while($order = mysqli_fetch_array($orders)) { 
        $orderid = $order["id"];
        // create xml node row for each order
        echo "<order>\n";
        echo "  <id>" . $order["id"]  . "</id>\n";
        echo "  <created>" . $order["created"] . "</created>\n";
        echo "  <status>" . $order["status"] . "</status>\n";
        // retrieve items that belong to the order
        $sql = "SELECT item.id, item.orderid, item.productid, item.quantity, drug.Naam as name
                                    FROM `middenpolder voorrraadbeheer`.orderitem as item
                                    INNER JOIN `middenpolder voorrraadbeheer`.medicijnen as drug ON drug.id = item.productid
                                    where orderid=$orderid order by id";
        $items = mysqli_query($con, $sql);
        if (!$items) {
            die('Error: ' . mysqli_error($con) . ", query " . $sql);
        }
        // create xml node with order items
        echo "<products>\n";
        while($item = mysqli_fetch_array($items)) {
            echo "<product>\n";
                echo "<id>" . $item["productid"] . "</id>"; 
                echo "<name>" . $item["name"] . "</name>"; 
                echo "<quantity>" . $item["quantity"] . "</quantity>";
            echo "</product>\n";
        }
        echo "</products>\n";
        echo "</order>\n";
    }
    
        // close the XML document
    echo "</orders>\n";

    // Disconnect from the database
    mysqli_close($con);
    
    // SAMPLE URL:
    // http://localhost/MiddenPolder/pages/ordersxml.php?orders=id1,id2,id3
    /*
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
    */
 ?>
