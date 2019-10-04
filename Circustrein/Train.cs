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
        //Method for creating and adding a animal to a wagon
        public bool AddAnimal(string name, int weight, Type.typeAnimal typeAnimal)
        {
            //Create the animal
            Animal animal = new Animal(name, weight, typeAnimal);
            //Add the animal to a list of animals
            animals.Add(animal);
            //Loop through all the wagons and check if the animal can be added.
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.addToWagon(animal))
                {
                    return true;
                }
            }
            //if the animal can't be added generate a new wagon
            if (!animal.Added)
            {
                noWagonFound(animal);
                return false;
            }

            return false;
        }

        //Generate a new wagon and add the animal to the wagon.
        private void noWagonFound(Animal animal)
        {
            Wagon wagon = new Wagon(10, false);
            wagon.addToWagon(animal);
            Wagons.Add(wagon);
        }
    }
}