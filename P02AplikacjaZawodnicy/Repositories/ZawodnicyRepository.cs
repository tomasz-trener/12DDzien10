using P02AplikacjaZawodnicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaZawodnicy.Repositories
{
    public class ZawodnicyRepository
    {
        public Zawodnik[] PodajWszytkichZawodnikow()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.ToArray();
        }
    }
}