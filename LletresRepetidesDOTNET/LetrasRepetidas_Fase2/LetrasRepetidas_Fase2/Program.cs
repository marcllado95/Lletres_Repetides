using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasRepetidas_Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> llistalletres = new List<char> { 'M', 'A', 'R', 'C' };
            char[] vocals = new char[5];
            vocals[0] = 'A';
            vocals[1] = 'E';
            vocals[2] = 'I';
            vocals[3] = 'O';
            vocals[4] = 'U';

            for (int i = 0; i < llistalletres.Count; i++)
            {
                if (llistalletres[i] >= 48 && llistalletres[i] <= 57) //comprovació ASCII
                    Console.WriteLine(llistalletres[i] + "  Els noms de persones no contenen números!");
                else
                {

                    bool esvocal = false;

                    for (int j = 0; j < vocals.Length; j++)
                    {
                        if (llistalletres[i] == vocals[j])
                        {
                            Console.WriteLine(llistalletres[i] + "  VOCAL");
                            esvocal = true;
                        }
                    }
                    if (!esvocal)
                        Console.WriteLine(llistalletres[i] + "  CONSONANT");
                }
            }
        }
    }
}
