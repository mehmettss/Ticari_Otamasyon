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


namespace Ticari_Otamasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string mail;

        private void btngonder_Click(object sender, EventArgs e)
        {
         
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp-mail.outlook.com"; // Doğru SMTP sunucu adresi
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("m.kilicer@windowslive.com", "Adnan.3669");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("m.kilicer@windowslive.com", "mehmet kılıcer");
                mail.To.Add(txtmail.Text);
                mail.Subject = txtkonu.Text;
                mail.IsBodyHtml = true;
                mail.Body = txtmesaj.Text;

                try
                {
                    sc.Send(mail);
                    MessageBox.Show("E-posta başarıyla gönderildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("E-posta gönderme hatası: " + ex.Message);
                }
            


        }





        private void frmmail_Load(object sender, EventArgs e)
        {
            txtmail.Text = mail;
        }
    }
}
