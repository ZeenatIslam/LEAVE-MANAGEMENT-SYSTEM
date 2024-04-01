using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System.PAL.Forms.AdminUserControlForms
{
    public partial class LeaveTypeUC : UserControl
    {
        public LeaveTypeUC()
        {
            InitializeComponent();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {
            AddLeaveForm lf = new AddLeaveForm();
            lf.ShowDialog();
        }
    }
}
