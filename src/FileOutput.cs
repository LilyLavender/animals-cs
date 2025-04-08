using System;
using System.IO;

namespace AnimalsCs
{
    public class FileOutput
    {
        private readonly StreamWriter? Writer;
        private readonly string FileName;

        public FileOutput(string fileName)
        {
            FileName = fileName;
            try
            {
                Writer = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General Error Opening File: {fileName} {e.Message}");
            }
        }

        public void FileWrite(string line)
        {
            if (Writer == null) return;

            try
            {
                Writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {FileName} {e.Message}");
            }
        }

        public void FileClose()
        {
            if (Writer != null)
            {
                try
                {
                    Writer.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"File Close Error: {FileName} {e.Message}");
                }
            }
        }
    }
}
