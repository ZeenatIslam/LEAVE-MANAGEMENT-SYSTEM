using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System.PAL.Forms
{
    public partial class LoginHRForm : KryptonForm
    {
        public LoginHRForm()
        {
            InitializeComponent();
        }

        private void LoginHRForm_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AdminMForm ad = new AdminMForm();
            ad.ShowDialog();
            this.Close();
        }
    }
}
