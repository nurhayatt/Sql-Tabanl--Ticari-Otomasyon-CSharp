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
using DevExpress.ClipboardSource.SpreadsheetML;

namespace ticariotomasyon
{
    public partial class frmbankalar : Form
    {
        public frmbankalar()
        {
            InitializeComponent();
        }

        private void txtsoyad_EditValueChanged(object sender, EventArgs e)
        {

        }

        

       

        private void txtmail_EditValueChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri ",bgl.baglanti());//procedure kullandık fazla kod kalabalığı olmasın diye
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from tbl_firmalar", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;

        }
        void temizle()
        {
            txtid.Text = "";
            txtbankad.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            txtsube.Text = "";
            mskdıban.Text = "";
            mskdhesapno.Text = "";
            txtyetkili.Text = "";
            mskdtel.Text = "";
            mskdtarih.Text = "";
            mskdhesaptür.Text = "";
        }

        private void frmbankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            firmalistesi();
            temizle();

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

        private void btnksydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_bankalar (BANKAADI,IL,ILCE,SUBE,IBAN, HESAPNO,YETKILI,TELEFON,TARIH," +
                "HESAPTURU,FIRMAID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbankad.Text);
            komut.Parameters.AddWithValue("@p2", cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", mskdıban.Text);
            komut.Parameters.AddWithValue("@p6", mskdhesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", mskdtel.Text);
            komut.Parameters.AddWithValue("@p9", mskdtarih.Text);
            komut.Parameters.AddWithValue("@p10", mskdhesaptür.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtbankad.Text = dr["BANKAADI"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                mskdıban.Text = dr["IBAN"].ToString();
                mskdhesapno.Text = dr["HESAPNO"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
                mskdtel.Text = dr["TELEFON"].ToString(); 
                mskdtarih.Text = dr["TARIH"].ToString();
                mskdhesaptür.Text = dr["HESAPTURU"].ToString();
               
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_bankalar where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_bankalar set BANKAADI=@p1,IL=@p2, ILCE=@p3,SUBE=@p4, IBAN=@p5, HESAPNO=@p6, " +
                "YETKILI=@p7, TELEFON=@p8, TARIH=@p9, HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankad.Text);
            komut.Parameters.AddWithValue("@p2", cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", mskdıban.Text);
            komut.Parameters.AddWithValue("@p6", mskdhesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", mskdtel.Text);
            komut.Parameters.AddWithValue("@p9", mskdtarih.Text);
            komut.Parameters.AddWithValue("@p10", mskdhesaptür.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", txtid.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
