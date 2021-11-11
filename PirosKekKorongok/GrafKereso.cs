using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    abstract class GrafKereso
    {
        protected bool kellKorfigyeles;

        protected List<Csucs> Kiterjeszt(Csucs cs)
        {
            List<Csucs> ujCsucsok = new List<Csucs>();

            for(int i=0;i<cs.Allapot.OperátorokSzáma();i++)
            {
                Állapot klon=(Állapot)cs.Allapot.Clone();
                if(klon.SzuperOperátor(i))
                    ujCsucsok.Add(new Csucs(klon, i, cs));
            }

            return ujCsucsok;
        }

        abstract protected void Adatbazisba(Csucs cs);

        // Ha nincs az adatbázisban csúcs, akkor null-t ad vissza
        abstract protected Csucs Adatbazisbol();

        public List<Csucs> Kereses()
        {
            Csucs aktCsucs;

            // Kezdőcsúcs létrehozása
            aktCsucs = new Csucs(new Állapot(), -1, null);

            // Kezdőcsúcs adatb-be
            Adatbazisba(aktCsucs);

            // Ciklus, amíg ki nem ürül az adatb vagy terminális csúcsot nem választunk ki
            while ((aktCsucs = Adatbazisbol()) != null && !aktCsucs.Allapot.CélÁllapotE())
            {
                // Kiválasztott csúcs kiterjesztése
                List<Csucs> ujCsucsok = Kiterjeszt(aktCsucs);

                // Új csúcsok az adatb-be
                foreach(Csucs cs in ujCsucsok)
                    Adatbazisba(cs);
            }

            // Nincs megoldás
            if (aktCsucs == null)
                return null;

            // Van megoldás, a csúcsait fordított sorrendbe állítjuk
            Stack<Csucs> st = new Stack<Csucs>();
            do
            {
                st.Push(aktCsucs);
                aktCsucs = aktCsucs.Szulo;
            } while (aktCsucs != null);

            return st.ToList();
        }
    }
}
