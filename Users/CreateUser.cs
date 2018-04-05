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
    public partial class CreateUser : Form
    {
        private Request.UserRequests req = new Request.UserRequests();
        string name;
        string email;
        string lastname;
        string password;

        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = emailTextBox.Text;
            if (Utils.StringUtilities.IsCorrectEmail(email) == true)
            {
                if (!nameTextBox.Text.Equals("") && !surnameTextBox.Text.Equals("") && !passwordTextBox.Text.Equals(""))
                {
                    name = nameTextBox.Text;
                    lastname = surnameTextBox.Text;
                    password = passwordTextBox.Text;
                    MessageBox.Show(req.registerUser(name, email, lastname, password), "Registro de usuario");
                }
                else
                {
                    MessageBox.Show("Todos los campos deben de ser válidos", "Error");
                }
            }
            else
            {
                MessageBox.Show("Correo electronico no valido", "Error");
            }
        }
    }
}
