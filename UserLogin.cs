using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        bool canclose = false;

        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            try{
            Request.UserRequests user = new Request.UserRequests();
            List<JSON.User> usersdata = user.getAllUsersData();
            foreach (JSON.User users in usersdata)
            {
                if (textBox1.Text.ToLower().Equals(users.email.ToLower()) && Utils.SecurityUtilities.Sha1Digest(textBox2.Text).Equals(users.password) && users.accountType.ToLower().Equals("admin"))
                {
                    login = true;
                }
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Problemas con el servidor, el programa se cerrará.", "Error");
                Application.Exit();
            }finally{
                if (login == true)
                {
                    canclose = true;
                    Form1 form = new Form1();
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Error");
                }
            }
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canclose == false)
            {
                Application.Exit();
            }
        }
    }
}
