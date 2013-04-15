using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;

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

            if (!StoreInSQL(ref ds))
                return false;
            return true;
        }

        private bool StoreInSQL(ref DataSet ds)
        {
            SqlConnection c;
            SqlCommand scmd;

            SqlParameter LVal18AFC      = new SqlParameter("@LVal18AFC", SqlDbType.NVarChar);
            SqlParameter DEven          = new SqlParameter("@DEven", SqlDbType.DateTime);
            SqlParameter ZTotTran       = new SqlParameter("@ZTotTran", SqlDbType.Decimal);
            SqlParameter QTotTran5J     = new SqlParameter("@QTotTran5J", SqlDbType.Decimal);
            SqlParameter QTotCap        = new SqlParameter("@QTotCap", SqlDbType.Decimal);
            SqlParameter InsCode        = new SqlParameter("@InsCode", SqlDbType.Float);
            SqlParameter LVal30         = new SqlParameter("@LVal30", SqlDbType.NVarChar);
            SqlParameter PClosing       = new SqlParameter("@PClosing", SqlDbType.Decimal);
            SqlParameter PDrCotVal      = new SqlParameter("@PDrCotVal", SqlDbType.Decimal);
            SqlParameter ZTotTran1      = new SqlParameter("@ZTotTran1", SqlDbType.Decimal);
            SqlParameter QTotTran5J1    = new SqlParameter("@QTotTran5J1", SqlDbType.Decimal);
            SqlParameter QTotCap1       = new SqlParameter("@QTotCap1", SqlDbType.Decimal);
            SqlParameter PriceChange    = new SqlParameter("@PriceChange", SqlDbType.Decimal);
            SqlParameter PriceMin       = new SqlParameter("@PriceMin", SqlDbType.Decimal);
            SqlParameter PriceMax       = new SqlParameter("@PriceMax", SqlDbType.Decimal);
            SqlParameter PriceFirst     = new SqlParameter("@PriceFirst", SqlDbType.Decimal);
            SqlParameter PriceYesterday = new SqlParameter("@PriceYesterday", SqlDbType.Decimal);

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
                
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    scmd = new SqlCommand("INSERT INTO " + (string)dr.ItemArray[0] +
                        "values(" +
                        "@LVal18AFC" +
                        "@DEven" +
                        "@ZTotTran" +
                        "@QTotTran5J" +
                        "@QTotCap" +
                        "@InsCode" +
                        "@LVal30" +
                        "@PClosing" +
                        "@PDrCotVal" +
                        "@ZTotTran1" +
                        "@QTotTran5J1" +
                        "@QTotCap1" +
                        "@PriceChange" +
                        "@PriceMin" +
                        "@PriceMax" +
                        "@PriceFirst" +
                        "@PriceYesterday" +
                        ")",c);
                    LVal18AFC.Value     = (string)dr.ItemArray[0];     
                    DEven.Value         = ShamsiToMiladi((string)dr.ItemArray[1]);         
                    ZTotTran.Value      = (Decimal)dr.ItemArray[2];     
                    QTotTran5J.Value    = (Decimal)dr.ItemArray[3];    
                    QTotCap.Value       = (Decimal)dr.ItemArray[4];
                    InsCode.Value       = (Double)dr.ItemArray[5];
                    LVal30.Value        = (string)dr.ItemArray[6];        
                    PClosing.Value      = (Decimal)dr.ItemArray[7];
                    PDrCotVal.Value     = (Decimal)dr.ItemArray[8];
                    ZTotTran1.Value     = (Decimal)dr.ItemArray[9];
                    QTotTran5J1.Value   = (Decimal)dr.ItemArray[10];
                    QTotCap1.Value      = (Decimal)dr.ItemArray[11];
                    PriceChange.Value   = (Decimal)dr.ItemArray[12];
                    PriceMin.Value      = (Decimal)dr.ItemArray[13];
                    PriceMax.Value      = (Decimal)dr.ItemArray[14];
                    PriceFirst.Value    = (Decimal)dr.ItemArray[15];
                    PriceYesterday.Value= (Decimal)dr.ItemArray[16];
                    
                    scmd.Parameters.Add(LVal18AFC);
                    scmd.Parameters.Add(DEven);
                    scmd.Parameters.Add(ZTotTran);
                    scmd.Parameters.Add(QTotTran5J);
                    scmd.Parameters.Add(QTotCap);
                    scmd.Parameters.Add(InsCode);
                    scmd.Parameters.Add(LVal30);
                    scmd.Parameters.Add(PClosing);
                    scmd.Parameters.Add(PDrCotVal);
                    scmd.Parameters.Add(ZTotTran1);
                    scmd.Parameters.Add(QTotTran5J1);
                    scmd.Parameters.Add(QTotCap1);
                    scmd.Parameters.Add(PriceChange);
                    scmd.Parameters.Add(PriceMin);
                    scmd.Parameters.Add(PriceMax);
                    scmd.Parameters.Add(PriceFirst);
                    scmd.Parameters.Add(PriceYesterday);
                    scmd.ExecuteNonQuery();
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

        private DateTime ShamsiToMiladi(String date_str)
        {
            string[] jdate = date_str.Split(new char[] {Convert.ToChar("\\")});
            PersianCalendar pd = new PersianCalendar();
            DateTime dt = pd.ToDateTime(Convert.ToInt32(jdate[0]), Convert.ToInt32(jdate[1]), Convert.ToInt32(jdate[2]), 0, 0, 0, 0);
            return dt;
        }

    }
}
