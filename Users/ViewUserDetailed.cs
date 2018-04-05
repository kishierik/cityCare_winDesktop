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
    public partial class ViewUserDetailed : Form
    {
        GridViewObject.GridObject gridObject;
        JSON.User user = new JSON.User();
        Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
        int rowindex;
        public ViewUserDetailed(JSON.User data, GridViewObject.GridObject grid, int row)
        {
            gridObject = grid;
            InitializeComponent();
            user = data;
            loadData();
            rowindex = row;
        }
        private void loadData()
        {
            id.Text = user._id;
            idprov.Text = user.id_prov;
            name.Text = user.name;
            lastname.Text = user.lastname;
            mail.Text = user.email;
            mac.Text = user.mac;
            pass.Text = user.password;
            gender.Text = Utils.Gender.englishToSpanish(user.gender);
            positivepoints.Text = user.positivePoints.ToString();
            negativepoints.Text = user.negativePoints.ToString();
            avatar.ImageLocation = user.avatar;
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            getStatus();
            incsended.Text = user.numberIncidences;
            inccompleted.Text = user.numberIncidencesSolved;
        }
        private void getStatus()
        {
            if (user.status == 0)
            {
                status.Text = "Bloqueado";
                status.ForeColor = System.Drawing.Color.Red;
                blockuserBtn.Text = "Desbloquear";
            }
            else
            {
                status.Text = "Activo";
                status.ForeColor = System.Drawing.Color.Green;
                blockuserBtn.Text = "Bloquear";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendNotification sendnot = new SendNotification(user._id);
            sendnot.TopMost = true;
            sendnot.ShowDialog();
        }

        private void blockuserBtn_Click(object sender, EventArgs e)
        {
            Request.UserRequests userRequest = new Request.UserRequests();
            if (user.status == 0)
            {
                userRequest.blockUser(user._id, "1");
                user.status = 1;
            }
            else
            {
                userRequest.blockUser(user._id, "0");
                user.status = 0;
            }
            getStatus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Request.UserRequests userRequests = new Request.UserRequests();
            DialogResult dialogResult = MessageBox.Show("¿Desea borrar permanentemente este usuario?", "Borrar usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userRequests.deleteUser(user._id);
                MessageBox.Show("Usuario borrado con éxito.", "Usuario borrado");
                this.Close();
            }
        }

        private void ViewUserDetailed_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridObject.refreshGrid(rowindex);
        }
    }
}
