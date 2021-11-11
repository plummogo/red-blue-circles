using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    class SzelessegiKereso : GrafKereso
    {
        List<Csucs> adatb = new List<Csucs>();
        int elsoNyiltCsucsIndex = 0;

        public SzelessegiKereso(bool kellKorfigyeles)
        {
            this.kellKorfigyeles = kellKorfigyeles;
        }

        protected override void Adatbazisba(Csucs cs)
        {
            if (!kellKorfigyeles || !adatb.Contains(cs))
                adatb.Add(cs);
        }

        protected override Csucs Adatbazisbol()
        {
            if (elsoNyiltCsucsIndex >= adatb.Count)
                return null;

            return adatb[elsoNyiltCsucsIndex++];
        }
    }
}
