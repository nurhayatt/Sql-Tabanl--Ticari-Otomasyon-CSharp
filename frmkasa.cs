using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Charts;
namespace ticariotomasyon
{
    public partial class frmkasa : Form
    {
        public frmkasa()
        {
            InitializeComponent();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void musterihareketle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec musterihareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void firmahareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("exec FirmaHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl4.DataSource = dt2;
            
        }
        public string ad;
        private void frmkasa_Load(object sender, EventArgs e)
        {
            lblaktkullsay.Text =ad;
            musterihareketle();
            firmahareket();
            //toplam tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("select sum(TUTAR) from tbl_faturadetay ",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbltoptut.Text = dr1[0].ToString()+ "TL";
            }
            bgl.baglanti().Close() ;

            //son ayın faturaları
            SqlCommand komut2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ) from tbl_giderler order by  ID asc ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblodeme.Text = dr2[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

            //son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("select MAASLAR from tbl_giderler order by  ID asc ", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblpermaas.Text = dr3[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

            //toplam müşteri sayısı
            SqlCommand komut4 = new SqlCommand("select count(*) tbl_musteriler  ", bgl.baglanti());
            SqlDataReader dr4= komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblmussay.Text = dr4[0].ToString() ;
            }
            bgl.baglanti().Close();

            //toplam firma sayısı
            SqlCommand komut5 = new SqlCommand("select count(*) tbl_firmalar  ", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirmasay.Text = dr5[0].ToString() ;
            }
            bgl.baglanti().Close();

            //toplam firma sehir sayısı
            SqlCommand komut6 = new SqlCommand("select count(Distinct (IL)) from  tbl_firmalar  ", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblfirsehirsay.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam müşteri sehir sayısı
            SqlCommand komut7 = new SqlCommand("select count(Distinct (IL)) from tbl_musteriler  ", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblmussehsay.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();



            //toplam personel sayısı
            SqlCommand komut8 = new SqlCommand("select count(*) from tbl_personeller  ", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblpersonelsayı.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();


            //toplam ürün sayısı
            SqlCommand komut9 = new SqlCommand("select sum(ADET) from tbl_urunler  ", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblstoksay.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

         

            ///grafikler tablosunun yanında bulunan gridcontrole verielri vt den çektik.
            SqlCommand komut12 = new SqlCommand("select * from tbl_giderler",bgl.baglanti());
            SqlDataReader dr12 = komut12.ExecuteReader();
            gridControl3.DataSource = dr12;
        }


        private void gridControl3_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //Elektrik
            if(sayac >0  && sayac <=5)
            {
                groupControl11.Text = "Elektrik";
                //1. chart kontrole son 4 ay elektrik faturası listeleme 
                SqlCommand komut10 = new SqlCommand("select top 4 AY, ELEKTRIK FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();


            }
               //Su
            if(sayac >5 && sayac<=10)
            {

                groupControl11.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, SU FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Doğalgaz
            if (sayac > 11 && sayac <= 16)
            {

                groupControl11.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay doğalgaz faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, DOGALGAZ FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //ınternet
            if (sayac >16 && sayac <= 21)
            {

                groupControl11.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay internet faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, INTERNET FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Maaşlar
            if (sayac > 21 && sayac <= 26)
            {

                groupControl11.Text = "Maaşlar";
                chartControl1.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, MAASLAR FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayac > 26 && sayac <= 31)
            {

                groupControl11.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, EKSTRA FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
                if (sayac == 31)
                {
                    sayac = 0;
                }
            }




        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            //Elektrik
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl13.Text = "Elektrik";
                //1. chart kontrole son 4 ay elektrik faturası listeleme 
                SqlCommand komut10 = new SqlCommand("select top 4 AY, ELEKTRIK FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();


            }
            //Su
            if (sayac2 > 5 && sayac2 <= 10)
            {

                groupControl13.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, SU FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Doğalgaz
            if (sayac2 > 11 && sayac2 <= 16)
            {

                groupControl13.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay doğalgaz faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, DOGALGAZ FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //ınternet
            if (sayac2 > 16 && sayac2 <= 21)
            {

                groupControl13.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay internet faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, INTERNET FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Maaşlar
            if (sayac2 > 21 && sayac2<= 26)
            {

                groupControl13.Text = "Maaşlar";
                chartControl2.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, MAASLAR FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //Ekstra
            if (sayac2 > 26 && sayac2 <= 31)
            {

                groupControl13.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                //2. chart kontrole son 4 ay su faturası listeleme 
                SqlCommand komut11 = new SqlCommand("select top 4 AY, EKSTRA FROM tbl_giderler order by ID Desc ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
                if (sayac2 == 31)
                {
                    sayac2 = 0;
                }
            }
            }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
