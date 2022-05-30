using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge16JsonSerializer.Models
{
    public class Members
    {
        public string name { get; set; }
        public int age { get; set; }
        public string secretIdentity { get; set; }
        public List<string> powers { get; set; }
    }
}
