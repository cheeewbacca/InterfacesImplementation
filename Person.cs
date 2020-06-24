using System;
using System.Collections;
namespace InterfaceImplementation
{
    class Person : IEnumerable, IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        Animal pet;

        public Person() { FirstName = string.Empty; LastName = string.Empty; pet = new Animal(); }
        public Person(string firstName, string lastName, string species, string name) { FirstName = firstName;
            LastName = lastName; pet = new Animal(species, name); }

        public override string ToString() => $"{FirstName} {LastName} has a {pet.Species} {pet.Name}";
        public IEnumerator GetEnumerator()
        {
            yield return FirstName;
            yield return LastName;
            yield return pet.Species;
            yield return pet.Name;
        } 
        public object Clone()
        {
            Person newPerson = (Person)this.MemberwiseClone();
            Animal newAnimal = new Animal();
            newAnimal.Species = this.pet.Species;
            newAnimal.Name = this.pet.Name;
            newPerson.pet = newAnimal;
            return newPerson;
        }
        int IComparable.CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp != null)
            {
                if ((int)this.FirstName[0] > (int)temp.FirstName[0])
                    return 1;
                if ((int)this.FirstName[0] < (int)temp.FirstName[0])
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Parametr is not an Animal");
        }
    }
}
