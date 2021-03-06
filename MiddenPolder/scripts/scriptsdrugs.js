﻿function ReloadPage() {
    window.location.href = window.location.href;
}

var isNewDrug = false;
var drugValidator = null;

function EditDrug(id, name) {
    // find the popup, initialize the title
    var popup = $('#DrugPopup');
    $('#Title', popup).html(name);
    isNewDrug = id == '';
    // retrieve drug details from drug.php?id=...
    $.ajax({
        url: 'drug.php?id=' + id,
        cache: false,
        dataType: 'html'
    }).success(function (data) {
        // when ready, insert the received HTML table into the fields container inside the popup
        $('#Fields', popup).html(data);
        window.setTimeout(function () {
            SetupValidation();
        }, 100);
        // now display the popup
        popup.modal({
            keyboard: true,
        });
    });

}

// Sets up field validators (uses jquery.validate plugin)
function SetupValidation() {
    drugValidator = new Validator({
        container: '#DrugEditor',
        invalidClass: 'invalid'
    });
}

// Checks whether the form is valid
function Validate() {
    return true;
}

function SaveDrug() {
    if (!validator.validate())
        return;

    // find the popup and get field values
    var popup = $('#DrugPopup');
    var editor = $('#DrugEditor')

    // Function returns a value in the specified field
    function getValue(field) {
        var control = $('#' + field, popup);
        if (control.attr('type') == 'checkbox') {
            return control.is(':checked') ? "TRUE" : "FALSE";
        }
        else {
            return control.val();
        }
    }

    // Function returns a query string parameter containing the specified field
function getField(field) {
        return field + '=' +  getValue(field) + '&';
    }

    // Create URL for saving or inserting the data
    var url = 'drugsave.php?' +
              'operation=' + (isNewDrug ? 'insert&' : 'update&') +
              getField('id') +
              getField('Naam') +
              getField('GeregistreerdOfGeneriek') +
              getField('ReceptOfZelfzorg') +
              getField('BCGofEU') +
              getField('Homeopatisch') +
              getField('FNA') +
              getField('Toedieningsvorm') +
              getField('Bestelgrootte') +
              getField('Bestelniveau') +
              getField('Doelvoorraad') +
              getField('Schapcode') +
              getField('Verrekenprijs') +
              getField('Prijs') +
              getField('Voorraad');
    
    // Send to the server
    $.ajax({
        url: url,
        cache: false,
    }).success(function (data) {
        // on return just hide the popup and reload the page
        if (data.indexOf('Error') == -1) {
            popup.modal('hide');
            ReloadPage();
        }
        else {
            alert(data);
        }
    });
}


function DownloadDrugs() {
    window.location.href = 'drugsxml.php?count=10&order=Id';
}

function RenderDrugsTable() {
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
                "next": "Volgende Pagina"
            }
        },
    };

    $("#DrugsTable").DataTable(options);
    $("#DrugsTable").show();
}

function RenderDepartmentDrugsTable() {
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
                "next": "Volgende Pagina"
            }
        },
        dom: 'T<"clear">lfrtip',
        tableTools: {
            "sRowSelect": "multi",
            "aButtons": ["select_all", "select_none"]
        }
    };

    $("#DepartmentDrugsTable").DataTable(options);
    $("#DepartmentDrugsTable").show();
}