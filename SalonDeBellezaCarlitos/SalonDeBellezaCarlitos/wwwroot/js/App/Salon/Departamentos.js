function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_depa_Codigo").attr('hidden', true);
    $("#lbl_depa_Descripcion").attr('hidden', true);
    var input = document.getElementById("depa_Descripcion",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
}

function GuardarModalCreate() {
    var depa_Codigo = $('#depa_Codigo').val();
    var depa_Descripcion = $('#depa_Descripcion').val();

    $("#lbl_depa_Codigo").attr('hidden', true);
    $("#lbl_depa_Descripcion").attr('hidden', true);

    if (depa_Codigo != "" && depa_Descripcion != "") {
        $("#formCreate").submit();

    } else {
        if (depa_Descripcion == "") {
            $("#lbl_depa_Descripcion").attr('hidden', false);
        }
        if (depa_Codigo == "") {
            $("#lbl_depa_Codigo").attr('hidden', false);
        }
    }

}

function soloNumeros(event) {
    var charCode = event.keyCode || event.which;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        event.preventDefault();
        return false;
    }
    return true;
}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#depa_Id_Edit").val(data[0]);
    $("#depa_Descripcion_Edit").val(data[1]);
    $("#depa_Codigo_Edit").val(data[2]);
    $("#EditarDepartamento").appendTo('body').modal('show');

    var input = document.getElementById("depa_Descripcion_Edit",);
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
};


function GuardarModalEdit() {
    var depa_Descripcion = $('#depa_Descripcion_Edit').val();
    var depa_Codigo = $('#depa_Codigo_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (depa_Descripcion != "" && depa_Codigo != "") {
        $("#formEdit").submit();

    } else {
        if (depa_Descripcion == "") {
            $("#lbl_DescripcionEditError").attr('hidden', false)
        }
        if (depa_Codigo == "") {
            $("#lbl_CodigoEditError").attr('hidden', false)
        }
    }   

}

function AbrirModalDelete(id) {
    $("#depa_Id_Delete").val(id);
    $("#EliminarDepartamento").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var depa_Descripcion = $('#depa_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (depa_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}