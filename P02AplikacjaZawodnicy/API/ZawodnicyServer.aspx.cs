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

           // Thread.Sleep(3000);

            string strona= Request["strona"];
            string ile = Request["ile"];

            int stronaInt = 1;
            int ileInt =5;

            if (strona != null)
                stronaInt = Convert.ToInt32(strona);

            if (ile != null)
                ileInt = Convert.ToInt32(ile);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnicy = zr.PodajWszytkichZawodnikow(stronaInt,ileInt);
            




        }
    }
}