using AutoMapper;
using CanalesElectronicosAPV.Core.Dto_s.Generic;
using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.Dto_s.Response;
using CanalesElectronicosAPV.Core.Interfaces;
using CanalesElectronicosAPV.Core.UseCases.Interfaces;
namespace CanalesElectronicosAPV.Core.UseCases
{
    public class ClienteUseCase : IClienteUseCase
    {
        private readonly IClienteRepository _repository;
        public ClienteUseCase(IClienteRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<GenericResponse<DatosClienteMainResponse>> ConsultarDatos(DatosClienteRequest clienteRequest)
        {
            return await _repository.ConsultarDatos(clienteRequest);

        }

        public async Task<GenericResponse<AfiliadoResponse>> InformacionUsuario(AfiliadoRequest data)
        {
            var cliente = await _repository.InformacionUsuario(data);
            return cliente;
        }

       

        //private readonly IBitacoraApvRepository _repository;

        //public BitacoraApvUseCase(IBitacoraApvRepository repository)
        //{
        //    _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        //}
        //public async Task<ResponseStatus> GuardarBitacoraApv(BitacoraApvRequest bitacoraApv, List<string> servicios, string canal)
        //{
        //    List<BitacoraApvRequest> bitacora = new List<BitacoraApvRequest>();
        //    foreach (var item in servicios)
        //    {
        //        BitacoraApvRequest b = new BitacoraApvRequest()
        //        {
        //            IdCliente = bitacoraApv.IdCliente,
        //            CodigoProducto = bitacoraApv.CodigoProducto,
        //            CodigoFondo = bitacoraApv.CodigoFondo,
        //            NombreCliente = bitacoraApv.NombreCliente,
        //            Servicio = item,
        //            Canal = canal,
        //        };
        //        bitacora.Add(b);
        //    }
        //    var bitacoraResponse = await _repository.GuardarBitacoraApv(bitacora);

        //    return bitacoraResponse;
        //}

    }
}
