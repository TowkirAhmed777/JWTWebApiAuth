using System.ComponentModel.DataAnnotations;

namespace JWTWebApiAuth.Core.Dtos
{
    public class UpdatePermissionDto
    {

        [Required(ErrorMessage = "UserName is required")]
        public int UserName { get; set; }
  }
} 
