using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "anagram";
            string secondWord = "magarna";

            Console.WriteLine($"Checking if \"{firstWord}\" and \"{secondWord}\" are anagrams.");
            Console.WriteLine(CheckAnagram(firstWord, secondWord));
        }

        public static bool CheckAnagram(string first, string second)
        {
            if (first.Length != second.Length)
                return false;

            char[] firstArr = first.ToLower().ToCharArray();
            char[] secondArr = second.ToLower().ToCharArray();

            Array.Sort(firstArr);
            Array.Sort(secondArr);

            string firstNew = new string(firstArr);
            string secondNew = new string(secondArr);

            return firstNew == secondNew;
        }
    }
}
