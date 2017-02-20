<?php
include 'components/sql.php';  

function AddField($field, $label, $value, $required=false, $hidden=false)
{
    if ($hidden)
        echo "<tr style='display:none;'><td>";
    else
        echo "<tr><td>";
    echo $label;
    echo "</td><td style='padding-left: 8px;'>";
    echo "<input id='" . $field . "' ";
    if ($required)
        echo "data-validate data-validate-required data-validate-message='The field is required' ";
    echo "value='" . $value . "' ";
    echo "type='text'></input></td></tr>\n";
}

function AddNumericField($field, $label, $value, $required=false, $minvalue, $maxvalue)
{
    echo "<tr><td>";
    echo $label;
    echo "</td><td style='padding-left: 8px;'>";
    echo "<input id='" . $field . "' data-validate data-validate-type='number' ";
    if ($required)
        echo "data-validate-required data-validate-message='Dit veld moet een getal bevatten.' ";
    else
        echo "data-validate-message='Invalid number' ";
    echo "data-validate-min='" . $minvalue . "' ";
    echo "data-validate-max='" . $maxvalue . "' ";
    echo "value='" . $value . "' ";
    echo "type='text'></input></td></tr>\n";
}
    
function Get($row, $field)
    {
        if (isset($row[$field]))
            return $row[$field];
        else
            return '';
    }

    echo "<form id='ProductEditor'><table id='Product'>";

    $artnr = $_GET["artnr"];  
    if ($artnr=="") {
        $row = array();
    }
    else {
        $result = mysqli_query($con, "SELECT * FROM overigeproducten WHERE artnr=" . $artnr);
        $row = mysqli_fetch_array($result);
    }
    
    AddField("artnr", "Artikelnummer", Get($row, 'artnr'), false, true);
    AddField("omschrijving", "Omschrijving",  Get($row, 'omschrijving'), true);
    AddField("verstreenheid", "Verstreenheid",  Get($row, 'verstreenheid'), true);
    AddField("besteleenheid", "Besteleenheid",  Get($row, 'besteleenheid'), true);
    AddNumericField("crednr", "Creditnummer",  Get($row, 'crednr'), true, 0, 100000);
    AddField("serieletter", "Serieletter",  Get($row, 'serieletter'), true);
    AddField("systeemdeelletter", "Systeemdeelletter",  Get($row, 'systeemdeelletter'), true);
    AddNumericField("gewenstevoorraad", "Gewenste Voorraad",  Get($row, 'gewenstevoorraad'), true, 0, 100000);
    AddNumericField("verpakkingsfactor", "Verpakkingsfactor",  Get($row, 'verpakkingsfactor'), true, 0, 100000);
    AddNumericField("bestelniveau", "Bestelniveau",  Get($row, 'bestelniveau'), true, 0, 100000);
    AddNumericField("wekenvoorraad", "Wekenvoorraad",  Get($row, 'wekenvoorraad'), true, 0, 100000);
    AddNumericField("brutoprijs", "Brutoprijs",  Get($row, 'brutoprijs'), true, 0, 100000);
    AddNumericField("schapcode", "Schapcode",  Get($row, 'schapcode'), true, 0, 100000);
    AddNumericField("lopendevoorraad", "Lopendevoorraad",  Get($row, 'lopendevoorraad'), true, 0, 100000);

    echo "</table></form>";
    
    mysqli_close($con);
?>

