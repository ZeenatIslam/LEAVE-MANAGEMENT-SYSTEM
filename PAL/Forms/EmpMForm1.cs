using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Leave_Management_System.PAL.Forms
{
    public partial class EmpMForm1 : KryptonForm

    {
        private bool isSidebarHidden = true;
        private int sidebarWidth = 250;

        public EmpMForm1()
        {
            InitializeComponent();
            // Configure your sidebar panel here
            sidebarPanel.Width = 80; // Hide sidebar initially


            timer.Interval = 10; // Adjust for desired animation speed
            //animationTimer.Tick += AnimationTimer_Tick;

        }
        private void EmpMForm1_Load(object sender, EventArgs e)
        {

        }

        private void ToggleSidebarButton_Click_1(object sender, EventArgs e)
        {
            isSidebarHidden = !isSidebarHidden;
            timer.Start();
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int movement = isSidebarHidden ? 10 : -10;
            int newWidth = sidebarPanel.Width + movement;

            if (isSidebarHidden && newWidth >= sidebarWidth)
            {
                newWidth = sidebarWidth;
                timer.Stop();
            }
            else if (!isSidebarHidden && newWidth <= 80)
            {
                newWidth = 80;
                timer.Stop();
            }

            sidebarPanel.Width = newWidth;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LeaveFormButton_Click_1(object sender, EventArgs e)
        {
        }

        private void PersonalizeButton_Click(object sender, EventArgs e)
        {
            EmpDashUserC.Visible = false;
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            EmpDashUserC.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpDashUserC.Visible = false;

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
