using ComponentFactory.Krypton.Toolkit;
using Leave_Management_System.PAL.Forms.AdminUserControlForms;
using Leave_Management_System.PAL.Forms.EmpUserControlForms;
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

    public partial class AdminMForm : KryptonForm
    {
        private bool isSidebarHidden = true;
        private int sidebarWidth = 250;

        public AdminMForm()
        {
            InitializeComponent();
            // Configure your sidebar panel here
            sidebarPanel.Width = 80
                ; // Hide sidebar initially


            timer1.Interval = 10; // Adjust for desired animation speed
            //animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AdminMForm_Load(object sender, EventArgs e)
        {

        }

        private void animationTimer(object sender, EventArgs e)
        {
            int movement = isSidebarHidden ? 10 : -10;
            int newWidth = sidebarPanel.Width + movement;

            if (isSidebarHidden && newWidth >= sidebarWidth)
            {
                newWidth = sidebarWidth;
                timer1.Stop();
            }
            else if (!isSidebarHidden && newWidth <= 80)
            {
                newWidth = 80;
                timer1.Stop();
            }

            sidebarPanel.Width = newWidth;
        }

        private void ToggleSidebarButton_Click(object sender, EventArgs e)
        {
            isSidebarHidden = !isSidebarHidden;
            timer1.Start();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isSidebarHidden = !isSidebarHidden;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }



        private void B2_Click(object sender, EventArgs e)
        {
            dashboarduc2.Visible = false;
            empSectionuc2.Visible = false;
            leaveTypeuc2.Visible = false;
            departmentuc2.Visible = false;
        }



        private void DepartmentSButton_Click(object sender, EventArgs e)
        {
            departmentuc2.Visible = true;
            empSectionuc2.Visible = true;
            leaveTypeuc2.Visible = false;
            dashboarduc2.Visible = false;




        }

        private void StaffSB_Click(object sender, EventArgs e)
        {
            leaveTypeuc2.Visible = false;
            empSectionuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void B3_Click(object sender, EventArgs e)
        {
            leaveTypeuc2.Visible = true;
            empSectionuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportB2_Click(object sender, EventArgs e)
        {

            dashboarduc2.Visible = false;
            empSectionuc2.Visible = false;
            leaveTypeuc2.Visible = false;
            departmentuc2.Visible = false;

        }



        private void EmpB4_Click(object sender, EventArgs e)
        {

            empSectionuc2.Visible = true;
            leaveTypeuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;


        }

        private void DashboardButton_Click_1(object sender, EventArgs e)
        {

            dashboarduc2.Visible = true;
            empSectionuc2.Visible = false;
            leaveTypeuc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void DashButton_Click(object sender, EventArgs e)
        {

            dashboarduc2.Visible = true;
            empSectionuc2.Visible = false;
            leaveTypeuc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            dashboarduc2.Visible = false;
            empSectionuc2.Visible = false;
            leaveTypeuc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            leaveTypeuc2.Visible = true;
            empSectionuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;


        }

        private void EmpButton_Click(object sender, EventArgs e)
        {

            empSectionuc2.Visible = true;
            leaveTypeuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;

        }

        private void DepartSecButton_Click(object sender, EventArgs e)
        {
            departmentuc2.Visible = true;
            empSectionuc2.Visible = true;
            leaveTypeuc2.Visible = false;
            dashboarduc2.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            leaveTypeuc2.Visible = false;
            empSectionuc2.Visible = false;
            dashboarduc2.Visible = false;
            departmentuc2.Visible = false;


        }
    }
}
