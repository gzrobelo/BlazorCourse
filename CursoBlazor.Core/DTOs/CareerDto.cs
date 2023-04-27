using System.ComponentModel.DataAnnotations;

namespace CursoBlazor.Core.DTOs
{
    public class CareerDto : DtoBase
    {
        [Required(ErrorMessage ="The {0} field is required!")]
        [MaxLength(ErrorMessage = "The CareerKey field must be greater than 0 characters and less than 20  ")]
        public string CareerKey { get; set; } = null!;

        [Required(ErrorMessage = "The {0} field is required!")]
        [MaxLength(ErrorMessage = "The Name field must be greater than 0 characters and less than 50 ")]
        public string Name { get; set; } = null!;

        [MaxLength(ErrorMessage = "The {0} field must be greater than 0 characters and less than 100 ")]
        public string? Description { get; set; }

        public CareerDto()
        {

        }
    }
}
