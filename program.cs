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
            p.ProcessArrayList();
        }

        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ProcessArrayList()
        {
            int LineNum = 0;
            foreach (var line in Beowulf)
            {
                if (ContainsWord(line.ToString().ToLower(), "fare") && (ContainsWord(line.ToString().ToLower(), "sea")))
                {
                    Console.WriteLine("Line is: {0}", LineNum);
                    LineNum++;
                }
            }


            int LineNumber = 0;

            foreach (var line in Beowulf)
            {
                if (ContainsWord(line.ToString().ToLower(), "fare") && !(ContainsWord(line.ToString().ToLower(), "war")))
                {
                    Console.WriteLine("Line number is: {0}", LineNumber);
                    LineNumber++;
                }
            }

            
        }

        public bool ContainsWord(string line, string word)
        {
            //TODO: write are algorithm to detect if a line contains a word
            if(line.Contains(word) == true)
            {
                return true;
            }
            return false;
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
                Console.WriteLine($"File has {counter} lines.");
            }

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
            return countSpaces;
        }
    }
}
