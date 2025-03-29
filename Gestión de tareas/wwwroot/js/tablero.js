function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    var tareaElement = document.getElementById(data);
    ev.target.appendChild(tareaElement);

    // Extraer ID y nuevo estado
    var tareaId = data.split("-")[1];
    var nuevoEstado = ev.target.id === "pendiente" ? "Pendiente" : "Completa";

    // Llamar a Blazor para actualizar la base de datos
    DotNet.invokeMethodAsync('GestionTareasApp', 'CambiarEstadoTarea', parseInt(tareaId), nuevoEstado);
}
