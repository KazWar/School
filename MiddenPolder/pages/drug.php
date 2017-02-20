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

function AddCheckBox($field, $label, $value)
{
    echo "<tr><td>";
    echo $label;
    echo "</td><td style='padding-left: 8px;'>";
    echo "<input id='";
    echo $field;
    echo "' ";
    if ($value == 'TRUE') {
        echo "checked='checked' ";
    }
    echo " type='checkbox'></input></td></tr>\n";
}

function AddDropdown($field, $label, $selected, $values, $labels)
{
    echo "<tr><td>";
    echo $label;
    echo "</td><td id='dropdown' style='padding-left: 8px;'>\n";
    echo "<select id='" . $field . "'>\n";
    for ($i=0; $i < count($values); $i++) {
        $label = $labels[$i];
        $value = $values[$i];
        echo "<option value='" . $value . "' ";
        if ($value == $selected)
            echo "selected ";
        echo ">" . $label . "</option>\n";
    }
    echo "</select></td></tr>\n";
}

function Get($row, $field)
{
    if (isset($row[$field]))
        return $row[$field];
    else
        return '';
}

    echo "<form id='DrugEditor'><table id='Drug'>";

    $drugid = $_GET["id"];  
    if ($drugid=="") {
        $row = array();
    }
    else {
        $result = mysqli_query($con, "SELECT * FROM medicijnen WHERE id=" . $drugid);
        $row = mysqli_fetch_array($result);
    }
    
    AddField("id", "id",  Get($row, 'id'), false, true);
    AddField("Naam", "Naam",  Get($row, 'Naam'), true);
    AddDropdown("GeregistreerdOfGeneriek", "Generiek?",  Get($row, 'GeregistreerdOfGeneriek'), ['Ger', 'Gen'], ['Geregistreerd', 'Generiek']);
    AddDropdown("ReceptOfZelfzorg", "Recept?",  Get($row, 'ReceptOfZelfzorg'), ['R', 'Z'], ['Recept', 'Zelfzorg']);
    AddDropdown("BCGofEU", "BCG of EU?",  Get($row, 'BCGofEU'), ['BCG', 'EU'], ['BCG', 'EU']);
    AddCheckbox("Homeopatisch", "Homeopatisch",  Get($row, 'Homeopatisch'));
    AddCheckbox("FNA", "FNA",  Get($row, 'FNA'));
    AddField("Toedieningsvorm", "Toedieningsvorm",  Get($row, 'Toedieningsvorm'), true);
    AddNumericField("Bestelgrootte", "Bestelgrootte",  Get($row, 'Bestelgrootte'), true, 0, 100000);
    AddNumericField("Bestelniveau", "Bestelniveau",  Get($row, 'Bestelniveau'), true, 0, 100000);
    AddNumericField("Doelvoorraad", "Doelvoorraad",  Get($row, 'Doelvoorraad'), true, 0, 100000);
    AddNumericField("Schapcode", "Schapcode",  Get($row, 'Schapcode'), true, 0, 100000000);
    AddNumericField("Verrekenprijs", "Verrekenprijs &#8364;",  Get($row, 'Verrekenprijs'), true, 0, 1000000);
    AddNumericField("Prijs", "Prijs &#8364;",  Get($row, 'Prijs'), true, 0, 1000000);
    AddNumericField("Voorraad", "Voorraad",  Get($row, 'Voorraad'), true, 0, 10000);

    echo "</table></div></form>";
    
    mysqli_close($con);
?>

