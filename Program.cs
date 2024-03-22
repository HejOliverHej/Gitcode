using System;

namespace Gitcode
{


    internal class program
    {

        static void Main(string[] args)
        {
            int run = 0;
            while (true)
            {
                Console.WriteLine("Välkommen");
                Console.WriteLine("Välj i menyn (ett heltal");
                run = int.Parse(Console.ReadLine());
                if (run == 1) 
                {
                    Greetings();
                }
                else if (run == 2)
                {

                    Oliver();
                }
                else 
                {
                    Console.WriteLine("Hej då");
                }

            }

            static void Greetings() 
            {
                Console.WriteLine("Hello from gihub");
            }

            static void Oliver() 
            {
                Console.WriteLine("Hello from Oliver");
            }

        }

    }
}
    







    