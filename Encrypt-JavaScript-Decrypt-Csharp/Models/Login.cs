using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Encrypt_JavaScript_Decrypt_Csharp.Models
{
    public class Login
    {
      
            [Required(ErrorMessage = "Enter Username")]
            public string Username { get; set; }
            [Required(ErrorMessage = "Enter Password")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
    }
}