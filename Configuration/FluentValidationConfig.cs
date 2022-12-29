using ConsultorioLegal.api.Application.Services.Validator;
using FluentValidation.AspNetCore;
using src.api.Application.Services.Validator;
using System.Globalization;
using Newtonsoft.Json;

namespace ConsultorioLegal.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                .AddFluentValidation(p =>
                {
                    p.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<AlteraClienteValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<NovoEnderecoValidator>();
                    p.RegisterValidatorsFromAssemblyContaining<NovoTelefoneValidator>();
                    p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                });
        }
    }
}
