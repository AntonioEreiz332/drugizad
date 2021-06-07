using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugizad
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaD objekt = new KlasaD();
            bool prvi=true;
            int drugi=50;
            prvi = objekt.Suprotno(prvi);
            drugi = objekt.Suprotno(drugi);
            Console.WriteLine("Prva= " + prvi);
            Console.WriteLine("Druga= " + drugi);

            Console.ReadKey();

        }
    }
}
