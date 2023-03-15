function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
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
function AbrirModalDelete(id) {
    $("#metp_Id_Delete").val(id);
    $("#EliminarMetodopago").appendTo('body').modal('show');
};

function GuardarModalDelete() {
    var metp_Id_Delete = $('#metp_Id_Delete').val();
    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (metp_Id_Delete != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}