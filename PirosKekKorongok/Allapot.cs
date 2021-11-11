using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
    enum Cella { Piros = -1, Ures = 0, Kek = 1 };

    class Állapot : AbsztraktÁllapot
    {
        // legyen páratlan!
        public const byte tablaMeret = 3;

        private Cella[,] tabla;
        public Cella[,] Tabla
        {
            get { return tabla; }
        }


        // az üres cella helye
        private byte uresX, uresY;
        public byte UresX
        {
            get { return uresX; }
        }
        public byte UresY
        {
            get { return uresY; }
        }

        public override object Clone()
        {
            // sekély klónozás: csak az érték típusú mezők értékei másolódnak
            Állapot ujAllapot = (Állapot)base.Clone();

            // az összes referencia típusú mező értékét klónozni kell
            ujAllapot.tabla = (Cella[,])this.tabla.Clone();

            return ujAllapot;
        }

        public override bool Equals(object a)
        {
            Állapot b = (Állapot)a;

            if (b.uresX != this.UresX)
                return false;
            if (b.uresY != this.UresY)
                return false;

            for (int i = 0; i < tablaMeret; i++)
                for (int j = 0; j < tablaMeret; j++)
                    if (b.tabla[i, j] != this.tabla[i, j])
                        return false;

            return true;
        }

        // Célállapot
/*        static private Cella[,] celTabla = new Cella[5, 5] {
    { Cella.Piros, Cella.Piros, Cella.Piros, Cella.Kek, Cella.Kek },
    { Cella.Piros, Cella.Piros, Cella.Piros, Cella.Kek, Cella.Kek },
    { Cella.Piros, Cella.Piros, Cella.Ures, Cella.Kek, Cella.Kek },
    { Cella.Piros, Cella.Piros, Cella.Kek, Cella.Kek, Cella.Kek },
    { Cella.Piros, Cella.Piros, Cella.Kek, Cella.Kek, Cella.Kek }
   };*/
        static private Cella[,] celTabla = new Cella[tablaMeret, tablaMeret];

        static Állapot()
        {
            byte kozep = tablaMeret / 2;
            for (int i = 0; i < tablaMeret; i++)
            {
                for (int j = 0; j < tablaMeret; j++)
                {
                    if (j < kozep)
                        celTabla[i, j] = Cella.Piros;
                    else if (j > kozep)
                        celTabla[i, j] = Cella.Kek;
                    else if (i < kozep)
                        celTabla[i, j] = Cella.Piros;
                    else if (i > kozep)
                        celTabla[i, j] = Cella.Kek;
                    else celTabla[i, j] = Cella.Ures;
                }
            }   
        }

        // Kezdőállapot
        public Állapot()
        {
   //         tabla = new Cella[5, 5] {
   // { Cella.Kek, Cella.Kek, Cella.Kek, Cella.Piros, Cella.Piros },
   // { Cella.Kek, Cella.Kek, Cella.Kek, Cella.Piros, Cella.Piros },
   // { Cella.Kek, Cella.Kek, Cella.Ures, Cella.Piros, Cella.Piros },
   // { Cella.Kek, Cella.Kek, Cella.Piros, Cella.Piros, Cella.Piros },
   // { Cella.Kek, Cella.Kek, Cella.Piros, Cella.Piros, Cella.Piros }
   //};
            tabla = new Cella[tablaMeret, tablaMeret];
            uresX = uresY = tablaMeret / 2;
            for (int i = 0; i < tablaMeret; i++)
            {
                for (int j = 0; j < tablaMeret; j++)
                {
                    if (j < uresY)
                        tabla[i, j] = Cella.Kek;
                    else if (j > uresY)
                        tabla[i, j] = Cella.Piros;
                    else if (i < uresX)
                        tabla[i, j] = Cella.Kek;
                    else if (i > uresX)
                        tabla[i, j] = Cella.Piros;
                    else tabla[i, j] = Cella.Ures;
                }
            }   
        }

        public override bool CélÁllapotE()
        {
            for (int i = 0; i < tablaMeret; i++)
                for (int j = 0; j < tablaMeret; j++)
                    if (tabla[i, j] != celTabla[i, j]) { return false; }

            return true;
        }

        public override bool ÁllapotE()
        {
            throw new NotImplementedException();
        }

        public override int OperátorokSzáma()
        {
            return 8;
        }

        // esetszétválasztás az operátor indexe alapján
        public override bool SzuperOperátor(int i)
        {
            switch (i)
            {
                case 0:
                    opLep(0, 1);
                    break;
                case 1:
                    opLep(-1, 0);
                    break;
                case 2:
                    opLep(0, -1);
                    break;
                case 3:
                    opLep(1, 0);
                    break;
                case 4:
                    opUgrik(0, 2);
                    break;
                case 5:
                    opUgrik(-2, 0);
                    break;
                case 6:
                    opUgrik(0, -2);
                    break;
                case 7:
                    opUgrik(2, 0);
                    break;
                default:
                    return false;
            }

            return true;
        }

        // operátor előfeltétele
        private bool preOpLep(sbyte honnanX, sbyte honnanY)
        {
            if (0 > uresX - honnanX || uresX - honnanX >= tablaMeret)
                return false;
            if (0 > uresY - honnanY || uresY - honnanY >= tablaMeret)
                return false;

            // csak közvetlen celláról léphetünk
            if (Math.Abs(honnanX) > 1 || Math.Abs(honnanY) > 1)
                return false;

            // ha felülről vagy balról lépünk, kék koronggal kell lépni
            // ha alulról vagy jobbról lépünk, piros koronggal kell lépni
            return tabla[uresX - honnanX, uresY - honnanY] == (Cella)(honnanX + honnanY);
        }

        public bool opLep(sbyte honnanX, sbyte honnanY)
        {
            // operátor alkalmazható-e
            if (!preOpLep(honnanX, honnanY))
                return false;

            // áttoljuk a korongot az üres cellára
            tabla[uresX, uresY] = tabla[uresX - honnanX, uresY - honnanY];
            tabla[uresX - honnanX, uresY - honnanY] = Cella.Ures;
            uresX = (byte)(uresX - honnanX);
            uresY = (byte)(uresY - honnanY);

            return true;
        }

        // operátor előfeltétele
        private bool preOpUgrik(sbyte honnanX, sbyte honnanY)
        {
            // a táblán levő celláról próbálunk-e korongot léptetni
            if (0 > uresX - honnanX || uresX - honnanX >= tablaMeret)
                return false;
            if (0 > uresY - honnanY || uresY - honnanY >= tablaMeret)
                return false;

            // csak 2-vel arrébb levő celláról léphetünk
            if (Math.Abs(honnanX) != 2 && Math.Abs(honnanY) != 2)
                return false;
            if (Math.Abs(honnanX) + Math.Abs(honnanY) != 2)
                return false;

            // ha felülről vagy balról lépünk, kék koronggal kell lépni
            // ha alulról vagy jobbról lépünk, piros koronggal kell lépni
            if (tabla[uresX - honnanX, uresY - honnanY] != (Cella)((honnanX + honnanY) / 2))
            {
                return false;
            }
            if ((int)tabla[uresX - honnanX, uresY - honnanY] * (int)tabla[uresX - honnanX / 2, uresY - honnanY / 2] >= 0)
            {
                return false;
            }

            return true;
        }

        public bool opUgrik(sbyte honnanX, sbyte honnanY)
        {
            // operátor alkalmazható-e
            if (!preOpUgrik(honnanX, honnanY))
                return false;

            // áttoljuk a korongot az üres cellára
            tabla[uresX, uresY] = tabla[uresX - honnanX, uresY - honnanY];
            tabla[uresX - honnanX, uresY - honnanY] = Cella.Ures;
            uresX = (byte)(uresX - honnanX);
            uresY = (byte)(uresY - honnanY);

            return true;
        }

        public int Heurisztika
        {
            get
            {
                // this állapotunk milyen "messze" van a célállapottól?
                return 0;
            }
        }
    }
}
