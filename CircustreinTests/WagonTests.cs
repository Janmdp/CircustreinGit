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

        [TestMethod]
        public void checkWeightTrueTest()
        {
            //By leaving the wagon empty the compatibility test will automatically pass so this will only focus on the weight test
            Wagon wagon = new Wagon(6, false);
            Animal animal = new Animal("test", 5, Type.typeAnimal.Herbivore);
            Assert.IsTrue(wagon.addToWagon(animal));
        }

        [TestMethod]
        public void checkWeightFalseTrue()
        {
            //By leaving the wagon empty the compatibility test will automatically pass so this will only focus on the weight test
            Wagon wagon = new Wagon(4, false);
            Animal animal = new Animal("test", 5, Type.typeAnimal.Herbivore);
            Assert.IsFalse(wagon.addToWagon(animal));
        }

        [TestMethod]
        public void checkCompatibilityTrueTest()
        {
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if we can add a larger herbivore to a wagon with a smaller carnivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", 3, Type.typeAnimal.Carnivore);
            wagon.addToWagon(animal);
            Animal animal2 = new Animal("test", 5, Type.typeAnimal.Herbivore);
            Assert.IsTrue(wagon.addToWagon(animal2));
        }

        [TestMethod]
        public void checkCompatibilityTrueTest2()
        {
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if we can add a smaller carnivore to a wagon with a larger herbivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", 5, Type.typeAnimal.Herbivore);
            wagon.addToWagon(animal);
            Animal animal2 = new Animal("test", 3, Type.typeAnimal.Carnivore);
            Assert.IsTrue(wagon.addToWagon(animal2));
        }

        [TestMethod]
        public void checkCompatibilityFalseTest()
        {
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if the method prevents a smaller herbivore being added to wagon with a larger carnivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", 5, Type.typeAnimal.Carnivore);
            wagon.addToWagon(animal);
            Animal animal2 = new Animal("test", 3, Type.typeAnimal.Herbivore);
            Assert.IsFalse(wagon.addToWagon(animal2));
        }

        [TestMethod]
        public void checkCompatibilityFalseTest2()
        {
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if the method prevents a carnivore and herbivore of the same size being added to the same wagon
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", 5, Type.typeAnimal.Carnivore);
            wagon.addToWagon(animal);
            Animal animal2 = new Animal("test", 5, Type.typeAnimal.Herbivore);
            Assert.IsFalse(wagon.addToWagon(animal2));
        }
    }
}