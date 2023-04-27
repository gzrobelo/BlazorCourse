using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CursoBlazor.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoBlazor.Core.Models
{
    public partial class PaymentReceipt : TrackingModel
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Invoice { get; set; } = null!;
        public Guid StudentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
       
        [ForeignKey("StudentId")]
        [InverseProperty("PaymentReceipts")]
        public virtual Student Student { get; set; } = null!;
    }
}
