using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    class Course
    {
        public int CourseId { get; set; }

        [Unicode]
        [StringLength(80, MinimumLength = 10)]
        public string Name { get; set; }

        [Unicode]
        public string? Description { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }

        public ICollection<Student> Students { get; } = new List<Student>();
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();


    }
}
