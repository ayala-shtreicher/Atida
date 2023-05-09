using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AtidaTwitter
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public override float Area()
        {
            return Width * Height;
        }

        public override void PrintStars()
        {
            throw new NotImplementedException();
        }

        public override float Scope()
        {
           return Width * 2 + Height * 2;
        }
    }
}
