namespace Simulator
{
    public class Animal
    {
        private string Name { get; set; }
        public int Life { get; set; }

        public Animal(string name, int life)
        {
            Name = name;
            Life = life;
        }
    }
}