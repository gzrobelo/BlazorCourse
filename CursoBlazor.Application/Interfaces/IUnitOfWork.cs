using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Application.Interfaces
{
    //public interface IUnitOfWork
    //{
    //    ICareerRepository Careers { get; }
    //    ICourseRepository Courses { get; }
    //    IInstructorRepository Instructors { get; }
    //    IPaymentReciept PaymentReciepts { get; }
    //    IStudentRepository Students { get; }
    //}

    public interface IUnitOfWork 
    {
        ICareerRepository CareerRepository { get; }
        ICourseRepository CourseRepository { get; }
        IInstructorRepository InstructorRepository { get; }
        IPaymentReciept PaymentRecieptRepository { get; }
        IStudentRepository StudentRepository { get; }

        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
