namespace AnimalsCs
{
    public abstract class Person(string name)
    {
        private string name = name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}