using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System.PAL.Forms.EmpUserControlForms
{
    public partial class EmpSectionUC : UserControl
    {
        public EmpSectionUC()
        {
            InitializeComponent();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            AddEmpSecForm f = new AddEmpSecForm();
            f.ShowDialog();
        }
    }
}
