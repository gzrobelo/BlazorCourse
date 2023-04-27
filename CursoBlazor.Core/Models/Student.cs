using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CursoBlazor.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoBlazor.Core.Models
{
    public partial class Student : TrackingModel
    {
        public Student()
        {
            PaymentReceipts = new HashSet<PaymentReceipt>();
        }

        [Key]
        public Guid StudentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string NumberControl { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SecondLastName { get; set; } = null!;
        public Guid CourseId { get; set; }
       
        [ForeignKey("CourseId")]
        [InverseProperty("Students")]
        public virtual Course Course { get; set; } = null!;
        [InverseProperty("Student")]
        public virtual ICollection<PaymentReceipt> PaymentReceipts { get; set; }
    }
}
