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
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi(); //yeni veritabanı listesi oluşturduk
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_urunler order by ID asc", bgl.baglanti()); //ürünler tablosunu veritabanından çektik.
            da.Fill(dt);
            gridControl1.DataSource = dt;
                
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            mskyil.Text = "";
            nudadet.Text= "";
            txtalis.Text = "";
            txtsatis.Text = "";
            rchdetay.Text = "";

        }
        private void frmurunler_Load(object sender, EventArgs e)
        {
            listele(); // veritabanındaki ürüünler tablosunu listeledik
            temizle();
        }

        private void btnksydet_Click(object sender, EventArgs e)
        {
            //verileri kaydetme  veritabanı open açık o yüzden bir daha açmamıza gerek yok
            SqlCommand komut = new SqlCommand("insert into tbl_urunler (URUNAD, MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text) ;
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", rchdetay.Text);
            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır.
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi ", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele(); 

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From tbl_urunler where ID=@p1 ",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txtad.Text = dr["URUNAD"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            txtmodel.Text = dr["MODEL"].ToString();
            mskyil.Text = dr["YIL"].ToString();
            nudadet.Value = decimal.Parse(dr["ADET"].ToString());
            txtalis.Text = dr["ALISFIYAT"].ToString();
            txtsatis.Text = dr["SATISFIYAT"].ToString();
            rchdetay.Text = dr["DETAY"].ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_urunler set URUNAD=@p1, MARKA=@p2, MODEL=@p3,YIL=@p4,ADET=@p5, ALISFIYAT=@p6, SATISFIYAT=@p7, DETAY=@p8 where ID=@p9 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", rchdetay.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);

            komut.ExecuteNonQuery(); // dml komutlarını çalıştırır.
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sistemden silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
