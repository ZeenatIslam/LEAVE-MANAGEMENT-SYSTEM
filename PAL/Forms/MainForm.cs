using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System.PAL.Forms
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
           // InitializeUI("UIMode");
        }
      /*  private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light ")
                {
                    this.ForeColor = Color.FromArgb(250, 250, 250);
                    this.BackColor = Color.FromArgb(250, 250, 250);
                    //flowLayoutPanel1.BackColor = Color.FromArgb(245, 246, 250);
                    ConfigurationManager.AppSettings[key] = "dark";
                }
                else
                {
                    this.ForeColor = Color.FromArgb(245, 246, 250);
                    this.BackColor = Color.FromArgb(94, 23, 235);
                    ConfigurationManager.AppSettings[key] = "light";
                }

            }
            catch (Exception ex)
            {
                throw;

            }

        }*/
       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }



       /* private void button1_Click_1(object sender, EventArgs e)
        {
            InitializeUI("dark");

            this.Refresh();

        }*/

        private void SignInasEmp_Click(object sender, EventArgs e)
        {
            LoginForm Lf = new LoginForm();
            Lf.ShowDialog();
            this.Close();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LoginHRForm HR = new LoginHRForm();
            HR.ShowDialog();
            this.Close();
        }
    }
}
