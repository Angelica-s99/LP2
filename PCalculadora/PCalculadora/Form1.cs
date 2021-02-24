using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
            //txtNum1.Text = String.Empty; TxtNum1.Text = null; txtNum1.Clear();
            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if((double.TryParse(txtNum1.Text, out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            { 
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);

                Resultado = Num1 + Num2;
                 txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if((double.TryParse(txtNum1.Text,out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);

                Resultado = Num1 - Num2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);

                Resultado = Num1 * Num2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }

            }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);
                if (Num2 == 0 || Num1==0)
                {
                    MessageBox.Show("Logaritmo de base/argumento 0 não existe");
                }
                else
                {
                    Resultado = Math.Log(Num1, Num2);

                    txtResultado.Text = Resultado.ToString("N2");
                }
                
              
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }

        }

        private void btnAngulo_Click(object sender, EventArgs e)
        {
            grpRaio.Enabled = true;
            txtNum2.Enabled = false;
            grpOperacao.Enabled = false;
            txtNum1.Enabled = true;
            txtNum2.Clear();
            txtResultado.Clear();
        }


        private void btnOperacao_Click(object sender, EventArgs e)
        {
            
            grpOperacao.Enabled = true;
            grpRaio.Enabled = false;
            txtNum1.Enabled = true;
            txtNum2.Enabled = true;
            txtResultado.Clear();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);

                Resultado = Math.Cos(Num1);

                txtResultado.Text = Resultado.ToString();

            }
            else
            {
                MessageBox.Show("Digitou valor inválidos");
            }

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text, out Num1))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);

                Resultado = Math.Tan(Num1);

                txtResultado.Text = Resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digitou valor inválido");
            }
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text, out Num1))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);

                Resultado = Math.Sin(Num1);

                txtResultado.Text = Resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digitou valor inválido");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if((double.TryParse(txtNum1.Text, out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);

                if (Num2 == 0)
                {
                    MessageBox.Show("Não tem como dividir por 0");
                }
                else
                {
                    Resultado = Num1 / Num2;
                    txtResultado.Text = Resultado.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if((double.TryParse(txtNum1.Text, out Num1)) && (double.TryParse(txtNum2.Text, out Num2)))
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);

                Resultado = Math.Pow(Num1, Num2);
                
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Digitou valores inválidos");
            }

        }
    }
}
