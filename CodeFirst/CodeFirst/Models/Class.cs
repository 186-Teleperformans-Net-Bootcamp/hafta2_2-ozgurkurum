using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
