using System;

namespace Project1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"We are starting with {numberOfPlayers} players!");
            Console.WriteLine(Environment.NewLine);
            int i = 1;
            string playerName;
            int winningNumber = 0;
            string winningPlayer = "";
            while (i <= numberOfPlayers)
            {
                playerName = $"Player {i}";

                Dice dice = new Dice();

                var result = dice.Roll();
                var number1 = result.Item1;
                var number2 = result.Item2;
                var total = result.Item3;

                Console.WriteLine($"{playerName} rolls the dice.");
                Console.WriteLine($"The first dice lands on {number1}");
                if (number1 == 1)
                {
                    Console.WriteLine("LOL! Thats rubbish!");
                }
                if (number1 == 6)
                {
                    Console.WriteLine("WOAH! That was lucky!");
                }
                Console.WriteLine($"The second dice lands on {number2}");
                if (number2 == 1)
                {
                    Console.WriteLine("LOL! Thats rubbish!");
                }
                if (number2 == 6)
                {
                    Console.WriteLine("WOAH! That was lucky!");
                }
                Console.WriteLine($"{number1} + {number2} is {total}");
                Console.WriteLine(Environment.NewLine);
                if (total > winningNumber)
                {
                    winningPlayer = playerName;
                    winningNumber = total;
                }
                i++;
            }
            Console.WriteLine($"{winningPlayer} won with a {winningNumber}");
        }
    }
}