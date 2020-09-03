using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace August10_FileIO.Exercise67
{
    public class Exercise67Utility
    {
        public static List<int> ReadFile(string filePath)
        {
            List<int> numbers = new List<int>();

            using (StreamReader reader = new StreamReader(filePath))
            {                
                while (!reader.EndOfStream)
                {
                    numbers.Add(int.Parse(reader.ReadLine()));
                }
            }
            return numbers;
        }

        public static Dictionary<string, string> CreateDictionary (string filePath)
        {
            Dictionary<string, string> translations = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    translations = File.ReadAllLines(filePath).Select(x => x.Split(",")).ToDictionary(x => x[0], x => x[1]);                    
                }
            }
            return translations;
        }
    }
}