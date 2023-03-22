namespace Krokkodillespillet
{
    internal class Program
    {
        static int points = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Fill in the gap with either '<', '=' or '>'");
            //game();
            GameLoop();


        }

        static void GameLoop()
        {
            Console.WriteLine(points + " Points");
            bool rightAnswer = false;
            Random rnd = new Random();
            int left = rnd.Next(10);
            int right = rnd.Next(10);
            Console.WriteLine($"{left} _ {right}");
            string userInput = Console.ReadLine();
            if (left < right && userInput == "<") rightAnswer = true;
            if (left > right && userInput == ">") rightAnswer = true;
            if (left == right && userInput == "=") rightAnswer = true;

            if (rightAnswer)
            {
                Console.WriteLine("Riktig svar");
                points++;
            }
            else
            {
                Console.WriteLine("Feil svar");
                points--;
            }



            GameLoop();
        }
        /*
        static void game()
        {
            Console.WriteLine(etellerannna + " Dette er noe");
            Console.ReadLine();
            Console.WriteLine("Dette var bare redeline");
            etellerannna++;
            Random rnd = new Random();
            int number1 = rnd.Next(1, 11);
            int number2 = rnd.Next(1, 11);
            char answer;

            Console.WriteLine(points + " Points");

            Console.WriteLine(number1 + "_" + number2);
            answer = (char)Console.Read();
            if (number1 == number2)
            {
                if (answer == '=')
                {
                    points++;
                }
                else { points--; }
            }
            else if (number1 < number2)
            {
                if (answer == '<')
                {
                    points++;
                }
                else { points--; }
            }
            else if (number1 > number2)
            {
                if (answer == '>')
                {
                    points++;
                }
                else { points--; }
            };

            Console.WriteLine("Congrats");
            game();
        }*/
    }
}