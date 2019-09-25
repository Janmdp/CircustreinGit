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
        public bool addToWagon(Animal animal)
        {
            if (checkCompatibility(animal) && checkWeight(animal))
            {
                AnimalsInWagon.Add(animal);
                Capacity = Capacity - animal.Weight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkWeight(Animal animal)
        {
            if (this.Capacity - animal.Weight >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkCompatibility(Animal animal)
        {
            foreach (Animal animalToCheck in this.AnimalsInWagon)
            {
                if (animalToCheck.Weight <= animal.Weight && animal.TypeAnimal == Type.typeAnimal.Carnivore)
                {
                    return false;
                }
                else if (animalToCheck.TypeAnimal == Type.typeAnimal.Carnivore && animalToCheck.Weight >= animal.Weight)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return $"Wagon, {capacity}";
        }
    }
}