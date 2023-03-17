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

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#cate_Id_Edit").val(data[0]);
    $("#cate_Descripcion_Edit").val(data[1]);
    $("#EditarCategoria").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var cate_Descripcion = $('#cate_Descripcion_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (cate_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        $("#lbl_DescripcionEditError").attr('hidden', false);
        console.log('holperra');
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
