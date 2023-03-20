$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navCargos').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrio un error al realizar la operacion!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito!");
    }
});


function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var carg_Descripcion = $('#carg_Descripcion').val();


    $("#lbl_DescripcionCreateError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formCreate").submit();

    } else {

        MostrarMensajeWarning("Complete los campos");
        $("#lbl_DescripcionCreateError").attr('hidden', false);
    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    console.log(datastring);
    var data = datastring.split(',');
    $("#carg_Id_Edit").val(data[0]);
    $("#carg_Descripcion_Edit").val(data[1]);
    $("#EditarCargos").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var carg_Descripcion = $('#carg_Descripcion_Edit').val();
    console.log('hola');

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        MostrarMensajeWarning("Complete los campos");
        $("#lbl_DescripcionEditError").attr('hidden', false);
    }

}



function AbrirModalDelete(id) {
    console.log(id);
    $("#carg_Id_Delete").val(id);
    $("#EliminarCargos").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var carg_Descripcion = $('#carg_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formDelete").submit();

    } else {

        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
