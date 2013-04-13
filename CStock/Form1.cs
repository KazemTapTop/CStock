﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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

        private void تنظیماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newOpt = new Options();
            newOpt.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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