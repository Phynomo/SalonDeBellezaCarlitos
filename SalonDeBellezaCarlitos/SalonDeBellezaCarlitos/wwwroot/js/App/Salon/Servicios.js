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