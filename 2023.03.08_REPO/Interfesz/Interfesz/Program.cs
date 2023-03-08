using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    internal class Program
    {
        static void Teszt()
        {
            SzamKitalaloJatek jatek = new SzamKitalaloJatek(1,100);
            VeletlenTippelo veletlen = new VeletlenTippelo();
            BejaroTippelo bejaro = new BejaroTippelo();

            jatek.VersenyzoFelvetele(veletlen);
            jatek.VersenyzoFelvetele(bejaro);

            jatek.Jatek();
        }
        
        static void Main(string[] args)
        {
            Teszt();
        }
    }
}
