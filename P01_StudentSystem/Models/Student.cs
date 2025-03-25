using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    class Student
    {
        public int StudentId { get; set; }

        [Unicode]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        [Unicode(false)]
        [StringLength(10, MinimumLength = 10)]

        public string? PhoneNumber { get; set; } 
        public DateTime RegisteredOn { get; set; }
        
        public string? Birthday { get; set; }

        public ICollection<Course> Courses { get; } = new List<Course>();
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();


    }
}
