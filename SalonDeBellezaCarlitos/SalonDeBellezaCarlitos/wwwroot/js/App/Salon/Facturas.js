$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navFacturas').addClass('active');
    $('#subnavSalon').addClass('show');

        $("#Servicio").attr("hidden", true);



    $("#fade_Cantidad").on('input', function () {
        if ($("#prod_Id").val() != 0 || $("#serv_Id").val() != 0) {
            $.getJSON('/Facturas/RevisarStock', { prod_Id: $("#prod_Id").val(), serv_Id: $("#serv_Id").val() })
            .done(function (stock) {
                if (stock < $("#fade_Cantidad").val()) {
                    MostrarMensajeWarning('No contamos con el stock necesario');
                }
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los productos: ' + textStatus + ', ' + errorThrown);
            });
        }
       
    })



    $("#prod_Id").prop("disabled", true);
    $("#serv_Id").prop("disabled", true);
    $("#fade_Cantidad").prop("disabled", true);
    $("#btnDetalles").prop("disabled", true);

    var logrado = $("#logrado").val();
    if (logrado == "true") {
        $("#clie_Id").prop("disabled", true);
        $("#metp_Id").prop("disabled", true);
        $("#empl_Id_Caja").prop("disabled", true);
        $("#empl_Id_Atendido").prop("disabled", true);
        $("#btnRegresar").attr("hidden", true);
        $("#fila2").attr("hidden", true);
        $("#btnFacturar").attr("hidden", true);
        $("#consumidor").attr("hidden", true);
        $("#Servicio").attr("hidden", false);

        $("#prod_Id").prop("disabled", false);
        $("#serv_Id").prop("disabled", false);
        $("#fade_Cantidad").prop("disabled", false);
        $("#btnDetalles").prop("disabled", false);

    }

    if (logrado == "edit") {
        $("#clie_Id").prop("disabled", true);
        $("#metp_Id").prop("disabled", true);
        $("#empl_Id_Caja").prop("disabled", true);
        $("#empl_Id_Atendido").prop("disabled", true);
        $("#btnFacturar").attr("hidden", true);
        $("#consumidor").attr("hidden", false);
        $("#Servicio").attr("hidden", false);

        $("#prod_Id").prop("disabled", false);
        $("#serv_Id").prop("disabled", false);
        $("#fade_Cantidad").prop("disabled", false);
        $("#btnDetalles").prop("disabled", false);

    }

    $('#prod_Id').val("0");
    $('#serv_Id').val("0");
    $('#fade_Cantidad').val("1");


    if ($("#toast").val() == 'errorD') {
        MostrarMensajeDanger("Ocurrio un error en esta operación, intentalo de nuevo");
    }
    if ($("#toast").val() == 'successD') {
        MostrarMensajeSuccess("La operacion se realizo con exito");
    }

    if ($("#toast").val() == 'errorH') {
        MostrarMensajeDanger("Ocurrio un error en esta operación, intentalo de nuevo");
    }
    if ($("#toast").val() == 'successH') {
        MostrarMensajeSuccess("La factura se creo con exito");
        MostrarMensajeInfo("Ya puedes insertar las compras que desees");
    }

    if ($("#toast").val() == 'errorB') {
        MostrarMensajeDanger("Ocurrio un error en esta operación, intentalo de nuevo");
    }
    if ($("#toast").val() == 'successB') {
        MostrarMensajeSuccess("Se ha ingresado con exito la compra");
        MostrarMensajeInfo("Puedes insertar mas compras si lo deseas");
    }
    if ($("#toast").val() == 'errorC') {
        MostrarMensajeDanger("Ocurrió un error mientras se cargaba la información, intentalo de nuevo");
    }
    if ($("#toast").val() == 'sucursal') {
        MostrarMensajeDanger("No puedes cargar una factura de otra sucursal");
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

        MostrarMensajeWarning("Llene todos los campos");
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
    console.log(Cantidad);

    if ((Producto != "0" && Servicio != "0") || Cantidad > 0) {
        $.getJSON('/Facturas/RevisarStock', { prod_Id: $("#prod_Id").val(), serv_Id: $("#serv_Id").val() })
            .done(function (stock) {
                if (stock >= $("#fade_Cantidad").val()) {
                    $("#formFacturaDetalle").submit();
                } else {
                    MostrarMensajeWarning('No se cuenta con el stock necesario');
                }
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los productos: ' + textStatus + ', ' + errorThrown);
            });


    } else {

        MostrarMensajeWarning("Llene todos los campos porfavor");
        if (Producto == "0" && Servicio == "0") {
            $("#lbl_prod_Id_AtendidoError").attr("hidden", false);
        }
        if (Cantidad <= 0) {
            $("#lbl_fade_Cantidad_AtendidoError").attr("hidden", false);
        }
    }


}




function AbrirModalDelete(id) {
    console.log(id);
    $("#fade_Id_Delete").val(id);
    $("#fade_UsuarioModificacion_Delete").val(1);
    $("#EliminarDetalle").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var carg_Descripcion = $('#fade_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}

