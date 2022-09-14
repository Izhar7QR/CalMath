using System;
using System.Collections;
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
    public partial class FrmRungeKutta : Form
    {
        ArrayList valoresX = new ArrayList();
        double[] valoresYt;
        double[] valoresYnRK;
        double[] valoresErRK;
        double[] valoresYnEM;
        double[] valoresErEM;
        double[] valoresYn;
        double[] valoresEr;
        public void calcularValoresX(double h, double hastaX, double xo)
        {
            valoresX.Insert(0, xo);
            double aux = xo;
            for (int i = 1; aux + h <= hastaX; i++)
            {
                aux = Math.Round(aux + h, 6);
                valoresX.Insert(i, aux);
            }
        }
        public void calcularValoresYt(ArrayList valoresX)
        {
            valoresYt = new double[valoresX.Count];
        }
        public void calcularValoresYn(ArrayList valoresX, double yo, double h)
        {
            valoresYn = new double[valoresX.Count];
            valoresYn[0] = yo;
            for (int i = 1; i < valoresX.Count; i++)
            {
                valoresYn[i] = Math.Round(valoresYn[i - 1] + h * (Math.Sqrt(valoresYn[i - 1])) / (2 *
               Convert.ToDouble(valoresX[i - 1]) + 1), 6);
            }
        }
        public double[] calcularValoresEr(double[] valoresYn, double[] valoresYt)
        {
            double[] valoresError;
            valoresError = new double[valoresYn.Length];
            for (int i = 0; i < valoresYn.Length; i++)
            {
                valoresError[i] = Math.Abs(Math.Round((valoresYn[i] - valoresYt[i]) / valoresYt[i] * 100,
               6));
            }
            return valoresError;
        }
        public void calcularValoresYnEM(ArrayList valoresX, double yo, double h)
        {
            valoresYnEM = new double[valoresX.Count];
            double u;
            valoresYnEM[0] = yo;
            for (int i = 1; i < valoresX.Count; i++)
            {
                u = Math.Round(valoresYnEM[i - 1] + h * (Math.Sqrt(valoresYnEM[i - 1]) / (2 *
               Convert.ToDouble(valoresX[i - 1]) + 1)), 6);
                valoresYnEM[i] = Math.Round(valoresYnEM[i - 1] + h * 1 / 2 *
               ((Math.Sqrt(valoresYnEM[i - 1]) / (2 * Convert.ToDouble(valoresX[i - 1]) + 1) + (Math.Sqrt(u) / (2
               * Convert.ToDouble(valoresX[i]) + 1)))), 6);
            }
        }
        public void calcularValoresYnRK(ArrayList valoresX, double yo, double h)
        {
            valoresYnRK = new double[valoresX.Count];
            double k1, k2, k3, k4;
            valoresYnRK[0] = yo;
            for (int i = 1; i < valoresX.Count; i++)
            {
                k1 = Math.Round(Math.Sqrt(valoresYnRK[i - 1]) / (2 * Convert.ToDouble(valoresX[i - 1]) +
               1), 6);

                k2 = Math.Round(Math.Sqrt(valoresYnRK[i - 1] + 0.5 * k1 * h) /
               (2 * (Convert.ToDouble(valoresX[i - 1]) + 0.5 * (h)) + 1), 6);

                k3 = Math.Round(Math.Sqrt(valoresYnRK[i - 1] + (0.5 * k2 * h)) /
               (2 * (Convert.ToDouble(valoresX[i - 1]) + 0.5 * (h)) + 1), 6);

                k4 = Math.Round(Math.Sqrt(valoresYnRK[i - 1] + (k3 * h)) /
               (2 * (Convert.ToDouble(valoresX[i - 1]) + h) + 1), 6);

                valoresYnRK[i] = Math.Round(valoresYnRK[i - 1] + 0.1666666666667 * (k1 + (2 * k2) + (2 * k3)
               + k4) * h, 6);
            }
        }
            public FrmRungeKutta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorH.Text == "")
            {
                MessageBox.Show("Error, debes ingresar un valor en H");
            }
            else if (txtValorHastaX.Text == "")
            {
                MessageBox.Show("Error, debes ingresar un valor en hasta X");
            }
            else if (txtValoresX0.Text == "")
            {
                MessageBox.Show("Error, debes ingresar un valor en XO ");
            }
            else if (txtValoresY0.Text == "")
            {
                MessageBox.Show("Error, debes ingresar un valor en YO");
            }
            else
            {
                dataGridView1.Rows.Clear();
                calcularValoresX(Convert.ToDouble(txtValorH.Text),
               Convert.ToDouble(txtValorHastaX.Text), Convert.ToDouble(txtValoresX0.Text));
                calcularValoresYt(valoresX);
                calcularValoresYn(valoresX, Convert.ToDouble(txtValoresY0.Text),
               Convert.ToDouble(txtValorH.Text));
                valoresEr = calcularValoresEr(valoresYn, valoresYt);
                calcularValoresYnEM(valoresX, Convert.ToDouble(txtValoresY0.Text),
               Convert.ToDouble(txtValorH.Text));
                valoresErEM = calcularValoresEr(valoresYnEM, valoresYt);
                calcularValoresYnRK(valoresX, Convert.ToDouble(txtValoresY0.Text),
               Convert.ToDouble(txtValorH.Text));
                valoresErRK = calcularValoresEr(valoresYnRK, valoresYt);
                for (int i = 0; i < valoresX.Count; i++)
                {
                    dataGridView1.Rows.Insert(i, i, valoresX[i], valoresYt[i], valoresYnRK[i],
                   valoresErRK[i], valoresYnEM[i], valoresErEM[i], valoresYn[i], valoresEr[i]);

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtValoresX0.Clear();
            txtValoresY0.Clear();
            txtValorH.Clear();
            txtValorHastaX.Clear();
            dataGridView1.Rows.Clear();

        }

        private void btnVolverMenu1_Click(object sender, EventArgs e)
        {
            FrmInicio Volver = new FrmInicio();
            Volver.Show();
            this.Hide();
        }

        private void txtValoresX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.ToString().Equals("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo acepta numeros");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtValoresY0_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.ToString().Equals("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo acepta numeros");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtValorH_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.ToString().Equals("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo acepta numeros");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtValorHastaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.ToString().Equals("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo acepta numeros");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
