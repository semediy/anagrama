using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше слово: ");
        string word1 = Console.ReadLine().ToLower().Replace(" ", "");

        Console.Write("Введіть друге слово: ");
        string word2 = Console.ReadLine().ToLower().Replace(" ", "");

        bool isAnagram = AreAnagrams(word1, word2);

        if (isAnagram)
            Console.WriteLine("Слова є анаграмами.");
        else
            Console.WriteLine("Слова НЕ є анаграмами.");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        return arr1.SequenceEqual(arr2);
    }
}