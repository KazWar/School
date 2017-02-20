 <?php include("menu.php"); ?>
<h2>
    <span style="margin-right: 16px;">Medicijnen</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="CreateDepartmentOrder()" title="Order Aanmaken">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>&nbsp;<span>Order Aanmakken</span>
        </button>
    </div>
</h2>


<div id="DrugsPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con,"SELECT * FROM medicijnen");

    echo "<table id='DepartmentDrugsTable' border='1' bgcolor='white' style='display:none'>
                        <thead>
                            <tr>
                                <td>Id</td>
                                <td>Naam</td>
                                <td>Geregistreerd of Generiek</td>
                                <td>Recept of Zelfzorg</td>
                                <td>BCG of EU</td>
                                <td>Homeopatisch</td>
                                <td>FNA</td>
                                <td>Toedieningsvorm</td>
                                <td>Bestelgrootte</td>
                                <td>Bestelniveau</td>
                                <td>Doelvoorraad</td>
                                <td>Schapcode</td>
                                <td>Verrekenprijs</td>
                                <td>Prijs (&#8364;)</td>
                                <td>Voorraad</td>
                                <td>Datum</td>
                            </tr>
                        </thead>
                        
                        <tbody>";

    while($row = mysqli_fetch_array($result)) {
        echo "<tr>";
        echo "<td nowrap>" . $row['id'] . "</td>";
        echo "<td nowrap>" . $row['Naam'] . "</td>";
        echo "<td nowrap>" . $row['GeregistreerdOfGeneriek'] . "</td>";
        echo "<td nowrap>" . $row['ReceptOfZelfzorg'] . "</td>";
        echo "<td nowrap>" . $row['BCGofEU'] . "</td>";
        echo "<td nowrap>" . $row['Homeopatisch'] . "</td>";
        echo "<td nowrap>" . $row['FNA'] . "</td>";
        echo "<td nowrap>" . $row['Toedieningsvorm'] . "</td>";
        echo "<td nowrap>" . $row['Bestelgrootte'] . "</td>";
        echo "<td nowrap>" . $row['Bestelniveau'] . "</td>";
        echo "<td nowrap>" . $row['Doelvoorraad'] . "</td>";
        echo "<td nowrap>" . $row['Schapcode'] . "</td>";
        echo "<td nowrap>" . $row['Verrekenprijs'] . "</td>";
        echo "<td nowrap>" . $row['Prijs'] . "</td>";
        echo "<td nowrap>" . $row['Voorraad'] . "</td>";
        echo "<td nowrap>" . $row['Datum'] . "</td>";
        echo "</tr>";
    }

    echo "</tbody></table>";
    
    mysqli_close($con);
    ?>
</div>

<script>
   $(document).ready(function() {
        RenderDepartmentDrugsTable();
   });  

</script>

<?php include("footer.php"); ?>

