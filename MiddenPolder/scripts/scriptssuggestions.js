function DownloadAankoopA() {
    window.location.href = 'aankoopxmlmedicijnen.php?count=&order=Id';
}

function DownloadAankoopB() {
    window.location.href = 'aankoopxmloverige.php?count=&order=Id';
}

function RenderSuggestionsTable() {
    var options = {
        scrollCollapse: false,
        pageLength: 12,
        ordering: true,
        stateSave: true,
        language: {
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

    $("#SuggestionTable").DataTable(options);
    $("#SuggestionTable").show();
}

function RenderOrderTable() {
    var options = {
        lengthChange: false,
        searching: false,
        ordering: false,
        paging: false,
        scrollCollapse: false,
        pageLength: 12,
    };
    $("#OrderTable").DataTable(options);
    $("#OrderTable").show();
}

function RenderDepartmentOrdersTable() {
    var options = {
        lengthChange: true,
        searching: true,
        ordering: true,
        paging: true,
        scrollCollapse: false,
        pageLength: 12,
        language: {
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
        }
        
    };
    $("#DepartmentOrdersTable").DataTable(options);
    $("#DepartmentOrdersTable").show();
}

function CreateOrder() {
    var table = TableTools.fnGetInstance('SuggestionTable');
    var data = table.fnGetSelectedData();
    var identifiers = [];
    for (var i = 0; i < data.length; i++) {
        identifiers.push(data[i][0]);
    }
    if (identifiers.length > 0) {
        var url = 'bestellenmedicijnen.php?id=' + identifiers.join(',');
        window.location = url;
    }
}

function CancelOrder() {
    window.location = 'aankoopvoorstelmedicijnen.php';
}

function SendOrder() {
    // collect IDs and values
    var inputs = $('input[type="text"]');
    var identifiers = [];
    var quantities = [];
    inputs.each(function (index, input) {
        var id = $(input).attr('id');
        var quantity = $(input).val();
        identifiers.push(id);
        quantities.push(quantity);
    });
    // send to a page which will save the order
    var url = 'drugordersave.php?id=' + identifiers.join(',') + '&quantity=' + quantities.join(',');
    $.ajax({
        url: url,
        cache: false,
    }).success(function (data) {
       window.location = 'orders.php';
    });
    
}

function DownloadOrders() {
    var table = TableTools.fnGetInstance('OrdersTable');
    var data = table.fnGetSelectedData();
    var identifiers = [];
    for (var i = 0; i < data.length; i++) {
        identifiers.push(data[i][0]);
    }
    if (identifiers.length > 0) {
        var url = 'ordersxml.php?orders=' + identifiers.join(',');
        window.location.href = url;
    }
}

/* Afdeling orders aanmaak */

function CreateDepartmentOrder() {
    var table = TableTools.fnGetInstance('DepartmentDrugsTable');
    var data = table.fnGetSelectedData();
    var identifiers = [];
    for (var i = 0; i < data.length; i++) {
        identifiers.push(data[i][0]);
    }
    if (identifiers.length > 0) {
        var url = 'aanmaakafdelingorder.php?id=' + identifiers.join(',');
        window.location = url;
    }
}

function CancelDepartmentOrder() {
    window.location = 'noEditDrugs.php';
}

function SendDepartmentOrder() {
    // collect IDs and values
    var inputs = $('input[type="text"]');
    var identifiers = [];
    var quantities = [];
    inputs.each(function (index, input) {
        var id = $(input).attr('id');
        var quantity = $(input).val();
        identifiers.push(id);
        quantities.push(quantity);
    });
    // send to a page which will save the order
    var url = 'afdelingdrugordersave.php?id=' + identifiers.join(',') + '&quantity=' + quantities.join(',');
    $.ajax({
        url: url,
        cache: false,
    }).success(function (data) {
        window.location = 'afdelingorders.php';
    });

}
