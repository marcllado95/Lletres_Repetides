using System;
using System.Collections.Generic;

namespace LetrasRepetidas_Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> llistalletres = new List<char> { 'M', 'A', 'R', 'C', 'R', 'C', 'M', 'C' };
            IDictionary<char, int> dict = new Dictionary<char, int>();

            for (int i=0; i < llistalletres.Count; i++)
            {

                if (!dict.ContainsKey(llistalletres[i])) //check que la lletra encara no existeixi al diccionari
                {
                    dict.Add(new KeyValuePair<char, int>(llistalletres[i], 1)); //guardem la lletra al diccionari amb el contador a 1
                }
                else dict[llistalletres[i]]++;           //si la lletra ja existia, sumem 1 al contador
            }

            foreach (KeyValuePair<char, int> item in dict)
                Console.WriteLine("Lletra: {0}, Nº vegades: {1}", item.Key, item.Value);
            //imprimim el diccionari sencer amb 'foreach'
        }
    }
}
