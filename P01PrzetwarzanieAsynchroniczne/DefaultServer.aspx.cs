using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01PrzetwarzanieAsynchroniczne
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string liczba1 = Request["liczba1"];
            string liczba2 = Request["liczba2Dane"];

            int wynik = Convert.ToInt32(liczba1) + Convert.ToInt32(liczba2);
          
            Thread.Sleep(3000);
            Response.Write(wynik);
        }
    }
}