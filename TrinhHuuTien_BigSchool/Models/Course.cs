﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrinhHuuTien_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lectuser { get; set; }
        [Required]
        public string LectuserId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }

   
  
}