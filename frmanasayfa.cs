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
using System.Xml;

namespace ticariotomasyon
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void stoklar()
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter ("select URUNAD , sum(ADET) as 'Adet' from tbl_urunler group by URUNAD having sum(adet) <= 36 order by sum(ADET) ", 
                bgl.baglanti());
            da.Fill(dt);
            gridControlazalan.DataSource = dt;

        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select TOP 8 TARIH, SAAT,BASLIK from tbl_notlar  ORDER BY ID DESC ",
                bgl.baglanti());
            da.Fill(dt);
            gridControlajanda.DataSource = dt;

        }
        void firmahareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec FirmaHareket2", bgl.baglanti());
            da.Fill(dt);
            gridControlhareket.DataSource= dt;

        }
        void firmabilgisi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD, TELEFON1 from tbl_firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControlencokfirma.DataSource = dt;

        }
        void haberler()
        {
            XmlTextReader xmloku = new  XmlTextReader ("https://www.hurriyet.com.tr/rss/anasayfa");
            while(xmloku.Read())
            {
                if(xmloku.Name=="title")
                {

                    listBox1.Items.Add(xmloku.ReadString());
                }

            }


        
        }

    
        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            firmahareketleri();
            firmabilgisi();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            haberler();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        
    }
}
