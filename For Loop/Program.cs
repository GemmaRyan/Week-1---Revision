using System.Drawing;

namespace For_Loop
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            int[] result = new int[7];
            int total = 0;
            for ( i =0 ; i < 7; i++)
            {
                Console.Write($"Please enter results for subject {i + 1} : ");
                result[i] = int.Parse(Console.ReadLine());
                total += result[i];

            }

            int largest = result[0];
            int smallest = result[0];

            //5
            for ( int j = 1; j < 7; j++)
            {
                if (result[j] > largest)
                {
                    largest = result[j];
                }
                if (result[j] < smallest)
                {
                    smallest = result[j];
                }
            }
            total = total - smallest;

            Console.WriteLine($"Your total points is {total} :)");
        }
    }
}
