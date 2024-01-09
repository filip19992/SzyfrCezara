using System;

namespace SzyfrCezara
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program szyfrujący tekst za pomocą szyfru Cezara (modyfikacja o 1)");

            while (true)
            {
                Console.Write("Podaj tekst do zaszyfrowania (q lub escape kończy): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q" || input.ToLower() == "escape")
                {
                    break;
                }

                string encryptedText = EncryptCesar(input);
                Console.WriteLine($"Zaszyfrowany tekst: {encryptedText}\n");
            }

            Console.WriteLine("Koniec programu.");
        }

        static string EncryptCesar(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsLetter(characters[i]))
                {
                    char baseChar = char.IsUpper(characters[i]) ? 'A' : 'a';
                    characters[i] = (char)(((characters[i] - baseChar + 1) % 26) + baseChar);
                }
            }

            return new string(characters);
        }
    }
}

