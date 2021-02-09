using System;

namespace Gmablersolution
{


    class   gmabler
    {
        const int stake = 100;
                
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
                Console.WriteLine("gambler Amount : " + result);

            }
            else if (win == 0 )
            {
                result = (stake - 1);
                Console.WriteLine("gambler Amount : " + result);
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
            
            
            
            

        }
    }
}
