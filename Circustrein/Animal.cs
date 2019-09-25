namespace Circustrein
{
    public class Animal
    {
        //fields
        private string name;

        private int weight;
        private bool added;
        private Type.typeAnimal typeAnimal;

        //constructor
        public Animal(string name, int weight, Type.typeAnimal typeAnimal)
        {
            this.Name = name;
            this.Weight = weight;
            this.typeAnimal = typeAnimal;
        }

        //properties
        public string Name { get => name; set => name = value; }

        public int Weight { get => weight; set => weight = value; }
        public bool Added { get => added; set => added = value; }
        public Type.typeAnimal TypeAnimal { get => typeAnimal; }

        //methods
        public override string ToString()
        {
            return $"{Name}, {Weight}";
        }
    }
}