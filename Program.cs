namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Створіть додаток, який відображає кількість значень у 
            масиві менше заданого параметра користувачем. Наприклад, 
            кількість значень менших, ніж 7 (7 введено користувачем 
            з клавіатури).*/
            int[] array = new int[10];
            int count = 0;
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < number)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of numbers less than {number} is {count}");
        }
    }
}