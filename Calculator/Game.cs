using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        bool quit = false;      

        float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        int GetInput(string description, string option1, string option2, string option3, string option4, string option5)
        {
            string input = "";
            int inputRecieved = 0;

            while (!(inputRecieved == 1 || inputRecieved == 2 || inputRecieved == 3 || inputRecieved == 4 || inputRecieved == 5))
            {
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);
                Console.WriteLine("4. " + option4);
                Console.WriteLine("5. " + option5);
                Console.Write("> ");

                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputRecieved = 2;
                }
                else if (input == "3" || input == option3)
                {
                    inputRecieved = 3;
                }
                else if (input == "4" || input == option4)
                {
                    inputRecieved = 4;
                }
                else if (input == "5" || input == option5)
                {
                    inputRecieved = 5;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }

                Console.Clear();
            }
            return inputRecieved;
        }

        void Calculation()
        {
            string value1;
            string value2;
            float num1;
            float num2;
            int input = GetInput("Would you like to:", "1. Add", "2. Subtract", "3. Multiply", "4. " +
                "Divide", "5. Quit");

            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Addition");
                Console.Write("First Number > ");
                value1 = Console.ReadLine();
                Single.TryParse(value1, out num1);
                Console.Write("Second Number > ");
                value2 = Console.ReadLine();
                Single.TryParse(value2, out num2);
                float result = Add(num1, num2);
                Console.WriteLine(result);

            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Subtraction");
                Console.Write("First Number > ");
                value1 = Console.ReadLine();
                Single.TryParse(value1, out num1);
                Console.Write("Second Number > ");
                value2 = Console.ReadLine();
                Single.TryParse(value2, out num2);
                float result = Subtract(num1, num2);
                Console.WriteLine(result);
            }
            else if (input == 3)
            {
                Console.Clear();
                Console.WriteLine("Multiplication");
                Console.Write("First Number > ");
                value1 = Console.ReadLine();
                Single.TryParse(value1, out num1);
                Console.Write("Second Number > ");
                value2 = Console.ReadLine();
                Single.TryParse(value2, out num2);
                float result = Multiply(num1, num2);
                Console.WriteLine(result);
            }
            else if (input == 4)
            {
                Console.Clear();
                Console.WriteLine("Division");
                Console.Write("First Number > ");
                value1 = Console.ReadLine();
                Single.TryParse(value1, out num1);
                Console.Write("Second Number > ");
                value2 = Console.ReadLine();
                Single.TryParse(value2, out num2);
                float result = Divide(num1, num2);
                Console.WriteLine(result);
            }
            else if (input == 5)
            {                            
                quit = true;
            }
        }
        public void Run()
        {
           while (!quit)
            {
                Calculation();                 
            }
            
        }
    }
}
