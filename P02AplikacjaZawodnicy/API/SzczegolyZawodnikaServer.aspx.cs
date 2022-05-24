using P02AplikacjaZawodnicy.Models;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy.API
{
    public partial class SzczegolyZawodnikaServer : System.Web.UI.Page
    {
        public Zawodnik ZawodnikWysietlany;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            ZawodnikWysietlany = zr.PodajZawodnika(id);
        }
    }
}