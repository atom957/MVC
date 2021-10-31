using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoiKrzyzyk
{
    public class Coordinates
    {
        public int x { get; }
        public int y { get; }
        public char k { get; set; }

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
