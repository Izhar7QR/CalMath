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
    public partial class FrmNewtonRaphson : Form
    {
        ArrayList valoresX = new ArrayList();
        ArrayList valoresFx = new ArrayList();
        ArrayList valoresFxd = new ArrayList();
        ArrayList valoresError = new ArrayList();
        public FrmNewtonRaphson()
        {
            InitializeComponent();
        }

        public double valorX(double Fxn, double Fxnd, double Xn)
        {
            double Xi;
            Xi = Math.Round(Xn - (Fxn / Fxnd), 6);
            return Xi;
        }
        public double valorFxn(double Xn)
        {
            double Fxn;
            Fxn = Math.Round(Math.Pow(Xn, 3) + 4 * Math.Pow(Xn, 2) - 10, 6);
            return Fxn;
        }
        public double valorFxnd(double Xn)
        {
            double Fxnd;
            Fxnd = Math.Round(3 * Math.Pow(Xn, 2) + 8 * Xn, 6);
            return Fxnd;
        }
        public double valorErrorAbsoluto(double Xn, double Xi)
        {
            double errorAbsoluto;
            errorAbsoluto = Math.Abs(Math.Round(Xi - Xn, 6));
            return errorAbsoluto;
        }
        public void metodoNewtonRaphson(double Xo)
        {
            valoresX.Insert(0, Xo);
            valoresFx.Insert(0, valorFxn(Xo));
            valoresFxd.Insert(0, valorFxnd(Xo));
            valoresError.Insert(0, "No hay valor");
            int i = 0;
            do
            {
                i++;
                valoresX.Insert(i, valorX(Convert.ToDouble(valoresFx[i - 1]),
                Convert.ToDouble(valoresFxd[i - 1]), Convert.ToDouble(valoresX[i - 1])));
                valoresFx.Insert(i, valorFxn(Convert.ToDouble(valoresX[i])));
                valoresFxd.Insert(i, valorFxnd(Convert.ToDouble(valoresX[i])));
                valoresError.Insert(i, valorErrorAbsoluto(Convert.ToDouble(valoresX[i - 1]),
                Convert.ToDouble(valoresX[i])));
                Console.WriteLine(Convert.ToDouble(valoresError[i]));
            } while (Convert.ToDouble(valoresError[i]) != 0);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorX0.Text == " ")
            {
                MessageBox.Show("Error, debes ingresar un valor en Xo");
            }
            else
            {
                dataGridView1.Rows.Clear();
                metodoNewtonRaphson(Convert.ToDouble(txtValorX0.Text));
                dataGridView1.Rows.Insert(0, 0, valoresX[0], valoresFx[0], valoresFxd[0],
               valoresError[0]);
                for (int i = 1; i < valoresX.Count; i++)
                {
                    dataGridView1.Rows.Insert(i, i, valoresX[i], valoresFx[i], valoresFxd[i],
                   valoresError[i]);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtValorX0.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnVolverMenu1_Click(object sender, EventArgs e)
        {
            FrmInicio Volver = new FrmInicio();
            Volver.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
