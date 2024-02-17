using Domain.AutoMapperProfiles;
using Domain.Repositories;
using Domain.Validators;
using FluentAssertions.Common;
using FluentValidation;
using FluentValidation.AspNetCore;
using Infra;
using Infra.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

public class Program
{
    protected Program() { }
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string? defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(defaultConnection, ServerVersion.AutoDetect(defaultConnection)));
        builder.Services.AddFluentValidationAutoValidation();
        builder.Services.AddValidatorsFromAssemblyContaining<WorkerUpdateDTOValidator>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<ICredentialsRepository, CredentialsRepository>();
        builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        builder.Services.AddScoped<IWorkerRepository, WorkerRepository>();
        builder.Services.AddScoped<IPaymentMachinesRepository,PaymentMachineRepository>();
        builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        builder.Services.AddScoped<IPaymentMachineForWorkerRepository,PaymentMachineForWorkerRepository>();
        builder.Services.AddScoped<IProcedureRepository, ProcedureRepository>();
        builder.Services.AddScoped<IPaymentRepository,PaymentRepository>();

        builder.Services.AddAutoMapper(typeof(MappingProfile));



        builder.Services.Configure<ApiBehaviorOptions>(op =>
        {
            op.SuppressModelStateInvalidFilter = true;
        });

        var app = builder.Build();       
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }




        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}