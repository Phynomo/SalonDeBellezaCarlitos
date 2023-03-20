$(document).ready(function () {

    $("#lblUsuario1").attr('hidden', false);
    $("#lblContraseña1").attr('hidden', false);


    if ($("#toast").val() == 'error') {
        MostrarMensajeDanger("Inicio de sesion fallido");
    }
    if ($("#toast").val() == 'recuperacionfallida') {
        MostrarMensajeDanger("No se pudo recuperar tu usuario");
    }
    if ($("#toast").val() == 'recuperacionExitosa') {
        MostrarMensajeSuccess("Recuperacion de usuario exitosa");
    }


});



function IniciarSesion() {
    var usuario = $('#usuario').val();
    var password = $('#password').val();


    $("#lblUsuario1").attr('hidden', false);
    $("#lblContraseña1").attr('hidden', false);
    $("#lblUsuario2").attr('hidden', true);
    $("#lblContraseña2").attr('hidden', true);

    if (usuario != "" && password != "") {
       $('#loginform').submit();
    }
    else {
        if (usuario == "") {
            $("#lblUsuario1").attr('hidden', true);
            $("#lblUsuario2").attr('hidden', false);
        }
        if (password == "") {
            $("#lblContraseña1").attr('hidden', true);
            $("#lblContraseña2").attr('hidden', false);
        }
    }

}



function Recuperar() {
    var usuario = $('#usur_UsuarioR').val();
    var password = $('#usur_Contrasenia').val();


    $("#lblUsuarioR").attr('hidden', true);
    $("#lblContraseñaR").attr('hidden', true);

    if (usuario != "" && password != "") {
        $('#recuperarForm').submit();
    }
    else {
        if (usuario == "") {
            $("#lblUsuarioR").attr('hidden', false);
        }
        if (password == "") {
            $("#lblContraseñaR").attr('hidden', false);
        }
    }

}
function abrirRecuperar() {
    $("#recuperarmodal").appendTo('body').modal('show');
}