using P02AplikacjaZawodnicy.Models;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy.API
{
    public partial class ZawodnicyServer : System.Web.UI.Page
    {
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            // teraz pobieramy zawodnikw z bazy danych 

            Thread.Sleep(3000);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnicy = zr.PodajWszytkichZawodnikow();
            




        }
    }
}