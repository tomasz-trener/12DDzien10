using P02AplikacjaZawodnicy.Models;
using P02AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaZawodnicy.Repositories
{
    public class ZawodnicyRepository
    {
        public Zawodnik[] PodajWszytkichZawodnikow(int strona=1, int ile = 5)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.Skip(ile*(strona-1)).Take(ile).ToArray();
        }

        public int PodajLiczbeStron(int ile)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            int ileStron = Convert.ToInt32(Math.Ceiling(db.Zawodnik.Count() / Convert.ToDouble(ile)));
            return ileStron;
        }

    }
}