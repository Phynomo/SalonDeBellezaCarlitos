$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navServicioxProducto').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrió un error al realizar la operación!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operación se realizo con exito!");
    }
});

function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_serv_Nombre").attr('hidden', true);
    $("#lbl_prod_Nombre").attr('hidden', true);

}

function GuardarModalCreate() {
    var serv_Nombre = $('#serv_Nombre').val();
    var prod_Nombre = $('#prod_Nombre').val();

    $("#lbl_serv_Nombre").attr('hidden', true);
    $("#lbl_prod_Nombre").attr('hidden', true);

    if (serv_Nombre != "" && prod_Nombre != "") {
        $("#formCreate").submit();

    } else {
        MostrarMensajeWarning("Llene todos los campos");
        if (serv_Nombre == "") {
            $("#lbl_serv_Nombre").attr('hidden', false);
        }
        if (serv_Descripcion == "") {
            $("#lbl_prod_Nombre").attr('hidden', false);
        }
    }
}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#spro_Id_Edit").val(data[0]);
    $("#serv_Id_Edit").val(data[1]);
    $("#prod_Id_Edit").val(data[2]);
    $("#EditarServicioxProducto").appendTo('body').modal('show');
};

function GuardarModalEdit() {
    var serv_Nombre = $('#serv_Nombre_Edit').val();
    var prod_Nombre = $('#prod_Nombre_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (serv_Nombre != "" && prod_Nombre != "") {
        $("#formEdit").submit();

    } else {
        MostrarMensajeWarning("Llene todos los campos");
        if (serv_Nombre == "") {
            $("#lbl_serv_Nombre_Edit").attr('hidden', false);
        }
        if (prod_Nombre == "") {
            $("#lbl_prod_Nombre_Edit").attr('hidden', false);
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


function tumama() {
    $("#modalCreate").appendTo('body').modal('show');
}