using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Images
{
    public partial class ViewImage : Form
    {
        public ViewImage(string url)
        {
            InitializeComponent();
            loadPicture(url);
        }
        private void loadPicture(string pictureUrl)
        {
            pictureBox1.ImageLocation = pictureUrl;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
