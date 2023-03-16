$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navFacturas').addClass('active');
    $('#subnavSalon').addClass('show');

    $("#prod_Id").prop("disabled", true);
    $("#serv_Id").prop("disabled", true);
    $("#fade_Cantidad").prop("disabled", true);
    //$("#btnDetalles").prop("disabled", true);

    var logrado = $("#logrado").val();
    if (logrado == "true") {
        $("#clie_Id").prop("disabled", true);
        $("#metp_Id").prop("disabled", true);
        $("#empl_Id_Caja").prop("disabled", true);
        $("#empl_Id_Atendido").prop("disabled", true);
        $("#btnRegresar").attr("hidden", true);
        $("#fila2").attr("hidden", true);
        $("#btnFacturar").attr("hidden", true);

        $("#prod_Id").prop("disabled", false);
        $("#serv_Id").prop("disabled", false);
        $("#fade_Cantidad").prop("disabled", false);
        $("#btnDetalles").prop("disabled", false);

    }


   


});


$('#prod_Id').change(function () {
    var producto = $('#prod_Id').val();
    if (producto != "0") {
        $("#serv_Id").prop("disabled", true);
    } else {
        $("#serv_Id").prop("disabled", false);
    }
});

$('#serv_Id').change(function () {
    var servicio = $('#serv_Id').val();
    if (servicio != "0") {
        $("#prod_Id").prop("disabled", true);
    } else {
        $("#prod_Id").prop("disabled", false);
    }
});


function EnviarFormFactura()
{

    $("#lbl_clie_IdError").attr("hidden", true);
    $("#lbl_metp_IdError").attr("hidden", true);
    $("#lbl_empl_Id_CajaError").attr("hidden", true);
    $("#lbl_empl_Id_AtendidoError").attr("hidden", true);


    var cliente = $("#clie_Id").val();
    var metodo = $("#metp_Id").val();
    var caja = $("#empl_Id_Caja").val();
    var atent = $("#empl_Id_Atendido").val();
    console.log("hola");
    if (cliente != "" && metodo != "" && caja != "" && atent != "") {
        $("#formCreateFactura").submit();
    } else {
        if (cliente == "") {
            $("#lbl_clie_IdError").attr("hidden", false);
        }
        if (metodo == "") {
            $("#lbl_metp_IdError").attr("hidden", false);
        }
        if (caja == "") {
            $("#lbl_empl_Id_CajaError").attr("hidden", false);
        }
        if (atent == "") {
            $("#lbl_empl_Id_AtendidoError").attr("hidden", false);
        }
    }


}

function EnviarFormDetalles() {

    $("#lbl_clie_IdError").attr("hidden", true);
    $("#lbl_metp_IdError").attr("hidden", true);
    $("#lbl_empl_Id_CajaError").attr("hidden", true);
    $("#lbl_empl_Id_AtendidoError").attr("hidden", true);


    var cliente = $("#clie_Id").val();
    var metodo = $("#metp_Id").val();
    var caja = $("#empl_Id_Caja").val();
    var atent = $("#empl_Id_Atendido").val();
    console.log("hola");
    if (cliente != "" && metodo != "" && caja != "" && atent != "") {
        $("#formCreateFactura").submit();
    } else {
        if (cliente == "") {
            $("#lbl_clie_IdError").attr("hidden", false);
        }
        if (metodo == "") {
            $("#lbl_metp_IdError").attr("hidden", false);
        }
        if (caja == "") {
            $("#lbl_empl_Id_CajaError").attr("hidden", false);
        }
        if (atent == "") {
            $("#lbl_empl_Id_AtendidoError").attr("hidden", false);
        }
    }


}


function EnviarFormDetalles() {

    $("#lbl_prod_Id_AtendidoError").attr("hidden", true);
    $("#lbl_fade_Cantidad_AtendidoError").attr("hidden", true);


    var Producto = $("#prod_Id").val();
    var Servicio = $("#serv_Id").val();
    var Cantidad = $("#fade_Cantidad").val();
    console.log("Detalles");

    if ((Producto != "0" || Servicio != "0") && Cantidad != "0") {
        $("#formFacturaDetalle").submit();
    } else {
        if (Producto == "0") {
            $("#lbl_prod_Id_AtendidoError").attr("hidden", false);
        }
        if (Servicio == "0") {
            $("#lbl_prod_Id_AtendidoError").attr("hidden", false);
        }
        if (Cantidad == "0") {
            $("#lbl_fade_Cantidad_AtendidoError").attr("hidden", false);
        }
    }


}
