using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranSystem
{
    public partial class FormSuporte : Form
    {
        public FormSuporte()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add("sup.transp.uscs@gmail.com");
            mmsg.Subject = txtAssunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = txtMessage.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("sup.transp.uscs@gmail.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("sup.transp.uscs@gmail.com", "0508rena");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com"; // smtp do google


            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao enviar E-mail");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
