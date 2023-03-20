function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_serv_Nombre").attr('hidden', true);
    $("#lbl_prod_Nombre").attr('hidden', true);

    var input = document.getElementById("serv_Nombre",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
    var input = document.getElementById("prod_Nombre",);
    input.addEventListener("keydown", function (event) {
        var key = event.key; 

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
}

function GuardarModalCreate() {
    var serv_Nombre = $('#serv_Nombre').val();
    var prod_Nombre = $('#prod_Nombre').val();

    $("#lbl_serv_Nombre").attr('hidden', true);
    $("#lbl_prod_Nombre").attr('hidden', true);

    if (serv_Nombre != "" && prod_Nombre != "") {
        $("#formCreate").submit();

    } else {
        if (serv_Nombre == "") {
            $("#lbl_serv_Nombre").attr('hidden', false);
        }
        if (serv_Descripcion == "") {
            $("#lbl_prod_Nombre").attr('hidden', false);
        }
    }
}

function AbrirModalDelete(id) {
    $("#spro_Id_Delete").val(id);
    $("#EliminarServicioXProducto").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var serv_Id_Delete = $('#spro_Id_Delete').val();
    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (serv_Id_Delete != "") {
        $("#formDelete").submit();

    } else {
        if (serv_Id_Delete == "") {
            $("#lbl_DescripcionDeleteError").attr('hidden', false);
        }

    }

}