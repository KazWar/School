 <?php include("menu.php"); ?>
<h2>
    <span style="margin-right: 16px;">Orders</span>
</h2>


<div id="DrugsPanel">
    <table id='DepartmentOrdersTable' border='1' bgcolor='white'>
        <thead>
            <tr>
                <td>Id</td>
                <td>Datum</td>
                <td>Status</td>
                <td>Items</td>
            </tr>
        </thead>
        <tbody>
         <?php
            include 'components/sql.php';
            // retrieve all orders, sort by creation date descending, to see the newest first
            $orders = mysqli_query($con, "SELECT * FROM `middenpolder voorrraadbeheer`.departmentorder ORDER BY id DESC");

            while($order = mysqli_fetch_array($orders)) { 
              $orderid = $order["id"];
              // create a table row for each order
              echo "<tr>\n";
              echo "  <td>" . $order["id"]  . "</td>\n";
              echo "  <td>" . $order["created"] . "</td>\n";
              echo "  <td>" . ($order["status"]==1 ? "Afgerond" : "In bewerking") . "</td>\n";
              echo "  <td>";
              // retrieve items that belong to the order
              $sql = "SELECT item.id, item.orderid, item.productid, item.quantity, drug.Naam as name
                                           FROM `middenpolder voorrraadbeheer`.departmentorderitem as item
                                           INNER JOIN `middenpolder voorrraadbeheer`.medicijnen as drug ON drug.id = item.productid
                                           where orderid=$orderid order by id";
              $items = mysqli_query($con, $sql);
              if (!$items) {
                die('Error: ' . mysqli_error($con) . ", query " . $sql);
              }
              // list these items in the order row, in last column
              while($item = mysqli_fetch_array($items)) {
                echo "<div>\n";
                echo "  <div class='orderitemname'>";
                echo $item["name"]; 
                echo "</div>\n";
                echo "  <div class='orderitemquantity'>";
                echo $item["quantity"];
                echo "</div>\n";
                echo "</div>\n";
              }
              
              echo "  </td>\n";
              echo "</tr>\n";
           }
    
            mysqli_close($con);
         ?>
        </tbody>
    </table>

 </div>

 
<script>
   $(document).ready(function() {
        RenderDepartmentOrdersTable();
   });  
</script>

<?php include("footer.php"); ?>

