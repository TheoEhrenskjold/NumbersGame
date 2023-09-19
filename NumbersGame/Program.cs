namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 20);
            var guess = Convert.ToInt32(Console.ReadLine());
            var guessloop = true;
            while (guessloop)
            {


                for (int i = 0; i < 5; i++)
                {

                    if (guess < number)
                    {
                        var guess1 = Console.ReadLine();
                        Console.WriteLine("Tyvärr du gissade för lågt");
                    }
                    else if (guess > number)
                    {
                        var guess2 = Console.ReadLine();
                        Console.WriteLine("Tyvärr du gissade för högt!");
                    }
                    else
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                    }


                    break;
                }
            }

        }
    }
}