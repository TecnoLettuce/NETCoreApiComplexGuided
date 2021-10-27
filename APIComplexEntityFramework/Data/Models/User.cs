using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Models
{
    public class User
    {        
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}