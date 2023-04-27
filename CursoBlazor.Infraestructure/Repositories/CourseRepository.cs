using CursoBlazor.Application.Interfaces;
using CursoBlazor.Core.Models;
using CursoBlazor.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Infraestructure.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(BlazorContext dbContext) : base(dbContext)
        {

        }
    }
}
