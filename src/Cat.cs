namespace AnimalsCs
{
    public class Cat(int mousesKilled, string name) : Pet(name), ITalkable
    {
        private int mousesKilled = mousesKilled;

        public int MousesKilled
        {
            get { return mousesKilled; }
        }

        public void AddMouse()
        {
            mousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: name={name} mousesKilled={mousesKilled}";
        }
    }
}
