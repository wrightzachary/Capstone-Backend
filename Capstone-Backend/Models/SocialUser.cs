using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Backend.Models
{
    public class SocialUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
