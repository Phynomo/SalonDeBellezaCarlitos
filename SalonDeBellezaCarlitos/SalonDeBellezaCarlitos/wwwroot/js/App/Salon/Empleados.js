$(document).ready(function () {
    $('#navSalon').addClass('active');
    $('#navEmpleados').addClass('active');
    $('#subnavSalon').addClass('show');

    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Ocurrió un error al realizar la operación!");
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


function EnviaFormuario()
{
    var empl_Nombre = $("#empl_Nombre").val();
    var empl_Apellido = $("#empl_Apellido").val();
    var depa_Id = $("#depa_Id").val();
    var muni_Id = $("#muni_Id").val();
    var M = $("#M").val();
    var F = $("#F").val();
    var sucu_Id = $("#sucu_Id").val();
    var estc_Id = $("#estc_Id").val();
    var carg_Id = $("#carg_Id").val();
    var empl_Telefono = $("#empl_Telefono").val();
    var empl_CorreoElectronico = $("#empl_CorreoElectronico").val();
    var empl_FechaNacimiento = $("#empl_FechaNacimiento").val();
    var empl_FechaContratacion = $("#empl_FechaContratacion").val();
    var empl_DireccionExacta = $("#empl_DireccionExacta").val();
    var sexo = "";


    $("#lblempl_Nombre").attr('hidden', true);
    $("#lblempl_Apellido").attr('hidden', true);
    $("#lbldepa_Id").attr('hidden', true);
    $("#lblmuni_Id").attr('hidden', true);
    $("#lblempl_Sexo").attr('hidden', true);
    $("#lblsucu_Id").attr('hidden', true);
    $("#lblestc_Id").attr('hidden', true);
    $("#lblcarg_Id").attr('hidden', true);
    $("#lblempl_Telefono").attr('hidden', true);
    $("#lblempl_CorreoElectronico").attr('hidden', true);
    $("#lblempl_FechaNacimiento").attr('hidden', true);
    $("#lblempl_FechaContratacion").attr('hidden', true);
    $("#lblempl_DireccionExacta").attr('hidden', true);



    if ($("#M").is(":checked")) {
        sexo = 'M';
    } else if ($("#F").is(":checked")) {
        sexo = 'F';
    }

    if (sexo != "" && empl_DireccionExacta != "" && empl_FechaContratacion != "" && empl_FechaNacimiento != ""
        && empl_Telefono != "" && carg_Id != "" && estc_Id != "" && sucu_Id != "" && muni_Id != "" && depa_Id != ""
        && empl_Apellido != "" && empl_Nombre != "") {
        $("#formCreate").submit();
    } else {
        MostrarMensajeWarning("Tienes campos vacíos, llenalos por favor");

        if (sexo == "") {
            $("#lblempl_Sexo").attr('hidden', false);
        }
        if (empl_DireccionExacta == "") {
            $("#lblempl_DireccionExacta").attr('hidden', false);
        }
        if (empl_FechaContratacion == "") {
            $("#lblempl_FechaContratacion").attr('hidden', false);
        }
        if (empl_FechaNacimiento == "") {
            $("#lblempl_FechaNacimiento").attr('hidden', false);
        }
        if (empl_Telefono == "") {
            $("#lblempl_Telefono").attr('hidden', false);
        }
        if (carg_Id == "") {
            $("#lblcarg_Id").attr('hidden', false);
        }
        if (estc_Id == "") {
            $("#lblestc_Id").attr('hidden', false);
        }
        if (sucu_Id == "") {
            $("#lblsucu_Id").attr('hidden', false);
        }
        if (muni_Id == "") {
            $("#lblmuni_Id").attr('hidden', false);
        }
        if (depa_Id == "") {
            $("#lbldepa_Id").attr('hidden', false);
        }
        if (empl_Apellido == "") {
            $("#lblempl_Apellido").attr('hidden', false);
        }
        if (empl_Nombre == "") {
            $("#lblempl_Nombre").attr('hidden', false);
        }
    }


}
