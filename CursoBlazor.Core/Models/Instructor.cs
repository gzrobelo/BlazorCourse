using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CursoBlazor.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoBlazor.Core.Models
{
    public partial class Instructor : TrackingModel
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public Guid InstructorId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Degree { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string FullName { get; set; } = null!;
       
        [InverseProperty("Instructor")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
