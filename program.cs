using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_c0726075
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();

            string text = System.IO.File.ReadAllText("U:/Users/725030/Beowulf.txt");
            p.FindNumberOfBlankSpaces(text);
            p.ProcessArrayList();
            p.FindNumberOfWords(text);
            p.AverageNumberOfLetters(text);
        }

        public void Run()
        {
            this.ReadTextFiles();

        }


        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/725030/Beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines. ");
            }
        }
        public int FindNumberOfBlankSpace(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }
        public void ProcessArrayList()
        {
            int LineNumber = 0;
            foreach (var line in Beowulf)
            {

                if (ContainsWord(line.ToString().ToLower(), "fare") && !(ContainsWord(line.ToString().ToLower(), "war")))
                {
                    Console.WriteLine("line number is: {0}", LineNumber);
                    LineNumber++;
                }
            }
        }
        public bool ContainsWord(string line, string word)
        {
            if (line.Contains(word) == true)
            {
                return true;
            }
            return false;
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;

                }

            }
            Console.WriteLine("Number of Blank Spaces: " + countSpaces);
            Console.WriteLine("Number of letters: " + countletters);
            return countletters;
        }
        public int FindNumberOfWords(string x)
        {
            int result = 0;
            x = x.Trim();
            if (x == "")
                return 0;
            while (x.Contains("  "))
                x = x.Replace("  ", " ");
            foreach (string y in x.Split(' '))
                result++;

            Console.WriteLine("Result is " + result);
            return result;

        }
        public double AverageNumberOfLetters(string text)
        {
            double average = ((text.Length - FindNumberOfBlankSpaces(text) / FindNumberOfWords(text)));
            Console.WriteLine("Average is " + average);
            return average;
        }
    }
}
