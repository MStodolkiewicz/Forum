﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CreateTopicDto
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

    }
}
