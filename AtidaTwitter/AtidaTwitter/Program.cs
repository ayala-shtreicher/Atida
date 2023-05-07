using AtidaTwitter;


bool flag = false;
Tower tower;
do
{
    Console.WriteLine();
    Console.WriteLine("Choose the appropriate option from the three options: " +
        "\n 1. A rectangular tower " +
        "\n 2. Triangle tower " +
        "\n 3. Go out");

    bool parse = int.TryParse(Console.ReadLine(), out int x);
    if (x == 3)
    {
        Console.WriteLine("Goodbye");
        flag = true;
    }
    if (x == 1)
    {
        //rectangle
        Rectangle rectangle = new Rectangle();

        Console.WriteLine("enter width:");
        float.TryParse(Console.ReadLine(), out float width);
        rectangle.Width = width;
        Console.WriteLine("enter height:");
        rectangle.Height = float.Parse(Console.ReadLine());

        tower = new Tower(rectangle);

        if (tower.LessThen5())
            Console.WriteLine("area: " + tower.Area());
        else
            Console.WriteLine("scope: " + tower.Scope());
    }
    //triangle
    if (x == 2)
    {
        //rectangle
        Triangle triangle = new Triangle();

        Console.WriteLine("enter width:");
        float.TryParse(Console.ReadLine(), out float width);
        triangle.Width = width;
        Console.WriteLine("enter height:");
        triangle.Height = float.Parse(Console.ReadLine());

        tower = new Tower(triangle);
        Console.WriteLine("scope: " + tower.Scope());
        if (tower.PrintValidation())
            Console.WriteLine("The triangle cannot be printed");

        else
            tower.PrintStars();
    }    
} while (!flag) ;

Console.ReadKey();



