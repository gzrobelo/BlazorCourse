using CursoBlazor.Application.Interfaces;
using CursoBlazor.Core.Models;
using CursoBlazor.Infraestructure.Context;


namespace CursoBlazor.Infraestructure.Repositories
{
    public class CareerRepository : GenericRepository<Career>, ICareerRepository
    { 
        public CareerRepository(BlazorContext dbContext) : base(dbContext)
        {
          
        }
    }
}
