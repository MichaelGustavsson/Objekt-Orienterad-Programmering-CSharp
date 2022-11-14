namespace Variabler;
class Program
{
    static void Main(string[] args)
    {        
        int age;
        age = 10;
        var newAge = 20;
        
        newAge = 49;
        var anotherAge = age.ToString();

        var x = Convert.ToDouble(newAge);

        Console.WriteLine("Åldern är: {0}", age);

        // Instantiate a new Person instance
        var person = new Person();
        Point point = new Point();
    }
}
    public class Person{
        string firstName = "";
        string lastName = "";
        string streetAddress = "";
        int age = 0;
    }

    public struct Point{
        int x;
        int y;
    }

