namespace AnimalsCs
{
    public class Dog(bool friendly, string name) : Pet(name), ITalkable
    {
        private readonly bool friendly = friendly;

        public bool IsFriendly()
        {
            return friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: name={name} friendly={friendly}";
        }
    }
}