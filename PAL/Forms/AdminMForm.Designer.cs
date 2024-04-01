namespace Leave_Management_System.PAL.Forms
{
    partial class AdminMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMForm));
            sidebarPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            button1 = new Button();
            DepartSecButton = new Button();
            Reportbutton = new Button();
            EmpButton = new Button();
            LeaveButton = new Button();
            DashButton = new Button();
            label1 = new Label();
            ToggleSidebarButton = new PictureBox();
            kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            leaveTypeuc2 = new AdminUserControlForms.LeaveTypeUC();
            departmentuc2 = new AdminUserControlForms.DepartmentUC();
            empSectionuc2 = new EmpUserControlForms.EmpSectionUC();
            dashboarduc2 = new AdminUserControlForms.DashboardUC();
            kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).BeginInit();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToggleSidebarButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(button1);
            sidebarPanel.Controls.Add(DepartSecButton);
            sidebarPanel.Controls.Add(Reportbutton);
            sidebarPanel.Controls.Add(EmpButton);
            sidebarPanel.Controls.Add(LeaveButton);
            sidebarPanel.Controls.Add(DashButton);
            sidebarPanel.Controls.Add(label1);
            sidebarPanel.Controls.Add(ToggleSidebarButton);
            sidebarPanel.Controls.Add(kryptonPanel1);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(4, 3, 4, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Palette = kryptonPalette2;
            sidebarPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            sidebarPanel.Size = new Size(250, 779);
            sidebarPanel.TabIndex = 1;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 86, 255);
            button1.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 453);
            button1.Name = "button1";
            button1.Size = new Size(244, 57);
            button1.TabIndex = 22;
            button1.Text = "         Staff Section";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DepartSecButton
            // 
            DepartSecButton.BackColor = Color.FromArgb(83, 86, 255);
            DepartSecButton.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            DepartSecButton.FlatStyle = FlatStyle.Flat;
            DepartSecButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartSecButton.ForeColor = Color.White;
            DepartSecButton.Image = (Image)resources.GetObject("DepartSecButton.Image");
            DepartSecButton.ImageAlign = ContentAlignment.MiddleLeft;
            DepartSecButton.Location = new Point(3, 390);
            DepartSecButton.Name = "DepartSecButton";
            DepartSecButton.Size = new Size(244, 57);
            DepartSecButton.TabIndex = 21;
            DepartSecButton.Text = "     Department Section";
            DepartSecButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DepartSecButton.UseVisualStyleBackColor = false;
            DepartSecButton.Click += DepartSecButton_Click;
            // 
            // Reportbutton
            // 
            Reportbutton.BackColor = Color.FromArgb(83, 86, 255);
            Reportbutton.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            Reportbutton.FlatStyle = FlatStyle.Flat;
            Reportbutton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reportbutton.ForeColor = Color.White;
            Reportbutton.Image = (Image)resources.GetObject("Reportbutton.Image");
            Reportbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Reportbutton.Location = new Point(3, 201);
            Reportbutton.Name = "Reportbutton";
            Reportbutton.Size = new Size(243, 57);
            Reportbutton.TabIndex = 19;
            Reportbutton.Text = " Report";
            Reportbutton.UseVisualStyleBackColor = false;
            Reportbutton.Click += Reportbutton_Click;
            // 
            // EmpButton
            // 
            EmpButton.BackColor = Color.FromArgb(83, 86, 255);
            EmpButton.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            EmpButton.FlatStyle = FlatStyle.Flat;
            EmpButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpButton.ForeColor = Color.White;
            EmpButton.Image = (Image)resources.GetObject("EmpButton.Image");
            EmpButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmpButton.Location = new Point(3, 327);
            EmpButton.Name = "EmpButton";
            EmpButton.Size = new Size(244, 57);
            EmpButton.TabIndex = 19;
            EmpButton.Text = "     Employee Section";
            EmpButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EmpButton.UseVisualStyleBackColor = false;
            EmpButton.Click += EmpButton_Click;
            // 
            // LeaveButton
            // 
            LeaveButton.BackColor = Color.FromArgb(83, 86, 255);
            LeaveButton.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            LeaveButton.FlatStyle = FlatStyle.Flat;
            LeaveButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeaveButton.ForeColor = Color.White;
            LeaveButton.Image = (Image)resources.GetObject("LeaveButton.Image");
            LeaveButton.ImageAlign = ContentAlignment.MiddleLeft;
            LeaveButton.Location = new Point(3, 264);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(243, 57);
            LeaveButton.TabIndex = 20;
            LeaveButton.Text = "        Leave Type";
            LeaveButton.UseVisualStyleBackColor = false;
            LeaveButton.Click += LeaveButton_Click;
            // 
            // DashButton
            // 
            DashButton.BackColor = Color.FromArgb(83, 86, 255);
            DashButton.FlatAppearance.BorderColor = Color.FromArgb(6, 142, 255);
            DashButton.FlatStyle = FlatStyle.Flat;
            DashButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashButton.ForeColor = Color.White;
            DashButton.Image = (Image)resources.GetObject("DashButton.Image");
            DashButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashButton.Location = new Point(3, 138);
            DashButton.Name = "DashButton";
            DashButton.Size = new Size(243, 57);
            DashButton.TabIndex = 18;
            DashButton.Text = "         Dashboard";
            DashButton.UseVisualStyleBackColor = false;
            DashButton.Click += DashButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 69);
            label1.TabIndex = 1;
            label1.Text = "      Leave \r\nManagement \r\n     System\r\n";
            // 
            // ToggleSidebarButton
            // 
            ToggleSidebarButton.BackColor = Color.Transparent;
            ToggleSidebarButton.Image = (Image)resources.GetObject("ToggleSidebarButton.Image");
            ToggleSidebarButton.Location = new Point(13, 12);
            ToggleSidebarButton.Margin = new Padding(4, 3, 4, 3);
            ToggleSidebarButton.Name = "ToggleSidebarButton";
            ToggleSidebarButton.Size = new Size(59, 63);
            ToggleSidebarButton.TabIndex = 1;
            ToggleSidebarButton.TabStop = false;
            ToggleSidebarButton.Click += pictureBox1_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(405, 0);
            kryptonPanel1.Margin = new Padding(4, 3, 4, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1356, 97);
            kryptonPanel1.TabIndex = 2;
            // 
            // kryptonPalette2
            // 
            kryptonPalette2.ButtonStyles.ButtonButtonSpec.StateCheckedTracking.Back.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette2.ButtonStyles.ButtonButtonSpec.StateCommon.Back.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette2.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette2.ButtonStyles.ButtonButtonSpec.StatePressed.Back.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette2.FormStyles.FormCommon.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette2.FormStyles.FormCommon.StateActive.Border.Rounding = 20;
            kryptonPalette2.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette2.FormStyles.FormCommon.StateCommon.Border.Rounding = 20;
            kryptonPalette2.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette2.PanelStyles.PanelCommon.StateCommon.Color2 = Color.FromArgb(83, 86, 255);
            // 
            // timer1
            // 
            timer1.Tick += animationTimer;
            // 
            // panel1
            // 
            panel1.Controls.Add(leaveTypeuc2);
            panel1.Controls.Add(departmentuc2);
            panel1.Controls.Add(empSectionuc2);
            panel1.Controls.Add(dashboarduc2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(250, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 776);
            panel1.TabIndex = 4;
            // 
            // leaveTypeuc2
            // 
            leaveTypeuc2.BackColor = Color.FromArgb(214, 229, 250);
            leaveTypeuc2.BorderStyle = BorderStyle.FixedSingle;
            leaveTypeuc2.Location = new Point(-2, -3);
            leaveTypeuc2.Name = "leaveTypeuc2";
            leaveTypeuc2.Size = new Size(1158, 971);
            leaveTypeuc2.TabIndex = 3;
            // 
            // departmentuc2
            // 
            departmentuc2.BackColor = Color.FromArgb(161, 234, 251);
            departmentuc2.Location = new Point(-2, -3);
            departmentuc2.Name = "departmentuc2";
            departmentuc2.Size = new Size(1158, 971);
            departmentuc2.TabIndex = 2;
            // 
            // empSectionuc2
            // 
            empSectionuc2.BackColor = Color.FromArgb(150, 239, 255);
            empSectionuc2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empSectionuc2.Location = new Point(0, -3);
            empSectionuc2.Margin = new Padding(4, 3, 4, 3);
            empSectionuc2.Name = "empSectionuc2";
            empSectionuc2.Size = new Size(1160, 974);
            empSectionuc2.TabIndex = 1;
            // 
            // dashboarduc2
            // 
            dashboarduc2.BackColor = Color.FromArgb(223, 245, 255);
            dashboarduc2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboarduc2.Location = new Point(0, -3);
            dashboarduc2.Margin = new Padding(4, 3, 4, 3);
            dashboarduc2.Name = "dashboarduc2";
            dashboarduc2.Size = new Size(1160, 974);
            dashboarduc2.TabIndex = 0;
            dashboarduc2.Visible = false;
            // 
            // kryptonContextMenu1
            // 
            kryptonContextMenu1.Enabled = false;
            // 
            // AdminMForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 779);
            Controls.Add(panel1);
            Controls.Add(sidebarPanel);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMForm";
            Load += AdminMForm_Load;
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToggleSidebarButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel sidebarPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PictureBox ToggleSidebarButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label1;
        private AdminUserControlForms.DashboardUC dashboarduc1;
        private EmpUserControlForms.EmpSectionUC empSectionuc1;
        private AdminUserControlForms.DepartmentUC departmentuc1;
        private AdminUserControlForms.LeaveTypeUC leaveTypeuc1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private AdminUserControlForms.DashboardUC dashboarduc2;
        private EmpUserControlForms.EmpSectionUC empSectionuc2;
        private AdminUserControlForms.DepartmentUC departmentuc2;
        private AdminUserControlForms.LeaveTypeUC leaveTypeuc2;
        private Button DashButton;
        private Button Reportbutton;
        private Button EmpButton;
        private Button LeaveButton;
        private Button DepartSecButton;
        private Button button1;
    }
}