using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    class Csucs
    {
        AbsztraktÁllapot allapot;
        internal AbsztraktÁllapot Allapot
        {
            get { return allapot; }
        }

        int operator_index; // annak az operátornak az indexe, melyet következő alkalommal alkalmazunk az állapotra
        public int Operator_index
        {
            get { return operator_index; }
        }
        public void OpLeptet()
        {
            operator_index++;
        }

        Csucs szulo;
        internal Csucs Szulo
        {
            get { return szulo; }
        }

        protected int melyseg;
        public int Melyseg
        {
            get { return melyseg; }
        }

        // heurisztika
        int h;
        public int H
        {
            get { return h; }
        }

        public int F
        {
            get { return melyseg + h; }
        }

        public Csucs(Állapot allapot, int operator_index, Csucs szulo)
        {
            this.allapot = allapot;
            this.operator_index = operator_index;
            this.szulo = szulo;
            this.melyseg = szulo == null ? 0 : szulo.melyseg + 1;
            // heurisztika kiszámolása
            this.h = allapot.Heurisztika;
        }

        public override bool Equals(object obj)
        {
            return this.Allapot.Equals((obj as Csucs).Allapot);
        }
    }
}
