using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Template()
        {
        }

        public Template(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
