using P02AplikacjaZawodnicy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaZawodnicy.ViewModels
{
    public class ZawodnicyRezultatVM
    {
        public Zawodnik[] Zawodnicy { get; set; }
        public int LiczbaStron { get; set; }
    }
}