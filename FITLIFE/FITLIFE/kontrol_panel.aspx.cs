using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kontrol_panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_gonder_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var kullanici = (from KULLANICI_LISTESI in ent.KULLANICI_LISTESI 
                             where KULLANICI_LISTESI.KULLANICIADI==txt_kullanıciAdi.Text &&
                             KULLANICI_LISTESI.SIFRE==txt_sifre.Text select KULLANICI_LISTESI).ToList();
            if (kullanici.Count > 0)
            {
                Response.Redirect("mesajlar.aspx");
            }
            else
                lbl_mesaj.Text = "Kullanıcı adınız veya şifreniz yanlış. Tekrar Deneyiniz";
        }
    }
}