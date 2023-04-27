using CursoBlazor.Core.DTOs;
using CursoBlazor.API.Services.Contracts;
using CursoBlazor.Application.Interfaces;
using CursoBlazor.Core.Models;


namespace CursoBlazor.API.Services
{
    public class CareerService : ICareerService
    {
        public IUnitOfWork _unitOfWork;
        public CareerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Career> AddCareer(CareerDto careerToAdd)
        {
            Career career = new()
            {
                CareerId = Guid.NewGuid(),
                CareerKey = careerToAdd.CareerKey,
                Name = careerToAdd.Name,
                Description = careerToAdd.Description,
                CreatedDate = DateTime.Now
            };

            _unitOfWork.CareerRepository.Add(career);

            await _unitOfWork.CommitAsync();

            return career;
        }

        

        public async Task<IEnumerable<Career>> GetAll() =>
            await _unitOfWork.CareerRepository.GetAllAsync();

        public async Task<Career> GetByCareerId(Guid id) =>
            await _unitOfWork.CareerRepository.GetAsync(car => car.CareerId == id);

        public async Task<Career> Update(CareerDto careerDtoToUpdate)
        {
            var searchCareer = await _unitOfWork.CareerRepository.GetAsync(car => car.CareerId == careerDtoToUpdate.Id);

            if (searchCareer != null)
            {
                Career careerToUpdate = new Career()
                {
                    CareerId = careerDtoToUpdate.Id,
                    CareerKey = searchCareer.CareerKey,
                    Name = careerDtoToUpdate.Name,
                    Description = careerDtoToUpdate.Description,
                    CreatedDate = searchCareer.CreatedDate,
                    ModifiedDate = DateTime.Now
                };

                 _unitOfWork.CareerRepository.Update(careerToUpdate);

                await _unitOfWork.CommitAsync();

                return careerToUpdate;
            }

            return new Career();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
