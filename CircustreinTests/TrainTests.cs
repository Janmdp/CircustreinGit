using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod]
        public void NoWagonFoundTest()
        {
            //No wagon was created which invokes the NoWagonFound which if executed correctly will add a new wagon to train.Wagons
            //and will also add 
            Train train = new Train();
            Assert.IsFalse(train.AddAnimal("test", 5, Type.typeAnimal.Carnivore));
            Assert.AreEqual(1, train.Wagons.Count);
            Assert.AreEqual(1,train.Wagons[0].AnimalsInWagon.Count);
        }

        [TestMethod]
        public void NoWagonFoundTest2()
        {
            //THe animal can't be added to a existing wagon which will invoke the NoWagonFound method which will generate a new wagon and add the animal to said wagon
            //which means the train.wagons should contain 2 wagons.
            Train train = new Train();
            Wagon wagon = new Wagon(3, false);
            train.Wagons.Add(wagon);
            Assert.IsFalse(train.AddAnimal("test", 5, Type.typeAnimal.Carnivore));
            Assert.AreEqual(2,train.Wagons.Count);
            Assert.AreEqual(1, train.Wagons[1].AnimalsInWagon.Count);
        }

        [TestMethod()]
        public void AddAnimalTrueTest()
        {
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);
            train.Wagons.Add(wagon);
            train.AddAnimal("test", 3, Type.typeAnimal.Herbivore);
            Assert.IsTrue(train.AddAnimal("test", 3, Type.typeAnimal.Herbivore));
        }

        [TestMethod()]
        public void AddAnimalFalseTest()
        {
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);
            train.Wagons.Add(wagon);
            train.AddAnimal("test", 3, Type.typeAnimal.Herbivore);
            Assert.IsFalse(train.AddAnimal("test", 3, Type.typeAnimal.Carnivore));
        }
    }
}