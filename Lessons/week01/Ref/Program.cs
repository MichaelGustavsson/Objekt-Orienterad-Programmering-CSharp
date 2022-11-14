namespace Ref;
class Program
{
    static void Main(string[] args)
    {
        int x = 10;

        // Skickar med adressen till x dvs värdet 10
        var result = RefMetod(2, ref x);
        Console.WriteLine("Resultat ifrån RefMetoden {0}", result);
        Console.WriteLine("Resultat ifrån RefMetodens ref argument {0}", x);
    }

    static int RefMetod(int arg1, ref int arg2){
        // Adressen till x finns nu i argumentet/parametern arg2...
        // Vi uppdaterar adressen och dess värde till 100...
        arg2 = 100;
        return arg1 * 2;
    }
}
