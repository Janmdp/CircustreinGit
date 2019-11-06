using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Circustrein.Type;
using static  Circustrein.Weight;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddNoneToWagonTest()
        {
            //arrange
            Wagon wagon = new Wagon(10, false);
            //act
            int count = wagon.AnimalsInWagon.Count();
            //assert
            Assert.AreEqual(0, count);
        }

        [TestMethod()]
        public void AddOneToWagonTest()
        {
            //arrange
            Wagon wagon = new Wagon(10, false);
            Animal animal = new Animal("test", Size.Small, typeAnimal.Herbivore);
            //act
            wagon.AddToWagon(animal);
            int count = wagon.AnimalsInWagon.Count();
            //assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CheckWeightTrueTest()
        {
            //arrange
            //By leaving the wagon empty the compatibility test will automatically pass so this will only focus on the weight test
            Wagon wagon = new Wagon(6, false);
            Animal animal = new Animal("test", Size.Large, typeAnimal.Herbivore);
            //act
            bool test = wagon.AddToWagon(animal);
            //assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void CheckWeightFalseTrue()
        {
            //arrange
            //By leaving the wagon empty the compatibility test will automatically pass so this will only focus on the weight test
            Wagon wagon = new Wagon(4, false);
            Animal animal = new Animal("test", Size.Large, typeAnimal.Herbivore);
            //act
            bool test = wagon.AddToWagon(animal);
            //assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void CheckCompatibilityTrueTest()
        {
            //arrange
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if we can add a larger herbivore to a wagon with a smaller carnivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", Size.Medium, typeAnimal.Carnivore);
            Animal animal2 = new Animal("test", Size.Large, typeAnimal.Herbivore);
            //act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);
            //assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void CheckCompatibilityTrueTest2()
        {
            //arrange
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if we can add a smaller carnivore to a wagon with a larger herbivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", Size.Large, typeAnimal.Herbivore);
            Animal animal2 = new Animal("test", Size.Medium, typeAnimal.Carnivore);
            //act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);
            //assert
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void CheckCompatibilityFalseTest()
        {
            //arrange
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if the method prevents a smaller herbivore being added to wagon with a larger carnivore.
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", Size.Large, typeAnimal.Carnivore);
            Animal animal2 = new Animal("test", Size.Medium, typeAnimal.Herbivore);
            //act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);
            //assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void CheckCompatibilityFalseTest2()
        {
            //arrange
            //By giving the wagon a huge capacity we can safely bypass the weight test and will only have to pass the compatibility test.
            //This test will check if the method prevents a carnivore and herbivore of the same size being added to the same wagon
            Wagon wagon = new Wagon(100, false);
            Animal animal = new Animal("test", Size.Large, typeAnimal.Carnivore);
            Animal animal2 = new Animal("test", Size.Large, typeAnimal.Herbivore);
            //act
            wagon.AddToWagon(animal);
            bool test = wagon.AddToWagon(animal2);
            //assert
            Assert.IsFalse(test);
        }
    }
}