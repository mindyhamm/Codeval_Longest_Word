using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeval_Longest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I have a dog";

            int sentLeng = sentence.Length;
            string[] sent = sentence.Split(' ');

            for (int i = 0; i < sent.Length; i++)
            {
                Console.WriteLine(sent[i]);
            }
            Console.ReadKey();
        }
    }
}
