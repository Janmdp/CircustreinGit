using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
     public class Wagon
    {
        //fields
        private List<Animal> animalsInWagon = new List<Animal>();
        private int capacity = 10;
        private bool isFull = false;

        public Wagon(int capacity, bool isFull)
        {
            this.AnimalsInWagon = AnimalsInWagon;
            this.Capacity = capacity;
            this.IsFull = isFull;
            
        }

        public int Capacity { get => capacity; set => capacity = value; }
        public bool IsFull { get => isFull; set => isFull = value; }
        public List<Animal> AnimalsInWagon { get => animalsInWagon; set => animalsInWagon = value; }
        //constructor

        //properties

        //methods
        public void addToWagon(Animal animal)
        {
            AnimalsInWagon.Add(animal);
            Capacity = Capacity - animal.Weight;
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
                if (animalToCheck.Weight <= animal.Weight && animal.Carnivore)
                {
                    return false;
                }
                else if (animalToCheck.Carnivore && animalToCheck.Weight >= animal.Weight)
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
