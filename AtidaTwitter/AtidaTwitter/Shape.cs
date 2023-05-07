using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtidaTwitter
{
    public abstract class Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Shape() { }
        public abstract float Scope();
        public abstract float Area();
        public abstract void PrintStars();
       
    }
}
