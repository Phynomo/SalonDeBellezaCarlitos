$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navSucursales').addClass('active');
    $('#subnavSalon').addClass('show');



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
});





function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

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