'use strict'

function changeActiveMenu(id) {
    const el1 = document.querySelector(`[href="${id}"]`).classList.toggle("active-custom");

}
function getCustomerData() {
    var settings = {
        "url": `${window.location.origin}/customerdata/getdata`,
        "method": "get",
        "timeout": 0,
        "headers": {
            "Content-Type": "application/json"
        }
    };

    $.ajax(settings).done(function (response) {
        var data = JSON.parse(response);
        var dataCliete = data.item.informacionPersonaDTO.datosBasicosClienteApvDTO;
        var vinculacionesDTO = data.item.vinculacionesDTO;
        var ubicacionesYLocalizadoresDTO = data.item.ubicacionesYLocalizadoresDTO;
        $('#clienteName').text(`${dataCliete.primerNombre} ${dataCliete.segundoNombre} ${dataCliete.primerApellido} ${dataCliete.segundoApellido}`);
        $('#tipoDoc').text(`${dataCliete.codigoTipoIdentificacion} `);
        $('#nit').text(`${dataCliete.nit}`);
        $('#fechaNac').text(`${dataCliete.fechaNacimiento}`);
        $('#docIdent').text(`${dataCliete.codigoTipoIdentificacion}`);
        $('#asesor').text(`${dataCliete.nombreAsesorAsignado} `);
        $('#nacionalidad').text(`${dataCliete.nombreNacionalidad}`);
        $('#expDoc').text(`${dataCliete.paisExpedicionIdentificacion}`);
        $('#anuencia').text(`${dataCliete.anuencia}`);
        $('#ocupacion').text(`${vinculacionesDTO.productosDTO[0].ocupacion}`);
        $('#vencDoc').text(`${dataCliete.fechaVencimientoIdentificacion}`);
        $('#estCivil').text(`${dataCliete.estadoCivil} `);
        $('#paisExpDoc').text(`${dataCliete.paisExpedicionIdentificacion}`);
        $('#estadoCliente').text(`${dataCliete.estadoAfiliado}`);
        $('#ciudadExpDoc').text(`${dataCliete.ciudadExpedicionIdentificacion}`);
        if (ubicacionesYLocalizadoresDTO.length > 0) {
            $('#cel').text(`${ubicacionesYLocalizadoresDTO[0].localizadores.localizadorCelular[0].numeroCelular}`);
            $('#tel').text(`${ubicacionesYLocalizadoresDTO[0].localizadores.localizadorTelefono[0].numeroTelefonico}`);
            $('#email').text(`${ubicacionesYLocalizadoresDTO[0].localizadores.localizadorCorreoElectronico[0].correoElectronico}`);
            $('#direccion').text(`${ubicacionesYLocalizadoresDTO[0].localizadores.localizadorDireccionFisica[0].direccionFisica}`);
        }
        if (ubicacionesYLocalizadoresDTO.length > 1) {
            $('#celular2').text(`${ubicacionesYLocalizadoresDTO[1].localizadores.localizadorCelular[0].numeroCelular}`);
            $('#tel2').text(`${ubicacionesYLocalizadoresDTO[1].localizadores.localizadorTelefono[0].numeroTelefonico}`);
            $('#dir2').text(`${ubicacionesYLocalizadoresDTO[1].localizadores.localizadorDireccionFisica[0].direccionFisica}`);
        }


        //console.log(response);
    });

}


window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
       
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            
        });
    }
    const expandirInfo = document.body.querySelector('#expandirInfo');
    if (expandirInfo) {
        
        expandirInfo.addEventListener('click', event => {
            event.preventDefault();
            var sbTopnav = document.getElementsByClassName("sb-topnav");
            sbTopnav[0].classList.toggle("expandInfo");
            var layoutSidenav = document.getElementById("layoutSidenav_content");
            layoutSidenav.classList.toggle("margin-movil-dinamic");

        });
    }
    let tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl, {
            container: 'body',
            trigger: 'click'
        });
    });

    changeActiveMenu(window.location.pathname);
    getCustomerData();
});