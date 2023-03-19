$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navCargos').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ese registro ya exite");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito");
    }
});


function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var usur_Usuario = $('#usur_Usuario').val();
    var usur_Contrasenia = $('#usur_Contrasenia').val();
    var empl_Id = $('#empl_Id').val();


    $("#lbl_usur_Usuario").attr('hidden', true);
    $("#lbl_usur_Contrasenia").attr('hidden', true);
    $("#lbl_empl_Id").attr('hidden', true);

    if (usur_Usuario != "" && usur_Contrasenia != "" && empl_Id != "") {
        $("#formCreate").submit();

    } else {
        MostrarMensajeWarning("Complete los campos");
        if (usur_Usuario == "") {
            $("#lbl_usur_Usuario").attr('hidden', false);
        }
        if (usur_Contrasenia == "") {
            $("#lbl_usur_Contrasenia").attr('hidden', false);
        }
        if (empl_Id == "") {
            $("#lbl_empl_Id").attr('hidden', false);
        }

    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#usur_IdE").val(data[0]);
    $("#empl_IdE").val(data[1]);
    $("#modalEdit").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var empl_Id = $('#empl_IdE').val();
    var usur_Id = $('#usur_IdE').val();


    $("#lbl_empl_IdE").attr('hidden', true);

    if (usur_Id != "" && empl_Id != "") {
        $("#formEdit").submit();

    } else {
        MostrarMensajeWarning("Complete los campos");
        if (empl_Id == "") {
            $("#lbl_empl_IdE").attr('hidden', false);
        }
        if (usur_Id == "") {
            MostrarMensajeDanger("MUY GRACIOSITO");
        }
    }

}



function AbrirModalDelete(id) {
    $("#usur_IdD").val(id);
    $("#EliminarUsuario").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var usur_IdD = $('#usur_IdD').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (usur_IdD != "") {
        $("#formDelete").submit();

    } else {
        MostrarMensajeDanger("MUY GRACIOSITO");
    }

}
