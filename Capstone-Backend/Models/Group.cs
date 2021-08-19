using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Backend.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public SocialUser User { get; set; }
        public string GroupName { get; set; }
    }
}
