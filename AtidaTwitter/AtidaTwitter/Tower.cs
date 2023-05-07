using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtidaTwitter
{
    public class Tower
    {
        Shape myTower;

        public Tower(Shape shape)
        {
            myTower = shape;
        }


        public void SetWidth(int width)
        {
            myTower.Width = width;
        }

        public float Scope()
        {
            return myTower.Scope();
        }

        public bool LessThen5()
        {
            return Math.Abs(myTower.Height - myTower.Width) > 5;
        }

        public float Area()
        {
            return myTower.Area();
        }

        public bool PrintValidation()
        {
            return myTower.Width % 2 == 0 || myTower.Height * 2 < myTower.Width;
        }
        public void PrintStars()
        {
            myTower.PrintStars();
        }
    }
}
