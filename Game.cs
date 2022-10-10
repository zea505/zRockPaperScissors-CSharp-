namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter START to Play!");

            string Entered = Console.ReadLine();

            if (Entered == "START")
            {
                string[] GameMoves = { "Rock", "Paper", "Scissors" };

                Console.WriteLine("Input Your Move!");
                Console.WriteLine("1)    Rock");
                Console.WriteLine("2)    Paper");
                Console.WriteLine("3)    Scissors");

                int PlayerInput = Convert.ToInt32(Console.ReadLine());
                Random Generate = new Random();
                int SystemInput = Generate.Next(1, 3);

                Console.WriteLine($"You Inputted \"{GameMoves[PlayerInput]}\"");
                Console.WriteLine($"System Inputted \"{GameMoves[SystemInput]}\"");

                if (PlayerInput == SystemInput)
                {
                    Console.WriteLine("MATCH Result = DRAW!");
                }
                else if (PlayerInput == 1 && SystemInput == 2 || PlayerInput == 2 && SystemInput == 3 || PlayerInput == 3 && SystemInput == 1)
                {
                    Console.WriteLine("MATCH Result = System WINS!");
                }
                else if (SystemInput == 1 && PlayerInput == 2 || SystemInput == 2 && PlayerInput == 3 || SystemInput == 3 && PlayerInput == 1)
                {
                    Console.WriteLine("MATCH Result = You WIN!");
                }
            }
        }
    }
}
