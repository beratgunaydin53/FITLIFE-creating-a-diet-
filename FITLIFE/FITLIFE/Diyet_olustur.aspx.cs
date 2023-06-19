using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Diyet_olustur : System.Web.UI.Page
{
    //sabit değişkenler
    int E = 1;
    double K = 0.95;
    double D1 = 0.25;
    int D2 = 24;
    double h_cal;
    double g_cal;
    double g_kilo;
    double i_a;
    static double ana_ogun;
    static double ara_ogun;

    protected void Page_Load(object sender, EventArgs e)
    {

        
    }
 

    
    public void btn_dytOlustur_Click(object sender, EventArgs e)
    {

        if (ddl_cins.SelectedIndex == 0)
        {
            lbl_bosCins.Visible = true;
            lbl_bosCins.Text = "Lütfen Cinsiyetinizi Seçiniz";
        }
        else
            lbl_bosCins.Visible = false;
        if (txt_yas.Text == "")
        {
            lbl_yasBos.Visible = true;
            lbl_yasBos.Text = "Lütfen Yaşınızı Yazınız";
        }
        else
            lbl_yasBos.Visible = false;
        if (txt_kilo.Text == "")
        {
            lbl_kiloBos.Visible = true;
            lbl_kiloBos.Text = "Lütfen Kilonuzu Yazınız";
        }
        else
            lbl_kiloBos.Visible = false;
        if (txt_boy.Text == "")
        {
            lbl_boyBos.Visible = true;
            lbl_boyBos.Text = "Lütfen Boyunuzu Yazınız";
        }
        else
            lbl_boyBos.Visible = false;
        if (ddl_adimlar.SelectedIndex == 0)
        {
            lbl_adimBos.Visible = true;
            lbl_adimBos.Text = "Lütfen Günde Attığınız Adım Sayısını Seçiniz";
        }
        else
        {
            lbl_adimBos.Visible = false;
        }
        if(ddl_cins.SelectedIndex!=0 && txt_boy.Text!="" && txt_kilo.Text!="" && txt_yas.Text!="" && ddl_adimlar.SelectedIndex!=0)
        { 
            btnPrint.Visible = true;
            gvAksamAra.Visible = true;
            lblAksamAra.Visible = true;
            gvAksam.Visible = true;
            lblAksam.Visible = true;
            gvAraOgle.Visible = true;
            lblAraOgle.Visible = true;
            gvOgle.Visible = true;
            lblOgle.Visible = true;
            gvAraSabah.Visible = true;
            lblAraSabah.Visible = true;
            gvSabah.Visible = true;
            lblSabah.Visible = true;
            lbl_uyari.Visible = true;
            lbl_almasiGerekenler.Visible = true;
            btn_SabahDegis.Visible = true;
            btn_AraSabahDegis.Visible = true;
            btn_OgleDegis.Visible = true;
            btn_AraOgleDegis.Visible = true;
            btn_AksamDegis.Visible = true;
            btn_AksamAraDegis.Visible = true;

        double bki = 0;
        double b = int.Parse(txt_boy.Text);
        int k = int.Parse(txt_kilo.Text);
        int y = int.Parse(txt_yas.Text);
        b = (b * b) / 10000;
        bki = k / b;
        if (bki > 18.5 && bki < 24.9)
        {
            if (ddl_cins.SelectedItem.Text == "Erkek")
            {
                h_cal = k * E * D2;
                if (ddl_adimlar.SelectedIndex == 1)
                    g_cal = h_cal * 1.3;
                else if (ddl_adimlar.SelectedIndex == 2)
                    g_cal = h_cal * 1.6;
                else if (ddl_adimlar.SelectedIndex == 3)
                    g_cal = h_cal * 1.7;
                else if (ddl_adimlar.SelectedIndex == 4)
                    g_cal = h_cal * 2.1;
                else if (ddl_adimlar.SelectedIndex == 5)
                    g_cal = h_cal * 2.4;
                else
                    lbl_adimBos.Text = "Lütfen Günlük Adımınızı Seçiniz";
            }
            else if (ddl_cins.SelectedItem.Text == "Kadın")
            {
                h_cal = k * K * D2;
                if (ddl_adimlar.SelectedIndex == 1)
                    g_cal = h_cal * 1.3;
                else if (ddl_adimlar.SelectedIndex == 2)
                    g_cal = h_cal * 1.5;
                else if (ddl_adimlar.SelectedIndex == 3)
                    g_cal = h_cal * 1.6;
                else if (ddl_adimlar.SelectedIndex == 4)
                    g_cal = h_cal * 1.9;
                else if (ddl_adimlar.SelectedIndex == 5)
                    g_cal = h_cal * 2.2;
                else
                    lbl_adimBos.Text = "Lütfen Günlük Adımınızı Seçiniz";
            }
                ana_ogun = (g_cal * 0.69) / 3;
                ara_ogun = (g_cal * 0.30) / 3;

            }
        else if (bki < 18.5 || bki > 24.9)
        {

            if (ddl_cins.SelectedItem.Text == "Erkek")
            {
                if (y >= 19 && y <= 24)
                    i_a = 21 * b;
                else if (y >= 25 && y <= 34)
                    i_a = 22 * b;
                else if (y >= 35 && y <= 44)
                    i_a = 23 * b;
                else if (y >= 45 && y <= 54)
                    i_a = 24 * b;
                else if (y >= 55 && y <= 65)
                    i_a = 25 * b;
                else if (y >= 65)
                    i_a = 26 * b;

                g_kilo = ((k - i_a) * D1) + i_a;
                h_cal = g_kilo * E * 24;

                if (ddl_adimlar.SelectedIndex == 1)
                    g_cal = h_cal * 1.3;
                else if (ddl_adimlar.SelectedIndex == 2)
                    g_cal = h_cal * 1.6;
                else if (ddl_adimlar.SelectedIndex == 3)
                    g_cal = h_cal * 1.7;
                else if (ddl_adimlar.SelectedIndex == 4)
                    g_cal = h_cal * 2.1;
                else if (ddl_adimlar.SelectedIndex == 5)
                    g_cal = h_cal * 2.4;
                else
                    lbl_adimBos.Text = "Lütfen Günlük Adımınızı Seçiniz";

            }
            else if (ddl_cins.SelectedItem.Text == "Kadın")
            {
                if (y >= 19 && y <= 24)
                    i_a = 21 * b;
                else if (y >= 25 && y <= 34)
                    i_a = 22 * b;
                else if (y >= 35 && y <= 44)
                    i_a = 23 * b;
                else if (y >= 45 && y <= 54)
                    i_a = 24 * b;
                else if (y >= 55 && y <= 65)
                    i_a = 25 * b;
                else if (y >= 65)
                    i_a = 26 * b;

                g_kilo = ((k - i_a) * D1) + i_a;
                h_cal = g_kilo * K * 24;

                if (ddl_adimlar.SelectedIndex == 1)
                    g_cal = h_cal * 1.3;
                else if (ddl_adimlar.SelectedIndex == 2)
                    g_cal = h_cal * 1.5;
                else if (ddl_adimlar.SelectedIndex == 3)
                    g_cal = h_cal * 1.6;
                else if (ddl_adimlar.SelectedIndex == 4)
                    g_cal = h_cal * 1.9;
                else if (ddl_adimlar.SelectedIndex == 5)
                    g_cal = h_cal * 2.2;
                else
                    lbl_adimBos.Text = "Lütfen Günlük Adımınızı Seçiniz";
            }
            ana_ogun = (g_cal * 0.69) / 3;
            ara_ogun = (g_cal * 0.30) / 3;
        }
        using (veritabani ent = new veritabani())
        {
                
            var toplamKalori = ent.SABAH_LISTESI.Sum(x => x.KALORI_MIKTARI);
            var verigetir = ent.SABAH_LISTESI.Where(x => x.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x => Guid.NewGuid())
                                             .ToList();

            while (toplamKalori > ana_ogun && verigetir.Count > 0)
            {
                var sonEleman = verigetir.Last();
                toplamKalori -= sonEleman.KALORI_MIKTARI;
                verigetir.Remove(sonEleman);
            }
            gvSabah.DataSource = verigetir;
            gvSabah.DataBind();

            var toplamKaloriAra = ent.ARA_OGUNLER.Sum(x1 => x1.KALORI_MIKTARI);
            var verigetirAra = ent.ARA_OGUNLER.Where(x1 => x1.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x1 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAra > ara_ogun && verigetirAra.Count > 0)
            {
                var sonElemanAra = verigetirAra.Last();
                toplamKaloriAra -= sonElemanAra.KALORI_MIKTARI;
                verigetirAra.Remove(sonElemanAra);
            }
            gvAraSabah.DataSource = verigetirAra;
            gvAraSabah.DataBind();

            var toplamKaloriOgle = ent.OGLE_LISTESI.Sum(x2 => x2.KALORI_MIKTARI);
            var verigetirOgle = ent.OGLE_LISTESI.Where(x2 => x2.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x2 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriOgle > ana_ogun && verigetirOgle.Count > 0)
            {
                var sonElemanOgle = verigetirOgle.Last();
                toplamKaloriOgle -= sonElemanOgle.KALORI_MIKTARI;
                verigetirOgle.Remove(sonElemanOgle);
            }
            gvOgle.DataSource = verigetirOgle;
            gvOgle.DataBind();
            var toplamKaloriOgleAra = ent.ARA_OGUNLER.Sum(x3 => x3.KALORI_MIKTARI);
            var verigetirOgleAra = ent.ARA_OGUNLER.Where(x3 => x3.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x3 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriOgleAra > ara_ogun && verigetirOgleAra.Count > 0)
            {
                var sonElemanOgleAra = verigetirOgleAra.Last();
                toplamKaloriOgleAra -= sonElemanOgleAra.KALORI_MIKTARI;
                verigetirOgleAra.Remove(sonElemanOgleAra);
            }
            gvAraOgle.DataSource = verigetirOgleAra;
            gvAraOgle.DataBind();
            var toplamKaloriAksam = ent.AKSAM_LISTESI.Sum(x4 => x4.KALORI_MIKTARI);
            var verigetirAksam = ent.AKSAM_LISTESI.Where(x4 => x4.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x4 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAksam > ana_ogun && verigetirAksam.Count > 0)
            {
                var sonElemanAksam = verigetirAksam.Last();
                toplamKaloriAksam -= sonElemanAksam.KALORI_MIKTARI;
                verigetirAksam.Remove(sonElemanAksam);
            }
            gvAksam.DataSource = verigetirAksam;
            gvAksam.DataBind();
            var toplamKaloriAksamAra = ent.ARA_OGUNLER.Sum(x5 => x5.KALORI_MIKTARI);
            var verigetirAksamAra = ent.ARA_OGUNLER.Where(x5 => x5.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x5 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAksamAra > ara_ogun && verigetirAksamAra.Count > 0)
            {
                var sonElemanAksamAra = verigetirAksamAra.Last();
                toplamKaloriAksamAra -= sonElemanAksamAra.KALORI_MIKTARI;
                verigetirAksamAra.Remove(sonElemanAksamAra);
            }
            gvAksamAra.DataSource = verigetirAksamAra;
            gvAksamAra.DataBind();

                if(bki > 18.5 && bki < 24.9)
                {
                    lbl_almasiGerekenler.Text = "Günlük Almanız Gereken kalori: " + g_cal + ". İdeal Kilonuz: Olduğunuz kilo ideal kilodur. Formunuzu korumanız için aşağıdaki diyeti kullanmanız yeterlidir ";
                }
                else
            lbl_almasiGerekenler.Text= "Günlük Almanız Gereken kalori: " + g_cal + ". İdeal Kilonuz: " + g_kilo + ".";

            lbl_uyari.Text =  "Uyarı: Eğer kilo almanızı ve kilo kaybetmenize sebep olan bir hastalığınız var" +
                    " ise bu diyeti uygulamadan önce doktorunuza danışınız. Aşağıda verilen diyet listesi 2 haftalık olup," +
                    " 2.haftanın sonunda güncel verilerinizi tekrar girerek sağlıklı bir diyet listesi oluşturabilirsiniz ";
            }
        }
    }

    protected void btnPrint_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(GetType(), "Print", "window.print();", true);

    }

    protected void btn_SabahDegis_Click(object sender, EventArgs e)
    {
       
        using (veritabani ent = new veritabani())
        {
            var toplamKalori = ent.SABAH_LISTESI.Sum(x6 => x6.KALORI_MIKTARI);
            var verigetir = ent.SABAH_LISTESI.Where(x6 => x6.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x6 => Guid.NewGuid())
                                             .ToList();

            while (toplamKalori > ana_ogun && verigetir.Count > 0)
            {
                var sonEleman = verigetir.Last();
                toplamKalori -= sonEleman.KALORI_MIKTARI;
                verigetir.Remove(sonEleman);
            }
            gvSabah.DataSource = verigetir;
            gvSabah.DataBind();
        }
    }

    protected void btn_AraSabahDegis_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var toplamKaloriAra = ent.ARA_OGUNLER.Sum(x1 => x1.KALORI_MIKTARI);
            var verigetirAra = ent.ARA_OGUNLER.Where(x1 => x1.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x1 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAra > ara_ogun && verigetirAra.Count > 0)
            {
                var sonElemanAra = verigetirAra.Last();
                toplamKaloriAra -= sonElemanAra.KALORI_MIKTARI;
                verigetirAra.Remove(sonElemanAra);
            }
            gvAraSabah.DataSource = verigetirAra;
            gvAraSabah.DataBind();
        }
    }

    protected void btn_OgleDegis_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var toplamKaloriOgle = ent.OGLE_LISTESI.Sum(x2 => x2.KALORI_MIKTARI);
            var verigetirOgle = ent.OGLE_LISTESI.Where(x2 => x2.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x2 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriOgle > ana_ogun && verigetirOgle.Count > 0)
            {
                var sonElemanOgle = verigetirOgle.Last();
                toplamKaloriOgle -= sonElemanOgle.KALORI_MIKTARI;
                verigetirOgle.Remove(sonElemanOgle);
            }
            gvOgle.DataSource = verigetirOgle;
            gvOgle.DataBind();
        }
    }

    protected void btn_AraOgleDegis_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var toplamKaloriOgleAra = ent.ARA_OGUNLER.Sum(x3 => x3.KALORI_MIKTARI);
            var verigetirOgleAra = ent.ARA_OGUNLER.Where(x3 => x3.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x3 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriOgleAra > ara_ogun && verigetirOgleAra.Count > 0)
            {
                var sonElemanOgleAra = verigetirOgleAra.Last();
                toplamKaloriOgleAra -= sonElemanOgleAra.KALORI_MIKTARI;
                verigetirOgleAra.Remove(sonElemanOgleAra);
            }
            gvAraOgle.DataSource = verigetirOgleAra;
            gvAraOgle.DataBind();
        }
    }

    protected void btn_AksamDegis_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var toplamKaloriAksam = ent.AKSAM_LISTESI.Sum(x4 => x4.KALORI_MIKTARI);
            var verigetirAksam = ent.AKSAM_LISTESI.Where(x4 => x4.KALORI_MIKTARI <= ana_ogun)
                                             .OrderBy(x4 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAksam > ana_ogun && verigetirAksam.Count > 0)
            {
                var sonElemanAksam = verigetirAksam.Last();
                toplamKaloriAksam -= sonElemanAksam.KALORI_MIKTARI;
                verigetirAksam.Remove(sonElemanAksam);
            }
            gvAksam.DataSource = verigetirAksam;
            gvAksam.DataBind();
        }
    }

    public void btn_AksamAraDegis_Click(object sender, EventArgs e)
    {
        using (veritabani ent = new veritabani())
        {
            var toplamKaloriAksamAra = ent.ARA_OGUNLER.Sum(x5 => x5.KALORI_MIKTARI);
            var verigetirAksamAra = ent.ARA_OGUNLER.Where(x5 => x5.KALORI_MIKTARI <= ara_ogun)
                                             .OrderBy(x5 => Guid.NewGuid())
                                             .ToList();
            while (toplamKaloriAksamAra > ara_ogun && verigetirAksamAra.Count > 0)
            {
                var sonElemanAksamAra = verigetirAksamAra.Last();
                toplamKaloriAksamAra -= sonElemanAksamAra.KALORI_MIKTARI;
                verigetirAksamAra.Remove(sonElemanAksamAra);
            }
            gvAksamAra.DataSource = verigetirAksamAra;
            gvAksamAra.DataBind();
        }
    }
}