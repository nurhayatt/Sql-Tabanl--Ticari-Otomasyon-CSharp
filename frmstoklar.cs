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

namespace ticariotomasyon
{
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmstoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul",4);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Adana", 12); 
            //chartControl1.Series["Series 1"].Points.AddPoint("Hatay", 7);
            //veritababındaki ürün miktarlarını isimleriyle beraber getirme
            SqlDataAdapter da = new SqlDataAdapter("select  URUNAD, sum(ADET) AS 'MİKTAR' from  tbl_urunler group by  URUNAD", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            //Charta Stok Miktarı listeleme
            SqlCommand komut = new SqlCommand("select  URUNAD, sum(ADET) AS 'MİKTAR' from  tbl_urunler group by  URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();
            //CHARTA FİRMA ŞEHİR SAYISI ÇEKME
            SqlCommand komut2 = new SqlCommand("select IL,COUNT(*) from tbl_firmalar group by IL", bgl.baglanti()); ;
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmstokdetay fr = new frmstokdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
                fr.Show();
            }
        }
    }
}
