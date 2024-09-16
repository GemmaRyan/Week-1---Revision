namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Attributes
            double result = 0, i = 0 , total = 0;
            
            while (result != -1)
            {

                Console.Write($"Please enter results for subject {i + 1} : ");
                result = int.Parse(Console.ReadLine());
                total += result;

                i++;
            }
            Console.WriteLine(total);
        }
    }
}
