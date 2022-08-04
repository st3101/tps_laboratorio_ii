using Biblioteca.Entitdades;
using Biblioteca.Sistema;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmAltaEditar : Form
    {
        /// <summary>
        /// Atrobito auxiliar de un escritorio
        /// </summary>
        Escritorio auxEscritorio;

        /// <summary>
        /// Atributo auxiliar de un mouse
        /// </summary>
        Mouse auxMouse;

        /// <summary>
        /// Atributo auxialiar de un monitor
        /// </summary>
        Monitor auxMonitor;

        /// <summary>
        /// Atributo de la clase que modifica el formulario
        /// </summary>
        string objeto;

        /// <summary>
        ///Atributo de la clase que modifica el formulario
        /// </summary>
        string accion;

        /// <summary>
        /// Propiedad que asigna objeto
        /// </summary>
        public string Objeto { get => objeto; set => objeto = value; }

        /// <summary>
        /// Propiedad que asigna Accion
        /// </summary>
        public string Accion { get => accion; set => accion = value; }

        /// <summary>
        /// Propiedad que asigna auxEscritorio
        /// </summary>
        public Escritorio AuxEscritorio { get => auxEscritorio; set => auxEscritorio = value; }
        /// <summary>
        /// Propiedad que asiga AuxMouse
        /// </summary>
        public Mouse AuxMouse { get => auxMouse; set => auxMouse = value; }
        /// <summary>
        /// Propiedad que asigna AuxMonitor
        /// </summary>
        public Monitor AuxMonitor { get => auxMonitor; set => auxMonitor = value; }

        /// <summary>
        /// Inicializa componente graficos y atributos de la clase
        /// </summary>
        /// <param name="nombreObjeto">Nombre de objeto a actuar</param>
        /// <param name="tipoAccion">Tipo de accion a realizar</param>
        public FrmAltaEditar(string nombreObjeto, string tipoAccion)
        {
            InitializeComponent();
            Objeto = nombreObjeto;
            Accion = tipoAccion;
        }
        /// <summary>
        /// Contructor que asigna escritorio y llama al contructor base
        /// </summary>
        /// <param name="nombreObjeto"></param>
        /// <param name="tipoAccion"></param>
        /// <param name="escritorio"></param>
        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Escritorio escritorio) : this(nombreObjeto, tipoAccion)
        {
            AuxEscritorio = escritorio;
        }

        /// <summary>
        /// Contructor que asigna Monitor y llama al contructor base
        /// </summary>
        /// <param name="nombreObjeto"></param>
        /// <param name="tipoAccion"></param>
        /// <param name="monitor"></param>
        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Monitor monitor) : this(nombreObjeto, tipoAccion)
        {
            AuxMonitor = monitor;
        }
        /// <summary>
        /// Contructor que asigna mouse y llama al contructor base
        /// </summary>
        /// <param name="nombreObjeto"></param>
        /// <param name="tipoAccion"></param>
        /// <param name="mouse"></param>
        public FrmAltaEditar(string nombreObjeto, string tipoAccion, Mouse mouse) : this(nombreObjeto, tipoAccion)
        {
            AuxMouse = mouse;
        }

        /// <summary>
        /// Llama editar label dependiendo la accion y objeto
        /// </summary>
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

        /// <summary>
        /// Cambia los labes y el titulo de formulario
        /// </summary>
        /// <param name="texto1">Accion a relaizar</param>
        /// <param name="texto2">Objeto</param>
        private void EditarLabel(string texto1, string texto2)
        {
            this.Text = $"{Accion} {Objeto}";
            LblAltaEditar.Text = accion;
            label1.Text = texto1;
            label2.Text = texto2;
        }
        /// <summary>
        /// LLama al formulario correspondiente segun la accion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga los textBox con los atributos del escritorio
        /// </summary>
        void CargarTexboxEscritorio()
        {
            textBox1.Text = AuxEscritorio.Modelo;
            textBox2.Text = AuxEscritorio.MetrosCuadrado.ToString();
        }

        /// <summary>
        /// Carga los textBox con los atributos Mouse
        /// </summary>
        void CargarTexboxMouse()
        {
            textBox1.Text = auxMouse.Dpi.ToString();
            textBox2.Text = auxMouse.Peso.ToString();
        }

        /// <summary>
        /// Carga los textBox con los atributos monitor
        /// </summary>
        void CargarTexboxMonitor()
        {
            textBox1.Text = AuxMonitor.Pulgadas.ToString();
            textBox2.Text = AuxMonitor.Hz.ToString();
        }

        /// <summary>
        /// Llama al metodo modificar form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaEditar_Load(object sender, EventArgs e)
        {
            ModificarForm();
        }
    }
}
