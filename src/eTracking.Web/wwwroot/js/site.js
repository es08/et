// Write your Javascript code.
function validateKnockoutForm(form) {
    form.removeData('validator');
    form.removeData('unobtrusiveValidation');
    $.validator.unobtrusive.parse(form);
    form.validate();
}

function DataTableInit(tableId, disableIndex, reportName) {
    var date = new Date();
    var str = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + "_" + date.getMinutes() + "_" + date.getSeconds();

    if (disableIndex) {
        return $('#' + tableId).DataTable({
            responsive: true,
            "aoColumnDefs": [
                { 'bSortable': false, 'aTargets': [disableIndex] }],
            "columnDefs": [{
                "targets": 6,
                "orderable": false
            }],
           // dom: 'Bfrtip',
            buttons: [
                {
                    extend: 'copyHtml5',
                    exportOptions: {
                        columns: function (i) {
                            return i < disableIndex;
                        }
                    }
                },
                {
                    extend: 'excelHtml5',
                    title: reportName + ' วันที่ ' + str,
                    exportOptions: {
                        columns: function (i) {
                            return i < disableIndex;
                        }
                    }
                },
                {
                    extend: 'print',
                    exportOptions: {
                        columns: function (i) {
                            return i < disableIndex;
                        }
                    }
                }
            ]
        });
    }
    else {
        return $('#' + tableId).DataTable({
            responsive: true
        });
    }
}