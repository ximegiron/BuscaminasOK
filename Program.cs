using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGame<Celda> game = new ConsoleGame<Celda>(6, 7, 5);
            //string a = "10";
            //Console.WriteLine(a.PadLeft(3));
            Console.ReadKey();
            Celda.Status test = Celda.Status.HIDDEN;

        }
    }
}
