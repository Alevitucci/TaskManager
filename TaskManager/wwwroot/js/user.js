var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { data: 'id' },
            { data: 'name', "width": "15%"},
            { data: 'email', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'company.name', "width": "15%" },
            { data: 'role', "width": "15%" },
            {
                data: { id: 'id', lockoutEnd: "lockoutEnd" },
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        return `<div class="text-center"> 
                                            <a href="/admin/user/RoleManagement?userId=${data.id}" class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                    <i class="bi bi-unlock-fill">Bloccare</i></a>                       
                    <a href="/admin/user/RoleManagement?userId=${data.id}" class="btn btn-success text-white" style = "cursor:pointer; width:100px;">
                    <i class="bi bi-pencil-square">Permessi</a>
                    </div>`
                    } else {
                        return `<div class="text-center"> 
                        <a href="/admin/user/RoleManagement?userId=${data.id}" class="btn btn-success text-white" style="cursor:pointer; width:100px;">
                    <i class="bi bi-unlock-fill">Sbloccare</i></a>
                    <a href="/admin/user/RoleManagement?userId=${data.id}" class="btn btn-success text-white" style = "cursor:pointer; width:100px;">
                                <i class="bi bi-pencil-square">Permessi</a>
                    </div>`
                    }
                   
                }, "width": "25%" }
        ]
    });
}

function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: '/Admin/User/LockUnlock',
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                dataTable.ajax.reload();
                var li = document.createElement("li");
                document.getElementById("messagesList").appendChild(li);
                li.textContent = `Confermato`;
            }
        }
    });
}