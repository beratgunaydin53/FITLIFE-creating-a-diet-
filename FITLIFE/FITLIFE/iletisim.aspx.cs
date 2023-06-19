using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnGonder_Click(object sender, EventArgs e)
    {
        if (txt_adsoyad.Text == "" && txt_konu.Text == "" && txt_mesaj.Text == "" && txt_posta.Text == "")
            LblMesajKontrol.Text = "lütfen boş olan alanları doldurunuz.";
        else
        {
            using (veritabani ent = new veritabani())
            {
                MESAJLAR_LISTESI mesaj = new MESAJLAR_LISTESI();
                mesaj.ADISOYADI = txt_adsoyad.Text;
                mesaj.EPOSTA = txt_posta.Text;
                mesaj.KONU = txt_konu.Text;
                mesaj.MESAJ = txt_mesaj.Text;
                ent.MESAJLAR_LISTESI.Add(mesaj);
                ent.SaveChanges();
                LblMesajKontrol.Text = "Mesajınız alınmıştır. En kısa sürede yazmış" +
                    " olduğunuz mail'e dönüş yapılacaktır <br/> Fit Life Ekibi";
            }
        }
       
    }
    
}