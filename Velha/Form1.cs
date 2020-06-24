using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Velha_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == ""){
                if (optX.Checked)
                {
                    ((Button)sender).Text = "X";
                    optO.Checked = true;
                }
                else
                {
                    ((Button)sender).Text = "O";
                    optX.Checked = true;
                }
                if (Verificar("X"))
                {
                    MessageBox.Show("Parabéns!!! O jogador 1 VENCEU");
                }
                if (Verificar("O"))
                {
                    MessageBox.Show("Parabéns!!! O jogador 2 VENCEU");
                }
            }
            

        }
        public bool Verificar(string opt)
        {
            if (btnUm.Text == opt && btnDois.Text == opt && btnTres.Text == opt)
            {
                return true;
            }
            if (btnQuatro.Text == opt && btnCinco.Text == opt && btnSeis.Text == opt)
            {
                return true;
            }
            if (btnSete.Text == opt && btnOito.Text == opt && btnNove.Text == opt)
            {
                return true;
            }
            if (btnUm.Text == opt && btnQuatro.Text == opt && btnSete.Text == opt)
            {
                return true;
            }
            if (btnDois.Text == opt && btnCinco.Text == opt && btnOito.Text == opt)
            {
                return true;
            }
            if (btnTres.Text == opt && btnSeis.Text == opt && btnNove.Text == opt)
            {
                return true;
            }
            if (btnUm.Text == opt && btnCinco.Text == opt && btnNove.Text == opt)
            {
                return true;
            }
            if (btnTres.Text == opt && btnCinco.Text == opt && btnSete.Text == opt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnUm.Text = "";
            btnDois.Text = "";
            btnTres.Text = "";
            btnQuatro.Text = "";
            btnCinco.Text = "";
            btnSeis.Text = "";
            btnSete.Text = "";
            btnOito.Text = "";
            btnNove.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
