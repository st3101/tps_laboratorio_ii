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

        /// <summary>
        /// Contrucor de la clase formCalculadora
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            btnConverirBinario.Enabled = false;
            btnConvertirDecimal.Enabled = false;
        }
        /// <summary>
        /// Llama al metodo operar al apretar el boton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Llama al metodo limpiar al apretar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// LLama al metodo limpiar cuando se cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// LLama al medotod close al apretar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama a la funcion convertir decimal a binario de la clase Operando al apretar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConverirBinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);

            if (lblResultado.Text != "Valor invalido")
            {
                btnConverirBinario.Enabled = false;
                btnConvertirDecimal.Enabled = true;
            }
        }
        /// <summary>
        /// LLama a la funcion convetir binario a decimal de la clase Operando al apretar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            btnConverirBinario.Enabled = true;
            btnConvertirDecimal.Enabled = false;
        }

        /// <summary>
        /// Pregunta si realmente quieres salir cuando se esta cerrando el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        /// <summary>
        /// Realiza y crea los elemento para realizar los calculo segundo los parametros ingresados
        /// </summary>
        /// <param name="numero1">numero al operar del tipo string</param>
        /// <param name="numero2">numero al operar del tiopp string</param>
        /// <param name="operador">operador para realizar la operacion</param>
        /// <returns>Resultado de la operacion del tipo double</returns>
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
        /// <summary>
        /// Limpia la pantalla de los valoren anteriormente cargados 
        /// </summary>
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
