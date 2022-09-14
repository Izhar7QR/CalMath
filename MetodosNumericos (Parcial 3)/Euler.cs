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
    public partial class FrmEuler : Form
    {
        ArrayList valoresX = new ArrayList();
        double[] valoresYt;
        double[] valoresYn;
        double[] valoresEr;

        public object Validar { get; private set; }

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
            for (int i = 0; i < valoresX.Count; i++)
            {
                valoresYt[i] = Math.Round(Math.Pow((Math.Log(2 * Convert.ToDouble(valoresX[i]) +
               1)) / 4 + 2, 2), 6);
            }
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
        public FrmEuler()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorHastaH.Text == "")
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
                calcularValoresX(Convert.ToDouble(txtValorHastaH.Text),
               Convert.ToDouble(txtValorHastaX.Text), Convert.ToDouble(txtValoresX0.Text));
                calcularValoresYt(valoresX);
                calcularValoresYn(valoresX, Convert.ToDouble(txtValoresY0.Text),
               Convert.ToDouble(txtValorHastaH.Text));
                valoresEr = calcularValoresEr(valoresYn, valoresYt);


                for (int i = 0; i < valoresX.Count; i++)
                {
                    dataGridView1.Rows.Insert(i, i, valoresX[i], valoresYt[i], valoresYn[i], valoresEr[i]);

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtValoresX0.Clear();
            txtValoresY0.Clear();
            txtValorHastaX.Clear();
            txtValorHastaH.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnVolverMenu1_Click(object sender, EventArgs e)
        {
            FrmInicio Volver = new FrmInicio();
            Volver.Show();
            this.Hide();
        }

        private void txtValoresX0_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValoresY0_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorHastaX_TextChanged(object sender, EventArgs e)
        {

        }

        private void xtValorH_TextChanged(object sender, EventArgs e)
        {

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

        private void txtValorHastaH_KeyPress(object sender, KeyPressEventArgs e)
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

        private void xtValorH_KeyPress(object sender, KeyPressEventArgs e)
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
