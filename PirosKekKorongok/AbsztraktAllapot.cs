using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirosKekKorongok
{
 /// <summary>
 /// Minden állapot osztály őse.
 /// </summary>
 abstract class AbsztraktÁllapot : ICloneable
 {
  // Megvizsgálja, hogy a belső állapot állapot-e.
  // Ha igen, akkor igazat ad vissza, egyébként hamisat.
  public abstract bool ÁllapotE();
  // Megvizsgálja, hogy a belső állapot célállapot-e.
  // Ha igen, akkor igazat ad vissza, egyébként hamisat.
  public abstract bool CélÁllapotE();
  // Visszaadja az alapoperátorok számát.
  public abstract int OperátorokSzáma();
  // A szuper operátoron keresztül lehet elérni az összes operátort.
  // Igazat ad vissza, ha az i.dik alap operátor alkalmazható a belső állapotra.
  // for ciklusból kell hívni 0-tól kezdve az alap operátorok számig. Pl. így:
  // for (int i = 0; i < állapot.GetNumberOfOps(); i++)
  // {
  // AbsztraktÁllapot klón=(AbsztraktÁllapot)állapot.Clone();
  // if (klón.SzuperOperátor(i))
  // {
  // Console.WriteLine("Az {0} állapotra az {1}.dik " +
  // "operátor alkalmazható", állapot, i);
  // }
  // }
  public abstract bool SzuperOperátor(int i);
  // Klónoz. Azért van rá szükség, mert némelyik operátor hatását vissza kell vonnunk.
  // A legegyszerűbb, hogy az állapotot leklónozom. Arra hívom az operátort.
  // Ha gond van, akkor visszatérek az eredeti állapothoz.
  // Ha nincs gond, akkor a klón lesz az állapot, amiből folytatom a keresést.
  // Ez sekély klónozást alkalmaz. Ha elég a sekély klónozás, akkor nem kell felülírni a gyermek osztályban.
  // Ha mély klónozás kell, akkor mindenképp felülírandó.
  public virtual object Clone()
  {
   return MemberwiseClone();
  }
  // Csak akkor kell felülírni, ha emlékezetes backtracket akarunk használni, vagy mélységi keresést.
  // Egyébként maradhat ez az alap implementáció.
  // Programozás technikailag ez egy kampó metódus, amit az OCP megszegése nélkül írhatok felül.
  public override bool Equals(Object a)
  {
   return false;
  }
  // Ha két példány egyenlő, akkor a hasító kódjuk is egyenlő.
  // Ezért, ha valaki felülírja az Equals metódust, ezt is illik felülírni.
  public override int GetHashCode()
  {
   return base.GetHashCode();
  }
 }
}

