using System;
using System.ComponentModel.Design;
using System.Net.Sockets;
using System.Xml.Schema;

namespace MathGames
{
    class Program
    {
        static int score = 0;
        static readonly Random ran1 = new Random();
        static readonly Random ran2 = new Random();

        static void Main(string[] args)
        {
            Initialize();
        }

        public static void Initialize()
        {
            Console.WriteLine("Welome to Gus's Math Games!");
            Console.WriteLine(
                "For Addition, enter 1 \n " +
                "For Subtraction, enter 2 \n " +
                "For Multiplication, enter 3 \n " +
                "For Division, enter 4");
            int probType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now, enter the number of problems to work on between 1 and 12");
                int numbProb = Convert.ToInt32(Console.ReadLine());


                if (probType == 1)
                {
                    Console.WriteLine($"You are attempting Addition and you have {numbProb} problems.");
                    Console.WriteLine("Press any key to begin:");
                    Console.ReadLine();
                    score = Add(numbProb);
                }
                else if (probType == 2)
                {
                    Console.WriteLine($"You are attempting Subtraction and you have {numbProb} problems.");
                    Console.WriteLine("Press any key to begin:");
                    Console.ReadLine();
                    score = Subtract(numbProb);
                }
                else if (probType == 3)
                {
                    Console.WriteLine($"You are attempting Multiplication and you have {numbProb} problems.");
                    Console.WriteLine("Press any key to begin:");
                    Console.ReadLine();
                    score = Multiply(numbProb);
                }
                else if (probType == 4)
                {
                    Console.WriteLine($"You are attempting Division and you have {numbProb} problems");
                    Console.WriteLine("For simplicity, limit your answer to two decimal places.");
                    Console.WriteLine("Press any key to begin:");
                    Console.ReadLine();
                    score = Divide(numbProb);
                }
                else
                {
                    Console.WriteLine("Invalid response, please try again.");
                    Initialize();
                }
                string report = Report(score);
                Console.WriteLine($"Your score is {report}");
            
        }

        


        static int Add(int numbProb)
            {
                int result;
                for (int i = 0; i < numbProb; i++)
                {
                    int num1 = ran1.Next(13);
                    int num2 = ran2.Next(13);
                    int sum = num1 + num2;
                    Console.WriteLine($"So, {num1} + {num2} is?");
                    result = Convert.ToInt32(Console.ReadLine());

                    if (result == sum)
                    {
                        score++;
                        Console.WriteLine($"You are correct! Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer is {sum}");
                    }

                }
                return score;
            }

            static int Subtract(int numbProb)
            {
                int result;
                for (int i = 0; i < numbProb; i++)
                {
                    int num1 = ran1.Next(13);
                    int num2 = ran2.Next(13);
                    int subtraction = 0;
                    if (num1 > num2)
                    {
                        subtraction =  num1 - num2;
                    }

                    Console.WriteLine($"So, {num1} - {num2} is?");
                    result = Convert.ToInt32(Console.ReadLine());

                    if (result == subtraction)
                    {
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer is {subtraction}");
                    }

                }
                return score;
            }

            static int Divide(int numbProb)
            {
                decimal result;
                for (int i = 0; i < numbProb; i++)
                {
                    decimal num1 = ran1.Next(13);
                    decimal num2 = ran2.Next(13);
                    decimal total = Math.Round(num1/num2, 2);
                    Console.WriteLine($"So, {num1} / {num2} is?");
                    result = Convert.ToDecimal(Console.ReadLine());

                    if (result == total)
                    {
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer is {total}");
                    }

                }
                return score;
            }

            static int Multiply(int numbProb)
            {
                int result;
                int score = 0;
                for (int i = 0; i < numbProb; i++)
                {
                    int num1 = ran1.Next(13);
                    int num2 = ran2.Next(13);
                    int total = num1 * num2;
                    Console.WriteLine($"So, {num1} * {num2} is?");
                    result = Convert.ToInt32(Console.ReadLine());

                    if (result == total)
                    {
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The correct answer is {total}");
                    }

                }
                return score;
            }

            static string Report(int score)
            {
                string total = Convert.ToString(score);
                return total;
            }
        
    }
}



