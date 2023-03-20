$(document).ready(function () {
    $('#navGeneral').addClass('active');
    $('#navEstadocivil').addClass('active');
    $('#subnavGeneral').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrio un error al realizar el registro!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito!");
    }
});

function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_DescripcionCreateError").attr('hidden', true);

    var input = document.getElementById("estc_Descripcion",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
}

function GuardarModalCreate() {
    var estc_Descripcion = $('#estc_Descripcion').val();


    $("#lbl_DescripcionCreateError").attr('hidden', true);

    if (estc_Descripcion != "") {
        $("#formCreate").submit();

    } else {
        console.log('false')
        $("#lbl_DescripcionCreateError").attr('hidden', false);
    }

}


function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#estc_Id_Edit").val(data[0]);
    $("#estc_Descripcion_Edit").val(data[1]);
    $("#EditarEstadoCivil").appendTo('body').modal('show');

    var input = document.getElementById("estc_Descripcion_Edit",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
};


function GuardarModalEdit() {
    var metp_Descripcion = $('#estc_Descripcion_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (metp_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        $("#lbl_DescripcionEditError").attr('hidden', false);
    }

}



function AbrirModalDelete(id) {
    $("#estc_Id_Delete").val(id);
    $("#EliminarEstadoCivil").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var estc_Descripcion = $('#estc_Id_Delete').val();
    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (estc_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}