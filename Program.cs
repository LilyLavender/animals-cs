using System;
using System.Collections.Generic;

namespace AnimalsCs {
    public class Program {

        private static readonly FileOutput OutFile = new("animals.txt");

        public static void Main(string[] args) {
            List<ITalkable> zoo = new();
            
            new UserAnimalCreator(zoo);

            foreach (ITalkable thing in zoo) {
                PrintOut(thing);
            }

            OutFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string? line;
            while ((line = indata.FileReadLine()) != null) {
                Console.WriteLine(line);
            }
            indata.FileClose();
        }

        public static void PrintOut(ITalkable p) {
            Console.WriteLine($"{p.GetName()} says={p.Talk()}");
            OutFile.FileWrite($"{p.GetName()} | {p.Talk()}");
        }
    }
}
