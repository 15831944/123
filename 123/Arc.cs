using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Arc
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Z { get; set; }

        public float startAngle { get; set; }
        public float endAngle { get; set; }

        public Arc(float x, float y, float z, float startAngle, float endAngle)
        {
            X = x;
            Y = y;
            Z = z;
            this.startAngle = startAngle;
            this.endAngle = endAngle;
        }
    }
}
