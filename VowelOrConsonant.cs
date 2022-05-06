using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class VowelOrConsonant
    {
        public static void FindVowelOrConsonant()

        {
            Char input;
            Console.WriteLine("Enter a character to check vowel or constant :  ");
            input = Convert.ToChar(Console.ReadLine());

            if (input == 'A' | input == 'E' | input == 'I' | input == 'O' | input == 'U')
            {
                Console.WriteLine("Its a vowel");
            }
            else
            {
                Console.WriteLine("Its a consonant");
            }
        }
    }
}
