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
    public partial class FrmGaussSeider : Form
    {
        public FrmGaussSeider()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresarInicio1_Click(object sender, EventArgs e)
        {
            FrmInicio VolverInicioFin = new FrmInicio();
            VolverInicioFin.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarNum(txtM1.Text)|| ValidarNum(txtM2.Text)|| ValidarNum(txtM3.Text)|| ValidarNum(txtR1.Text)|| ValidarNum(txtM4.Text)|| ValidarNum(txtM5.Text)|| ValidarNum(txtM6.Text)|| ValidarNum(txtR2.Text)|| ValidarNum(txtM7.Text)|| ValidarNum(txtM8.Text)|| ValidarNum(txtM9.Text)|| ValidarNum(txtR3.Text)|| ValidarNum(txtX1.Text)|| ValidarNum(txtY2.Text)|| ValidarNum(txtZ3.Text))
            {
                MessageBox.Show("Solo acepta numeros");
            }
            else
            {
                double A1 = Convert.ToDouble(txtM1.Text);
                double B1 = Convert.ToDouble(txtM2.Text);
                double C1 = Convert.ToDouble(txtM3.Text);
                double R1 = Convert.ToDouble(txtR1.Text);
                double A2 = Convert.ToDouble(txtM4.Text);
                double B2 = Convert.ToDouble(txtM5.Text);
                double C2 = Convert.ToDouble(txtM6.Text);
                double R2 = Convert.ToDouble(txtR2.Text);
                double A3 = Convert.ToDouble(txtM7.Text);
                double B3 = Convert.ToDouble(txtM8.Text);
                double C3 = Convert.ToDouble(txtM9.Text);
                double R3 = Convert.ToDouble(txtR3.Text);
                double[,] data = {  { A1, B1, C1, R1 },
                                { A2, B2, C2, R2 },
                                { A3, B3, C3, R3 } };

                double X0 = Convert.ToDouble(txtX1.Text);
                double Y0 = Convert.ToDouble(txtY2.Text);
                double Z0 = Convert.ToDouble(txtZ3.Text);

                int posX = 0;
                int posY = 0;
                int posZ = 0;

                double valor = data[0, 0];
                for (int i = 0; i < 2; i++)
                {
                    if (valor < data[i + 1, 0])
                    {
                        valor = data[i + 1, 0];
                        posX = i + 1;
                    }
                }

                valor = data[0, 1];
                for (int i = 0; i < 2; i++)
                {
                    if (valor < data[i + 1, 1] && i + 1 != posX)
                    {
                        valor = data[i + 1, 1];
                        posY = i + 1;
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    if (posZ == posX || posZ == posY)
                    {
                        posZ++;
                    }
                }


                double[] rowX = { data[posX, 0], data[posX, 1], data[posX, 2], data[posX, 3] };
                double[] rowY = { data[posY, 0], data[posY, 1], data[posY, 2], data[posY, 3] };
                double[] rowZ = { data[posZ, 0], data[posZ, 1], data[posZ, 2], data[posZ, 3] };

                for (int i = 0; i < 4; i++)
                {
                    data[0, i] = rowX[i];
                    data[1, i] = rowY[i];
                    data[2, i] = rowZ[i];
                }

                string funcion = "";

                for (int i = 0; i < 3; i++)
                {
                    funcion += data[i, 0] + "x ";
                    if (data[i, 1] > 0) funcion += "+" + data[i, 1] + "y ";
                    else funcion += data[i, 1] + "y "; 
                    if(data[i, 2] > 0) funcion += "+" + data[i, 2] + "z = " + data[i, 3] + "\n";
                    else funcion += data[i, 2] + "z = " + data[i, 3] + "\n";
                }

                lblMatriz.Text = funcion;


                List<double[]> datos = new List<double[]>();
                double[] actual = { X0, Y0, Z0, 0, 0, 0 };
                datos.Add(new double[] { X0, Y0, Z0, 0, 0, 0 });
                do
                {
                    double[] prev = new double[] { actual[0], actual[1], actual[2], actual[3], actual[4], actual[5] };
                    double a, b, c, r;
                    for (int n = 0; n < 3; n++)
                    {
                        a = data[n, 0];
                        b = data[n, 1];
                        c = data[n, 2];
                        r = data[n, 3];
                        switch (n)
                        {
                            case 0:
                                actual[0] = Truncar((r - b * prev[1] - c * prev[2]) / a);
                                break;
                            case 1:
                                actual[1] = Truncar((r - a * actual[0] - c * prev[2]) / b);
                                break;
                            case 2:
                                actual[2] = Truncar((r - a * actual[0] - b * actual[1]) / c);
                                break;
                        }
                    }
                    actual[3] = Truncar(Math.Abs((actual[0] - prev[0]) / actual[0] * 100));
                    actual[4] = Truncar(Math.Abs((actual[1] - prev[1]) / actual[1] * 100));
                    actual[5] = Truncar(Math.Abs((actual[2] - prev[2]) / actual[2] * 100));
                    datos.Add(new double[] { actual[0], actual[1], actual[2], actual[3], actual[4], actual[5] });
                }
                while (actual[3] >= 1 || actual[4] >= 1 || actual[5] >= 1);

                

                int j = 0;
                foreach (double[] dato in datos)
                {
                    dataGauss.Rows.Add(j, dato[0], dato[1], dato[2], dato[3] + "%", dato[4] + "%", dato[5] + "%");
                    j++;
                }
                
            }
        }
        public double Truncar(double valor)
        {
            return Math.Round(Math.Truncate(valor * 10000000) / 10000000, 6, MidpointRounding.AwayFromZero);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGauss.Rows.Clear();
        }
        private bool ValidarNum (String texto)
        {
            try
            {
                double.Parse(texto);

            }
            catch (Exception e)
            {
                return true;
            }
            return false;
        }
    }
}
