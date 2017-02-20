function ReloadPage() {
    window.location.href = window.location.href;
}

var isNewProduct = false;
var ProductValidator = null;

function EditProduct(artnr, omschrijving) {
    // find the popup, initialize the title
    var popup = $('#ProductPopup');
    $('#Title', popup).html(omschrijving);
    isNewProduct = artnr == '';
    // retrieve drug details from drug.php?id=...
    $.ajax({
        url: 'product.php?artnr=' + artnr,
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
    ProductValidator = new Validator({
        container: '#ProductEditor',
        invalidClass: 'invalid'
    });
}

// Checks whether the form is valid
function Validate() {
    return true;
}

function SaveProduct() {
    if (!validator.validate())
        return;

    // find the popup and get field values
    var popup = $('#ProductPopup');
    var editor = $('#ProductEditor');

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
    var url = 'productsave.php?' +
              'operation=' + (isNewProduct ? 'insert&' : 'update&') +
              getField('artnr') +
              getField('omschrijving') +
              getField('verstreenheid') +
              getField('besteleenheid') +
              getField('crednr') +
              getField('serieletter') +
              getField('systeemdeelletter') +
              getField('gewenstevoorraad') +
              getField('verpakkingsfactor') +
              getField('bestelniveau') +
              getField('wekenvoorraad') +
              getField('brutoprijs') +
              getField('schapcode') +
              getField('lopendevoorraad');

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

//XML
function DownloadProducten() {
    window.location.href = 'productxml.php?count=&order=Id';
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

    $("#ProductTable").DataTable(options);
    $("#ProductTable").show();
}