using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos__Parcial_3_
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnMetodoEuler_Click(object sender, EventArgs e)
        {
            FrmEuler MetodoEuler = new FrmEuler();
            MetodoEuler.Show();
            this.Hide();
        }

        private void btnMetodoEulerMejorado_Click(object sender, EventArgs e)
        {
            FrmEulerMejorado EulerMejorado = new FrmEulerMejorado();
            EulerMejorado.Show();
            this.Hide();
        }

        private void btnMetodoRungeKutta_Click(object sender, EventArgs e)
        {
            FrmRungeKutta RungeKutta = new FrmRungeKutta();
            RungeKutta.Show();
            this.Hide();
        }

        private void btnMetodoNewtonRaphson_Click(object sender, EventArgs e)
        {
            FrmNewtonRaphson NewtonRaphson = new FrmNewtonRaphson();
            NewtonRaphson.Show();
            this.Hide();
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGauss_Click(object sender, EventArgs e)
        {
            FrmGaussSeider GaussSeider = new FrmGaussSeider();
            GaussSeider.Show();
            this.Hide();
        }
    }
}
