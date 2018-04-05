using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.GridViewObject
{
    public class GridObject
    {
        private Request.UserRequests userRequests = new Request.UserRequests();
        private Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
        private List<JSON.Incidence> incidenceList;
        private List<JSON.Incidence> resultList;
        private List<JSON.User> users;
        private DataGridView dataGridView;
        // 0 = users, 1 = blacklist, 2 = incidences
        private int gridType;
        public GridObject()
        {
        }
        public GridObject(DataGridView gridView)
        {
            dataGridView = gridView;
        }
        public void loadUsersOnDataGridBlackList()
        {
            gridType = 1;
            dataGridView.Rows.Clear();
            users = userRequests.getAllUsersData();
            if (users == null)
            {
                MessageBox.Show("No hay ningún usuario en la lista negra", "Lista de usuarios vacía");
            }
            else
            {
                int i = 0;
                foreach (JSON.User user in users)
                {
                    if (user.status == 0)
                    {
                        dataGridView.Rows.Insert(i, user._id, user.email, user.password, user.name, user.lastname, Utils.UserStatus.numToString(user.status));
                        i++;
                    }
                }
            }
        }
        public void loadUsersOnDataGrid()
        {
            gridType = 0;
            dataGridView.Rows.Clear();
            users = userRequests.getAllUsersData();
            if (users == null)
            {
                MessageBox.Show("No hay ningún usuario en la base de datos", "Lista de usuarios vacía");
            }
            else
            {
                int i = 0;
                foreach (JSON.User user in users)
                {
                    dataGridView.Rows.Insert(i, user._id, user.email, user.password, user.name, user.lastname, Utils.UserStatus.numToString(user.status));
                    i++;
                }
            }
        }
        public void refreshUserOnBlackList(int row)
        {
            string id = dataGridView.Rows[row].Cells[0].Value.ToString();
            JSON.User user = userRequests.getUserData(id);
            if (user.status == 1)
            {
                dataGridView.Rows.RemoveAt(row);
            }
        }
        public void refreshUser(int row)
        {
            string id = dataGridView.Rows[row].Cells[0].Value.ToString();
            try
            {
                JSON.User user = userRequests.getUserData(id);
                dataGridView.Rows[row].SetValues(user._id, user.email, user.password, user.name, user.lastname, Utils.UserStatus.numToString(user.status));
            }
            catch (Exception e)
            {
                dataGridView.Rows.RemoveAt(row);
            }
        }

        public void refreshIncidence(int row)
        {
            string id = dataGridView.Rows[row].Cells[0].Value.ToString();
            try
            {
                JSON.Incidence incidence = incidenceRequest.getIncidence(id);
                string[] date = incidence.date.Split(new[] { '/' }, 3);
                dataGridView.Rows[row].SetValues(incidence._id, incidence.title, incidence.street, incidence.email, Utils.IncidenceCategory.NumToString(incidence.category), Utils.IncidenceStatus.NumToString(incidence.status), string.Format("{1}/{0}/{2}", date));
            }
            catch (Exception e)
            {
                dataGridView.Rows.RemoveAt(row);
            }
        }

        public void loadIncidencesOnGrid()
        {
            gridType = 2;
            dataGridView.Rows.Clear();
            incidenceList = incidenceRequest.getAllIncidencesData();
            if (incidenceList == null)
            {
                MessageBox.Show("No hay ninguna incidencia en la base de datos", "Lista de incidencias vacía");
            }
            else
            {
                int i = 0;
                foreach (JSON.Incidence incidence in incidenceList)
                {
                    string[] date = incidence.date.Split(new[] { '/' }, 3);
                    dataGridView.Rows.Insert(i, incidence._id, incidence.title, incidence.street, incidence.email, Utils.IncidenceCategory.NumToString(incidence.category), Utils.IncidenceStatus.NumToString(incidence.status), string.Format("{1}/{0}/{2}", date));
                    i++;
                }
            }
        }
        public void loadIncidencesOnGridWithSearch(string incidenceName, string incidenceLocation, string incidenceEmail, int incidenceType, int incidenceStatus, string incidenceDate)
        {
            gridType = 2;
            resultList = incidenceRequest.getAllIncidencesData();
            resultList = resultList.FindAll(x => x.title.ToLower().Contains(incidenceName.ToLower()));
            resultList = resultList.FindAll(x => x.email.ToLower().Contains(incidenceEmail.ToLower()));
            if (incidenceType >= 0)
            {
                resultList = resultList.FindAll(x => x.category == incidenceType);
            }
            if (incidenceStatus >= 0)
            {
                resultList = resultList.FindAll(x => x.status == incidenceStatus);
            }
            if (Utils.isDateNumeric.isIt(incidenceDate))
            {
                resultList = resultList.FindAll(x => (x.date.Substring(3, 2).Equals(incidenceDate.Substring(0,2)) && (x.date.Substring(0, 2).Equals(incidenceDate.Substring(3,2)) && (x.date.Substring(6, 4).Equals(incidenceDate.Substring(6,4))))));
            }
             resultList = resultList.FindAll(x => x.street.ToLower().Contains(incidenceLocation.ToLower()));

            dataGridView.Rows.Clear();
            int i = 0;
            foreach (JSON.Incidence incidence in resultList)
            {
                string[] date = incidence.date.Split(new [] {'/'}, 3);
                dataGridView.Rows.Insert(i, incidence._id, incidence.title, incidence.street, incidence.email, Utils.IncidenceCategory.NumToString(incidence.category), Utils.IncidenceStatus.NumToString(incidence.status), string.Format("{1}/{0}/{2}", date));
                i++;
            }

        }
        public JSON.Incidence loadIncidenceFromDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dataGridView.Rows.Count - 1)
            {
                foreach (JSON.Incidence inc in incidenceList)
                {
                    if (inc._id.Equals(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        return inc;
                    }
                }
            }
            return null;
        }
        public JSON.User loadUserFromDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (JSON.User user in users)
                {
                    if (user._id.Equals(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        return userRequests.getUserData(user._id);
                    }
                }
            }
            return null;
        }

        public void refreshGrid(int row)
        {
            if (gridType == 0)
            {
                refreshUser(row);
            }
            else if (gridType == 1)
            {
                refreshUserOnBlackList(row);
            }
            else if (gridType == 2)
            {
                refreshIncidence(row);
            }
        }

        public DataGridView returnGridView()
        {
            return dataGridView;
        }
    }
}

/* /* List<JSON.Incidence> resultList2 = new List<JSON.Incidence>();
             List<JSON.Incidence> resultList3 = new List<JSON.Incidence>();
             List<JSON.Incidence> resultList4 = new List<JSON.Incidence>();
             List<JSON.Incidence> resultList5 = new List<JSON.Incidence>();
             List<JSON.Incidence> resultList6 = new List<JSON.Incidence>();
             List<JSON.Incidence> resultList7 = new List<JSON.Incidence>();*/

/*if (!isNumeric(incidenceDate))
{
    incidenceDate = "";
}
if (!isEmpty(incidenceName))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (!inc.title.Contains(incidenceName))
        {
            resultList2.Add(inc);
        }
    }
}
else
{
    //resultList2 = resultList;
}
if (!isEmpty(incidenceLocation))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (!inc.street.Contains(incidenceLocation))
        {
            resultList3.Add(inc);
        }
    }
}
else
{
   // resultList3 = resultList;
}
if (!isEmpty(incidenceEmail))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (!userRequest.getUserData(inc.userId).email.Contains(incidenceEmail))
        {
            resultList4.Add(inc);
        }
    }
}
else
{
   // resultList4 = resultList;
}
if (!isEmpty(incidenceType))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (inc.category != Utils.IncidenceCategory.StringToNum(incidenceType))
        {
            resultList5.Add(inc);
        }
    }
}
else
{
   // resultList5 = resultList;
}
if (!isEmpty(incidenceStatus))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (inc.status != Utils.IncidenceStatus.StringToNum(incidenceStatus))
        {
            resultList6.Add(inc);
        }
    }
}
else
{
   // resultList6 = resultList;
}
if (!isEmpty(incidenceDate))
{
    foreach (JSON.Incidence inc in resultList)
    {
        if (!inc.date.Equals(incidenceDate))
        {
            resultList7.Add(inc);
        }
    }
}
else
{
   // resultList7 = resultList;
}*/
