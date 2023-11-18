using Microsoft.VisualBasic;
using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car()
            { 
                Make = "Scion",
                Model = "tC",
                Year = 2008,

            };

            Console.WriteLine($"My car is a {Car.Year} {Car.Make} {Car.Model}");
           

        }
    }
}
