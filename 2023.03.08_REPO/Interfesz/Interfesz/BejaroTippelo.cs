using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    internal class BejaroTippelo : GepiJatekos
    {
        int aktualis;
        public override int KovetkezoTipp()
        {
            aktualis++;
            return aktualis - 1;
        }

        public override void JatekIndul(int alsoHatar, int felsoHatar)
        {
            aktualis = alsoHatar;
        }
    }
}
