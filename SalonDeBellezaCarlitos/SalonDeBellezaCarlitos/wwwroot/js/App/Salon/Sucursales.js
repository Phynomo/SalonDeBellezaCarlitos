function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var sucu_Descripcion = $('#sucu_Descripcion').val();
    var muni_Id = $('#muni_Id').val();
    var sucu_DireccionExacta = $('#sucu_DireccionExacta').val();

    $("#lbl_sucu_Descripcion").attr('hidden', true);
    $("#lbl_muni_Id").attr('hidden', true);
    $("#lbl_sucu_DireccionExacta").attr('hidden', true);

    if (sucu_Descripcion != "" && muni_Id != "" && sucu_DireccionExacta != "") {
        $("#formCreate").submit();

    } else {
        if (sucu_Descripcion == "") {
            $("#lbl_sucu_Descripcion").attr('hidden', false);
        }
        if (muni_Id == "") {
            $("#lbl_muni_Id").attr('hidden', false);
        }
        if (sucu_DireccionExacta == "") {
            $("#lbl_sucu_DireccionExacta").attr('hidden', false);
        }
    }

}