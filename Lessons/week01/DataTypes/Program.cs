namespace DataTypes;
class Program
{
    class One
    {
        public int varX;
    }

    static void Main(string[] args)
    {
        int x = 10;
        int y = 5;

        Console.WriteLine(@"
            {0},
            {1}
        ", x, y); Console.WriteLine("Hello, World!");

        y = x;
        Console.WriteLine(@"
            {0},
            {1}
        ", x, y); Console.WriteLine("Hello, World!");

        if (x == y)
        {
            Console.WriteLine("x och y är samma");
        }

        x = 5;

        Console.WriteLine(@"
            {0},
            {1}
        ", x, y);

        var objectOne = new One();
        var objectTwo = new One();

        objectOne.varX = 10;
        objectTwo = objectOne;

        if (objectOne == objectTwo)
        {
            Console.WriteLine("Objekt One är samma som Objekt Two");
        }
        else
        {
            Console.WriteLine("Objekt One är inte samma som Objekt Two");
        }

        Console.WriteLine(@"
            {0},
            {1}
        ", objectOne.varX, objectTwo.varX);

        objectTwo.varX = 200;

        Console.WriteLine(@"
            {0},
            {1}
        ", objectOne.varX, objectTwo.varX);
    }
}
