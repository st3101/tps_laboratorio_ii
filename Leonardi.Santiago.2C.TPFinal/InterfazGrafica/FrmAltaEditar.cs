using Biblioteca.Entitdades;
using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmAltaEditar : Form
    {
        Escritorio auxEscritorio;
        Mouse auxMouse;
        Monitor auxMonitor;

        string objeto;
        string accion;

        public string Objeto { get => objeto; set => objeto = value; }
        public string Accion { get => accion; set => accion = value; }
        public Escritorio AuxEscritorio { get => auxEscritorio; set => auxEscritorio = value; }
        public Mouse AuxMouse { get => auxMouse; set => auxMouse = value; }
        public Monitor AuxMonitor { get => auxMonitor; set => auxMonitor = value; }

        public FrmAltaEditar(string nombreObjeto, string tipoAccion)
        {
            InitializeComponent();
            Objeto = nombreObjeto;
            Accion = tipoAccion;

        }

        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Escritorio escritorio) : this(nombreObjeto, tipoAccion)
        {
            AuxEscritorio = escritorio;
        }
        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Monitor monitor) : this(nombreObjeto, tipoAccion)
        {
            AuxMonitor = monitor;
        }
        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Mouse mouse) : this(nombreObjeto, tipoAccion)
        {
            AuxMouse = mouse;
        }

        private void ModificarForm()
        {
            if (accion == "Alta")
            {
                switch (Objeto)
                {
                    case "Escritorio":
                        EditarLabel("Modelo", "Metros Cuadrados");
                        break;
                    case "Monitor":
                        EditarLabel("Pulgadas", "Hz");
                        break;
                    case "Mouse":
                        EditarLabel("Dpi", "Peso");
                        break;
                    default:
                        new Exception("No existe ese objeto");
                        break;
                }
            }
            else if (accion == "Editar")
            {
                switch (Objeto)
                {
                    case "Escritorio":
                        EditarLabel("Modelo", "Metros Cuadrados");
                        CargarTexboxEscritorio();
                        break;
                    case "Monitor":
                        EditarLabel("Pulgadas", "Hz");
                        CargarTexboxMonitor();
                        break;
                    case "Mouse":
                        EditarLabel("Dpi", "Peso");
                        CargarTexboxMouse();
                        break;
                    default:
                        new Exception("No existe ese objeto");
                        break;
                }
            }

        }

        private void EditarLabel(string texto1, string texto2)
        {
            this.Text = $"{Accion} {Objeto}";
            LblAltaEditar.Text = accion;
            label1.Text = texto1;
            label2.Text = texto2;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                switch (objeto)
                {
                    case "Escritorio":
                        Sistema.AgregarEscritorio(textBox1.Text, textBox2.Text);
                        break;
                    case "Monitor":
                        Sistema.AgregarMonitor(textBox1.Text, textBox2.Text);
                        break;
                    case "Mouse":
                        Sistema.AgregarMouse(textBox1.Text, textBox2.Text);
                        break;
                    default:
                        new Exception("Objeto no encontrado");
                        break;
                }

            }
            else if (Accion == "Editar")
            {
                switch (objeto)
                {
                    case "Escritorio":
                        Sistema.PisarInfoEscritorio(textBox1.Text, textBox2.Text, auxEscritorio);
                        break;
                    case "Monitor":
                        Sistema.PisarInfoMonitor(textBox1.Text, textBox2.Text, auxMonitor);
                        break;
                    case "Mouse":
                        Sistema.PisarInfoMouse(textBox1.Text, textBox2.Text, auxMouse);
                        break;
                    default:
                        new Exception("Objeto no encontrado");
                        break;
                }
            }

            DialogResult = DialogResult.OK;
        }

        void CargarTexboxEscritorio()
        {
            textBox1.Text = AuxEscritorio.Modelo;
            textBox2.Text = AuxEscritorio.MetrosCuadrado.ToString();
        }
        void CargarTexboxMouse()
        {
            textBox1.Text = auxMouse.Dpi.ToString();
            textBox2.Text = auxMouse.Peso.ToString();
        }
        void CargarTexboxMonitor()
        {
            textBox1.Text = AuxMonitor.Pulgadas.ToString();
            textBox2.Text = AuxMonitor.Hz.ToString();
        }

        private void FrmAltaEditar_Load(object sender, EventArgs e)
        {
            ModificarForm();
        }


    }
}
