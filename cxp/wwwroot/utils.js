function confirmar3(title, text, pregunta, textcancel, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: pregunta,
            cancelButtonText: textcancel
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}
function confirmar(titulo, mensaje, icono) {
    return new Promise(resolve => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            icon: icono,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si'


        }).then((result) => {

            resolve(result.isConfirmed);

        })
    })

}

function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octect-stream;base64," + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function agregadetalle(title, text, pregunta, textcancel, icon) {
    return new Promise(resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: pregunta,
            cancelButtonText: textcancel
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}
