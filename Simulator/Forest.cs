using System.Collections.Generic;

namespace Simulator
{
    public class Forest
    {
        private IList<Animal> Animals { get; set; }
        public Forest()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void RunDayCycle()
        {
            foreach (Animal animal in Animals)
            {
                if (animal.Life > 0)
                {
                    animal.Life = animal.Life - 1;
                }
            }
        }
    }
}