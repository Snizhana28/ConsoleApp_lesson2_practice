namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sun cat dogs cup tea;
            //nus tac sgod puc aet
            Console.Write("Enter a sentence : ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                words[i] = new string(word);
            }
            sentence = string.Join(" ", words);
            Console.WriteLine("Reversed sentence : " + sentence);
            Console.ReadLine();
        }
    }
}