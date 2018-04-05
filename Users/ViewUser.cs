using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Users
{
    public partial class ViewUser : Form
    {
        GridViewObject.GridObject gridObject;
        public ViewUser()
        {
            InitializeComponent();
            gridObject = new GridViewObject.GridObject(usersViewDataGrid);
            gridObject.loadUsersOnDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridObject.loadUsersOnDataGrid();
        }

        private void refreshData(object sender, EventArgs e)
        {

        }

       private void usersViewDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void usersViewDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gridObject.loadUserFromDataGrid(sender, e) != null)
            {
                Users.ViewUserDetailed vud = new ViewUserDetailed(gridObject.loadUserFromDataGrid(sender, e), gridObject, e.RowIndex);
                vud.TopMost = true;
                vud.Show();
            }
        }
    }
}
