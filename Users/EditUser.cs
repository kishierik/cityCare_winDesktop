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
    public partial class EditUser : Form
    {
        private Request.UserRequests userRequests = new Request.UserRequests();
        string userid;
        public EditUser()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel3.Controls.Add(button6);
        }
        private void loadUsersOnDataGrid()
        {
            usersEditDataGrid.Rows.Clear();
            if (userRequests.getAllUsersData() == null)
            {
                MessageBox.Show("No hay ningún usuario en la base de datos", "Lista de usuarios vacía");
            }
            else
            {
                int i = 0;
                foreach (JSON.User user in userRequests.getAllUsersData())
                {
                    usersEditDataGrid.Rows.Insert(i, user.email, user.password, user._id);
                    i++;
                }
            }
        }

        private void getUserDataFromRow(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            panel3.Visible = true;
            if (e.RowIndex != -1)
            {
                foreach (JSON.User user in userRequests.getAllUsersData())
                {
                    if (user._id.Equals(usersEditDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        nameTextBox.Text = user.name;
                        passwordTextBox.Text = user.password;
                        lastnameTextBox.Text = user.lastname;
                        emailTextBox.Text = user.email;
                        userid = user._id;
                        if(user.password == null)
                        {
                            nameTextBox.Enabled = false;
                            emailTextBox.Enabled = false;
                            lastnameTextBox.Enabled = false;
                            button1.Enabled = false;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!newpasswordTextBox.Text.Equals(""))
            {
                    passwordTextBox.Text = Utils.SecurityUtilities.Sha1Digest(newpasswordTextBox.Text);
                    newPasswordGrp.Visible = false;
            }
            else
            {
                MessageBox.Show("La nueva contraseña debe tener un contenido valido.", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newpasswordTextBox.Text = "";
            newPasswordGrp.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals("") || passwordTextBox.Text != null)
            {
                newPasswordGrp.Visible = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            userRequests.editUser(userid, nameTextBox.Text, emailTextBox.Text, lastnameTextBox.Text, passwordTextBox.Text);
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadUsersOnDataGrid();
        }

        private void refreshData(object sender, EventArgs e)
        {
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
