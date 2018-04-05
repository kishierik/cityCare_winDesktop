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
    public partial class SendNotification : Form
    {
        Request.PushRequest pushRequest = new Request.PushRequest();
        string user_id;
        public SendNotification(string id)
        {
            user_id = id;
            InitializeComponent();
            textBox1.Text = user_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pushRequest.sendPush(user_id, textBox2.Text, textBox3.Text);
            MessageBox.Show("Notificación enviada con éxito", "Notificación");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
