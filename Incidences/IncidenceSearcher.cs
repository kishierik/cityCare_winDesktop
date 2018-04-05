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
    public partial class IncidenceSearcher : Form
    {
        GridViewObject.GridObject gridObject;
        private bool firstTimeYear = false;
        private bool firstTimeMonth = false;
        private bool firstTimeDay = false;
        public IncidenceSearcher()
        {
            InitializeComponent();
            gridObject = new GridViewObject.GridObject(incidencesGridView);
            gridObject.loadIncidencesOnGrid();
        }

        private bool isEmpty(string value)
        {
            if (value.Length <= 0 || value == null || value.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        
        private void GestorIncidenciasBuscador_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridObject.loadIncidencesOnGridWithSearch(incidenceNameTxt.Text, incidenceLocationTxt.Text, incidenceEmailTxt.Text, incidenceTypeCmb.SelectedIndex, incidenceStatusCmb.SelectedIndex, day.Text+"/"+month.Text+"/"+year.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridObject.loadIncidencesOnGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            incidenceNameTxt.Text = "";
            incidenceEmailTxt.Text = "";
            incidenceLocationTxt.Text = "";
            incidenceTypeCmb.SelectedIndex = -1;
            incidenceStatusCmb.SelectedIndex = -1;
            day.Text = "DD";
            month.Text = "MM";
            year.Text = "AAAA";
            firstTimeDay = true;
            firstTimeMonth = true;
            firstTimeYear = true;
        }

        private void year_Enter(object sender, EventArgs e)
        {
            if (firstTimeYear == false)
            {
                year.Text = "";
                firstTimeYear = true;
            }
        }

        private void month_Enter(object sender, EventArgs e)
        {
            if (firstTimeMonth == false)
            {
                month.Text = "";
                firstTimeMonth = true;
            }
        }

        private void day_Enter(object sender, EventArgs e)
        {
            if (firstTimeDay == false)
            {
                day.Text = "";
                firstTimeDay = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            incidenceNameTxt.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            incidenceLocationTxt.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            incidenceEmailTxt.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            incidenceTypeCmb.SelectedIndex = -1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            incidenceStatusCmb.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            day.Text = "DD";
            month.Text = "MM";
            year.Text = "AAAA";
            firstTimeDay = true;
            firstTimeMonth = true;
            firstTimeYear = true;
        }
        
        private void incidencesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridObject.loadIncidenceFromDataGrid(sender, e) != null)
            {
                ViewIncidence viewIncidence = new ViewIncidence(gridObject.loadIncidenceFromDataGrid(sender, e), gridObject, e.RowIndex);
                viewIncidence.TopLevel = true;
                viewIncidence.Show();
            }
        }

    }
}
