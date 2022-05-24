using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy.API
{
    public partial class EdycjaZawodnika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            string imie = Request["imie"];
            string nazwisko = Request["nazwisko"];
            string kraj= Request["kraj"];
            DateTime dataUr = Convert.ToDateTime(Request["dataUr"]);
            int waga = Convert.ToInt32(Request["waga"]);
            int wzrost = Convert.ToInt32(Request["wzrost"]);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.EdycjaZawodnika(id, imie, nazwisko, kraj, dataUr, wzrost, waga);


        }
    }
}