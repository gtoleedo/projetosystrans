﻿using System;
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
    public partial class AdicionarMotorista : Form
    {
        public AdicionarMotorista()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdicionarVeiculo AdicionarVeiculo = new AdicionarVeiculo();
            AdicionarVeiculo.Show();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroMotorista CadastroMotorista = new CadastroMotorista();
            CadastroMotorista.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
