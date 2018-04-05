using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        Request.ServerStatusRequest serverRequest = new Request.ServerStatusRequest();
        Request.PushRequest push = new Request.PushRequest();

        Users.CreateUser createUserForm;
        Users.EditUser editUserForm;
        Users.DeleteUser deleteUserForm;
        Users.ViewUser viewUserForm;
        Users.BlackList blackListForm;

        Incidences.IncidenceSearcher incidenceSearcherForm;
        Incidences.HistoricIncidence historicIncidenceForm;

        Main main;

        System.Timers.Timer timer = new System.Timers.Timer();

        Form previousForm = null;

        public Form1()
        {
            InitializeComponent();
            screenManagement();
            checkServerStatus(null,null);
            timerReference();
        }
        private void timerReference()
        {
            timer.Interval = 120000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(checkServerStatus);
            timer.Enabled = true;
            timer.Start();
        }

        private void checkServerStatus(object source, System.Timers.ElapsedEventArgs e)
        {
            if (Request.ServerStatusRequest.getStatus() != 0)
            {
                MessageBox.Show("El servidor está apagado", "Servidor");
            }
        }
        
        private void screenManagement()
        {
            Location = new Point(0, 0);
            Screen myScreen = Screen.PrimaryScreen;
            int mywidth = (myScreen.WorkingArea.Width);
            int myheight = (myScreen.WorkingArea.Height-50);
            this.Size = new Size(mywidth, myheight);
            panel1.Size = new Size(mywidth, myheight);
        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            screenManagement();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public void openForm(Form formToOpen)
        {
            if (previousForm != null)
            {
                previousForm.Visible = false;
                previousForm.Close();
            }
            formToOpen.TopLevel = false;
            this.panel1.Controls.Add(formToOpen);
            formToOpen.Show();
            previousForm = formToOpen;
        }
        private void añadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUserForm = new Users.CreateUser();
            openForm(createUserForm);
        }
        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editUserForm = new Users.EditUser();
            openForm(editUserForm);
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUserForm = new Users.DeleteUser();
            openForm(deleteUserForm);
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewUserForm = new Users.ViewUser();
            openForm(viewUserForm);
        }

        private void gestiónDeIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUserForm = new Users.CreateUser();
            openForm(createUserForm);
        }

        private void gestiónDeImágenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackListForm = new Users.BlackList();
            openForm(blackListForm);
        }

        private void listaNegraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackListForm = new Users.BlackList();
            openForm(blackListForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void borrarIncidenciasCompletadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historicIncidenceForm = new Incidences.HistoricIncidence();
            openForm(historicIncidenceForm);
        }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewUserForm = new Users.ViewUser();
            openForm(viewUserForm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main = new Main();
            openForm(main);
        }

        private void buscadorDeIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incidenceSearcherForm = new Incidences.IncidenceSearcher();
            openForm(incidenceSearcherForm);
        }

        private void exportarIncidenciasAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = (DateTime.Now + "_incidenceReport").Replace("/", "_").Replace(":", "_");
            saveDialog.DefaultExt = ".xlsx";
            saveDialog.Filter = "Excel (.xlsx) |*.xlsx";
            saveDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Exportando incidencias a Excel, espere unos segundos...", "Exportando");
                Incidences.ExportIncidencesToExcel.Export(saveDialog.FileName);
                MessageBox.Show("Incidencias exportadas correctamente", "Exportado correctamente");
            }
        }

        private void exportarUsuariosAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = (DateTime.Now + "_usersReport").Replace("/", "_").Replace(":", "_");
            saveDialog.DefaultExt = ".xlsx";
            saveDialog.Filter = "Excel (.xlsx) |*.xlsx";
            saveDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Exportando usuarios a Excel, espere unos segundos...", "Exportando");
                Users.ExportUsersToExcel.Export(saveDialog.FileName);
                MessageBox.Show("Usuarios exportados correctamente", "Exportado correctamente");
            }
        }

        private void eliminarIncidenciasResueltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historicIncidenceForm = new Incidences.HistoricIncidence();
            openForm(historicIncidenceForm);
        }

        private void menúPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main = new Main();
            openForm(main);
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUserForm = new Users.DeleteUser();
            openForm(deleteUserForm);
        }

        private void editarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editUserForm = new Users.EditUser();
            openForm(editUserForm);
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

    }

}

