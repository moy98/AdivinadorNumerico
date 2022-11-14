using System;

namespace NumberGuesser
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GetAppInfo(); 

            GreetUser(); 

            while (true)
            {

             

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Adivina un numero entre el 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Por favor, coloca un numero valido");

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Error message
                        PrintColorMessage(ConsoleColor.Red, "Incorrecto, Intenta otra vez");
                    }
                }

                //  success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECTO!! Haz Adivinado!");

                // Ask to play again
                Console.WriteLine("¿Quieres jugar otra vez? [Y o N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }           

        }

        static void GetAppInfo() {
           
            string appName = "Adivinador de numeros";
            

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine(appName);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser() {
            // Ask users name
            Console.WriteLine("Cual es tu nombre?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hola {0}, Vamos a jugar...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
