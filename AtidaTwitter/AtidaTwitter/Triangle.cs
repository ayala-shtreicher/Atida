using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtidaTwitter
{
    public class Triangle : Shape
    {
        public Triangle()
        {
        }

        public override float Area()
        {
            return (Width * Height) / 2;
        }

        public override float Scope()
        {
            return (float)Math.Sqrt(Math.Pow(0.5 * Width, 2) + Math.Pow(Height, 2)) * 2 + Width;
        }
        public override void PrintStars()
        {
            int linesCount, module, linesOdd;
            linesOdd = ((int)(Width / 2 - 1));
            linesCount = (int)((Height - 2) / linesOdd);
            module = (int)((Height - 2) % linesOdd);
            //drow first row
            for (int i = 0; i < linesOdd + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();

            for (int k = 0; k < linesOdd; k++)
            {

                for (int i = 0; i < linesCount + module; i++)
                {
                    for (int j = 0; j < linesOdd - k; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < 3 + k * 2; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
                module = 0;
            }
            //drow last row
            for (int i = 0; i < Width; i++)
            {
                Console.Write("*");
            }
        }
    }
}
