using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyecto_Final
{
    public partial class Main : Form
    {
        Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
        Request.UserRequests userRequest = new Request.UserRequests();
        System.Timers.Timer timer = new System.Timers.Timer();
        public Main()
        {
            InitializeComponent();
            try
            {
                loadCounts();
                checkStatus();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }
        private void loadIncidences()
        {
            int incidence = 0;
            int[] count = incidenceRequest.getAllCount();
            send.Text = count[0].ToString();
            read.Text = count[1].ToString();
            process.Text = count[2].ToString();
            solved.Text = count[3].ToString();
            denied.Text = count[4].ToString();
            undefined.Text = count[5].ToString();
            for (int i = 0; i < count.Length; i++)
            {
                incidence += count[i];
            }
            inc_total.Text = incidence.ToString();
        }
        private void loadUsers()
        {
            int[] users = userRequest.getAllUsersType();
            active.Text = users[0].ToString();
            blocked.Text = users[1].ToString();
            total.Text = (users[0] + users[1]).ToString();
            facebook.Text = users[2].ToString();
            nofacebook.Text = users[3].ToString();
        }
        private void loadCategory()
        {
            int[] count = incidenceRequest.getAllCountCategory();
            via.Text = count[0].ToString();
            urbano.Text = count[1].ToString();
            farolas.Text = count[2].ToString();
            alcantarilla.Text = count[3].ToString();
            limpieza.Text = count[4].ToString();
            semaforo.Text = count[5].ToString();
        }
        private void loadCounts()
        {
            try{
            loadIncidences();
            loadUsers();
            loadCategory();
            }catch(Exception e){
                Console.Write(e);
            }
        }
        private void checkStatus()
        {
            if(Request.ServerStatusRequest.getStatus() == 0){
                status.Text = "ENCENDIDO";
            }
            else
            {
                status.Text = "APAGADO";
            }
        }
    }
}

