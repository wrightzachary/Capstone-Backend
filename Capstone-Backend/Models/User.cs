﻿using Microsoft.AspNetCore.Identity;

namespace Capstone_Backend.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
