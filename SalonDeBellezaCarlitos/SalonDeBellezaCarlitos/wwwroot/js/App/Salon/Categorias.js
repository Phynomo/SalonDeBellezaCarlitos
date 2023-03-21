$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navCategorias').addClass('active');
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
    $("#lbl_DescripcionCreateError").attr('hidden', true);
    var input = document.getElementById("cate_Descripcion");
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
}

function GuardarModalCreate() {
    var cate_Descripcion = $('#cate_Descripcion').val();


    $("#lbl_DescripcionCreateError").attr('hidden', true);

    if (cate_Descripcion != "") {

        $("#formCreate").submit();

    } else {
        MostrarMensajeWarning("Llene todos los campos");
        $("#lbl_DescripcionCreateError").attr('hidden', false);
    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#cate_Id_Edit").val(data[0]);
    $("#cate_Descripcion_Edit").val(data[1]);
    $("#EditarCategoria").appendTo('body').modal('show');

    var input = document.getElementById("cate_Descripcion_Edit");
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
};


function GuardarModalEdit() {
    var cate_Descripcion = $('#cate_Descripcion_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (cate_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        MostrarMensajeWarning("Llene todos los campos");
        $("#lbl_DescripcionEditError").attr('hidden', false);
    }

}

function AbrirModalDelete(id) {
    console.log(id);
    $("#cate_Id_Delete").val(id);
    $("#EliminarCategoria").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var cate_Descripcion = $('#cate_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (cate_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
