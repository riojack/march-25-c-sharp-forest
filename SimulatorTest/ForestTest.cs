using NUnit.Framework;
using Simulator;

namespace SimulatorTest
{
    public class ForestTest
    {
        [Test]
        public void ShouldReduceAnimalLifeByOne()
        {
            // ARRANGE
            Forest forest = new Forest();
            Animal animal = new Animal("Bear", 10);

            forest.AddAnimal(animal);

            // ACT
            forest.RunDayCycle();

            // ASSERT
            Assert.AreEqual(9, animal.Life);
        }

        [Test]
        public void ShouldKeepDeadAnimalsAtLifeOfZero() {
            // ARRANGE
            Forest forest = new Forest();
            Animal animal = new Animal("Pine Marten", 0);

            forest.AddAnimal(animal);

            // ACT
            forest.RunDayCycle();

            // ASSERT
            Assert.AreEqual(0, animal.Life);
        }
    }
}