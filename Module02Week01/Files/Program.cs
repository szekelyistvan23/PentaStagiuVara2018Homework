using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Files
{
    class MainClass
    {
        private static List<string> people;

        public static void Main(string[] args)
        {
            LoadFilePeople();
            RemoveOneName();
            AddName();
            SaveToNewFile();

            Console.ReadKey();
        }

        private static void LoadFilePeople()
        {
            List<string> array = new List<string>();
            using (StreamReader streamReader = new StreamReader("../../people.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (IsValidName(line))
                    {
                        array.Add(line);
                    } 
                }
            }
            people = array;
        }

        private static void RemoveOneName()
        {
            int length = people.Count;
            Random random = new Random();
            int index = random.Next(0, length - 1);

            people.RemoveAt(index);
        }

        private static bool IsValidName(string name)
        {
            if (!Regex.IsMatch(name, @"^[\p{L}\p{M}]+$") || name.Trim().Equals(""))
            {
                Console.WriteLine("Invalid name: {0}", name);
                return false;
            }
            return true;
        }

        private static void AddName()
        {
            string[] newPeople = { "Tina", "Michael" };

            foreach (string name in newPeople)
            {
                people.Add(name);
            }
        }

        private static void WriteToFile(string fileName, FileMode fileMode, FileAccess fileAcces)
        {
            FileStream fileStream = new FileStream(fileName, fileMode, fileAcces);
            foreach (string name in people)
            {
                string newName = name + "\n";
                byte[] array = Encoding.ASCII.GetBytes(newName);
                foreach (byte toWrite in array)
                {
                    fileStream.WriteByte(toWrite);
                }
            }
            fileStream.Close();
        }

        private static void SaveToNewFile()
        {
            string file = "../../newpeople.txt";
            try
            {
                WriteToFile(file, FileMode.Open, FileAccess.Write);
            }
            catch (FileNotFoundException)
            {
                WriteToFile(file, FileMode.OpenOrCreate, FileAccess.Write);
            }
        }
    }
}
