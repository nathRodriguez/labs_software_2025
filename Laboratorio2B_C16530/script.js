function agregar() {
    const lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li").length;
    const elemento = document.createElement("li");
    elemento.innerHTML = "Elemento" + (elementos + 1);
    lista.appendChild(elemento);
}

function cambiarFondo() {

}
function borrar() {
    const lista = document.getElementById("lista");
    const elementos = lista.getElementsByTagName("li");
    if (elementos.length > 0) {
        lista.removeChild(elementos[elementos.length - 1]);
    }
}
