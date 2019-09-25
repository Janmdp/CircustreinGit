using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void noWagonFoundAddTest()
        {
            Train train = new Train();
            Animal animal = new Animal("test", 5, Type.typeAnimal.Carnivore);
            train.noWagonFound(animal);
            int count = train.Wagons.Count();
            Assert.AreEqual(1, count);
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