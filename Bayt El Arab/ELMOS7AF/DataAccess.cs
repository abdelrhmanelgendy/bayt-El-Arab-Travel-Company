using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMOS7AF
{
    class DataAccess
    {

        public SqlConnection sqlconnections;

        public  DataAccess()
        {
            string mode = Properties.Settings.Default.Mode;
            string server = Properties.Settings.Default.Server;
            string dataBase = Properties.Settings.Default.DataBase;
            string userName = Properties.Settings.Default.ID;
            string password = Properties.Settings.Default.Password;
            if (mode.Equals("sql"))
            {
                sqlconnections = new SqlConnection(@"Server=" + server + ";DataBase=" + dataBase + ";Integrated security=false;user id="+userName+" ; password="+password+"");
            }
            else if (mode.Equals("windows"))
            {
               sqlconnections = new SqlConnection(@"Server="+server+";DataBase="+dataBase+";Integrated security=true");
               

            }
           

        }

        public void open()
        {
            if (sqlconnections.State != System.Data.ConnectionState.Open)
            {
                sqlconnections.Open();
            }


        }

        public void close()
        {
            if (sqlconnections.State == System.Data.ConnectionState.Open)
            {
                sqlconnections.Close();
            }


        }

        public String returncurrentdate()
        {
            String date = DateTime.Now.ToShortDateString();

            return date;

        }

    }
}
