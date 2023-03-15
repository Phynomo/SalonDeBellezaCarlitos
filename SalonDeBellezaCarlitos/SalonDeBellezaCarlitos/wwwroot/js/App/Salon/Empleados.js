$(document).ready(function () {
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
    $.getJSON('/Empleados/CargarMunicipios', {id: departamentoId })
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
