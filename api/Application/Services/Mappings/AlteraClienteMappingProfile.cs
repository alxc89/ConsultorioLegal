﻿using AutoMapper;
using ConsultorioLegal.api.UI.ModelView;
using src.api.Domain.Entities;

namespace ConsultorioLegal.api.Application.Services.Mappings
{
    public class AlteraClienteMappingProfile : Profile
    {
        public AlteraClienteMappingProfile()
        {
            CreateMap<AlteraCliente, Cliente>()
                .ForMember(d => d.UltimaAlteracao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
