namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        // Skapa en array för 5 heltal
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        for (var i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(@"index: {0} value: {1}", i, numbers[i]);
        }

        /*
            Om vi behöver ändra storleken på vår array behöver vi skapa en ny array
            och kopiera det befintliga data i vår gamla array.
            Sedan ominitierar vi vår ursprungliga array till den önskade storleken.
            Avslutningsvis kopierar vi datat ifrån vår kopia över till den ominitierade
            array'en
        */

        // Skapa en ny array som ska fungera som en temporär kopia
        // int[] copy = new int[numbers.Length];
        // Kopiera allt ifrån vår numbers array till vår copy array.
        // CopyTo tar två argument:
        // Det första är vart vi ska kopiera till
        // Det andra är ifrån vilken position ska vi börja kopiera ifrån.
        // numbers.CopyTo(copy, 0);

        // Det finns ett mer modernt sätt från och med C# 8.0 som vi kan använda...
        // Observera att detta kopierar allt ifrån numbers och skapar en ny array
        // med exakt antal element som existerar i numbers(käll array)...
        var copy = numbers[..];

        Console.WriteLine("-----------------------------------------");

        for (var i = 0; i < copy.Length; i++)
        {
            Console.WriteLine(@"index: {0} value: {1}", i, numbers[i]);
        }

        // Ominitiera vår numbers array att nu kunna hantera 10 element/värden
        numbers = new int[10];
        // Kopiera ifrån vår kopia till vår ominitierade array.
        copy.CopyTo(numbers, 0);
        // Denna syntax fungerar inte.
        //numbers = copy[..];

        // Addera ett nytt element på en ny position...
        numbers[5] = 6;

        Console.WriteLine("-----------------------------------------");

        for (var i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(@"index: {0} value: {1}", i, numbers[i]);
        }

        var temp = numbers[..];

        Console.WriteLine("-----------------------------------------");

        for (var i = 0; i < temp.Length; i++)
        {
            Console.WriteLine(@"index: {0} value: {1}", i, temp[i]);
        }
    }
}
