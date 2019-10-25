using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Models
{
    public class UserProfile
    {
        public int userId { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

    }
}
