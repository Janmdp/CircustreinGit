using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Tests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void noWagonFoundAddTest()
        {
            Train train = new Train();
            Animal animal = new Animal("test", 5, true);
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
            train.AddAnimal("test", 3, false);
            Assert.IsTrue(train.AddAnimal("test", 3, false));
        }

        [TestMethod()]
        public void AddAnimalFalseTest()
        {
            Train train = new Train();
            Wagon wagon = new Wagon(10, false);
            train.Wagons.Add(wagon);
            train.AddAnimal("test", 3, false);
            Assert.IsFalse(train.AddAnimal("test", 3, true));
        }
    }
}


