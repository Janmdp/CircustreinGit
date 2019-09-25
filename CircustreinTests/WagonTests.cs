using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void addNoneToWagonTest()
        {
            Wagon wagon = new Wagon(10, false);
            int count = wagon.AnimalsInWagon.Count();
            Assert.AreEqual(0, count);
        }

        [TestMethod()]
        public void addOneToWagonTest()
        {
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", 1, Type.typeAnimal.Herbivore);
            wagon.addToWagon(animal);
            int count = wagon.AnimalsInWagon.Count();
            Assert.AreEqual(1, count);
        }

        [TestMethod()]
        public void checkWeightTrueTest()
        {
            Animal animal = new Animal("test", 1, Type.typeAnimal.Herbivore);
            Wagon wagon = new Wagon(10, false);
            Assert.IsTrue(wagon.checkWeight(animal));
        }

        [TestMethod()]
        public void checkWeightFalseTest()
        {
            Animal animal = new Animal("test", 5, Type.typeAnimal.Herbivore);
            Wagon wagon = new Wagon(4, false);
            Assert.IsFalse(wagon.checkWeight(animal));
        }

        [TestMethod()]
        public void checkCompatibilityTrueTest()
        {
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", 1, Type.typeAnimal.Carnivore);
            Animal animal2 = new Animal("test", 3, Type.typeAnimal.Herbivore);
            wagon.AnimalsInWagon.Add(animal);
            Assert.IsTrue(wagon.checkCompatibility(animal2));
        }

        [TestMethod()]
        public void checkCompatibilityFalseTest()
        {
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", 1, Type.typeAnimal.Herbivore);
            Animal animal2 = new Animal("test", 3, Type.typeAnimal.Carnivore);
            wagon.AnimalsInWagon.Add(animal);
            Assert.IsFalse(wagon.checkCompatibility(animal2));
        }

        [TestMethod()]
        public void checkCompatibilityFalse2Test()
        {
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", 3, Type.typeAnimal.Carnivore);
            Animal animal2 = new Animal("test", 3, Type.typeAnimal.Herbivore);
            wagon.AnimalsInWagon.Add(animal);
            Assert.IsFalse(wagon.checkCompatibility(animal2));
        }
    }
}