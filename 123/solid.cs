using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Solid
    {
        public float X1 { get; set; }

        public float Y1 { get; set; }

        public float X2 { get; set; }

        public float Y2 { get; set; }

        public float X3 { get; set; }

        public float Y3 { get; set; }

        public float X4 { get; set; }

        public float Y4 { get; set; }

        public Solid(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }
    }
}
