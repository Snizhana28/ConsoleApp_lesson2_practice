namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 3, 5, 7 };
            int even = 0;
            int odd = 0;
            int unique = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        unique++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {odd}");
            Console.WriteLine($"Unique: {array.Length - unique}");
        }
    }
}