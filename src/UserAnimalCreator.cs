using System;
using System.Collections.Generic;

namespace AnimalsCs {
    public class UserAnimalCreator {
        private List<ITalkable> _zoo;

        public UserAnimalCreator(List<ITalkable> zoo) {
            _zoo = zoo;
            CreateAnimal();
        }

        private void CreateAnimal() {
            while (true) {
                Console.WriteLine("What type of animal would you like to create? (dog/cat/teacher)");
                string? type = Console.ReadLine()?.Trim().ToLower();

                switch (type) {
                    case "dog":
                        string dogName;
                        bool isFriendly;

                        Console.Write("Enter the dog's name: ");
                        dogName = Console.ReadLine()!;

                        while (true) {
                            Console.Write("Is the dog friendly? (Y/n): ");
                            string? input = Console.ReadLine()?.Trim().ToLower();
                            if (input == "y" || input == "yes") {
                                isFriendly = true;
                                break;
                            } else if (input == "n" || input == "no") {
                                isFriendly = false;
                                break;
                            } else {
                                Console.WriteLine("Please enter 'Y' or 'N'.");
                            }
                        }

                        _zoo.Add(new Dog(isFriendly, dogName));
                        return;

                    case "cat":
                        string catName;
                        int miceKilled;

                        Console.Write("Enter the cat's name: ");
                        catName = Console.ReadLine()!;

                        while (true) {
                            Console.Write("How many mice has the cat killed?: ");
                            if (int.TryParse(Console.ReadLine(), out miceKilled))
                                break;
                            Console.WriteLine("Please enter a valid integer.");
                        }

                        _zoo.Add(new Cat(miceKilled, catName));
                        return;

                    case "teacher":
                        string teacherName;
                        int age;

                        Console.Write("Enter the teacher's name: ");
                        teacherName = Console.ReadLine()!;

                        while (true) {
                            Console.Write("Enter the teacher's age: ");
                            if (int.TryParse(Console.ReadLine(), out age))
                                break;
                            Console.WriteLine("Please enter a valid integer.");
                        }

                        _zoo.Add(new Teacher(age, teacherName));
                        return;

                    default:
                        Console.WriteLine("Invalid animal type entered. Please choose from: dog, cat, teacher.");
                        break;
                }
            }
        }
    }
}
