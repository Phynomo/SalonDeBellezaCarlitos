function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
    $("#lbl_metp_Descripcion").attr('hidden', true);

    var input = document.getElementById("metp_Descripcion");

    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            //var miValor = "Ingrese solo Letras!";
            //document.getElementById("lbl_metp_Descripcion").innerHTML = miValor;
            event.preventDefault();
        }
    });
}

function GuardarModalCreate() {
    var metp_Descripcion = $('#metp_Descripcion').val();

    $("#lbl_metp_Descripcion").attr('hidden', true);

    if (metp_Descripcion != "") {
        $("#formCreate").submit();

    } else {
        if (metp_Descripcion == "") {
            $("#lbl_metp_Descripcion").attr('hidden', false);
        }
    }
}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#metp_Id_Edit").val(data[0]);
    $("#metp_Descripcion_Edit").val(data[1]);
    $("#EditarMetodopago").appendTo('body').modal('show');

    var input = document.getElementById("metp_Descripcion_Edit");
    input.addEventListener("keydown", function (event) {
        var key = event.key;

        if (!isNaN(parseFloat(key)) && isFinite(key)) {
            event.preventDefault();
        }
    });
};


function GuardarModalEdit() {
    var metp_Descripcion = $('#metp_Descripcion_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (metp_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        $("#lbl_DescripcionEditError").attr('hidden', false);
    }
}

function AbrirModalDelete(id) {
    console.log(id);
    $("#metp_Id_Delete").val(id);
    $("#EliminarMetodopago").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var metp_Descripcion = $('#metp_Id_Delete').val();
    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (metp_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}