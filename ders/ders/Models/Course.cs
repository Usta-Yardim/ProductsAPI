using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ders.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        
        public string? Description { get; set; }
    }
}