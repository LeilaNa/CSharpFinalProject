using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ComboItem
    {
         
        public int Value { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}

