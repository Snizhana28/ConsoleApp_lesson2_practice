using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static int CountWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence : ");
            string sentence = Console.ReadLine();
            int wordCount = CountWords(sentence);
            Console.WriteLine("Word count : " + wordCount);
        }
    }
}