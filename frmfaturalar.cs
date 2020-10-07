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
    public partial class frmfaturalar : Form
    {
        public frmfaturalar()
        {
            InitializeComponent();
        }

        private void txtmaıl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
        void temizle()
        {
            txtid.Text = "";
            txtseri.Text = "";
            txtsıra.Text = "";
            mskdetarih.Text = "";
            mskdesaat.Text = "";
            txtvergi.Text = "";
            txtalıcı.Text = "";
            txtteslimedeb.Text = "";
            txtteslimalan.Text = "";

        }
        private void frmfaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        { 
           
            if (txtfaturaıd.Text=="" ) //fatura detay boşsa fatura bilgideki bilgiler fatura detaya gelsin
            {
                SqlCommand komut = new SqlCommand("insert into tbl_faturabilgi (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsıra.Text);
                komut.Parameters.AddWithValue("@p3", mskdetarih.Text);
                komut.Parameters.AddWithValue("@p4", mskdesaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergi.Text);
                komut.Parameters.AddWithValue("@p6", txtalıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtteslimedeb.Text);
                komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
             
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            //firma carisi
            if (txtfaturaıd.Text != "" && comboBox1.Text == "Firma") // boş değilse ikinci kaydetmeye yapacak
            {
                double miktar,  tutar,  fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmıktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into tbl_faturadetay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1",texturunad.Text);
                komut2.Parameters.AddWithValue("@p2", txtmıktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                ////////hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into tbl_firmahareketler (URUNID ,ADET, PERSONEL,FIRMA, FIYAT,TOPLAM, FATURAID, TARIH) " +
                    "VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txturunıd.Text);
                komut3.Parameters.AddWithValue("@h2", txtmıktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtpersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtfirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtfiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txttutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtfaturaıd.Text);
                komut3.Parameters.AddWithValue("@h8", mskdetarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                ///stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set ADET=ADET-@s1 where ID=@s2",bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtmıktar.Text);
                komut4.Parameters.AddWithValue("@s2",txturunıd.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
               
                MessageBox.Show("Fatura Ait Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               listele();
            }
          
            ////if (txtfaturaıd.Text == "") //fatura detay boşsa fatura bilgideki bilgiler fatura detaya gelsin
            ////{
            ////    SqlCommand komut = new SqlCommand("insert into tbl_faturabilgi (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            ////    komut.Parameters.AddWithValue("@p1", txtseri.Text);
            ////    komut.Parameters.AddWithValue("@p2", txtsıra.Text);
            ////    komut.Parameters.AddWithValue("@p3", mskdetarih.Text);
            ////    komut.Parameters.AddWithValue("@p4", mskdesaat.Text);
            ////    komut.Parameters.AddWithValue("@p5", txtvergi.Text);
            ////    komut.Parameters.AddWithValue("@p6", txtalıcı.Text);
            ////    komut.Parameters.AddWithValue("@p7", txtteslimedeb.Text);
            ////    komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
            ////    komut.ExecuteNonQuery();
            ////    bgl.baglanti().Close();

            ////    MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////    listele();
            ////}
            //Müşteri carisi
            if (txtfaturaıd.Text != "" && comboBox1.Text == "Müşteri") // boş değilse ikinci kaydetmeye yapacak
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmıktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into tbl_faturadetay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", texturunad.Text);
                komut2.Parameters.AddWithValue("@p2", txtmıktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                ////////hareket tablosuna veri girişi
                SqlCommand komut3 = new SqlCommand("insert into tbl_musterihareketler (URUNID ,ADET, PERSONEL,MUSTERI, FIYAT,TOPLAM, FATURAID, TARIH) " +
                    "VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txturunıd.Text);
                komut3.Parameters.AddWithValue("@h2", txtmıktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtpersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtfirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtfiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txttutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtfaturaıd.Text);
                komut3.Parameters.AddWithValue("@h8", mskdetarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                ///stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtmıktar.Text);
                komut4.Parameters.AddWithValue("@s2", txturunıd.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura Ait Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
      

         private void txtsektor_EditValueChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_faturabilgi", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
   

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // imlecin seçtiği satırı dr ye atıyor
            if (dr != null)
            {
                txtid.Text = dr["FATURABILGIID"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                txtsıra.Text = dr["SIRANO"].ToString();
                mskdetarih.Text = dr["TARIH"].ToString();
                mskdesaat.Text = dr["SAAT"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
                txtalıcı.Text = dr["ALICI"].ToString();
                txtteslimedeb.Text = dr["TESLIMEDEN"].ToString();
                txtteslimalan.Text = dr["TESLIMALAN"].ToString();
            }
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_faturabilgi where FATURABILGIID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();

        }

        private void btntemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturabilgi set SERI=@p1, SIRANO=@p2, TARIH=@p3, SAAT=@p4,VERGIDAIRE=@p5, ALICI=@p6, TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtseri.Text);
            komut.Parameters.AddWithValue("@p2", txtsıra.Text);
            komut.Parameters.AddWithValue("@p3", mskdetarih.Text);
            komut.Parameters.AddWithValue("@p4", mskdesaat.Text);
            komut.Parameters.AddWithValue("@p5", txtvergi.Text);
            komut.Parameters.AddWithValue("@p6", txtalıcı.Text);
            komut.Parameters.AddWithValue("@p7", txtteslimedeb.Text);
            komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaurundetay fr = new frmfaturaurundetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
                fr.Show();
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select URUNAD, SATISFIYAT FROM tbl_urunler where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txturunıd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                texturunad.Text = dr[0].ToString();
                txtfiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
