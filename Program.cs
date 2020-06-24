using System;
namespace InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            Menu.Initialization(people);
            Menu.ShowInfo(people);
            Menu.Sort(people);
            Menu.ShowInfo(people);
            Menu.UsingEnumerator(people[0]);
            Console.ReadKey();
        }
    }
}
