using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

              TimeSpan TIEMPOI = DateTime.Now - DateTime.Today;
              TimeSpan TIEMPOF = TimeSpan.Parse("00:00:00");
              TimeSpan RESTA = TIEMPOI - TIEMPOF;

              string FORMATO = string.Format("{0} HOURAS, {1} MINUTOS, {2} SEGUNDOS", RESTA.Hours, RESTA.Minutes, RESTA.Seconds);

              Console.WriteLine("EL TRANSCURRIDO ES: " + FORMATO);

            
           
            /*int  Resultado, T, I;
            long sum = 0;

            for (T = 1; T <= 10; T++)
            {
                
                for (I = T; I >= 1; I--)
                {

                    sum += I ;                 

                    Console.WriteLine("{0}", sum);
                }
                Console.Write("Pulse una Tecla:"); Console.ReadLine();
            }*/
           

        }
    }
}
