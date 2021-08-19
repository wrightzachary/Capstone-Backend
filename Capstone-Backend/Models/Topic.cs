﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Backend.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public int DateModified { get; set; }
        public int TopicName { get; set; }
    }
}