using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01PrzetwarzanieAsynchroniczne
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrzeslijNaSerwer_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(txtLiczba1.Text);
            int liczba2 = Convert.ToInt32(txtLiczba2.Text);

            Thread.Sleep(3000);

            int wynik = liczba1 + liczba2;

            txtWynik.Text = wynik.ToString();
        }
    }
}