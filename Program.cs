using System.Globalization;
using ConsultorioLegal.api.Application.Services.Mappings;
using ConsultorioLegal.api.Application.Services.Validator;
using ConsultorioLegal.Configuration;
using ConsultorioLegal.Configurations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using src.api.Application.Services.Validator;
using src.api.Infrastructure.Database.Context;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite("Data source=consultorio_legal.db");
        });

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddFluentValidationConfiguration();

        builder.Services.AddAutoMapperConfiguration();
        builder.Services.AddDependecyInjectionConfiguration();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerConfiguration();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseSwaggerConfiguration();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}