using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Roses : IVegetation, IData
    {
        public string Leafcolor { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
    }
}
