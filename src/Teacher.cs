namespace AnimalsCs
{
    public class Teacher(int age, string name) : Person(name), ITalkable {
        private int age = age;

        public int GetAge() {
            return age;
        }

        public void SetAge(int age) {
            this.age = age;
        }

        public string Talk() {
            return "Don't forget to do the assigned reading!";
        }
    }
}