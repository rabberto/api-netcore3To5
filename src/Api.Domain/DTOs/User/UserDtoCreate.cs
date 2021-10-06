using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name Email deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}