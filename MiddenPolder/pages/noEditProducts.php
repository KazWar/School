<?php include("menu.php"); ?>

<h2>
    <span style="margin-right: 16px;">Overige Producten</span>
    <div class="btn-group">
        <button class="btn btn-success" onclick="EditProduct('', 'Nieuw product toevoegen')" title="Nieuw product toevoegen">
            <span class="glyphicon glyphicon-plus"></span>
        </button>
        <button class="btn btn-success" onclick="DownloadProducten()" title="Producten als XML downloaden">
            <span class="glyphicon glyphicon-circle-arrow-down"></span>
        </button>
    </div>
</h2>


<div id="ProductPanel">
    <?php
    include 'components/sql.php';
    
    $result = mysqli_query($con,"SELECT * FROM overigeproducten");

    echo "<table id='ProductTable' border='1' bgcolor='white' style='display:none;'>
                        <thead>
                            <tr>
                                <td>Artikelnummer</td>
                                <td>Omschrijving</td>
                                <td>Verstreenheid</td>
                                <td>Besteleenheid</td>
                                <td>Creditnummer</td>
                                <td>Serieletter</td>
                                <td>Systeemdeelletter</td>
                                <td>Gewenste Voorraad</td>
                                <td>Verpakkingsfactor</td>
                                <td>Bestelniveau</td>
                                <td>Wekenvoorraad</td>
                                <td>Brutoprijs</td>
                                <td>Schapcode</td>
                                <td>Lopendevoorraad</td>
                                <td>Datum</td>
                            </tr>
                        </thead>
                        
                        <tbody>";

    while($row = mysqli_fetch_array($result)) {
        echo "<tr onclick='EditProduct(" . $row['artnr'] . ", \"" . $row['omschrijving'] . "\")'>";
        echo "<td nowrap>" . $row['artnr'] . "</td>";
        echo "<td nowrap>" . $row['omschrijving'] . "</td>";
        echo "<td nowrap>" . $row['verstreenheid'] . "</td>";
        echo "<td nowrap>" . $row['besteleenheid'] . "</td>";
        echo "<td nowrap>" . $row['crednr'] . "</td>";
        echo "<td nowrap>" . $row['serieletter'] . "</td>";
        echo "<td nowrap>" . $row['systeemdeelletter'] . "</td>";
        echo "<td nowrap>" . $row['gewenstevoorraad'] . "</td>";
        echo "<td nowrap>" . $row['verpakkingsfactor'] . "</td>";
        echo "<td nowrap>" . $row['bestelniveau'] . "</td>";
        echo "<td nowrap>" . $row['wekenvoorraad'] . "</td>";
        echo "<td nowrap>" . $row['brutoprijs'] . "</td>";
        echo "<td nowrap>" . $row['schapcode'] . "</td>";
        echo "<td nowrap>" . $row['lopendevoorraad'] . "</td>";
        echo "<td nowrap>" . $row['datum'] . "</td>";
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
            "language": {
                "search": "Zoeken:",
                "emptyTable": "Geen gegevens beschikbaar",
                "info": "Weergeven _START_ van _END_ van de _TOTAL_ gegevens",
                "infoFiltered": "(Gefilterd _MAX_ totale gegevens)",
                "infoEmpty": "Weergeven 0 van 0 van de 0 gegevens",
                "lengthMenu": "Weergeven _MENU_ Gegevens",
                "loadingRecords": "Laden...",
                "processing": "Berekenen...",
                "search": "Zoeken:",
                "zeroRecords": "Geen gegevens gevonden",
                "paginate": {
                    "previous": "Vorige Pagina",
                    "next":     "Volgende Pagina"
                }
            }
        };

        $("#ProductTable").DataTable(options);
        $("#ProductTable").show();
    });
</script>

<?php include("footer.php"); ?>