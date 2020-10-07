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
    public partial class frmfaturaurunduzenleme : Form
    {
        public frmfaturaurunduzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmfaturaurunduzenleme_Load(object sender, EventArgs e)
        {
            txturunıd.Text = urunid;
            SqlCommand komut = new SqlCommand("select * from tbl_faturadetay where FATURABILGIID=@p1", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1",urunid);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read()) //okuma işlemi gerçekleştiği sürece
            {
                txtfiyat.Text = dr[3].ToString();
                txtmıktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                texturunad.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturadetay SET URUNAD=@p1 , MIKTAR=@p2, FIYAT=@p3, TUTAR=@p4 where FATURABILGIID=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texturunad.Text);
            komut.Parameters.AddWithValue("@p2", txtmıktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p5", txturunıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değşiklikler Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturadetay where  FATURABILGIID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
