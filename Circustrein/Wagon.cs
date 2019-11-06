using System.Collections.Generic;

namespace Circustrein
{
    public class Wagon
    {
        //fields
        private List<Animal> animalsInWagon = new List<Animal>();

        private int capacity = 10;
        private bool isFull = false;

        //constructor
        public Wagon(int capacity, bool isFull)
        {
            this.AnimalsInWagon = AnimalsInWagon;
            this.Capacity = capacity;
            this.IsFull = isFull;
        }

        //properties
        public int Capacity { get => capacity; set => capacity = value; }

        public bool IsFull { get => isFull; set => isFull = value; }
        public List<Animal> AnimalsInWagon { get => animalsInWagon; set => animalsInWagon = value; }

        //methods
        //checks if an animal can be added to a wagon, and adds te animal if possible
        public bool AddToWagon(Animal animal)
        {
            //The animals passes the tests and gets added
            if (CheckCompatibility(animal) && CheckWeight(animal))
            {
                //Animal gets marked as added and the capacity of the wagon gets adjusted.
                AnimalsInWagon.Add(animal);
                animal.Added = true;
                Capacity = Capacity - (int) animal.Weight;
                return true;
            }
            //The animal can't be added
            else
            {
                return false;
            }
        }

        //Checks if the weight of the animal is compatible with the leftover space in the wagon
        private bool CheckWeight(Animal animal)
        {
            //The animal fits and gets added to the wagon
            if (this.Capacity - animal.Weight >= 0)
            {
                return true;
            }
            //The animal can't be added
            else
            {
                return false;
            }
        }

        //Checks for conficts between herbivores and carnivores
        private bool CheckCompatibility(Animal animal)
        {
            //Check each animal in the wagon
            foreach (Animal animalToCheck in this.AnimalsInWagon)
            {
                //If there are any conflicts return false
                if (animalToCheck.Weight <= animal.Weight && animal.TypeAnimal == Type.typeAnimal.Carnivore || animalToCheck.TypeAnimal == Type.typeAnimal.Carnivore && animalToCheck.Weight >= animal.Weight)
                {
                    return false;
                }
            }
            //No conflicts return true
            return true;
        }

        public override string ToString()
        {
            return $"Wagon, {capacity}";
        }
    }
}