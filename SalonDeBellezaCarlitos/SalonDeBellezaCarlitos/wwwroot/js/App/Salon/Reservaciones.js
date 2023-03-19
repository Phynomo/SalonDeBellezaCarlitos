$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navReservaciones').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ese registro ya exite");
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito");
    }

    if ($("#toast").val() == 'errorC') {
        MostrarMensajeDanger("Ocurrio un error mientras se cargaban los datos");
    }

});


function btnCreate() {
    var clie_Id = $("#clie_Id").val();
    var sucu_Id = $("#sucu_Id").val();
    var rese_DiaReservado = $("#rese_DiaReservado").val();
    var rese_HoraInicio = $("#rese_HoraInicio").val();
    var rese_HoraFin = $("#rese_HoraFin").val();

    $("#lblclie_Id").attr('hidden', true);
    $("#lblsucu_Id").attr('hidden', true);
    $("#lblrese_DiaReservado").attr('hidden', true);
    $("#lblrese_HoraInicio").attr('hidden', true);
    $("#lblrese_HoraFin").attr('hidden', true);

    if (clie_Id != "" && sucu_Id != "" && rese_DiaReservado != "" && rese_HoraFin != "" && rese_HoraInicio != "" && rese_HoraFin > rese_HoraInicio) {
        $("#fromCreate").submit();
    } else {
        MostrarMensajeWarning("Hay campos vacios");
        if (clie_Id == "" ) {
            $("#lblclie_Id").attr('hidden', false);
        }
        if (sucu_Id == "") {
            $("#lblsucu_Id").attr('hidden', false);
        }
        if (rese_DiaReservado == "") {
            $("#lblrese_DiaReservado").attr('hidden', false);
        }
        if (rese_HoraInicio == "") {
            $("#lblrese_HoraInicio").attr('hidden', false);
        }
        if (rese_HoraFin == "") {
            $("#lblrese_HoraFin").attr('hidden', false);
        }
        if (rese_HoraFin < rese_HoraInicio) {
            MostrarMensajeWarning("La hora de fin no puede ser mayor a la de incio");
        }
    }


}



function btnEdit() {
    var clie_Id = $("#clie_Id").val();
    var sucu_Id = $("#sucu_Id").val();
    var rese_DiaReservado = $("#rese_DiaReservado").val();
    var rese_HoraInicio = $("#rese_HoraInicio").val();
    var rese_HoraFin = $("#rese_HoraFin").val();

    $("#lblclie_Id").attr('hidden', true);
    $("#lblsucu_Id").attr('hidden', true);
    $("#lblrese_DiaReservado").attr('hidden', true);
    $("#lblrese_HoraInicio").attr('hidden', true);
    $("#lblrese_HoraFin").attr('hidden', true);

    if (clie_Id != "" && sucu_Id != "" && rese_DiaReservado != "" && rese_HoraFin != "" && rese_HoraInicio != "" && rese_HoraFin > rese_HoraInicio) {
        $("#fromCreate").submit();
    } else {
        MostrarMensajeWarning("Hay campos vacios");
        if (clie_Id == "") {
            $("#lblclie_Id").attr('hidden', false);
        }
        if (sucu_Id == "") {
            $("#lblsucu_Id").attr('hidden', false);
        }
        if (rese_DiaReservado == "") {
            $("#lblrese_DiaReservado").attr('hidden', false);
        }
        if (rese_HoraInicio == "") {
            $("#lblrese_HoraInicio").attr('hidden', false);
        }
        if (rese_HoraFin == "") {
            $("#lblrese_HoraFin").attr('hidden', false);
        }
        if (rese_HoraFin < rese_HoraInicio) {
            MostrarMensajeWarning("La hora de fin no puede ser mayor a la de incio");
        }
    }


}



function AbrirModalDelete(id) {
    console.log(id);
    $("#rese_IdD").val(id);
    $("#EliminarReservacion").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var rese_IdD = $('#rese_IdD').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (rese_IdD != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
