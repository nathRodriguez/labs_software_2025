<template>
    <div class="container mt-5">
        <h1 class="display-4 text-center">Lista de paises</h1>
        <table
            class="table is-bordered is-striped is-narrow is-hoverable is-fullwidth"
        >
            <thead> 
                <tr>
                    <th>Nombre</th>
                    <th>Continente</th>
                    <th>Idioma</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Costa Rica</td>
                    <td>América</td>
                    <td>Español</td>
                    <td>
                        <button class="btn btn-secondary btn-sm">Editar</button>
                        <button class="btn btn-danger btn-sm">Eliminar</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: "ListaPaises",
    };
</script>

<style lang="scss" scoped>

</style>