using System.Runtime.InteropServices.Marshalling;

namespace Selection___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Attributes    
            double percentGrade;
            int points;


            Console.Write("Enter percentage grade : ");
            percentGrade = double.Parse(Console.ReadLine());

            if (percentGrade >= 0 && percentGrade < 30 )
            {
                points = 0;      //H8
                Console.WriteLine($"You got {points} points!");
            }
            else if (percentGrade >= 30 && percentGrade < 40)
            {
                points = 37;     //H7
                Console.WriteLine($"You got {points} points!");
            }
            else if (percentGrade >= 40 && percentGrade < 50)
            {
                points = 46;     //H6
                Console.WriteLine($"You got {points} points!");

            }
            else if(percentGrade >= 50 && percentGrade < 60)
            {
                points = 56;     //H5
                Console.WriteLine($"You got {points} points!");
            }
            else if (percentGrade >= 60 && percentGrade < 70)
            {
                points = 66;     //H4
                Console.WriteLine($"You got {points} points!");
            }
            else if (percentGrade >= 70 && percentGrade < 80)
            {
                points = 77;     //H3
                Console.WriteLine($"You got {points} points!");
            }
            else if(percentGrade >= 80 && percentGrade < 90)
            {
                
                points = 88;     //H2
                Console.WriteLine($"You got {points} points!");
            }
            else if (percentGrade >= 90 && percentGrade <= 100)
            {
                points = 100;     //H1
                Console.WriteLine($"You got {points} points!");
            }
        }
    }
}

                
