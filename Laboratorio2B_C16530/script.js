function agregar() {
    var lista = document.getElementById("lista");
    var elementos = lista.getElementsByTagName("li").length;
    var elemento = document.createElement("li");
    elemento.innerHTML = "Elemento" + (elementos + 1);
    lista.appendChild(elemento);
}

function cambiarFondo() {

}
function borrar() {
    var lista = document.getElementById("lista");
    var elementos = lista.getElementsByTagName("li").length;
    if (elementos.length > 0) {
        lista.removeChild(lista.lastChild);
    }
}