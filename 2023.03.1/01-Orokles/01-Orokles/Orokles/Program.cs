using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            Jarmu tardis = new Jarmu('#',10,10, terkep);

            TerkepEsJarmuRajzolo hudehude = new TerkepEsJarmuRajzolo(terkep,5);
            hudehude.JarmuFelvetele(tardis);
            hudehude.Kirajzol();
        }

        static void Main(string[] args)
        {
            Teszt1();
            Console.ReadKey();
        }
    }
}
