﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Entities
{
    public class User
    {
        private int Id { get; set;}
        private string HashedPassword { get; set;}

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public string Email { get ; set;}
        
    }
}