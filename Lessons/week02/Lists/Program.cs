using System.Collections;

namespace Lists;

class Person
{
    public string Name = "";
    public int Age;
    public string Address = "";
}

class Vehicle
{
    public string Make = "";
    public string Model = "";
    public int ModelYear;
    public int Mileage;
}
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("i = {0}", i);
        }

        ArrayList objects = new ArrayList();

        objects.Add(1);
        objects.Add("Michael");
        objects.Add(DateTime.Today);
        objects.Add(2.25);
        objects.Add(true);
        Console.WriteLine("\nArrayList and for loop ---------------------\n");
        for (int i = 0; i < objects.Count; i++)
        {
            Console.WriteLine("item = {0}", i);
        }
        Console.WriteLine("\nArray List and foreach loop ---------------------\n");
        foreach (var item in objects)
        {
            Console.WriteLine("item = {0}", item);
        }

        ArrayList newList = new ArrayList{
            new Person { Name = "Michael", Age = 58, Address = "Gatan 1" },
            new Vehicle { Make = "Volvo", Model = "V90", ModelYear = 2019, Mileage = 45000 }
        };

        Console.WriteLine("\nCasting to correkt type ---------------------\n");

        // foreach (var item in newList)
        // {
        //     Console.WriteLine("{0}", ((Person)item).Name);
        //     Console.WriteLine("{0}", ((Vehicle)item).Name);
        // }        

        foreach (var item in newList)
        {
            var person = item as Person;
            if (person is not null)
            {
                Console.WriteLine("{0}", ((Person)item).Name);
            }
            if (item as Vehicle is not null)
            {
                Console.WriteLine("{0}", ((Vehicle)item).Make);
            }
        }

        Console.WriteLine("\nSimplified cast ---------------------\n");

        // En förenklad syntax för göra en konvertering
        // Vi kan använda en referens variabel skapad i if satsen...
        foreach (var item in newList)
        {
            if (item is Vehicle v)
            {
                Console.WriteLine(v.Make);
            }

            if (item is Person p)
            {
                Console.WriteLine(p.Name);
            }
        }

        // Generic list, the way to go...
        var vehicles = new List<Vehicle>{
            new Vehicle{Make="Ford", Model="Mustang MACH-E", ModelYear=2022, Mileage=100},
            new Vehicle{Make="Volvo", Model="XC60", ModelYear=2018, Mileage=89000},
            // new Person{}
        };

        var persons = new List<Person> {
            new Person{Name="Oscar", Age = 33, Address="Hörngatan 4"},
            // new Vehicle{}
        };
    }
}
