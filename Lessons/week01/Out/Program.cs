namespace Out;
class Program
{
    static void Main(string[] args)
    {
        // Min out variabel...
        int x;

        // Code smell 🤬
        var result = OutMetod(5, out x);

        Console.WriteLine("Resultat ifrån OutMetodens return rad: {0}", result);
        Console.WriteLine("Resultat ifrån OutMetodens out variabel: {0}", x);

        // Enda gången det är OK att använda out som nyckelord...
        // Enligt Michael...
        var ok = int.TryParse("Michael", out x);

        if(ok){
            Console.WriteLine("Okidoki");
        }else{
            Console.WriteLine("Inte okidoki");
        }

    }

    static int OutMetod(int arg1, out int arg2){
        arg2 = 100;
        return arg1 * 2;
    }
}
