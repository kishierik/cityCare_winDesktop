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
    public partial class BlackList : Form
    {
        GridViewObject.GridObject gridObject;
        Request.UserRequests userRequests = new Request.UserRequests();
        public BlackList()
        {
            InitializeComponent();
            gridObject = new GridViewObject.GridObject(usersViewDataGrid);
            gridObject.loadUsersOnDataGridBlackList();
        }

        private void usersViewDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridObject.loadUserFromDataGrid(sender, e) != null)
            {
                Users.ViewUserDetailed vud = new ViewUserDetailed(gridObject.loadUserFromDataGrid(sender, e), gridObject, e.RowIndex);
                vud.TopMost = true;
                vud.Show();
            }
        }

        private void BlackList_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridObject.loadUsersOnDataGridBlackList();
        }
    }
}
