<?php include("menu.php"); ?>

<h2>
    <span style="margin-right: 16px;">Bestellen Medicijnen</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="SendDepartmentOrder()">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>&nbsp;<span>Verzenden</span>
        </button>
        <button class="btn btn-warning" onclick="CancelDepartmentOrder()">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>&nbsp;<span>Annuleren</span>
        </button>
    </div>
</h2>

<div id="OrderPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con, "SELECT *, `doelvoorraad` - `voorraad` as `TeBestellen` FROM `middenpolder voorrraadbeheer`.medicijnen
                                  where id in (" . $_GET["id"] . ")");

    ?>
    
    <table id="OrderTable">
        <thead>
            <tr>
                <td>Product ID</td>
                <td>Naam</td>
                <td>Aantal</td>
            </tr>
        </thead>
        <tbody>
        
     <?php
       while($row = mysqli_fetch_array($result)) { 
         echo "<tr>";
         echo "<td>" . $row["id"]  . "</td>";
         echo "<td>" . $row["Naam"] . "</td>";
         echo "<td>";
         echo "<input id='" . $row["id"] . "' type='text' value='" . $row["Bestelgrootte"] . "' />";
         echo "</td>";
         echo "</tr>";
       }
     ?>
     
     </tbody>
    </table>
</div>

<script>
   $(document).ready(function() {
        RenderOrderTable();
   });  
</script>

<?php include("footer.php"); ?>



