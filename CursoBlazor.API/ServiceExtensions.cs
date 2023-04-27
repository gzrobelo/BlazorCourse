using CursoBlazor.API.Services;
using CursoBlazor.API.Services.Contracts;
using CursoBlazor.Application.Interfaces;
using CursoBlazor.Infraestructure.Context;
using CursoBlazor.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CursoBlazor.API
{
    public static class ServiceExtensions
    {
        public static void AddApplication(this IServiceCollection service)
        {
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddTransient(typeof(ICareerService),typeof(CareerService));
            //service.AddSingleton<BlazorContext>();
            //service.AddDbContext<BlazorContext>(opt =>
            //                 opt.UseInMemoryDatabase("BlazorDataContext"));
        }
    }
}
