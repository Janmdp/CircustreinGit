using System.Collections.Generic;

namespace Circustrein
{
    public class Train
    {
        //fields
        private List<Animal> animals = new List<Animal>();

        private List<Wagon> wagons = new List<Wagon>();

        //constructor
        public Train()
        {
        }

        //properties
        public List<Animal> Animals { get => animals; set => animals = value; }

        public List<Wagon> Wagons { get => wagons; set => wagons = value; }

        //methods
        public bool AddAnimal(string name, int weight, Type.typeAnimal typeAnimal)
        {
            bool added = false;
            Animal animal = new Animal(name, weight, typeAnimal);
            animals.Add(animal);
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.addToWagon(animal))
                {
                    added = true;
                    return true;
                }
            }
            if (!added)
            {
                noWagonFound(animal);
                return false;
            }

            return false;
        }

        public void noWagonFound(Animal animal)
        {
            Wagon wagon = new Wagon(10, false);
            wagon.addToWagon(animal);
            Wagons.Add(wagon);
        }
    }
}