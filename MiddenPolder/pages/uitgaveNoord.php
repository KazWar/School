 <?php include("menu.php"); ?>
<h2>
    <span style="margin-right: 16px;">Bestellingen afdelingen</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="EditDepartmentOrder('', 'Nieuwe bestelling toevoegen')" title="Nieuwe bestelling toevoegen">
            <span class="glyphicon glyphicon-plus"></span>
        </button>
        <button class="btn btn-success" onclick="DownloadDepartmentOrder()" title="bestellingen als XML downloaden">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>
        </button>
    </div>
</h2>


<div id="DrugsPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con,"SELECT * FROM medicijnen");

    echo "<table id='DepartmentOrderTable' border='1' bgcolor='white' style='display:none;'>
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
        echo "<tr onclick='EditDrug(" . $row['id'] . ", \"" . $row['Naam'] . "\")'>";
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

<div class="modal fade" id="DepartmentOrderPopup">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                <h3 class="modal-title">
                    <span class="glyphicon glyphicon-th-list"></span>
                    <span id="Title">Details</span>
                </h3>
            </div>
            <div class="modal-body" id="Fields">
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-primary" data-dismiss="modal">Sluiten</button>
                <button class="btn btn-success" type="button" onclick="SaveDepartmentOrder()">Opslaan</button>
            </div>
        </div>
    </div>
</div>

<script>
   $(document).ready(function() {
        RenderDepartmentOrderTable();
   });  

</script>

<?php include("footer.php"); ?>

