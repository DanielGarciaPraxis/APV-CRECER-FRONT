using CanalesElectronicosAPV.Core.Dto_s.Common;

namespace CanalesElectronicos.Infrastructures.Common
{
    public interface IRestRepository
    {
        IDictionary<string, string> Headers { get; set; }
        Task<RestRepositoryDto> DatosConsumerAsync(ConsultService datos, object request);
        Task<RestRepositoryDto> DatosAsyncGet(ConsultService datos);
    }
}
