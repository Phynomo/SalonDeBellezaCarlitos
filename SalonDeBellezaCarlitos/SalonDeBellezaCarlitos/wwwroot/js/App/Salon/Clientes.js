function AbrirModalCreate() {
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var clie_Nombre = $('#clie_Nombre').val();
    var clie_Apellido = $('#clie_Apellido').val();
    var clie_Telefono = $('#clie_Telefono').val();
    var clie_CorreoElectronico = $('#clie_CorreoElectronico').val();

    $("#lbl_clie_Nombre").attr('hidden', true);
    $("#lbl_clie_Apellido").attr('hidden', true);
    $("#lbl_clie_Telefono").attr('hidden', true);
    $("#lbl_clie_CorreoElectronico").attr('hidden', true);

    if (clie_Nombre != "" && clie_Apellido != "" && clie_Telefono != "" && clie_CorreoElectronico != "") {

        $("#formCreate").submit();

    } else {
        if (clie_Nombre == "") {
            $("#lbl_clie_Nombre").attr('hidden', false);
        }
        if (clie_Apellido == "") {
            $("#lbl_clie_Apellido").attr('hidden', false);
        }
        if (clie_Telefono == "") {
            $("#lbl_clie_Telefono").attr('hidden', false);
        }
        if (clie_CorreoElectronico == "") {
            $("#lbl_clie_CorreoElectronico").attr('hidden', false);
        }
    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    console.log('Hola');
    var data = datastring.split(',');
    $("#clie_Id_Edit").val(data[0]);
    $("#clie_Nombre_Edit").val(data[1]);
    $("#clie_Apellido_Edit").val(data[2]);
    $("#clie_Telefono_Edit").val(data[3]);
    $("#clie_CorreoElectronico_Edit").val(data[4]);
    $("#EditarCliente").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var clie_Nombre = $('#serv_Nombre_Edit').val();
    var clie_Apellido = $('#clie_Apellido_Edit').val();
    var clie_Telefono = $('#clie_Telefono_Edit').val();
    var clie_CorreoElectronico = $('#clie_CorreoElectronico_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (clie_Nombre != "" && clie_Apellido != "" && clie_Telefono != "" && clie_CorreoElectronico != "") {
        $("#formEdit").submit();

    } else {
        if (clie_Nombre == "") {
            $("#lbl_NombreEditError").attr('hidden', false);
        }
        if (clie_Apellido == "") {
            $("#lbl_ApellidoEditError").attr('hidden', false);
        }
        if (clie_Telefono == "") {
            $("#lbl_TelefonoEditError").attr('hidden', false);
        }
        if (clie_CorreoElectronico == "") {
            $("#lbl_CorreoEditError").attr('hidden', false);
        }
    }

}

function AbrirModalDelete(id) {
    console.log(id);
    $("#clie_Id_Delete").val(id);
    $("#EliminarCliente").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var clie_Descripcion = $('#clie_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (clie_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
