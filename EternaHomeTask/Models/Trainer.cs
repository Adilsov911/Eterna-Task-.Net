using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public List<About> Abouts { get; set; }
    }
}
