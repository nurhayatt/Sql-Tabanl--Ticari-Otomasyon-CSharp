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
using System.CodeDom.Compiler;

namespace ticariotomasyon
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi(); // veritabanı  baglanmak için yeni bir bağlantı oluşturdum
        void listele() // veritabanındaki bilgileri listelemek için komutları yazdık
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_musteriler order by ID asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select  SEHIR from  tbl_iller ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); // veriler okunuyor 
            while (dr.Read()) // okuma işlemi sürdülçe
            {
                cmbil.Properties.Items.Add(dr[0]); //iller combaxında iller aktarıldı orada gözüküyor
            }
            bgl.baglanti().Close();        
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void temizle()
        {

            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            mskdtel.Text = "";
            mskdtell.Text = "";
            mskdtc.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            rchadres.Text = "";
            txtvergi.Text = "";
            txtmail.Text = "";
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            listele(); //veritababındaki bilgileri form ekranına geldi 
            sehirlistesi(); // combobaxa iller yüklendi
            temizle();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();

            SqlCommand komut = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR = @p1", bgl.baglanti()); // tıklanan sehrin ilcelerini getir
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1); //tıklanan illin ilçesi.
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]); //Seçtiğim ilce ekranda gözüksün
            }
            bgl.baglanti().Close();
        }

        private void btnksydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT into tbl_musteriler (AD, SOYAD, TELEFON, TELELFON2,TC, IL, ILCE,ADRES, VERGIDAIRE, MAIL ) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdtel.Text);
            komut.Parameters.AddWithValue("@p4", mskdtell.Text);
            komut.Parameters.AddWithValue("@p5", mskdtc.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", txtvergi.Text);
            komut.Parameters.AddWithValue("@p10", txtmail.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Yüklendi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // imlecin seçtiği satırı dr ye atıyor
            if (dr!=null)
            {
                txtid.Text = dr["ID"].ToString(); 
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                mskdtel.Text = dr["TELEFON"].ToString();
                mskdtell.Text = dr["TELELFON2"].ToString();
                mskdtc.Text = dr["TC"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_musteriler where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery(); // insert update delete komutunda kullanılıyor. executereader select komutunda kullanılıyor
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_musteriler set AD=@p1, SOYAD=@p2,TELEFON=@p3,TELELFON2=@p4,TC=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,VERGIDAIRE=@p9 ,MAIL=@p10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdtel.Text);
            komut.Parameters.AddWithValue("@p4", mskdtell.Text);
            komut.Parameters.AddWithValue("@p5", mskdtc.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", txtvergi.Text);
            komut.Parameters.AddWithValue("@p10", txtmail.Text);
            komut.Parameters.AddWithValue("@p11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sistemde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
