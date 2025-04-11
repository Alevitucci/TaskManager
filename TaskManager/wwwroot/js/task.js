var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/task/getall' },
        "columns": [
            { data: 'id'},
            { data: 'taskName', "width": "15%" },
            { data: 'description', "width": "15%" },
            { data: 'scheduler', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group"> 
                    <a href="/admin/product/upsert?Id=${data}" class="btn btn-secondary mx-2">Aggiornare</a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2">Cancellare</a></div>`
                }, "width": "15%" }
        ] //Nel href si passa l'upsert con l'id dell'elemento
    });
}

function Delete(url) {
    Swal.fire({
        title: "Confermare?",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sì"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                }
            })
        }
    })
}