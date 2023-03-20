$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navEmpleados').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrio un error al realizar el registro!");
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




function AbrirModalDelete(id) {
    console.log(id);
    $("#empl_Id_Delete").val(id);
    $("#EliminarEmpleado").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var carg_Descripcion = $('#empl_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}
