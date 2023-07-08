
namespace ConsoleApp_lesson2_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 , 4, 3};
            int[] array2 = { 4, 5, 6, 3, 4, 3};
            int[] array3 = new int[array1.Length + array2.Length];
            int commonElementsCount = 0;

            foreach (var element1 in array1)
            {
                foreach (var element2 in array2)
                {
                    if (element1 == element2)
                    {
                        bool duplicate = false;
                        for (int i = 0; i < commonElementsCount; i++)
                        {
                            if (array3[i] == element1)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                        if (!duplicate)
                        {
                            array3[commonElementsCount] = element1;
                            commonElementsCount++;
                        }
                        break;
                    }
                }
            }
            Array.Resize(ref array3, commonElementsCount);
            foreach (var i in array3)
            {
                Console.WriteLine(i);
            }

        }
    }
}