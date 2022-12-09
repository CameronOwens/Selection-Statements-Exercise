namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you csn guess the correct number");
            Console.WriteLine("What is the upper limit for the range of the number");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Take your guess:");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("Too high! Sorry try again");
            }
            else if(guess < number)
            {
                Console.WriteLine("Too low! Sorry try again");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}
