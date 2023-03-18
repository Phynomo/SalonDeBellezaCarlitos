function AbrirModalDelete(id) {
    console.log(id);
    $("#prod_Id_Delete").val(id);
    $("#EliminarProducto").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var prod_Descripcion = $('#prod_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (prod_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}