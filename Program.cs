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
            foreach (int i in array)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;

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