using System;
namespace InterfaceImplementation
{
    static class Menu
    {
        delegate void MessageHandler(string message);
        static event MessageHandler ShowMessage;
        static Menu() => ShowMessage += Display;
        public static void Initialization(Person[] people)
        {
            people[0] = new Person("Sherlock", "Holmes", "dog", "Baskerville");
            people[1] = (Person)people[0].Clone();
            people[2] = new Person("Pleasance", "Alice", "rabbit", "Nivens mcTwisp");
        }
        static void Display(string message) => Console.WriteLine(message);
        public static void ShowInfo(Person[] people)
        {
            foreach (var person in people)
                ShowMessage.Invoke(person.ToString());
        }
        public static void Sort(Person[] people) => Array.Sort(people);
        public static void UsingEnumerator(Person person)
        {
            ShowMessage.Invoke("Using Enumerator");
            foreach (var data in person)
                ShowMessage.Invoke((string)data);
        }
    }
}
