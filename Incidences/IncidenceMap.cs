using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32; 

namespace Proyecto_Final.Incidences
{
    public partial class IncidenceMap : Form
    {
        public IncidenceMap(string lat, string lng)
        {
            InitializeComponent();
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

            var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(appName, 9999, RegistryValueKind.DWord);
            Key.Close();
            webBrowser1.Url = new Uri("https://www.google.es/maps/place/" + lat + "N" + lng + "E/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
