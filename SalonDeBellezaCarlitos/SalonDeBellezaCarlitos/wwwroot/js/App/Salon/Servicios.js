function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var serv_Nombre = $('#serv_Nombre').val();
    var serv_Descripcion = $('#serv_Descripcion').val();
    var serv_Precio = $('#serv_Precio').val();

    $("#lbl_serv_Nombre").attr('hidden', true);
    $("#lbl_serv_Descripcion").attr('hidden', true);
    $("#lbl_serv_Precio").attr('hidden', true);

    if (serv_Nombre != "" && serv_Descripcion != "" && serv_Precio != "") {
        $("#formCreate").submit();

    } else {
        if (serv_Nombre == "") {
            $("#lbl_serv_Nombre").attr('hidden', false);
        }
        if (serv_Descripcion == "") {
            $("#lbl_serv_Descripcion").attr('hidden', false);
        }
        if (serv_Precio == "0,00") {
            $("#lbl_serv_Precio").attr('hidden', false);
        }
    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    console.log(datastring);
    var data = datastring.split(',');
    $("#serv_Id_Edit").val(data[0]);
    $("#serv_Nombre_Edit").val(data[1]);
    $("#serv_Descripcion_Edit").val(data[2]);
    $("#serv_Precio_Edit").val(data[3]);
    $("#EditarServicio").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var serv_Nombre = $('#serv_Nombre_Edit').val();
    var serv_Descripcion = $('#serv_Descripcion_Edit').val();
    var serv_Precio = $('#serv_Precio_Edit').val();
    
    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (serv_Nombre != "" && serv_Descripcion != "" && serv_Precio != "") {
        $("#formEdit").submit();

    } else {
        if (serv_Nombre == "") {
            $("#lbl_NombreEditError").attr('hidden', false);
        }
        if(serv_Descripcion == "") {
            $("#lbl_DescripcionEditError").attr('hidden', false);
        }
        if (serv_Precio == "") {
            $("#lbl_PrecioEditError").attr('hidden', false);
        }
    }

}

function AbrirModalDelete(id) {
    $("#serv_Id_Delete").val(id);
    $("#EliminarServicio").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var serv_Id_Delete = $('#serv_Id_Delete').val();
    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (serv_Id_Delete != "") {
        $("#formDelete").submit();

    } else {
        if (serv_Nombre == "") {
            $("#lbl_DescripcionDeleteError").attr('hidden', false);
        }

    }

}