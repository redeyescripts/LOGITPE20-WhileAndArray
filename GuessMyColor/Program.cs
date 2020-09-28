using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ComputerNumber = rnd.Next(1, 4);


            bool rightGuess = false;

            //  int userGuess = Int32.Parse(Console.ReadLine());
            while (!rightGuess)
            {
                Console.WriteLine("Whats my color?");
                string userInput = Console.ReadLine().ToLower();





                if (ComputerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;


                }
                else if (ComputerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;

                }
                else if (ComputerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;

                }else
                {
                    Console.WriteLine("Try again :(");
                } 
            }
        }
    }
}



