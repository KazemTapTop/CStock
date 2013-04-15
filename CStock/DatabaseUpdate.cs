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
    public class TradeLastDay_DBUpdate
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

            ConvertAraToFar(); //Convert arabic chars to farsi ones.
            
            if (!CreateNewNomads(ref ds))
                return false;

            if (!StoreInSQL())
                return false;
            return true;
        }

        private bool StoreInSQL()
        {
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

            }
            catch (Exception e)
            {
                Log.WriteLog(e.ToString());
                return false;
            }
            return true;
        }
        private bool CreateNewNomads(ref DataSet ds)
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
                    StringBuilder cmd_str = new StringBuilder("create ");
                    string s = (string)dr.ItemArray[0];
                    if (nomad_names.IndexOf(s) == -1)
                    {
                        cmd_str.Append(s + ";");
                        //Add columns to newly created table
                        cmd_str.AppendLine("ALTER TABLE " + s);
                        cmd_str.AppendLine("ADD LVal18AFC nvarchar(30),");
                        cmd_str.AppendLine("ADD DEven datetime,");
                        cmd_str.AppendLine("ADD ZTotTran decimal(18,10),");
                        cmd_str.AppendLine("ADD QTotTran5J decimal(18,10),");
                        cmd_str.AppendLine("ADD QTotCap decimal(18,10),");
                        cmd_str.AppendLine("ADD InsCode float,");
                        cmd_str.AppendLine("ADD LVal30 nvarchar(30),");
                        cmd_str.AppendLine("ADD PClosing decimal(18,10),");
                        cmd_str.AppendLine("ADD PDrCotVal decimal(18,10),");
                        cmd_str.AppendLine("ADD ZTotTran1 decimal(18,10),");
                        cmd_str.AppendLine("ADD QTotTran5J1 decimal(18,10),");
                        cmd_str.AppendLine("ADD QTotCap1 decimal(18,10),");
                        cmd_str.AppendLine("ADD PriceChange decimal(18,10),");
                        cmd_str.AppendLine("ADD PriceMin decimal(18,10),");
                        cmd_str.AppendLine("ADD PriceMax decimal(18,10),");
                        cmd_str.AppendLine("ADD PriceFirst decimal(18,10),");
                        cmd_str.AppendLine("ADD PriceYesterday decimal(18,10);");

                        SqlCommand sc = new SqlCommand(cmd_str.ToString(),c);
                        sc.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Log.WriteLog(e.ToString());
                return false;
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
