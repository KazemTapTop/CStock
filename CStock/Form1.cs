﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using CStock.tsePublic;

namespace CStock
{
    public partial class CStock_Form : Form
    {
        public CStock_Form()
        {
            InitializeComponent();
            if (Settings.InitializeSettings() == false)
            {
                System.Environment.Exit(1);
            }
        }
        private Thread thread_UpData;
        
        private DataSet LastDay_DS;
        private volatile bool ExitFlag = false;
        private readonly string stock_user = "tsstock.ir";
        private readonly string stock_pass = "tsstock";
        private void Update_Data()
        {

            TsePublicSoapClient tseclient = new TsePublicSoapClient();
            TradeLastDay_DBUpdate du = new TradeLastDay_DBUpdate();
            
            while ((!ExitFlag))
            {
                try
                {
                    LastDay_DS = tseclient.TradeLastDay(stock_user, stock_pass);
                    SetTradeLastDay();
                    du.UpdateData(ref LastDay_DS);
                }
                catch (Exception e)
                {
                    Stat_NoConnection(true);
#if DEBUG
                    Log.WriteLog(e.ToString());
#else
                    Log.WriteLog(CStock.Properties.Resources.ERROR_CONNECTION);
#endif

                    for (int i = 0; i < Settings.Update_Time; i++)
                    {
                        if (ExitFlag)
                            break;
                        Thread.Sleep(1000);
                    }
                }
                Stat_NoConnection(false);
                for (int i = 0; i < Settings.Update_Time; i++)
                {
                    if (ExitFlag)
                        break;
                    Thread.Sleep(1000);
                }
            }
        }
        //A function and delegate defined because only creating thread can change form status;
        delegate void Stat_NoConnCallback(bool visibility);

        private void Stat_NoConnection(bool visibility)
        {
            if (this.LastTradeDay_Stat.InvokeRequired)
            {
                Stat_NoConnCallback s = new Stat_NoConnCallback(Stat_NoConnection);
                this.Invoke(s,new object[] {visibility});
            }
            else
            {
                this.LastTradeDay_Stat.Visible = visibility;
                this.LastTradeDay_Stat.Text = CStock.Properties.Resources.NOCONNECTION;
            }
        }

        delegate void SetTradeLastDayCallBack();

        private void SetTradeLastDay()
        {
            if (LastDayTrade_DG.InvokeRequired)
            {
                SetTradeLastDayCallBack sc = new SetTradeLastDayCallBack(SetTradeLastDay);
                this.Invoke(sc);
            }
            else
            {
                this.LastDayTrade_DG.AutoGenerateColumns = false;
                this.LastDayTrade_DG.DataSource = LastDay_DS.Tables[0];
            }
        }
        private void CStock_Form_Load(object sender, EventArgs e)
        {
            ThreadStart updata= new ThreadStart(Update_Data);
            thread_UpData = new Thread(updata);
            TradeLastDay_DBUpdate du = new TradeLastDay_DBUpdate();
            du.UpdateData(ref LastDay_DS);
            //thread_UpData.Start();
        }

        private void ExitToolStripMenuItem_Click(object sender, FormClosedEventArgs e)
        {
            ExitFlag = true;
            Application.Exit();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            ExitFlag = true;
            Application.Exit();
        }

        private void Sec15MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 15;
        }

        private void Sec30MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 30;
        }

        private void Min1MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 60;
        }

        private void Min2MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 120;
        }

        private void Min5MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 300;
        }

        private void Min10MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 600;
        }

        private void Min15MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 900;
        }

        private void Hour1MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 3600;
        }

        private void Hour2MenuItem_Click(object sender, EventArgs e)
        {
            Settings.Update_Time = 7200;
        }

        private void CustomUpTimeMenuItem_Click(object sender, EventArgs e)
        {
            Form custom = new CustomUpTime();
            custom.ShowDialog();
        }

        private void ViewMenuItem_Click(object sender, EventArgs e)
        {
            switch (Settings.Update_Time)
            {
                case 15:
                    this.Sec15MenuItem.Checked = true;
                    break;
                case 30 :
                    this.Sec30MenuItem.Checked = true;
                    break;
                case 60:
                    this.Min1MenuItem.Checked = true;
                    break;
                case 300:
                    this.Min5MenuItem.Checked = true;
                    break;
                case 600:
                    this.Min10MenuItem.Checked = true;
                    break;
                case 900:
                    this.Min15MenuItem.Checked = true;
                    break;
                case 3600:
                    this.Hour1MenuItem.Checked = true;
                    break;
                case 7200:
                    this.Hour2MenuItem.Checked = true;
                    break;
                default:
                    this.CustomUpTimeMenuItem.Checked = true;
                    break;
            }
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            Form opt = new Options();
            opt.ShowDialog();
        }
    }

    public enum SetCode  //Settings Code
	{
        IPADDR = 0,
        PORT,
        USERNAME,
        PASSWORD,
        SERVER_TYPE,
        UPDATE_TIME	         
	}
    public class Settings
    {
        private static string _ip_addr = "127.0.0.1";
        private static UInt16 _port = 1403;
        private static string _username;
        private static string _password;
        private static int _Server_Type = 0; //0 means local,1 means remote
        private static UInt16 _Update_Time = 60;  //Time in seconds

        public static string ip_addr
        {
            get {return _ip_addr;}
            set 
            {
                _ip_addr = value;
                UpdateRegistry(_ip_addr,SetCode.IPADDR);
            }
        }
        public static UInt16 port
        {
            get {return _port;}
            set
            {
                _port = value;
                UpdateRegistry(_port.ToString(),SetCode.PORT);
            }
        }
        public static string username
        {
            get {return _username;}
            set
            {
                _username = value;
                UpdateRegistry(_username,SetCode.USERNAME);
            }
        }
        public static string password 
        { 
            get {return _password;}
            set
            {
                _password = value;
                UpdateRegistry(_password,SetCode.PASSWORD);
            }
        }
        public static int Server_Type
        {
            get {return _Server_Type;}
            set
            {
                _Server_Type = value;
                UpdateRegistry(_Server_Type.ToString(),SetCode.SERVER_TYPE);
            }
        }
        public static UInt16 Update_Time
        {
            get {return _Update_Time;}
            set
            {
                _Update_Time = value;
                UpdateRegistry(_Update_Time.ToString(),SetCode.UPDATE_TIME);
            }
        }
        private static void UpdateRegistry(string set_value,SetCode setCode)
        {
            RegistryKey rootKey = Registry.LocalMachine.OpenSubKey("Software\\CStock\\Settings",RegistryKeyPermissionCheck.ReadWriteSubTree);
            switch (setCode)
            {
                case SetCode.IPADDR:
                    rootKey.SetValue("ip_addr", set_value);                   
                    break;
                case SetCode.PASSWORD:
                    rootKey.SetValue("password", set_value);
                    break;
                case SetCode.PORT:
                    rootKey.SetValue("port", set_value);
                    break;
                case SetCode.SERVER_TYPE:
                    rootKey.SetValue("Server_Type", set_value);
                    break;
                case SetCode.UPDATE_TIME:
                    rootKey.SetValue("Update_Time", set_value);
                    break;
                case SetCode.USERNAME:
                    rootKey.SetValue("username", set_value);
                    break;
            }
        }
        public static bool InitializeSettings()
        {
            try
            {
                RegistryKey rootKey = Registry.LocalMachine.OpenSubKey("Software",RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (rootKey.OpenSubKey("CStock") == null)
                    rootKey.CreateSubKey("CStock");
                rootKey = rootKey.OpenSubKey("CStock",RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (rootKey.OpenSubKey("Settings") == null)
                    rootKey.CreateSubKey("Settings");
                rootKey = rootKey.OpenSubKey("Settings",RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (rootKey.GetValue("ip_addr") == null)
                    rootKey.SetValue("ip_addr", "127.0.0.1");
               Settings.ip_addr =  (string)rootKey.GetValue("ip_addr");
                if (rootKey.GetValue("port") == null)
                    rootKey.SetValue("port", "1403");
                Settings.port = Convert.ToUInt16(rootKey.GetValue("port"));
                if (rootKey.GetValue("username") == null)
                    rootKey.SetValue("username", "");
                Settings.username = (string)rootKey.GetValue("username");
                if (rootKey.GetValue("password") == null)
                    rootKey.SetValue("password", "");
                Settings.password = (string)rootKey.GetValue("password");
                if (rootKey.GetValue("Server_Type") == null)
                    rootKey.SetValue("Server_Type", "0");
                Settings.Server_Type = Convert.ToInt32(rootKey.GetValue("Server_Type"));
                if (rootKey.GetValue("Update_Time") == null)
                    rootKey.SetValue("Update_Time", "60");
                Settings.Update_Time = Convert.ToUInt16(rootKey.GetValue("Update_Time"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }
    }
    
}
