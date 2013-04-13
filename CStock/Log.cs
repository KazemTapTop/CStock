using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace CStock
{
    public class Log
    {
        //private readonly string log_file = "Error_Log.txt";
        public static void WriteLog(String msg)
        {
            try
            {
                DateTime dt = DateTime.Now;
                PersianCalendar date = new PersianCalendar();
                StringBuilder sb = new StringBuilder(string.Format("{0}/{1}/{2} {3}:{4}", date.GetYear(dt), date.GetMonth(dt), date.GetDayOfMonth(dt),
                    dt.Hour,dt.Minute));
                sb.Append("     ");
                sb.Append(msg);
                sb.Append("\r\n");
                FileStream fs = File.Open("Error_Log.txt", FileMode.Append, FileAccess.Write, FileShare.Read);
                byte[] txt = new byte[sb.Length * sizeof(char)];
                System.Buffer.BlockCopy(sb.ToString().ToCharArray(), 0, txt, 0, txt.Length);
                fs.Write(txt, 0, txt.Length);
                fs.Close();
            }
            catch (Exception)
            {
                return;
            }

        }
    }
}
