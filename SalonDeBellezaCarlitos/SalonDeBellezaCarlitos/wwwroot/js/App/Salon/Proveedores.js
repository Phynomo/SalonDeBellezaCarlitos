$(document).ready(function () {
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




function EnviarForm() {
    var prov_NombreEmpresa = $("#prov_NombreEmpresa").val();
    var prov_NombreContacto = $("#prov_NombreContacto").val();
    var depa_Id = $("#depa_Id").val();
    var muni_Id = $("#muni_Id").val();
    var prov_DireccionExacta = $("#prov_DireccionExacta").val();
    var prov_Telefono = $("#prov_Telefono").val();


    $("#lblprov_NombreEmpresa").attr('hidden', true);
    $("#lblprov_NombreContacto").attr('hidden', true);
    $("#lbldepa_Id").attr('hidden', true);
    $("#lblmuni_Id").attr('hidden', true);
    $("#lblprov_DireccionExacta").attr('hidden', true);
    $("#lblprov_Telefono").attr('hidden', true);

    if (prov_NombreEmpresa != "" && prov_NombreContacto != "" && depa_Id != "" &&
        muni_Id != "" && prov_DireccionExacta != "" && prov_Telefono != "") {
        $("#form").submit();
    } else {
        MostrarMensajeWarning("Tienes campos vacios, llenalos por favor");
        if (prov_NombreEmpresa == "") {
            $("#lblprov_NombreEmpresa").attr('hidden', false);
        }
        if (prov_NombreContacto == "") {
            $("#lblprov_NombreContacto").attr('hidden', false);
        }
        if (depa_Id == "") {
            $("#lbldepa_Id").attr('hidden', false);
        }
        if (muni_Id == "") {
            $("#lblmuni_Id").attr('hidden', false);
        }
        if (prov_DireccionExacta == "") {
            $("#lblprov_DireccionExacta").attr('hidden', false);
        }
        if (prov_Telefono == "") {
            $("#lblprov_Telefono").attr('hidden', false);
        }
    }

}

