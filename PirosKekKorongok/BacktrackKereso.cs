using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    class BacktrackKereso
    {
        Csucs aktCsucs;
        int melyseg_korlat;

        public BacktrackKereso(int melyseg_korlat)
        {
            this.melyseg_korlat = melyseg_korlat;
        }

        public bool Kereses()
        {
            aktCsucs = new Csucs(new Állapot(), 0, null);

            // ha aktCsucs == null, akkor nincs megoldás
            while (aktCsucs != null && !aktCsucs.Allapot.CélÁllapotE())
            {
                if (aktCsucs.Melyseg < melyseg_korlat && aktCsucs.Operator_index < aktCsucs.Allapot.OperátorokSzáma())
                {
                    Állapot ujAllapot = (Állapot)aktCsucs.Allapot.Clone();
                    if (ujAllapot.SzuperOperátor(aktCsucs.Operator_index))
                    {
                        aktCsucs.OpLeptet();
                        aktCsucs = new Csucs(ujAllapot, 0, aktCsucs);
                    }
                    else // ha az op nem alkalmazható, csak lépünk a köv. op-ra
                        aktCsucs.OpLeptet();
                }
                else // visszalépés
                    aktCsucs = aktCsucs.Szulo;
            }

            return aktCsucs != null;
        }
    }
}
