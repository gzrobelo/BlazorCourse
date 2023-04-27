using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoBlazor.Application.Interfaces;
using CursoBlazor.Core.Models;
using CursoBlazor.Infraestructure.Context;

namespace CursoBlazor.Infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        //public ICareerRepository Careers { get; }
        //public ICourseRepository Courses { get; }

        //public IInstructorRepository Instructors { get; }

        //public IPaymentReciept PaymentReciepts { get; }

        //public IStudentRepository Students { get; }


        //public UnitOfWork(ICareerRepository carrerRepository)
        //{
        //    Careers = carrerRepository;
        //    //Courses = 
        //}
        private readonly BlazorContext _dbContext;
        private ICareerRepository _careerRepository;
        private ICourseRepository _courseRepository;


        public UnitOfWork(BlazorContext dbContext)
        {
            _dbContext = dbContext;
        }


        public ICareerRepository CareerRepository
        {
            get { return _careerRepository = _careerRepository ?? new CareerRepository(_dbContext); }
        }

        public ICourseRepository CourseRepository
        {
            get { return _courseRepository = _courseRepository ?? new CourseRepository(_dbContext); }
        }

       

        public IInstructorRepository InstructorRepository => throw new NotImplementedException();

        public IPaymentReciept PaymentRecieptRepository => throw new NotImplementedException();

        public IStudentRepository StudentRepository => throw new NotImplementedException();

        public void Commit()
            => _dbContext.SaveChanges();


        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();


        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();



    }
}
