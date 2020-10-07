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
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }

        private void mskdtc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_firmalar order by ID asc", bgl.baglanti());
            DataTable dt = new DataTable();
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
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 From frm_kodlar ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


        }
        void temizle()
        {
            txtad.Text = "";
            txtid.Text = "";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
            txtmaıl.Text = "";
            txtsektor.Text = "";
            txtvergi.Text = "";
            textyetkili.Text = "";
            rchadres.Text = "";
            mskdfax.Text = "";
            mskdtc.Text = "";
            mskdtel.Text = "";
            mskdtel2.Text = "";
            mskdtel3.Text = "";
            txtyetkigorev.Text = "";
            txtad.Focus();
            
            
        
        }
        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            sehirlistesi();
            carikodaciklamalar();
            temizle();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // imlecin seçtiği satırı dr ye atıyor
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtyetkigorev.Text = dr["YETKILISTATU"].ToString();
                textyetkili.Text = dr["YETKILIADSOYAD"].ToString();
                mskdtel.Text = dr["TELEFON1"].ToString();
                mskdtel2.Text = dr["TELEFON2"].ToString();
                mskdtel3.Text = dr["TELEFON3"].ToString();
                txtmaıl.Text = dr["MAIL"].ToString();
                txtsektor.Text = dr["SEKTOR"].ToString();
                mskdtc.Text = dr["YETKILITC"].ToString();
                mskdfax.Text = dr["FAX"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtkod1.Text = dr["OZELKOD1"].ToString();
                txtkod2.Text = dr["OZELKOD2"].ToString();
                txtkod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_firmalar (AD, YETKILISTATU, YETKILIADSOYAD, TELEFON1, TELEFON2, TELEFON3, MAIL, SEKTOR, YETKILITC, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2 ,  OZELKOD3)" +
                " values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyetkigorev.Text);
            komut.Parameters.AddWithValue("@p3", textyetkili.Text);
            komut.Parameters.AddWithValue("@p4", mskdtel.Text);
            komut.Parameters.AddWithValue("@p5", mskdtel2.Text); 
            komut.Parameters.AddWithValue("@p6", mskdtel3.Text);
            komut.Parameters.AddWithValue("@p7", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p8", txtsektor.Text);
            komut.Parameters.AddWithValue("@p9", mskdtc.Text);
            komut.Parameters.AddWithValue("@p10", mskdfax.Text);
            komut.Parameters.AddWithValue("@p11", cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergi.Text);
            komut.Parameters.AddWithValue("@p14", rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();

            SqlCommand komut = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR = @p1", bgl.baglanti()); // tıklanan sehrin ilcelerini getir
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1); //tıklanan illin ilçesi.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]); //Seçtiğim ilce ekranda gözüksün
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_firmalar where ID=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistesi();
            MessageBox.Show("Müşteri Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE tbl_firmalar set" +
            " AD = @p1, YETKILISTATU = @p2, YETKILIADSOYAD = @p3, TELEFON1 = @p4 , TELEFON2 = @p5, TELEFON3 = @p6, MAIL = @p7, SEKTOR = @p8," +
            "YETKILITC = @p9, FAX = @p10, IL = @p11 ,ILCE = @p12, VERGIDAIRE = @p13, ADRES = @p14, OZELKOD1 = @p15, OZELKOD2 = @p16, OZELKOD3 = @p17 WHERE ID = @p18 ", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyetkigorev.Text);
            komut.Parameters.AddWithValue("@p3", textyetkili.Text);
            komut.Parameters.AddWithValue("@p4", mskdtel.Text);
            komut.Parameters.AddWithValue("@p5", mskdtel2.Text);
            komut.Parameters.AddWithValue("@p6", mskdtel3.Text);
            komut.Parameters.AddWithValue("@p7", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p8", txtsektor.Text);
            komut.Parameters.AddWithValue("@p9", mskdtc.Text);
            komut.Parameters.AddWithValue("@p10", mskdfax.Text);
            komut.Parameters.AddWithValue("@p11", cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergi.Text);
            komut.Parameters.AddWithValue("@p14", rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.Parameters.AddWithValue("@p18", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            firmalistesi();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
