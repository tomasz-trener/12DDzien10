using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy.API
{
    public partial class LiczbaStronServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int ile = Convert.ToInt32(Request["ile"]);
            
            int wynik = zr.PodajLiczbeStron(ile);
            Response.Write(wynik);
        }
    }
}