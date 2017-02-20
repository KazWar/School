<?php include("menu.php"); ?>

<h2>
    <span style="margin-right: 16px;">Aankoopvoorstel Overigeproducten</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="DownloadAankoopB()" title="Aankoopvoorstel downloaden als XML bestand">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>
        </button>
    </div>
</h2>

<div id="SuggestionPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con,"SELECT *, `gewenstevoorraad` - `lopendevoorraad` as `TeBestellen` FROM `middenpolder voorrraadbeheer`.overigeproducten
where (`lopendevoorraad` <= `bestelniveau`) and (`gewenstevoorraad` - `lopendevoorraad` > 0)");

    echo "<table id='SuggestionTable' border='1' bgcolor='white' style='display:none;'>
                        <thead>
                            <tr>
                                <td>Artikelnummer</td>
                                <td>Omschrijving</td>
                                <td>Verstreenheid</td>
                                <td>Besteleenheid</td>
                                <td>Creditnummer</td>
                                <td>Gewenste Voorraad</td>
                                <td>Lopendevoorraad</td>
                                <td>Te Bestellen</td>
                                <td>Verpakkingsfactor</td>
                                <td>Bestelniveau</td>
                                <td>Wekenvoorraad</td>
                                <td>Schapcode</td>
                            </tr>
                        </thead>

                        <tbody>";

    while($row = mysqli_fetch_array($result)) {
        echo "<tr>";
        echo "<td nowrap>" . $row['artnr'] . "</td>";
        echo "<td nowrap>" . $row['omschrijving'] . "</td>";
        echo "<td nowrap>" . $row['verstreenheid'] . "</td>";
        echo "<td nowrap>" . $row['besteleenheid'] . "</td>";
        echo "<td nowrap>" . $row['crednr'] . "</td>";
        echo "<td nowrap>" . $row['gewenstevoorraad'] . "</td>";
        echo "<td nowrap>" . $row['lopendevoorraad'] . "</td>";
        echo "<td nowrap>" . $row['TeBestellen'] . "</td>";
        echo "<td nowrap>" . $row['verpakkingsfactor'] . "</td>";
        echo "<td nowrap>" . $row['bestelniveau'] . "</td>";
        echo "<td nowrap>" . $row['wekenvoorraad'] . "</td>";
        echo "<td nowrap>" . $row['schapcode'] . "</td>";
        echo "</tr>";
    }

    echo "</tbody></table>";
    
    mysqli_close($con);
    ?>
</div>

<script>
    $(function () {
        var options = {
            scrollCollapse: false,
            pageLength: 12,
            ordering: true,
            stateSave: true,
        };
        $("#SuggestionTable").DataTable(options);
        $("#SuggestionTable").show();
    });
</script>

<?php include("footer.php"); ?>

