using AtidaTwitter;


int x, countmid, modulmid, numbers;
bool flag = false;
Tower tower = new Tower();
do
{
    Console.WriteLine();
    Console.WriteLine("Choose the appropriate option from the three options: \n 1. A rectangular tower \n 2. Triangle tower \n 3. Go out");
    x = int.Parse(Console.ReadLine());
    if (x == 3)
    {
        Console.WriteLine("Goodbye");
        flag = true;
    }
    else
    {
        Console.WriteLine("enter width:");
        tower.Width = int.Parse(Console.ReadLine());
        Console.WriteLine("enter height:");
        tower.Height = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            tower.eType = EType.Rectangular;
            if (Math.Abs(tower.Height - tower.Width) > 5)
                Console.WriteLine("area: " + tower.Width * tower.Height);
            else
                Console.WriteLine("scope: " + tower.Width * 2 + tower.Height * 2);
        }
        else
        {
            tower.eType = EType.Triangle;
            Console.WriteLine("scope: " + (Math.Sqrt(Math.Pow(0.5 * tower.Width, 2) + Math.Pow(tower.Height, 2)) * 2 + tower.Width));
            if (tower.Width % 2 == 0 || tower.Height * 2 < tower.Width)
                Console.WriteLine("The triangle cannot be printed");
            else
            if (tower.Width % 2 == 1 && tower.Height * 2 > tower.Width)
            {
                numbers = (tower.Width / 2 - 1);
                countmid = (tower.Height - 2) / numbers;
                modulmid = (tower.Height - 2) % numbers;
                //drow first row
                for (int i = 0; i < numbers + 1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();

                for (int k = 0; k < numbers; k++)
                {

                    for (int i = 0; i < countmid + modulmid; i++)
                    {
                        for (int j = 0; j < numbers - k; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < 3 + k * 2; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    modulmid = 0;
                }
                //drow last row
                for (int i = 0; i < tower.Width; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }

} while (!flag);

Console.ReadKey();



