using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ticariotomasyon
{
    public partial class frmAnamodul : DevExpress.XtraEditors.XtraForm
    {
        public frmAnamodul()
        {
            InitializeComponent();
        }
        frmurunler fr;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed) //birden fazzla sayfa açılamasın diye..
            {
                fr = new frmurunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        public string kulllanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr14 == null )
            {
                fr14 = new frmanasayfa();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
        frmMusteriler fr2;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new frmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            
            }
        }
        frmfirmalar fr3;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new frmfirmalar();
                fr3.MdiParent = this;
                fr3.Show();

            }
        }
        frmpersoneller fr4;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4==null || fr4.IsDisposed)
            {
                fr4 = new frmpersoneller();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmrehber fr5;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new frmrehber();
                fr5.MdiParent = this;
                fr5.Show();
            
            }
        }
        frmgiderler fr6;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null)
            {
                fr6 = new frmgiderler();
                fr6.MdiParent = this;
                fr6.Show();

            }
        }
        frmbankalar fr7;
        private void BtnBanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new frmbankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        frmfaturalar fr8;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new frmfaturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        frmnotlar fr9;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new frmnotlar();
                fr9.MdiParent = this;
                fr9.Show();
            }

        }
        frmhareketler fr10;
        private void BTNHAREKTLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new frmhareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        frmstoklar fr11;
        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new frmstoklar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        frmayarlar fr12;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new frmayarlar();
                fr12.Show();
            }
        }
        frmkasa fr13;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new frmkasa();
                fr13.ad = kulllanici;
                fr13.MdiParent = this;
                fr13.Show();
            }
        }
        frmanasayfa fr14;
        private void BtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new frmanasayfa();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
    }
}
