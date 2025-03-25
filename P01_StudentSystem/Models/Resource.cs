using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    enum ResourceType {
        Video, Presentation, Document
    }
    class Resource
    {
        public int ResourceId { get; set; }

        [Unicode]
        [MaxLength(50)]
        public string Name { get; set; }

        [Unicode]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
