using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Utils
{
    public static class WriteCoordinates
    {
        public static void writeCoordinates(string imagePath, JSON.Incidence incidence, PictureBox picture)
        {
            List<PointF> location = new List<PointF>();
            location.Add(new PointF(10f, 10f));
            location.Add(new PointF(10f, 40f));
            location.Add(new PointF(10f, 70f));
            location.Add(new PointF(10f, 100f));

            Bitmap bitmap = new Bitmap(picture.Image);
            

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
               using (Font arialFont = new Font("Arial", 20))
                {
                   graphics.DrawString("User Email: " + incidence.email, arialFont, Brushes.White, location[0]);
                   graphics.DrawString("Street: " + incidence.street, arialFont, Brushes.White, location[1]);
                   graphics.DrawString("Latitude: " + incidence.lat, arialFont, Brushes.White, location[2]);
                   graphics.DrawString("Longitude: " + incidence.lng, arialFont, Brushes.White, location[3]);
                }
            }

            bitmap.Save(imagePath);
        }
    }
}
