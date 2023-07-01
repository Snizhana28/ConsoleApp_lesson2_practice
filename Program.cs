namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int[] input = new int[3];
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input[0] && array[i + 1] == input[1] && array[i + 2] == input[2])
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of sequence: {count}");
        }
    }
}