using System.ComponentModel.Design;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            game();

        }
        public static void game()
        {
        repeat://I make this my starting point so i can comeback here later.
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();//I create my random method to generate a number between 1-20.
            Console.WriteLine("\nTill vilket ska vi generera ett tal?");
            var topnumber = Convert.ToInt32(Console.ReadLine()); //I let the user decide which number should be the "roof".
            int number = random.Next(1, topnumber);
            

            var rightguess = false;

            for (int i = 0; i < 6; i++)//I make the for loop go to 6 because if it only goes to 5 it stops before i can make my last if statement.
            {
                
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number) //If the guess is correct to this.
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    
                    Console.WriteLine("Vill du spela en gång till? ja/nej");
                    var gamemore = Console.ReadLine();
                    Console.Clear(); //I clear the console window to make it easier to read.

                    if (gamemore == "ja")
                    {
                        goto repeat; //I use a goto statement to repeat the loop.
                    }

                    if (gamemore == "nej")
                    {

                        Console.WriteLine("Ha en fortsatt fin dag!");
                        rightguess = true;//I change the bool to true to end the loop
                        break;
                    }
                    
                }
                if (guess > number)
                {

                    Console.WriteLine("Tyvärr du gissade för högt!");
                }

                if (guess < number)
                {
                 
                    Console.WriteLine("Tyvärr du gissade för lågt");
                }

                
                while (i == 5)
                {
                    
                    
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                
                Console.WriteLine("Vill du spela en gång till? ja/nej");
                var gamemore = Console.ReadLine();
                    Console.Clear();

                 if (gamemore == "ja")
                 {

                 goto repeat;//Here i go to my starting point by using the "goto" function.

                 }

                 if (gamemore == "nej")
                 {

                 Console.WriteLine("Ha en fortsatt fin dag!");
                 rightguess = true; //Here i end the loop by making the bool true.
                 break;

                 }
                    
                }



            }
        }
    }
}