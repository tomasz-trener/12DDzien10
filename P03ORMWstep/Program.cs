using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ORMWstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            Zawodnik[] zawodnicy = db.Zawodnik.Where(x=>x.id_trenera==3).ToArray();

            foreach (var z in zawodnicy)
                Console.WriteLine(z.imie + " " + z.nazwisko);

            Console.ReadKey();
        }
    }
}
