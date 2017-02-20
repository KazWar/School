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
// Retrieve values to save from the query string
// list of product identifiers, passed to the page as comma-separated list under id= parameter
$ids = explode(",", mysqli_real_escape_string($con, Get($_GET, 'id'))); 
// list of product quantities, passed to the page as comma-separated list under quantity= parameter
$quantities = explode(",", mysqli_real_escape_string($con, Get($_GET, 'quantity')));

// INSERT NEW ORDER
 $sql = "insert into `middenpolder voorrraadbeheer`.`departmentorder` (`created`) VALUES (now())";
    if (!mysqli_query($con, $sql)) {
        die('Error: ' . mysqli_error($con));
    } else 
    {
        // retrieve the identifier of the newly inserted order
        $orderid = mysqli_insert_id($con);
        echo $orderid;
    }

// INSERT ORDER ITEMS
$i = 0;
// Loop over product identifiers
foreach ($ids as $productid) {
    // get associated quantity
    $quantity = $quantities[$i];
    $i = $i + 1;
    // create order item, linked to the just-saved order
    $sql = "insert into `middenpolder voorrraadbeheer`.`departmentorderitem` (`orderid`, `productid`, `quantity`) 
            VALUES ($orderid, $productid, $quantity)";
    if (!mysqli_query($con, $sql)) {
        die('Error: ' . mysqli_error($con) . ", query " . $sql);
    } else 
    {
    }
}


 mysqli_close($con);
?>
