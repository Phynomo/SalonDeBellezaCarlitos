﻿$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navProveedores').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'repetido') {
        MostrarMensajeWarning("El nombre de la empresa ya fue registrado");
    }
    if ($("#toast").val() == 'success') {
        MostrarMensajeSuccess("La operacion se realizo con exito");
    }
    if ($("#toast").val() == 'fatal') {
        MostrarMensajeWarning("Complete todos los campos");
    }
    if ($("#toast").val() == 'noprevisto') {
        MostrarMensajeDanger("A ocurrido algo no previsto, intentalo de nuevo");
    }
    if ($("#toast").val() == 'errorC') {
        MostrarMensajeDanger("Ocurrio un error mientras se cargaba la informacion, intentalo de nuevo");
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
    $("#prov_Id_Delete").val(id);
    $("#EliminarProveedor").appendTo('body').modal('show');
};



function GuardarModalDelete() {
    var carg_Descripcion = $('#prov_Id_Delete').val();

    $("#lbl_DescripcionDeleteError").attr('hidden', true);

    if (carg_Descripcion != "") {
        $("#formDelete").submit();

    } else {
        $("#lbl_DescripcionDeleteError").attr('hidden', false);
    }

}