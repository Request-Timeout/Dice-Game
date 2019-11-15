using System;

namespace Project1
{
    public class Dice
    {
        public string player;
        public string Player
        {
            get { return player; }
            private set { player = value; }
        }
        public (int, int, int) Roll()
        {
            Random rndm = new Random();
            int number1 = rndm.Next(1, 7);
            int number2 = rndm.Next(1, 7);
            int total = number1 + number2;
            return (number1, number2, total);
        }
    }
}