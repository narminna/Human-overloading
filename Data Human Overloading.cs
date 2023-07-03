using System;
namespace Consoleapp6
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string name, string surname, int age, int weight, int height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, age: {Age}, weight: {Weight}, Height: {Height}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            Person person = new Person(name, surname, age, weight, height);
            Console.WriteLine(person.ToString());
        }
    }
}

