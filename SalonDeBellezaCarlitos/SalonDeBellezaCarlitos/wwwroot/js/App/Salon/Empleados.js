
    $(document).ready(function () {
        $("#ddlMunicipios").prop("disabled", true);
        $('#depa_Id').change(function () {
            var departamentoId = $("#depa_Id").val();
    $.getJSON('/Empleados/CargarMunicipios', {id: departamentoId })
    .done(function (municipios) {
        $("#muni_Id").prop("disabled", false);
    var municipiosSelect = $('#muni_Id');
    municipiosSelect.empty();
    municipiosSelect.append($('<option>', {
        value: '',
        text: '--Selecciona un municipio--'
                    }));
        $.each(municipios, function (index, item) {
            municipiosSelect.append($('<option>', {
                value: item.muni_id,
                text: item.muni_Nombre
            }));
        console.log(item.muni_Id)
                    });
                })
        .fail(function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
                });
        });
    });

        $(document).ready(function () {
            $("#ddlMunicipios").prop("disabled", true);
        $('#muni').change(function () {
            var departamentoId = $("#muni").val();
        $.getJSON('/Empleado/CargarMunicipios', {id: departamentoId })
        .done(function (municipios) {
            $("#muni_Id").prop("disabled", false);
        var municipiosSelect = $('#muni_Id');
        municipiosSelect.empty();
        municipiosSelect.append($('<option>', {
            value: '',
            text: '--Selecciona un municipio--'
                    }));
            $.each(municipios, function (index, item) {
                municipiosSelect.append($('<option>', {
                    value: item.muni_id,
                    text: item.muni_Nombre
                }));
            console.log(item.muni_Id)
                    });
                })
            .fail(function (jqXHR, textStatus, errorThrown) {
                console.error('Error al cargar los municipios: ' + textStatus + ', ' + errorThrown);
                });
        });
    });