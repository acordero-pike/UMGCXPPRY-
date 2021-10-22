function confirmar(titulo, mensaje, icono) {
    return new Promise(resolve => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            icon: icono,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si Eliminar'


        }).then((result) => {
             
            resolve(result.isConfirmed);
             
        })})
   
}
