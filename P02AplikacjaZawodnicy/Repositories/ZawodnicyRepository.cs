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
        public Zawodnik[] PodajWszytkichZawodnikow(int strona=1, int ile = 5, string filtr=null)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            if (filtr == null)
                return db.Zawodnik.Skip(ile * (strona - 1)).Take(ile).ToArray();
            else
                return db.Zawodnik
                    .Where(x=>x.imie.Contains(filtr) || x.nazwisko.Contains(filtr) || x.kraj.Contains(filtr))
                    .Skip(ile * (strona - 1)).Take(ile).ToArray();

        }

        public int PodajLiczbeStron(int ile)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            int ileStron = Convert.ToInt32(Math.Ceiling(db.Zawodnik.Count() / Convert.ToDouble(ile)));
            return ileStron;
        }

        public Zawodnik PodajZawodnika(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
        }

        public void EdycjaZawodnika(int id, string imie, string nazwisko, string kraj, DateTime dataUr, int wzrost, int waga)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var zawodnik = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
            zawodnik.imie = imie;
            zawodnik.nazwisko = nazwisko;
            zawodnik.kraj = kraj;
            zawodnik.data_ur = dataUr;
            zawodnik.wzrost = wzrost;
            zawodnik.waga = waga;
            db.SubmitChanges();
        }

        public void Usuwanie (int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var zawodnik = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
            db.Zawodnik.DeleteOnSubmit(zawodnik);
            db.SubmitChanges();
        }

        public void DodajZawodnika(string imie, string nazwisko, string kraj, DateTime dataUr, int wzrost, int waga)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.imie = imie;
            zawodnik.nazwisko = nazwisko;
            zawodnik.kraj = kraj;
            zawodnik.data_ur = dataUr;
            zawodnik.wzrost = wzrost;
            zawodnik.waga = waga;
            db.Zawodnik.InsertOnSubmit(zawodnik);
            db.SubmitChanges();
        }
    }
}