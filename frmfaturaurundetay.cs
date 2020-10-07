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
    public partial class frmfaturaurundetay : Form
    {
        public frmfaturaurundetay()
        {
            InitializeComponent();
        }
        public string id;
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_faturadetay where FATURAID='"+ id +"'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        
        }
        private void frmfaturaurundetay_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaurunduzenleme fr = new frmfaturaurunduzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.urunid = dr["FATURABILGIID"].ToString() ;

            }
            fr.Show();
        }
    }
}
