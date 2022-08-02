using CanalesElectronicosAPV.Core.Dto_s.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CanalesElectronicosAPV.Core.Dto_s.Generic
{
    [ExcludeFromCodeCoverage]
    public class GenericResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T Item { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ResponseEstadoCuenta<T>
    { 
        public ResponseStatus Status { get; set; }
        public ResponseItem<T> Item { get; set; }
        public string Periodo { get; set; }
    }

}
