using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    class AAlgoritmus : GrafKereso
    {

        List<Csucs> adatb = new List<Csucs>();
        int elsoNyiltCsucsIndex = 0;

        protected override void Adatbazisba(Csucs a)
        {
            int i = 0;
            if (kellKorfigyeles && (i = adatb.IndexOf(a)) >= 0) // i értéke -1, ha nem találjuk a-t
            {
                if (adatb[i].F <= a.F) // ha az új csúcs költsége nem kisebb, az új csúcsot eldobjuk
                    return;
                
                adatb.RemoveAt(i); // ha az új csúcs költsége kisebb, a régi csúcsot dobjuk el
                if (i < elsoNyiltCsucsIndex) // ha zárt csúcsot töröltünk
                    elsoNyiltCsucsIndex--;
            }

            for (i = elsoNyiltCsucsIndex; i < adatb.Count; i++)
                if (adatb[i].F >= a.F)
                {
                    adatb.Insert(i, a);
                    return;
                }
            adatb.Add(a);
        }

        protected override Csucs Adatbazisbol()
        {
            if (elsoNyiltCsucsIndex >= adatb.Count)
                return null;

            return adatb[elsoNyiltCsucsIndex++];
        }

        public AAlgoritmus(bool kellKorfigyeles)
        {
            this.kellKorfigyeles = kellKorfigyeles;
        }
    }
}
