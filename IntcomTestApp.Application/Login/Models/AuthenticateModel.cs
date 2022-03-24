using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntcomTestApp.Application.Login.Dto
{
    public class AuthenticateModel
    {
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Senha { get; set; }
    }
}
