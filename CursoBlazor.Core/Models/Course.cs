using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CursoBlazor.Core.Models
{
    public partial class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public Guid CourseId { get; set; }
        [StringLength(10)]
        public string CourseKey { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public int Hours { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Description { get; set; }
        public Guid InstructorId { get; set; }
        public Guid CareerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [ForeignKey("CareerId")]
        [InverseProperty("Courses")]
        public virtual Career Career { get; set; } = null!;
        [ForeignKey("InstructorId")]
        [InverseProperty("Courses")]
        public virtual Instructor Instructor { get; set; } = null!;
        [InverseProperty("Course")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
