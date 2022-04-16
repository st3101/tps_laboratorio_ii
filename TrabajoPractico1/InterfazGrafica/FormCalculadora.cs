using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FormCalculadora : Form
    {

        public FormCalculadora()
        {
            InitializeComponent();
            btnConverirBinario.Enabled = false;
            btnConvertirDecimal.Enabled = false;
        }

        private void Operar_Click(object sender, EventArgs e)
        {
            double resultado;

            resultado = operar(txtNumero1.Text,txtNumero2.Text,cmbOperador.Text);

            lblResultado.Text = resultado.ToString(); 

            if(cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }

            lblHistorial.Text += $"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {resultado}\n";

            btnConverirBinario.Enabled = true;
            btnConvertirDecimal.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConverirBinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);

            if (lblResultado.Text != "Valor invalido")
            {
                btnConverirBinario.Enabled = false;
                btnConvertirDecimal.Enabled = true;
            }
        }
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            btnConverirBinario.Enabled = true;
            btnConvertirDecimal.Enabled = false;
        }

        private void btnCerrar_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private static double operar(string numero1, string numero2, string operador)
        {
            double resultado;
            char OperadorChar; 

            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);

            if(!char.TryParse(operador,out OperadorChar))
            {
                OperadorChar = '+';
            }

            resultado = Calculadora.Operar(n1, n2, OperadorChar);

            return resultado;
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = "";
            lblHistorial.Text = "";
            lblResultado.Text = "";
        }

    }
}
