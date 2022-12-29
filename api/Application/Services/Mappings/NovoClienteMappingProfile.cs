using AutoMapper;
using ConsultorioLegal.api.UI.ModelView;
using src.api.Domain.Entities;

namespace ConsultorioLegal.api.Application.Services.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
            CreateMap<NovoEndereco, Endereco>();
            CreateMap<NovoTelefone, Telefone>();
        }
    }
}
