using static Circustrein.Weight;

namespace Circustrein
{
    public class Animal
    {
        //fields
        private string name;

        private Size weight;
        private bool added;
        private Type.typeAnimal typeAnimal;

        //constructor
        public Animal(string name, Size weight, Type.typeAnimal typeAnimal)
        {
            this.Name = name;
            this.Weight = weight;
            this.typeAnimal = typeAnimal;
        }

        //properties
        public string Name { get => name; set => name = value; }

        public Size Weight { get => weight; set => weight = value; }
        public bool Added { get => added; set => added = value; }
        public Type.typeAnimal TypeAnimal { get => typeAnimal; }

        //methods
        public override string ToString()
        {
            return $"{Name}, {Weight}";
        }
    }
}