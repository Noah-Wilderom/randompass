using System;
using System.Collections.Generic;

namespace RandomPass
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args[0] != null)
            {
                Console.WriteLine(RandomPass(args[0]));
            }
            else
            {
                Console.Write("Hoeveel karakters: ");
                string length = Console.ReadLine();
                Console.WriteLine(RandomPass(length));
            }
                    
        }
        static string RandomPass(string length)
        {
            int passlength = Int32.Parse(length);
        
            Random rnd = new Random();
                    
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789!@#$%&*-_=+";
            char[] FormatArray = characters.ToCharArray();
            List<char> KeyArray = new List<char>();
        
            for (int i = 0; i < passlength; i++)
            {
                if (rnd.Next(1, 3) == 2)
                {
                    KeyArray.Add(characters[rnd.Next(0, FormatArray.Length)]);
                }
                else
                {
                    KeyArray.Add(numbers[rnd.Next(0, 10)]);
                }
            }
        
            return string.Join("", KeyArray);
        
        }
        
    }
}