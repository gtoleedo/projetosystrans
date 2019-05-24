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
    public partial class CadastroMotorista : Form
    {
        public CadastroMotorista()
        {
            InitializeComponent();
        }

        private void CadastroMotorista_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CadastroVeiculo CadastroVeiculo = new CadastroVeiculo();
            CadastroVeiculo.Show();
            this.Hide();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            AdicionarMotorista AdicionarMotorista = new AdicionarMotorista();
            AdicionarMotorista.Show();
            this.Hide();
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
