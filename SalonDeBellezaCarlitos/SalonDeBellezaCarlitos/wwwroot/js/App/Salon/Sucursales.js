$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navSucursales').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrio un error al realizar el registro!");
        $("#modalCreate").appendTo('body').modal('show');
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito!");
    }

    if ($("#muni_Id").val() == '') {
        var departamentoId = $("#depa_Id").val();
        $.getJSON('/Empleados/CargarMunicipios', { id: departamentoId })
            .done(function (municipios) {
                var municipiosSelect = $('#muni_Id');
                municipiosSelect.empty();
                municipiosSelect.append($('<option>', {
                    value: '',
                    text: '--Selecciona un Municipio--'
                }));
                $.each(municipios, function (index, item) {
                    municipiosSelect.append($('<option>', {
                        value: item.muni_Id,
                        text: item.muni_Descripcion
                    }));
                });
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
            });
    }


    $('#depa_Id').change(function () {
        var departamentoId = $("#depa_Id").val();
        $.getJSON('/Empleados/CargarMunicipios', { id: departamentoId })
            .done(function (municipios) {
                var municipiosSelect = $('#muni_Id');
                municipiosSelect.empty();
                municipiosSelect.append($('<option>', {
                    value: '',
                    text: '--Selecciona un Municipio--'
                }));
                $.each(municipios, function (index, item) {
                    municipiosSelect.append($('<option>', {
                        value: item.muni_Id,
                        text: item.muni_Descripcion
                    }));
                });
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
            });
    });
    $('#depa_IdE').change(function () {
        var departamentoId = $("#depa_IdE").val();
        $.getJSON('/Empleados/CargarMunicipios', { id: departamentoId })
            .done(function (municipios) {
                var municipiosSelect = $('#muni_IdE');
                municipiosSelect.empty();
                municipiosSelect.append($('<option>', {
                    value: '',
                    text: '--Selecciona un Municipio--'
                }));
                $.each(municipios, function (index, item) {
                    municipiosSelect.append($('<option>', {
                        value: item.muni_Id,
                        text: item.muni_Descripcion
                    }));
                });
            })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
            });
    });

});





function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}


//$('#sucu_Descripcion').on('input', function () {
//    var c = this.selectionStart,
//        r = /[^1 234567890qwertyuiopasdfghjklzxcvbnm~!@#$%^&*()_+QWERTYUIOP{}|ASDFGHJKL:ZXCVBNM<>?]/gi,
//        v = $(this).val();
//    if (r.test(v)) {
//        $(this).val(v.replace(r, ''));
//        c--;
//    }
//    this.setSelectionRange(c, c);
//});
//$('#sucu_DireccionExacta').on('input', function () {
//    var c = this.selectionStart,
//        r = /[^a-z 0-9]/gi,
//        v = $(this).val();
//    if (r.test(v)) {
//        $(this).val(v.replace(r, ''));
//        c--;
//    }
//    this.setSelectionRange(c, c);
//});
//$('#sucu_DescripcionE').on('input', function () {
//    var c = this.selectionStart,
//        r = /[^a-z 0-9]/gi,
//        v = $(this).val();
//    if (r.test(v)) {
//        $(this).val(v.replace(r, ''));
//        c--;
//    }
//    this.setSelectionRange(c, c);
//});
//$('#sucu_DireccionExactaE').on('input', function () {
//    var c = this.selectionStart,
//        r = /[^a-z 0-9]/gi,
//        v = $(this).val();
//    if (r.test(v)) {
//        $(this).val(v.replace(r, ''));
//        c--;
//    }
//    this.setSelectionRange(c, c);
//});

function GuardarModalCreate() {
    var sucu_Descripcion = $('#sucu_Descripcion').val();
    var muni_Id = $('#muni_Id').val();
    var depa_Id = $('#depa_Id').val();
    var sucu_DireccionExacta = $('#sucu_DireccionExacta').val();

    $("#lbl_sucu_Descripcion").attr('hidden', true);
    $("#lbl_muni_Id").attr('hidden', true);
    $("#lbl_depa_Id").attr('hidden', true);
    $("#lbl_sucu_DireccionExacta").attr('hidden', true);

    if (sucu_Descripcion != "" && muni_Id != "" && sucu_DireccionExacta != "" && depa_Id != "") {
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
        if (depa_Id == "") {
            $("#lbl_depa_Id").attr('hidden', false);
        }
    }

}




function AbrirModalEdit(cadena) {
    var datastring = cadena;
    var data = datastring.split(',');
    $("#sucu_DescripcionE").val(data[0]);
    $("#depa_IdE").val(data[1]);
    $("#sucu_DireccionExactaE").val(data[3]);
    $("#sucu_IdE").val(data[4]);
    //$("#depa_IdE option[value='05']").attr("selected", true);

    console.log(data);

    $.getJSON('/Empleados/CargarMunicipios', { id: data[1] })
        .done(function (municipios) {
            var municipiosSelect = $('#muni_IdE');
            municipiosSelect.empty();
            municipiosSelect.append($('<option>', {
                value: '',
                text: '--Selecciona un Municipio--'
            }));
            $.each(municipios, function (index, item) {
                municipiosSelect.append($('<option>', {
                    value: item.muni_Id,
                    text: item.muni_Descripcion
                }));
            });
            $("#muni_IdE").val(data[2]);
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
        });


    $("#modalEdit").appendTo('body').modal('show');
};


function GuardarModalEdit() {
    var sucu_DescripcionE = $("#sucu_DescripcionE").val();
    var depa_IdE = $('#depa_IdE').val();
    var sucu_DireccionExactaE = $('#sucu_DireccionExactaE').val();
    var muni_IdE = $('#muni_IdE').val();


    $("#lbl_sucu_DescripcionE").attr('hidden', true);
    $("#lbl_muni_IdE").attr('hidden', true);
    $("#lbl_depa_IdE").attr('hidden', true);
    $("#lbl_sucu_DireccionExactaE").attr('hidden', true);

    if (sucu_DescripcionE != "" && muni_IdE != "" && sucu_DireccionExactaE != "" && depa_IdE != "") {
        $("#formEdit").submit();

    } else {
        if (sucu_DescripcionE == "") {
            $("#lbl_sucu_DescripcionE").attr('hidden', false);
        }
        if (muni_IdE == "") {
            $("#lbl_muni_IdE").attr('hidden', false);
        }
        if (sucu_DireccionExactaE == "") {
            $("#lbl_sucu_DireccionExactaE").attr('hidden', false);
        }
        if (depa_IdE == "") {
            $("#lbl_depa_IdE").attr('hidden', false);
        }
    }

}


function AbrirModalDelete(id) {
    console.log(id);
    $("#sucu_IdD").val(id);
    $("#EliminarSucursal").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var sucu_IdD = $('#sucu_IdD').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (sucu_IdD != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
