$(document).ready(function () {
    $('#navMunicipios').addClass('active');
    $('#navGeneral').addClass('active');
    $('#subnavGeneral').addClass('show');
});


function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var muni_Descripcion = $('#muni_Descripcion').val();
    var muni_Codigo = $('#muni_Codigo').val();
    var depa_Id = $('#depa_Id').val();


    $("#lbl_MunicipioCreateError").attr('hidden', true);
    $("#lbl_DescripcionCreateError").attr('hidden', true);
    $("#lbl_DepartamentoCreateError").attr('hidden', true);

    if (muni_Descripcion != "" && muni_Codigo != "" && depa_Id != "") {
        $("#formCreate").submit();

    } else {
        console.log('false')
        if (muni_Descripcion == "") {
            $("#lbl_DescripcionCreateError").attr('hidden', false);
        }
        if (muni_Codigo == "") {
            $("#lbl_MunicipioCreateError").attr('hidden', false);
        }
        if (depa_Id == "") {
            $("#lbl_DepartamentoCreateError").attr('hidden', false);
        }
        
    }

}

function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#muni_Id_Edit").val(data[0]);
    $("#muni_DescripcionE").val(data[2]);
    $("#muni_CodigoE").val(data[1]);
    $("#depa_IdE").val(data[3]);
    //$("#depa_IdE option[value='05']").attr("selected", true);

    console.log(data);

    $("#EditarMunicipios").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var carg_Descripcion = $('#carg_Descripcion_Edit').val();

    $("#lbl_DescripcionEditError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formEdit").submit();

    } else {
        $("#lbl_DescripcionEditError").attr('hidden', false);
    }

}



function AbrirModalDelete(id) {
    console.log(id);
    $("#muni_IdD").val(id);
    $("#EliminarMunicipio").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var carg_Descripcion = $('#muni_IdE').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
