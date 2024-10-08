namespace topic_7_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 3, coinToss;
            string input;
            Random generator = new Random();
            

            Console.WriteLine("Lets do some gambling!");
            Console.WriteLine("Call a coin toss and guessing correctly will give you a point, and guessing incorrectly will lose you a point.");
            Console.WriteLine("You start with three points. Heads or Tails!");
            input = Console.ReadLine().ToLower();

            while (input != "quit")
            {
                coinToss = generator.Next(1, 3);
                if (coinToss == 1)
                    Console.WriteLine("Heads!");
                if (coinToss == 2)
                {
                    Console.WriteLine("Tails!");
                }
                if (input == "heads" && coinToss == 1)
                {
                    Console.WriteLine("Nice guess!");
                    score += 1;
                }
                if (input == "tails" && coinToss == 2)
                {
                    Console.WriteLine("Nice guess!");
                    score += 1;
                }
                if (input == "heads" && coinToss == 2)
                {
                    Console.WriteLine("Incorrect!");
                    score -= 1;
                }
                if (input == "tails" && coinToss == 1)
                {
                    Console.WriteLine("Incorrect!");
                    score -= 1;
                }
                Console.WriteLine("Heads, tails or quit?");
                input = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Thanks for playing! your final score was " + score + ".");


        }
    }
}
