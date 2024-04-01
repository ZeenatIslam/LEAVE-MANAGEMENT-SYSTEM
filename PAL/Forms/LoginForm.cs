using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class LoginForm : KryptonForm
    {
        //MaterialForm f = new MaterialForm();
        int min = 20;
        public LoginForm()
        {

            InitializeComponent();

        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            //  pbCross.Image = Image.FromFile("C:\\Users\\user\\Pictures\\Animated Icon\\import.gif");

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCross_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            EmpMForm1 MF = new EmpMForm1();
            MF.ShowDialog();
            this.Close();
        }

        private void SignInasEmp_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            //groupBox1.Visible = false;
            //pictureBox2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // pictureBox1.Left -= min;

        }
    }

}
