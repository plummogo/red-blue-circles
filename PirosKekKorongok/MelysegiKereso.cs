using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    class MelysegiKereso : GrafKereso
    {
        List<Csucs> zartak = new List<Csucs>();
        Stack<Csucs> nyiltak = new Stack<Csucs>();

        public MelysegiKereso(bool kellKorfigyeles)
        {
            this.kellKorfigyeles = kellKorfigyeles;
        }

        protected override void Adatbazisba(Csucs cs)
        {
            if (!kellKorfigyeles || (!zartak.Contains(cs) && !nyiltak.Contains(cs)))
                nyiltak.Push(cs);
        }

        protected override Csucs Adatbazisbol()
        {
            if (nyiltak.Count == 0)
                return null;
            return nyiltak.Pop();
        }
    }
}
