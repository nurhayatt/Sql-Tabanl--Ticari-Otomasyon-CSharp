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
    public partial class frmrehber : Form
    {
        public frmrehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmrehber_Load(object sender, EventArgs e)
        {
            // Müşteri bilgileri geldi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD, SOYAD, TELEFON, TELELFON2, MAIL from tbl_musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            // Firma bilgileri geldi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select AD, YETKILIADSOYAD, TELEFON1, TELEFON2, TELEFON3, MAIL ,FAX from tbl_firmalar", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmmail frm=new frmmail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                frm.mail = dr["MAIL"].ToString();

            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmmail frm = new frmmail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();

            }
            frm.Show();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
