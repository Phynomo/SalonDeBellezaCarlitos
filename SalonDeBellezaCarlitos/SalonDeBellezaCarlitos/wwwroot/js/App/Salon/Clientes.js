﻿$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navClientes').addClass('active');
    $('#subnavSalon').addClass('show');
    
    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrió un error al realizar la operación!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operación se realizo con exito!");
    }
});
function AbrirModalCreate() {
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_clie_Nombre").attr('hidden', true);
    $("#lbl_clie_Apellido").attr('hidden', true);
    $("#lbl_clie_Telefono").attr('hidden', true);
    $("#lbl_clie_CorreoElectronico").attr('hidden', true);

    var input = document.getElementById("clie_Nombre",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });

    var input = document.getElementById("clie_Apellido",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
}

function soloNumeros(event) {
    var charCode = event.keyCode || event.which;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        event.preventDefault();
        return false;
    }
    return true;
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
        MostrarMensajeWarning("Llene todos los campos");
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
    var data = datastring.split(',');
    $("#clie_Id_Edit").val(data[0]);
    $("#clie_Nombre_Edit").val(data[1]);
    $("#clie_Apellido_Edit").val(data[2]);
    $("#clie_Telefono_Edit").val(data[3]);
    $("#clie_CorreoElectronico_Edit").val(data[4]);
    $("#EditarCliente").appendTo('body').modal('show');

    var input = document.getElementById("clie_Nombre_Edit",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });

    var input = document.getElementById("clie_Apellido_Edit",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
};


function GuardarModalEdit() {
    var clie_Nombre = $('#clie_Nombre_Edit').val();
    var clie_Apellido = $('#clie_Apellido_Edit').val();
    var clie_Telefono = $('#clie_Telefono_Edit').val();
    var clie_CorreoElectronico = $('#clie_CorreoElectronico_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (clie_Nombre != "" && clie_Apellido != "" && clie_Telefono != "" && clie_CorreoElectronico != "") {
        $("#formEdit").submit();

    } else {
        MostrarMensajeWarning("Llene todos los campos");
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
