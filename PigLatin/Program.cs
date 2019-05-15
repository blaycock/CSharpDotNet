using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main gets the word from the user to translate
            Console.WriteLine("Enter the word that you want translated to Pig Latin!\n");
            string pigTrans = Console.ReadLine().ToLower();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int firstVowelPos = pigTrans.IndexOfAny(vowels);
            if (firstVowelPos == -1)
            {
                Console.WriteLine (pigTrans + "ay");
            }
            else
            {
                char firstLet = pigTrans[0];
                char lastLet = pigTrans[pigTrans.Length - 1];
                if (vowels.Contains(firstLet)&& vowels.Contains(lastLet))
                {
                    Console.WriteLine(pigTrans + "yay");
                }
                else
                {
                    string firstHalf = pigTrans.Substring(0, firstVowelPos);
                    string secondHalf = pigTrans.Substring(firstVowelPos);
                    Console.WriteLine(secondHalf + firstHalf + "ay");
                }
            }
       
            Console.Read();
        }

    }
}
