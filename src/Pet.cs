namespace AnimalsCs
{
    public abstract class Pet(string name)
    {
        protected string name = name;

        public string GetName()
        {
            return name;
        }
    }
}