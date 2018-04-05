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
    public partial class ViewIncidence : Form
    {
        private string pictureUrl;
        GridViewObject.GridObject gridObject;
        JSON.Incidence newIncidence = new JSON.Incidence();
        Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
        Request.UserRequests userRequest = new Request.UserRequests();
        int rowindex;

        public ViewIncidence(JSON.Incidence aux, GridViewObject.GridObject grid, int row)
        {
            InitializeComponent();
            gridObject = grid;
            pictureUrl = Utils.Constants.serverAddress + "incidencias/image/" + aux.imageName;
            newIncidence = aux;
            loadData();
            rowindex = row;
        }
        private void loadData()
        {
            id.Text = newIncidence._id;
            incidence.Text = newIncidence.title;
            location.Text = newIncidence.street;
            lat.Text = newIncidence.lat;
            lon.Text = newIncidence.lng;
            useremail.Text = newIncidence.email;
            type.Text = Utils.IncidenceCategory.NumToString(newIncidence.category);
            status.Text = Utils.IncidenceStatus.NumToString(newIncidence.status);
            date.Text = newIncidence.date;
            picture.ImageLocation = pictureUrl;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            if (newIncidence.status == 0)
            {
                incidenceRequest.setRead(newIncidence._id);
            }
            if (newIncidence.streetbyUser == null)
            {
            }
            else if (newIncidence.streetbyUser.Equals("1"))
            {
                location.BackColor = System.Drawing.Color.AntiqueWhite;
                lat.BackColor = System.Drawing.Color.AntiqueWhite;
                lon.BackColor = System.Drawing.Color.AntiqueWhite;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picture_DoubleClick(object sender, EventArgs e)
        {
            openViewImage();
        }

        private void openViewImage()
        {
            Images.ViewImage vi = new Images.ViewImage(pictureUrl);
            vi.TopMost = true;
            vi.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = newIncidence.imageName;
            saveDialog.DefaultExt = ".jpg";
            saveDialog.Filter = "Imagen (.jpg) |*.jpg";
            saveDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Utils.WriteCoordinates.writeCoordinates(saveDialog.FileName, newIncidence, picture);
                }
                catch (Exception exc)
                {
                    Console.Write(exc);
                }
                finally
                {
                    estado.Text = "Imagen descargada correctamente.";
                }
            }
        }


        private void picture_Click(object sender, EventArgs e)
        {
            openViewImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            switch (Utils.IncidenceStatus.StringToNum(status.Text))
            {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
                case 3:
                    radioButton4.Checked = true;
                    break;
                case 4:
                    radioButton5.Checked = true;
                    break;
                case 5:
                    radioButton6.Checked = true;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stat = -1;
            if (radioButton1.Checked)
            {
                stat = 0;
            }
            else if (radioButton2.Checked)
            {
                stat = 1;
            }
            else if (radioButton3.Checked)
            {
                stat = 2;
            }
            else if (radioButton4.Checked)
            {
                stat = 3;
            }
            else if (radioButton5.Checked)
            {
                stat = 4;
            }
            else if (radioButton6.Checked)
            {
                stat = 5;
            }
            groupBox3.Visible = false;
            incidenceRequest.changeStatus(newIncidence._id, stat);
            status.Text = Utils.IncidenceStatus.NumToString(stat);
        }

        private void useremail_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            JSON.User userdata = userRequest.getUserData(newIncidence.userId);
            Users.ViewUserDetailed vud = new Users.ViewUserDetailed(userdata, gridObject, rowindex);
            vud.TopMost = true;
            vud.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Las incidencias borradas no podrán ser recuperadas. ¿Está seguro que desea eliminar permanentemente esta incidencia?", "¿Desea borrar esta incidencia?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                incidenceRequest.deleteIncidence(newIncidence._id, newIncidence.imageName);
                MessageBox.Show("Incidencia eliminada con éxito", "Incidencia eliminada");
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IncidenceMap map = new IncidenceMap(newIncidence.lat, newIncidence.lng);
            map.TopMost = true;
            map.ShowDialog();
        }

        private void ViewIncidence_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridObject.refreshGrid(rowindex);
        }
    }
}
