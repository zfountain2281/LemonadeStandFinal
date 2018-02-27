using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new ConsoleApp1.Game();
            game.RunGame();
            Console.ReadKey();
        }
    }
}
