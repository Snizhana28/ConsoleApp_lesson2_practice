namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int count = 0;
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number of values in the array is less than the specified parameter {number} : ");
            foreach (int i in array)
            {
                if (i < number)
                {
                    count++;
                    Console.Write(count);
                }
            }
        }
    }
}