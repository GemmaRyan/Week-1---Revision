namespace Selection___Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //attributes
            string grade = "";
            int points;

            //Asking for grade
            Console.Write("Enter grade : ");
            grade = Console.ReadLine().ToUpper();

            //switch statmentu

            switch (grade)
            {
                case "H1":
                    points = 100;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H2":
                    points = 88;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H3":
                    points = 77;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H4":
                    points = 66;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H5":
                    points = 56;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H6":
                    points = 46;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H7":
                    points = 37;
                    Console.WriteLine($"You got {points} points!");
                    break;

                case "H8":
                    points = 0;
                    Console.WriteLine($"You got {points} points!");
                    break;

                default:
                    Console.WriteLine("incorrect formatt please enter grade eg. H1");
                    break;
            }
        }
    }
}
