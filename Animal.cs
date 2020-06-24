namespace InterfaceImplementation
{
    class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal() { Species = string.Empty; Name = string.Empty; }
        public Animal(string species, string name) { Species = species; Name = name; }
    }
}
