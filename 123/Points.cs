using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zabawa
{
    class Points
    {
        public double X1 { get; set; }
        public double X2 { get; set; }

        public double Y1 { get; set; }

        public double Y2 { get; set; }

        public Points(double x1, double y1)
        {
            X1 = x1;
            Y1 = y1;
        }

        public Points(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }
    }
}
