using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Incidences
{
    public partial class HistoricIncidence : Form
    {
        Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
        public HistoricIncidence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteIncidence();
        }
        private void deleteIncidence()
        {
            List<JSON.Incidence> incidenceList = incidenceRequest.getAllIncidencesData();
            bool delete = false;
            DateTime sinceDay = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);
            foreach (JSON.Incidence inc in incidenceList)
            {
                if (inc.resolutionDate != null)
                {
                        DateTime clearDate = new DateTime(int.Parse(inc.date.Substring(6, 4)), int.Parse(inc.date.Substring(0, 2)), int.Parse(inc.date.Substring(3, 2)));
                        if (clearDate.Date <= monthCalendar1.SelectionStart.Date)
                        {
                            incidenceRequest.deleteIncidence(inc._id, inc.imageName);
                            delete = true;
                        }
                }
            }
            if (delete)
            {
                MessageBox.Show("Historico borrado correctamente", "Borrado con éxito");
            }
            else
            {
                MessageBox.Show("No hay ninguna incidencia resuelta en ese periodo de tiempo", "Aviso");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
