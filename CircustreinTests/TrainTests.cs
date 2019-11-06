using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static Circustrein.Weight;
using static Circustrein.Type;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod]
        public void NoWagonFoundTest()
        {
            //arrange
            //No wagon was created which invokes the NoWagonFound which if executed correctly will add a new wagon to train.Wagons
            //and will also add 
            Train train = new Train();
            //assert
            Assert.IsFalse(train.AddAnimal("test", Size.Large, typeAnimal.Carnivore));
            Assert.AreEqual(1, train.Wagons.Count);
            Assert.AreEqual(1,train.Wagons[0].AnimalsInWagon.Count);
        }

        [TestMethod]
        public void NoWagonFoundTest2()
        {
            //arrange
            //THe animal can't be added to a existing wagon which will invoke the NoWagonFound method which will generate a new wagon and add the animal to said wagon
            //which means the train.wagons should contain 2 wagons.
            Train train = new Train();
            Wagon wagon = new Wagon(3, false);
            //act
            train.Wagons.Add(wagon);
            //assert
            Assert.IsFalse(train.AddAnimal("test", Size.Large, typeAnimal.Carnivore));
            Assert.AreEqual(2,train.Wagons.Count);
            Assert.AreEqual(1, train.Wagons[1].AnimalsInWagon.Count);
        }

        [TestMethod()]
        public void AddAnimalTrueTest()
        {
            //arrange
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);
            //act
            train.Wagons.Add(wagon);
            //assert
            train.AddAnimal("test", Size.Medium, typeAnimal.Herbivore);
            Assert.IsTrue(train.AddAnimal("test", Size.Medium, typeAnimal.Herbivore));
        }

        [TestMethod()]
        public void AddAnimalFalseTest()
        {
            //arrange
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);
            //act
            train.Wagons.Add(wagon);
            train.AddAnimal("test", Size.Medium, typeAnimal.Herbivore);
            //assert
            Assert.IsFalse(train.AddAnimal("test", Size.Medium, typeAnimal.Carnivore));
        }
    }
}