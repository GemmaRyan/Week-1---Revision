namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Attributes
            double result = 0, i = 0 , total = 0;
            double percentGrade = 0;
            int points = 0;
            string level = "";


            Console.Write("Enter percentage grade or -1 to end it: ");
            percentGrade = double.Parse(Console.ReadLine());

            while (percentGrade != -1)
            {
  
                //asking for higher or ordinary level
                Console.Write("Enter Higher or Ordinary Level (H/O) : ");
                level = Console.ReadLine().ToUpper();


                //Get Ordinary Level results 

                if (level == "O")
                {
                    if (percentGrade >= 0 && percentGrade < 30)
                    {
                        points = 0;      //O8
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 30 && percentGrade < 40)
                    {
                        points = 0;     //O7
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 40 && percentGrade < 50)
                    {
                        points = 12;     //O6
                        Console.WriteLine($"You got {points} points!");

                    }
                    else if (percentGrade >= 50 && percentGrade < 60)
                    {
                        points = 20;     //O5
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 60 && percentGrade < 70)
                    {
                        points = 28;     //O4
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 70 && percentGrade < 80)
                    {
                        points = 37;     //O3
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 80 && percentGrade < 90)
                    {

                        points = 46;     //O2
                        Console.WriteLine($"You got {points} points!");
                    }
                    else if (percentGrade >= 90 && percentGrade <= 100)
                    {
                        points = 56;     //O1
                        Console.WriteLine($"You got {points} points!");
                    }
                }

                //Get Higher Level results 
                else if (level == "H")
                {
                    if (percentGrade >= 0 && percentGrade < 30)
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
                    else if (percentGrade >= 50 && percentGrade < 60)
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
                    else if (percentGrade >= 80 && percentGrade < 90)
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
                else { Console.WriteLine("Incorrect letter please enter either a O / H :) "); }
                total += points;


                i++;

                Console.Write("Enter percentage grade or -1 to end it: ");
                percentGrade = double.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Your total points are {total}");
        }
    }
}
