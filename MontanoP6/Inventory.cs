using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP6
{
    public class Inventory
    {
        public Inventory(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
