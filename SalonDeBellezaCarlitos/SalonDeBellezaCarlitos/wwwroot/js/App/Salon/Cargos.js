﻿function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var carg_Descripcion = $('#carg_Descripcion').val();


    $("#lbl_DescripcionCreateError").attr('hidden', true);

    if (carg_Descripcion != "") {
        console.log("pq");

        $("#formCreate").submit();

    } else {
        $("#lbl_DescripcionCreateError").attr('hidden', false);
        console.log("hola");
    }

}