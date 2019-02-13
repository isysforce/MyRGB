using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRGB
{
    class Zone_t
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ZoneMode_t Mode { get; set; }
        public string Description { get; set; }

        public int LedCount { get; set; }


    }
}
