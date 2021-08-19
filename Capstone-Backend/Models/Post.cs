using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Backend.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public SocialUser User { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int DateCreated { get; set; }
    }
}
