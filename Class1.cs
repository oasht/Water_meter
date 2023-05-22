using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_meter
{
    internal class Meter
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime CheckDate { get; set; }
        public bool Temp { get; set; }
    }
}
