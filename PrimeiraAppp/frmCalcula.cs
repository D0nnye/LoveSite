using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAppp
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            num1 = double.Parse(txtN1.Text);
            num2 = double.Parse(txtN2.Text);
            resp = num1 + num2;
            lblResultadoSoma.Text = resp.ToString();
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            num1 = double.Parse(txtN1.Text);
            num2 = double.Parse(txtN2.Text);
            resp = num1 - num2;
            lblResultadoSub.Text = resp.ToString();
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            num1 = double.Parse(txtN1.Text);
            num2 = double.Parse(txtN2.Text);
            resp = num1 / num2;
            lblResultadoDiv.Text = resp.ToString();
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
            num1 = double.Parse(txtN1.Text);
            num2 = double.Parse(txtN2.Text);
            resp = num1 * num2;
            lblResultadoMult.Text = resp.ToString();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lblResultadoDiv.Text = "";
            lblResultadoSub.Text = "";
            lblResultadoSoma.Text = "";
            lblResultadoMult.Text = "";
        }
    }
}
