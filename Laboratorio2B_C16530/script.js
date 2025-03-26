function agregar() {
    var lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li").length;
    var elemento = document.createElement("li");
    elemento.innerHTML = "Elemento" + (elementos + 1);
    lista.appendChild(elemento);
}

function cambiarFondo() {

}
function borrar() {
    var lista = document.getElementById("lista");
    lista.removeChild(lista.lastChild);
}