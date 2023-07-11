namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static int CountWords(string sentence)
        {
            int vowelCount = 0;
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence : ");
            string sentence = Console.ReadLine();
            Console.WriteLine(CountWords(sentence));
        }
    }
}