function RenderDepartmentOrderTable() {
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
        }
    };

    $("#DepartmentOrderTable").DataTable(options);
    $("#DepartmentOrderTable").show();
}


function DownloadDepartmentOrders() {
    window.location.href = 'drugsxml.php?count=10&order=Id';
}