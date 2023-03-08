using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    internal class SzamKitalaloJatek
    {
        const int MAX_VERSENYZO = 5;

        ITippelo[] versenyzok = new ITippelo[MAX_VERSENYZO];
        int versenyzoN;
        int alsoHatar;
        int felsoHatar;
        int cel;

        public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
            versenyzoN = -1;
        }

        public void VersenyzoFelvetele(ITippelo tmp)
        {
            if (versenyzoN < versenyzok.Length - 1)
            {
                versenyzok[versenyzoN + 1] = tmp;
                versenyzoN++;
            }
        }

        public void VersenyIndul()
        {
            int randomSzam = Util.rnd.Next(alsoHatar,felsoHatar + 1);
            cel = randomSzam;
            
            for (int i = 0; i < versenyzoN; i++)
            {
                versenyzok[i].JatekIndul(alsoHatar, felsoHatar);
            }

        }

        public bool MindenkiTippel()
        {
            bool voltNyertes = false;
            for (int i = 0; i < versenyzoN; i++)
            {
                if (versenyzok[i].KovetkezoTipp() == cel)
                {
                    versenyzok[i].Nyert();
                    voltNyertes = true;
                }
                else
                {
                    versenyzok[i].Veszitett();
                }
            }
            
            return voltNyertes;
        }

        public void Jatek()
        {
            VersenyIndul();
            do
            {
                Console.WriteLine($"A cél {cel}");
                Console.WriteLine("Érkezzenek a tippek: ");
            } while (!MindenkiTippel());
        }
    }
}
