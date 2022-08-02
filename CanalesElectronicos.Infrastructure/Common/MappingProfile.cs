using AutoMapper;
using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicos.Infrastructures
{
    [ExcludeFromCodeCoverage]
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //CreateMap<DatosClienteResponse, ExtractoSaldoRequest>().ForMember(x => x.header, opt => opt.Ignore());
            //CreateMap<DatosBasicosRequest, AfiliadoRequest>().ForMember(dest => dest.NumeroDocumento, sou => sou.MapFrom(src => src.numeroIdentificacion)).
            //                                                  ForMember(dest => dest.TipoDocumento, sou => sou.MapFrom(src => src.codigoTipoIdentificacion));

            //CreateMap<AfiliadoResponse, BitacoraApvRequest>().ForMember(dest => dest.CodigoFondo, opt => opt.MapFrom(a => a.IdFondo))
            //                                                .ForMember(dest => dest.CodigoProducto, opt => opt.MapFrom(a => a.IdProducto))
            //                                                .ForMember(dest => dest.NombreCliente, opt => opt.MapFrom(a => string.Format("{0} {1} {2} {3}", a.PrimerNombre, a.SegundoNombre, a.PrimerApellido, a.SegundoApellido).TrimEnd()));
        }

    }   
        
}

