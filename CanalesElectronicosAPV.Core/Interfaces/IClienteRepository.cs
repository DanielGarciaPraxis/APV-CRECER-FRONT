using CanalesElectronicosAPV.Core.Dto_s.Generic;
using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.Dto_s.Response;

namespace CanalesElectronicosAPV.Core.Interfaces
{
    public interface IClienteRepository
    {
        Task<GenericResponse<DatosClienteMainResponse>> ConsultarDatos(DatosClienteRequest clienteRequest);
        Task<GenericResponse<AfiliadoResponse>> InformacionUsuario(AfiliadoRequest data);
    }
}
