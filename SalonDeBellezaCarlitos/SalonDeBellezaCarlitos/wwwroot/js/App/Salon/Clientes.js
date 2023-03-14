function AbrirModalCreate() {
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var clie_Nombre = $('#clie_Nombre').val();
    var clie_Apellido = $('#clie_Apellido').val();
    var clie_Telefono = $('#clie_Telefono').val();
    var clie_CorreoElectronico = $('#clie_CorreoElectronico').val();

    $("#lbl_clie_Nombre").attr('hidden', true);
    $("#lbl_clie_Apellido").attr('hidden', true);
    $("#lbl_clie_Telefono").attr('hidden', true);
    $("#lbl_clie_CorreoElectronico").attr('hidden', true);

    if (clie_Nombre != "" && clie_Apellido != "" && clie_Telefono != "" && clie_CorreoElectronico != "") {

        $("#formCreate").submit();

    } else {
        if (clie_Nombre == "") {
            $("#lbl_clie_Nombre").attr('hidden', false);
        }
        if (clie_Apellido == "") {
            $("#lbl_clie_Apellido").attr('hidden', false);
        }
        if (clie_Telefono == "") {
            $("#lbl_clie_Telefono").attr('hidden', false);
        }
        if (clie_CorreoElectronico == "") {
            $("#lbl_clie_CorreoElectronico").attr('hidden', false);
        }
    }

}