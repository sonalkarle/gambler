using System;

namespace Gmablersolution
{
    class gmabler
    {
        //Constant variable
        const int stake = 100;
        const int count = 0;

        public static void gamblermoney()
        {
            //gambler money
            int stake = 100;
            int bet = 1;

        }
        public static void winOrloss()
        {
            //Random function 
            Random random = new Random();
            int win = random.Next(0, 2);
            int result;
            //If gmabler win 1 rs added to gambler money
            if (win == 1)
            {
                result = (stake + 1);
                Console.WriteLine("gambler won");



            }
            //If loose 1 rs is loose from gambler money
            else if (win == 0)
            {
                result = (stake - 1);
                Console.WriteLine("gambler loss");
            }
        }

        public static void resignDay()

        {
            //Check until gambler money reached for day
            winOrloss();
            resignDay();
            for (int i = 1; i < stake; i++)
            {
                if (stake == stake / 2)
                {
                    Console.WriteLine("Gambler should resgin for day");
                }
            }
        }
        public static void Daytarck()
        {
            //Checking track of 20 days
            for (int day = 1; day < 20; day++)
            {

                resignDay();
                Console.WriteLine("Gambler won");
                Console.WriteLine("Gambler loss");

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to gambling solution");
            gmabler.gamblermoney();
            gmabler.winOrloss();
            gmabler.resignDay();
            gmabler.Daytarck();


        }
    }
}