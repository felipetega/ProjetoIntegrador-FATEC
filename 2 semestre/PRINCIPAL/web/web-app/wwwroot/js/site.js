// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function mostrarOcultarSenha(){
    var senha = document.getElementById("senha");
    if (senha.type == "password") {
        senha.type = "text";
    } else {
        senha.type = "password";
    }
}