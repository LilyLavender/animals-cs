using System;
using System.Collections.Generic;

namespace AnimalsCs {
    public class Program {

        private static readonly FileOutput OutFile = new("animals.txt");
        private static readonly FileInput InFile = new("animals.txt");

        public static void Main(string[] args) {
            List<ITalkable> zoo = new();
            
            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (ITalkable thing in zoo) {
                PrintOut(thing);
            }

            OutFile.FileClose();
            InFile.FileRead();
            InFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string? line;
            while ((line = indata.FileReadLine()) != null) {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable p) {
            Console.WriteLine($"{p.GetName()} says={p.Talk()}");
            OutFile.FileWrite($"{p.GetName()} | {p.Talk()}");
        }
    }
}
