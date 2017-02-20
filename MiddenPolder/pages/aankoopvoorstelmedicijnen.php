<?php include("menu.php"); ?>

<h2>
    <span style="margin-right: 16px;">Aankoopvoorstel Medicijnen</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="DownloadAankoopA()" title="Aankoopvoorstel downloaden als XML bestand">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>&nbsp;<span>Downloaden</span>
        </button>
        <button class="btn btn-success" onclick="CreateOrder()" title="Bestelling verzenden">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>&nbsp;<span>Bestellen</span>
        </button>
    </div>
</h2>

<div id="SuggestionPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con,"SELECT *, `doelvoorraad` - `voorraad` as `TeBestellen` FROM `middenpolder voorrraadbeheer`.medicijnen
where (`voorraad` <= `bestelniveau`) and (`doelvoorraad` - `voorraad` > 0)");

    echo "<table id='SuggestionTable' border='1' bgcolor='white' style='display:none;'>
                        <thead>
                            <tr>
                                <td>Id</td>
                                <td>Naam</td>
                                <td>Bestelgrootte</td>
                                <td>Bestelniveau</td>
                                <td>Doelvoorraad</td>
                                <td>Voorraad</td>
                                <td>Verschil</td>
                                <td>Schapcode</td>
                                <td>Verrekenprijs</td>
                                <td>Prijs</td>
                            </tr>
                        </thead>
                        
                        <tbody>";

    while($row = mysqli_fetch_array($result)) {
        echo "<tr>";
        echo "<td nowrap>" . $row['id'] . "</td>";
        echo "<td nowrap>" . $row['Naam'] . "</td>";
        echo "<td nowrap>" . $row['Bestelgrootte'] . "</td>";
        echo "<td nowrap>" . $row['Bestelniveau'] . "</td>";
        echo "<td nowrap>" . $row['Doelvoorraad'] . "</td>";
        echo "<td nowrap>" . $row['Voorraad'] . "</td>";
        echo "<td nowrap>" . $row['TeBestellen'] . "</td>";
        echo "<td nowrap>" . $row['Schapcode'] . "</td>";
        echo "<td nowrap>" . $row['Verrekenprijs'] . "</td>";
        echo "<td nowrap>" . $row['Prijs'] . "</td>";
        echo "</tr>";
    }

    echo "</tbody></table>";
    
    mysqli_close($con);
    ?>
</div>

<script>
   $(document).ready(function() {
        RenderSuggestionsTable();
   });  
</script>

<?php include("footer.php"); ?>



