using System;
using System.Collections.Generic;

namespace LetrasRepetidas_Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char> { 'M', 'A', 'R', 'C' };
            List<char> surname1 = new List<char> { 'L', 'L', 'A', 'D', 'Ó' };
            List<char> surname2 = new List<char> { 'M', 'A', 'L', 'D', 'O', 'N', 'A', 'D', 'O' };

            List<char> completename = new List<char> ();

            foreach (char el in name) 
                completename.Add(el);
            completename.Add(' ');


            foreach (char el in surname1)
                completename.Add(el);
            completename.Add(' ');

            foreach (char el in surname2)
                completename.Add(el);


            foreach (char el in completename)
                Console.Write(el);

            Console.WriteLine();
            Console.WriteLine("Total elements: " + completename.Count);
        }
    }
}
