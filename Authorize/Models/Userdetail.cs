using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Authorizationdemo1.Models
{
    public class Userdetail
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}