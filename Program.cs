namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence : ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter a word to search : ");
            string search = Console.ReadLine();            
            int count = 0;
            int startIndex = 0;

            while ((startIndex = sentence.IndexOf(search, startIndex)) != -1)
            {
                count++;
                startIndex += search.Length;
            }
            Console.WriteLine("Result : " + count);
        }
    }
}