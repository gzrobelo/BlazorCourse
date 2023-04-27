using CursoBlazor.Core.DTOs;
using CursoBlazor.Core.Models;

namespace CursoBlazor.API.Services.Contracts
{
    public interface ICareerService
    {
        public Task<IEnumerable<Career>> GetAll();
        public Task<Career> AddCareer(CareerDto careerToAdd);
        public Task<Career> GetByCareerId(Guid id);

        public Task<Career> Update(CareerDto careerToUpdate);
        public Task Delete(Guid id);
       
    }
}
