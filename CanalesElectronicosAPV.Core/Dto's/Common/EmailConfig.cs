using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CanalesElectronicosAPV.Core.Dto_s.Common
{
    [ExcludeFromCodeCoverage]
    public class EmailConfig
    {
        public string UsrApvCliente { get; set; }
        public string VersionApvCliente { get; set; }
        public string CuentaMailCarne { get; set; }
        public string AsuntoCarne { get; set; }
        public string CuentaMailEstadoCuenta { get; set; }
        public string CuentaMailEsadoCuentaCero { get; set; }
        public string AsuntoEstadoCuenta { get; set; }
        public string AsuntoHistoricoMovimientos { get; set; }
        public string CuentaMailHistoricoMovimientos { get; set; }
        public string CuentaMailHistoricoMovimintosSaldoCero { get; set; }
    }
}
