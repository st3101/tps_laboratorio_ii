using Biblioteca.Entitdades;
using Biblioteca.Sistema;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfazGrafica
{
    public partial class FrmMenu : Form
    {
        Action unDelegado;

        Task guardarServidor;
        Task cargarServidor;
        Task esperarEnvio;

        FrmAltaEditar frmAltaEditar;

        public FrmMenu()
        {
            InitializeComponent();

            unDelegado = new Action(CargarServidor);  
            
            cargarServidor = new Task(unDelegado);
            guardarServidor = new Task(GudardarServidor);
            esperarEnvio = new Task(IntervaloEntreEnvios);

            Sistema.evento += TaskEnvio;      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTodosDgv();
        }

        private void escritorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaEditar = new FrmAltaEditar("Escritorio", "Alta");

                if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarDataGridEscritorio();
                    Serializador<Escritorio>.GuardarEscritorio();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaEditar = new FrmAltaEditar("Monitor", "Alta");

                if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                {
                    Serializador<Monitor>.GuardarMonoitor();
                    ActualizarDataGridMonitor();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void mouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaEditar = new FrmAltaEditar("Mouse", "Alta");

                if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                {
                    Serializador<Mouse>.GuardarMouse();
                    ActualizarDataGridMouse();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        private void ActualizarTodosDgv()
        {
            ActualizarDataGridEscritorio();
            ActualizarDataGridMonitor();
            ActualizarDataGridMouse();
        }

        private void ActualizarDataGridEscritorio()
        {
            DgvEscrtitorio.DataSource = string.Empty;
            DgvEscrtitorio.DataSource = Sistema.EstanteEscritorio.Inventario;
        }

        private void ActualizarDataGridMonitor()
        {
            DgvMonitor.DataSource = string.Empty;
            DgvMonitor.DataSource = Sistema.EstanteMonitor.Inventario;
        }
        private void ActualizarDataGridMouse()
        {
            DgvMouse.DataSource = string.Empty;
            DgvMouse.DataSource = Sistema.EstanteMouse.Inventario;
        }

        private void escritorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Escritorio auxEscritorio;

            try
            {
                int i = DgvEscrtitorio.CurrentRow.Index;

                if (i >= 0)
                {
                    auxEscritorio = Sistema.BuscarEscritorio(i);

                    frmAltaEditar = new FrmAltaEditar("Escritorio", "Editar", auxEscritorio);

                    if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                    {
                        ActualizarDataGridEscritorio();
                        Serializador<Escritorio>.GuardarEscritorio();
                    }
                }


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }


        }

        private void monitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          Monitor auxMonitor;

            try
            {
                int i = DgvMonitor.CurrentRow.Index;

                if (i >= 0)
                {
                    auxMonitor = Sistema.BuscarMonitor(i);

                    frmAltaEditar = new FrmAltaEditar("Monitor", "Editar", auxMonitor);

                    if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                    {
                        Serializador<Monitor>.GuardarMonoitor();
                        ActualizarDataGridMonitor();
                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void mouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mouse auxMouse;

            try
            {
                int i = DgvMouse.CurrentRow.Index;

                if (i >= 0)
                {
                    auxMouse = Sistema.BuscarMouse(i);

                    if (auxMouse is not null)
                    {
                        frmAltaEditar = new FrmAltaEditar("Mouse", "Editar", auxMouse);

                        if (frmAltaEditar.ShowDialog() == DialogResult.OK)
                        {
                            Serializador<Mouse>.GuardarMouse();
                            ActualizarDataGridMouse();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void escritorioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = DgvEscrtitorio.CurrentRow.Index;

                if (i >= 0)
                {
                    if (Sistema.BorrarEscritorio(i))
                    {
                        ActualizarDataGridEscritorio();
                        Serializador<Escritorio>.GuardarEscritorio();
                    }
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void monitorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = DgvMonitor.CurrentRow.Index;

                if (i >= 0)
                {
                    if (Sistema.BorrarMonitor(i))
                    {
                        Serializador<Monitor>.GuardarMonoitor();
                        ActualizarDataGridMonitor();
                    }
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void mouseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = DgvMouse.CurrentCell.RowIndex;

                if (i >= 0)
                {
                    if (Sistema.BorrarMouse(i))
                    {
                        Serializador<Mouse>.GuardarMouse();
                        ActualizarDataGridMouse();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void escritorioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string metodDeEntrega;
            int i;
            try
            {
                i = DgvEscrtitorio.CurrentRow.Index;

                if (i >= 0)
                {
                    metodDeEntrega = Sistema.MetodoDeEntregaEscritorio(i);

                    Sistema.InvocarEvento();

                    if (metodDeEntrega is null)
                    {
                        throw new ArgumentNullException();
                    }
                    MessageBox.Show(metodDeEntrega);
                    escritorioToolStripMenuItem2_Click(sender, e);
                    Serializador<Escritorio>.GuardarEscritorio();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void monitorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string metodDeEntrega;
            int i;

            try
            {
                i = DgvMonitor.CurrentRow.Index;

                if (i >= 0)
                {
                    metodDeEntrega = Sistema.MetodoDeEntrgaMonitor(i);

                    if (metodDeEntrega is null)
                    {
                        throw new ArgumentNullException();
                    }
                    MessageBox.Show(metodDeEntrega);
                    monitorToolStripMenuItem2_Click(sender, e);
                    Serializador<Monitor>.GuardarMonoitor();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void mouseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string metodoDeEntrga;
            int i;

            try
            {
                i = DgvMouse.CurrentRow.Index;
                if (i >= 0)
                {
                    metodoDeEntrga = Sistema.MetodoDeEntrgaMouse(i);

                    if (metodoDeEntrga is null)
                    {
                        throw new ArgumentNullException();
                    }

                    MessageBox.Show(metodoDeEntrga);
                    mouseToolStripMenuItem2_Click(sender, e);
                    Serializador<Mouse>.GuardarMouse();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Sistema.EstanteEscritorio.Inventario = Serializador<List<Escritorio>>.LeerEscritorio();
                Sistema.EstanteMonitor.Inventario = Serializador<List<Monitor>>.LeerMonitores();
                Sistema.EstanteMouse.Inventario = Serializador<List<Mouse>>.LeerMouse();
                ActualizarTodosDgv();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                guardarServidor.Start();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private async void bajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cargarServidor.Start();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                ActualizarTodosDgv();
            }
        }

        private void GudardarServidor()
        {
            conexionSql.GuardarEscritorio(Sistema.EstanteEscritorio.Inventario);
            conexionSql.GuardarMonitor(Sistema.EstanteMonitor.Inventario);
            conexionSql.GuardarMouse(Sistema.EstanteMouse.Inventario);
        }

        private void CargarServidor()
        {
            Sistema.LeerDatosSql();

            this.DgvEscrtitorio.BeginInvoke((MethodInvoker)delegate ()
            {
                ActualizarTodosDgv();
                cargarServidor = new Task(unDelegado);
            });
        }

        private void BloquearEnvio()
        {         
            this.enviarToolStripMenuItem.Enabled = false;          
        }

        private void HabilitarEnvio()
        {
            this.enviarToolStripMenuItem.Enabled = true;
        }
       
        private void TaskEnvio()
        {
            BloquearEnvio();
            esperarEnvio.Start();
           
        }
        private void IntervaloEntreEnvios()
        {           
            System.Threading.Thread.Sleep(10000);
            Invoke(new Action(() => HabilitarEnvio()));
            esperarEnvio = new Task(IntervaloEntreEnvios);
        }
    }
}
