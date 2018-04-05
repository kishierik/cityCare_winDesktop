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
    public partial class DeleteUser : Form
    {
        private Request.UserRequests userRequests = new Request.UserRequests();
        public DeleteUser()
        {
            InitializeComponent();
            loadUsersOnDataGrid();
        }

        private void loadUsersOnDataGrid()
        {
            usersDeleteDataGrid.Rows.Clear();
            if (userRequests.getAllUsersData() == null)
            {
                MessageBox.Show("No hay ningún usuario en la base de datos", "Lista de usuarios vacía");
            }
            else
            {
                int i = 0;
                foreach (JSON.User user in userRequests.getAllUsersData())
                {
                    usersDeleteDataGrid.Rows.Insert(i,user._id, user.email, user.password, user.name, user.lastname, Utils.UserStatus.numToString(user.status));
                    i++;
                }
            }
        }

        private void deleteUserFromRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != usersDeleteDataGrid.Rows.Count - 1)
            {
                foreach (JSON.User user in userRequests.getAllUsersData())
                {
                    if (user._id.Equals(usersDeleteDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea borrar permanentemente este usuario?", "Borrar usuario", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            userRequests.deleteUser(user._id);
                            MessageBox.Show("Usuario borrado con éxito.", "Usuario borrado");
                        }
                    }
                }
            }
            loadUsersOnDataGrid();
        }

        private void refreshData(object sender, EventArgs e)
        {

        }

    }
}
