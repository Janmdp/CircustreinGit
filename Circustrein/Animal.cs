using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        //fields
        private string name;
        private int weight;
        private bool carnivore;
        private bool added;

        //constructor
        public Animal(string name, int weight, bool carnivore)
        {
            this.Name = name;
            this.Weight = weight;
            this.Carnivore = carnivore;
        }

        //properties
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public bool Carnivore { get => carnivore; set => carnivore = value; }
        public bool Added { get => added; set => added = value; }

        //methods
        public override string ToString()
        {
            return $"{Name}, {Weight}";
        }
    }
}
