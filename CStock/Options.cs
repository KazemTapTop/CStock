using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions;
using System.Net;

namespace CStock
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((this.textUpdate_Time.Text != "") && (this.textIP.Text != "") && (this.textPass.Text != "")
                && (this.textPort.Text != "") && (this.textUser.Text != ""))
            {
                try
                {
                    Settings.Update_Time  = Convert.ToUInt16(this.textUpdate_Time.Text, 10);
                }
                catch (Exception)
                {
                    MessageBox.Show("مقدار وارد شده برای زمان به روزآوری صحیح نمی باشد.لطفا مقداری بین 30 تا 7200 وارد نمایید", "خطا!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                try
                {
                    IPAddress ip = IPAddress.Parse(textIP.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("لطفا مقدار آدرس سرور SQL را به صورت مقابل وارد نمایید.***.***.***.***", "خطا!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    return;
                }

                Settings.ip_addr = textIP.Text;

                try
                {
                    Settings.port = Convert.ToUInt16(textPort.Text, 10);
                }
                catch (Exception)
                {
                    MessageBox.Show("لطفا برای مقدار پورت اتصال به پایگاه داده عددی بین 0 تا 65535 وارد فرمایید.", "خطا!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("یکی از انتخابها فاقد مقدار می باشند لطفا آن را وارد نمایید.", "خطا!"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }
            Settings.username = this.textUser.Text;
            Settings.password = this.textPass.Text;
            this.Close();

        }

        private void Options_Load(object sender, EventArgs e)
        {

            cboServer_Type.SelectedIndex    = Settings.Server_Type;
            textIP.Text                     = Settings.ip_addr;
            textPort.Text                   = Settings.port.ToString();
            textPass.Text                   = Settings.password;
            textUser.Text                   = Settings.username;
            textUpdate_Time.Text            = Settings.Update_Time.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboServer_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServer_Type.SelectedIndex == 0)
            {
                textIP.Enabled = false;
            }
            else
                textIP.Enabled = true;
        }
    }
}
