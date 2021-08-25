using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneBackend.Models 
{
    public class Post
    {
        public int PostId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public string User { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        public string Topic { get; set; }
        public string PostName { get; set; }
        public int DateCreated { get; set; }
    }
}