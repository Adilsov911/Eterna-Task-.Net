using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Date { get; set; }
        public string Description { get; set; }

        public int? TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public int? SearchId { get; set; }
        public Search Search { get; set; }
    }
}
