using System;
using System.IO;

namespace AnimalsCs
{
    public class FileInput
    {
        private readonly StreamReader? Reader;
        private readonly string FileName;

        public FileInput(string fileName)
        {
            FileName = fileName;
            try
            {
                Reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {FileName} {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General Error Opening File: {FileName} {e.Message}");
            }
        }

        public void FileRead()
        {
            if (Reader == null) return;

            try
            {
                string? line;
                while ((line = Reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {FileName} {e.Message}");
            }
        }

        public string? FileReadLine()
        {
            if (Reader == null) return null;

            try
            {
                return Reader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {FileName} {e.Message}");
                return null;
            }
        }

        public void FileClose()
        {
            if (Reader != null)
            {
                try
                {
                    Reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"File Close Error: {FileName} {e.Message}");
                }
            }
        }
    }
}
