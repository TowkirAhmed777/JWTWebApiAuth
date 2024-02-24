﻿using System.ComponentModel.DataAnnotations;

namespace JWTWebApiAuth.Core.Dtos
{
    public class UpdatePermissionDto
    {

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
  }
} 
