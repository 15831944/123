using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Text
    {

        public string text { get; set; }
        public float X { get; set; }

        public float Y { get; set; }

        public float textHeight { get; set; }
        public Text(string text, float x, float y)
        {
            this.text = text;
            this.X = x;
            this.Y = y;
        }

        public Text(string text, float x, float y, float textHeight) : this(text, x, y)
        {
            this.textHeight = textHeight;
        }
    }
}
