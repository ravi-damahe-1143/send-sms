﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class Lead
    {
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Display(Name = "Your Phone Number")]
        public string Phone { get; set; }
        [Display(Name = "How can we help?")]
        public string Message { get; set; }
        public string Result { get; set; }
    }
}