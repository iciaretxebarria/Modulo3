// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let fotos = document.getElementsByClassName('foto');

for (var i = 0; i < fotos.length; i++) {

    fotos[i].addEventListener('click', function () {

        let celda = document.getElementsByClassName('celda-foto');

        for (var i = 0; i < celda.length; i++) {

            celda[i].style.backgroundColor = "grey";
        }

    })

}
