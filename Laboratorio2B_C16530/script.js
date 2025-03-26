let color_pagina = "blanco";

// Función que agrega un nuevo elemento a la lista con nombre secuencial
function agregar() {
    const lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li").length;
    const elemento = document.createElement("li");
    // Se genera el texto del nuevo elemento basado en la cantidad actual
    elemento.innerHTML = "Elemento" + (elementos + 1);
    lista.appendChild(elemento);
}

// Función que alterna el color de fondo de la página entre blanco y verde
function cambiarFondo() {
    if (color_pagina == "blanco") {
        document.body.style.backgroundColor = "#9caf88";
        color_pagina = "verde";
    } else {
        document.body.style.backgroundColor = "white";
        color_pagina = "blanco";
    }
}

// Función que borra el último elemento de la lista, si existe al menos uno
function borrar() {
    const lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li");
    if (elementos.length > 0) {
        lista.removeChild(elementos[elementos.length - 1]);
    }
}