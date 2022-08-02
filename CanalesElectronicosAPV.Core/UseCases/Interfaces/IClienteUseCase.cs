using CanalesElectronicosAPV.Core.Dto_s.Generic;
using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.Dto_s.Response;
namespace CanalesElectronicosAPV.Core.UseCases.Interfaces
{
    public interface IClienteUseCase
    {
        Task<GenericResponse<AfiliadoResponse>> InformacionUsuario(AfiliadoRequest data);
        Task<GenericResponse<DatosClienteMainResponse>> ConsultarDatos(DatosClienteRequest clienteRequest);
    }
}
