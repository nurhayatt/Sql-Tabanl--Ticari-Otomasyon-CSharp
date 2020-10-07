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
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace ticariotomasyon
{
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }




       sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_admin ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmayarlar_Load(object sender, EventArgs e)
        {
            listele();
            tctkullanıc.Text = "";
            txtsifre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text== "Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_admin values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", tctkullanıc.Text);
                komut.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Kullanıcı Sisteme Yüklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if(button1.Text=="Güncelle")
            {
                SqlCommand komut1= new SqlCommand("update tbl_admin set Sifre=@p2 where  KulaniciAd=@p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", tctkullanıc.Text);
                komut1.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                tctkullanıc.Text = dr["KulaniciAd"].ToString();
                txtsifre.Text = dr["Sifre"].ToString();
            }
        }

        private void tctkullanıc_TextChanged(object sender, EventArgs e)
        {
            if (tctkullanıc.Text != "")
            {
                button1.Text = "Güncelle";
                button1.BackColor = Color.Pink;

            }
            else
            {
                button1.Text = "Kaydet";
                button1.BackColor = Color.LightSteelBlue;
            
            }
        }
    }
}
