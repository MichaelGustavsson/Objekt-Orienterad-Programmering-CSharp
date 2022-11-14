namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;
        // numbers[5] = 6;

        int[] numbers2 = {1,2,3,4};
        numbers2[3] = 5;

        string name = "Michael";

        Console.WriteLine("Tecken 2 = {0}", name[1]);
        Console.WriteLine("Tecken 2 = {0}", name.Substring(0));
        Console.WriteLine("Tecken 2 = {0}", name.Substring(2,2));


        Console.WriteLine("Storlek på min array: {0}", numbers.Length);
        Console.WriteLine("Storlek på min numbers2: {0}", numbers2.Length);
        Console.WriteLine("Värde: {0}", numbers2[2]);
        Console.WriteLine("Sista värdet: {0}", numbers[4]);
    }
}
