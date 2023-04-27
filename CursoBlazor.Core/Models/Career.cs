using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace CursoBlazor.Core.Models
{
    public partial class Career : TrackingModel
    {
        public Career()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public Guid CareerId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string CareerKey { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Description { get; set; }
       

        [InverseProperty("Career")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
