using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CStock
{
    public partial class CustomUpTime : Form
    {
        public CustomUpTime()
        {
            InitializeComponent();
        }

        private void CustomUpTimeOK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ushort a = Convert.ToUInt16(this.CustomUpTimetextBox.Text, 10);
                if ((a > 7200) && (a < 0))
                    throw new System.ArgumentException();

                Settings.Update_Time = a;

            }
            catch (Exception)
            {
                MessageBox.Show("مقدار وارد شده برای زمان به روزآوری صحیح نمی باشد.لطفا مقداری بین 30 تا 7200 وارد نمایید", "خطا!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }
        }
    }
}
