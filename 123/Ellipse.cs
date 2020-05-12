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
        public float ratio { get; set; }


        public Ellipse(float x, float y, float ratio)
        {
            this.x = x;
            this.y = y;
            this.ratio = ratio;
        }
    }
}
