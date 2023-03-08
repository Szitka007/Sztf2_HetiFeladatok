using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    internal class VeletlenTippelo : GepiJatekos
    {
        public override int KovetkezoTipp()
        {
            return Util.rnd.Next(alsoHatar,felsoHatar + 1);
        }
    }
}
