﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        [BindNever]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}
