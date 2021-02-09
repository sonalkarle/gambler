using System;

namespace Gmablersolution
{


    class   gmabler
    {
        const int stake = 100;
        const int count = 0;
                
        public static void gamblermoney()
        {
            const int stake = 100;
            int bet = 1;
            
        }
       public static void winOrloss()
        {
            
            Random random = new Random();
            int win = random.Next(0, 2);
            int result;
            
            if (win == 1)
            {
                result = (stake + 1);
                Console.WriteLine("gambler won");
                
                

            }
            else if (win == 0 )
            {
                result = (stake - 1);
                Console.WriteLine("gambler loss");
            }
        }

        public static void resignDay()

        {
            winOrloss();
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
            for (int day =1; day<20; day++)
            {
                winOrloss();
                Console.WriteLine("Gambler won: " + day);

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
