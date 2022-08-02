using CanalesElectronicosAPV.Core.Dto_s.Response;
using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicosAPV.Core.Dto_s.Common
{
    [ExcludeFromCodeCoverage]
    public class RestRepositoryDto
    {
        public ResponseStatus Status { get; set; }
        public string Json { get; set; }
    }
}
