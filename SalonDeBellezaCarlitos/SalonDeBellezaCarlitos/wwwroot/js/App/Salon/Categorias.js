function AbrirModalCreate() {
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var cate_Descripcion = $('#cate_Descripcion').val();


    $("#lbl_DescripcionCreateError").attr('hidden', true);

    if (cate_Descripcion != "") {

        $("#formCreate").submit();

    } else {
        $("#lbl_DescripcionCreateError").attr('hidden', false);
    }

}