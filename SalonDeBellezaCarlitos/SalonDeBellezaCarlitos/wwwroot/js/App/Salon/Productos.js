$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navProductos').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrió un error al realizar la operación!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operación se realizo con exito!");
    }
});
function AbrirModalDelete(id) {
    console.log(id);
    $("#prod_Id_Delete").val(id);
    $("#EliminarProducto").appendTo('body').modal('show');
};

var input = document.getElementById("prod_Nombre",);
input.addEventListener("keydown", function (event) {
    var key = event.key;

    if (!isNaN(parseFloat(key)) && isFinite(key)) {
        event.preventDefault();
    }
});

function soloNumeros(event) {
    var charCode = event.keyCode || event.which;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        event.preventDefault();
        return false;
    }
    return true;
}

function GuardarModalDelete() {
    var prod_Descripcion = $('#prod_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (prod_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}