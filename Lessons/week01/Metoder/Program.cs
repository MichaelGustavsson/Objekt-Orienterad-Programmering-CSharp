namespace Metoder;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Calc returnerar: {0}", Calc(2.75));
        Console.WriteLine("Calc returnerar: {0}", Calc(2));
        Console.WriteLine("Calc returnerar: {0}", Calc(2,5));
        Console.WriteLine("Calc returnerar: {0}", Calc("Nisse"));
        Console.WriteLine("Calc returnerar: {0}", Calc(1,2,3,4,8,7,4,9,0,1,22));
    }

    // Signaturen är Calc(int x)
    static int Calc(int x){
        return x * x;
    }
    // Signaturen är Calc(int x, int y)
    static int Calc(int x, int y){
        return x * y;
    }
    // Signaturen är Calc(int[] values)
    static int Calc(params int[] values){
        Console.WriteLine("Antal värden i values: {0}", values.Length);
        // Returnera ett dummy värde i detta fall första värdet i vår array...
        return values[0];
    }
    static double Calc(double x){
        return x * x;
    }
    static int Calc(string x){
        return 10;
    }
}
