using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ticariotomasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmmail_Load(object sender, EventArgs e)
        {
            txtmailadres.Text = mail;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("nurhayatberber349@gmail.com","27011998n");//hangi e postadan mail atacağımız kısım
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtmailadres.Text);
            mesajim.From = new MailAddress("nurhayatberber349@gmail.com");
            mesajim.Subject = txtkonu.Text;
            mesajim.Body = txtmesaj.Text;
            istemci.Send(mesajim);
        }
    }
}
