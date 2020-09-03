using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace August10_FileIO
{
    public class FileUtility
    {
        public static void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }

        public static void ModifyFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("This is a new string");
            }
        }

        public static void ModifyFile(string filePath, bool canAppend, List<string> linesOfInput = null)
        {
            using (StreamWriter writer = new StreamWriter(filePath, canAppend))
            {
                if (linesOfInput == null)
                {
                    writer.WriteLine("This is a new string");
                }
                else
                {
                    foreach(var line in linesOfInput)
                    {
                        writer.WriteLine(line);
                    }
                }                
            }
        }

        public static void ReadFromFile (string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                /* Old Way
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }*/

                //Correct Way
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }             

        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }
    }
}
