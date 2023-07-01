namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            int min = 0;
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLongLength(1); j++)
                {
                    array[i, j] = random.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Min value : {min}");
            Console.WriteLine($"max value : {max}");
        }
    }
}