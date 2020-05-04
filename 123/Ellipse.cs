using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Ellipse
    {
        public float x { get; set; }
        public float y { get; set; }
        public float endAngle { get; set; }
        public float startAngle { get; set; }

        public Ellipse(float x, float y, float endAngle, float startAngle)
        {
            this.x = x;
            this.y = y;
            this.endAngle = endAngle;
            this.startAngle = startAngle;
        }
    }
}
