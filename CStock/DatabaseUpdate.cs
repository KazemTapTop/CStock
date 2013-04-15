using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace CStock
{
    public class DatabaseUpdate
    {
        ArrayList nomad_names = new ArrayList();

        private bool InitNomads()
        {
            SqlConnection c;
            DataSet n = new DataSet();

            try
            {
                if (Settings.Server_Type == 0) //Local Server
                {
                    c = new SqlConnection("user id=" + Settings.username + ";Pwd=" + Settings.password + ";" +
                       "Data Source=" + Settings.ip_addr + "," + Settings.port.ToString() + ";Trusted_Connection=true;Connection Timeout=30;Database=kazem");
                }
                else
                {
                    c = new SqlConnection("user id=" + Settings.username + ";Pwd=" + Settings.password + ";" +
                        "Data Source=" + Settings.ip_addr + "," + Settings.port.ToString() + ";Trusted_Connection=false;Connection Timeout=30;Database=kazem");
                }
                
                SqlDataAdapter sd = new SqlDataAdapter("Select Name from nomad", c);
                sd.Fill(n, "nomad");
                foreach (DataRow dr in n.Tables[0].Rows)
                {
                    nomad_names.Add(new StringBuilder((string)dr.ItemArray[0]));
                }
                return true; 
            }
            catch(Exception e)
            {
#if DEBUG
                Log.WriteLog(e.ToString());
#else
                Log.WriteLog("Error in Data connection");
#endif

                return false;
            }
            
        }

        public bool UpdateData(ref DataSet ds)
        {
            if (!InitNomads())  //Get previous nomads from SQL Server
                return false;

            ConvertAraToFar();
            
            if (!CreateNewTables(ref ds))
                return false;

            if (!StoreInSQL())
                return false;
            return true;
        }

        private bool StoreInSQL()
        {
            return true;
        }
        private bool CreateNewTables(ref DataSet ds)
        {
            SqlConnection c;
            try
            {
                if (Settings.Server_Type == 0) //Local Server
                {
                    c = new SqlConnection("user id=" + Settings.username + ";Pwd=" + Settings.password + ";" +
                       "Data Source=" + Settings.ip_addr + "," + Settings.port.ToString() + ";Trusted_Connection=true;Connection Timeout=30;Database=kazem");
                }
                else
                {
                    c = new SqlConnection("user id=" + Settings.username + ";Pwd=" + Settings.password + ";" +
                        "Data Source=" + Settings.ip_addr + "," + Settings.port.ToString() + ";Trusted_Connection=false;Connection Timeout=30;Database=kazem");
                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string s = (string)dr[0];
                    if (nomad_names.IndexOf(s) == -1)
                    {
                        SqlCommand sc = new SqlCommand("create " + s,c);
                        sc.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Log.WriteLog(e.ToString());
            }
            return true;
        }

        private void ConvertAraToFar()
        {
            
            foreach (StringBuilder dr in nomad_names)
            {
                dr.Replace("ي", "ی");
                dr.Replace("ك", "ک");
                dr.Replace("إ", "ا");
                dr.Replace("أ", "ا");
                dr.Replace("ة", "ت");
                dr.Replace("ٶ", "و");
            }
        }

    }
}
