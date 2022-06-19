using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using TrinhHuuTien_BigSchool.Models;

namespace TrinhHuuTien_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(Date + " " + Time, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        }

        public IEnumerable<Course> UpComingCourses { get; set; }
        public bool ShowAction{ get; set;}
        }
}