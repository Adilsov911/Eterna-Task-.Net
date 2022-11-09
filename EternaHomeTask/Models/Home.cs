using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int? AboutId { get; set; }
        public About About { get; set; }

        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
