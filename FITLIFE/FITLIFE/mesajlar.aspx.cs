using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mesajlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        veri_getir();
    }
    private void mesaj_sil(int id)
    {
        using (veritabani ent = new veritabani())
        {
            var sil = (from s in ent.MESAJLAR_LISTESI where s.ID == id select s).FirstOrDefault();
            ent.MESAJLAR_LISTESI.Remove(sil);
            ent.SaveChanges();
        }
    }
    private void veri_getir()
    {
        using (veritabani ent = new veritabani())
        {
            var mesajlar = (from i in ent.MESAJLAR_LISTESI select i).ToList();
            gv_mesajlar.DataSource = mesajlar;
            gv_mesajlar.DataBind();
        }
    }

    protected void gv_mesajlar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        int id = int.Parse(gv_mesajlar.Rows[index].Cells[1].Text);
        if (e.CommandName == "sil")
        {
            mesaj_sil(id);
            veri_getir();
        }
    }
}