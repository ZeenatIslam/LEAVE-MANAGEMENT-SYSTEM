namespace Leave_Management_System.PAL.Forms
{
    partial class EmpMForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpMForm1));
            sidebarPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            button1 = new Button();
            LeaveButton = new Button();
            label1 = new Label();
            ToggleSidebarButton = new PictureBox();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            timer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            EmpDashUserC = new EmpDashUserC();
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).BeginInit();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToggleSidebarButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(button1);
            sidebarPanel.Controls.Add(LeaveButton);
            sidebarPanel.Controls.Add(label1);
            sidebarPanel.Controls.Add(ToggleSidebarButton);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Palette = kryptonPalette1;
            sidebarPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            sidebarPanel.Size = new Size(250, 779);
            sidebarPanel.TabIndex = 0;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 86, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 198);
            button1.Name = "button1";
            button1.Size = new Size(234, 60);
            button1.TabIndex = 18;
            button1.Text = "        Personalize";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LeaveButton
            // 
            LeaveButton.BackColor = Color.FromArgb(83, 86, 255);
            LeaveButton.FlatAppearance.BorderSize = 0;
            LeaveButton.FlatStyle = FlatStyle.Flat;
            LeaveButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeaveButton.ForeColor = Color.White;
            LeaveButton.Image = (Image)resources.GetObject("LeaveButton.Image");
            LeaveButton.ImageAlign = ContentAlignment.MiddleLeft;
            LeaveButton.Location = new Point(9, 135);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(234, 57);
            LeaveButton.TabIndex = 17;
            LeaveButton.Text = "         Leave Form";
            LeaveButton.UseVisualStyleBackColor = false;
            LeaveButton.Click += LeaveButton_Click;
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
            label1.TabIndex = 16;
            label1.Text = "      Leave \r\nManagement \r\n     System\r\n";
            // 
            // ToggleSidebarButton
            // 
            ToggleSidebarButton.BackColor = Color.Transparent;
            ToggleSidebarButton.Image = (Image)resources.GetObject("ToggleSidebarButton.Image");
            ToggleSidebarButton.Location = new Point(12, 23);
            ToggleSidebarButton.Name = "ToggleSidebarButton";
            ToggleSidebarButton.Size = new Size(60, 58);
            ToggleSidebarButton.TabIndex = 1;
            ToggleSidebarButton.TabStop = false;
            ToggleSidebarButton.Click += ToggleSidebarButton_Click_1;
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color2 = Color.FromArgb(83, 86, 255);
            kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color1 = Color.FromArgb(83, 86, 255);
            kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color2 = Color.FromArgb(83, 86, 255);
            // 
            // timer
            // 
            timer.Tick += AnimationTimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(EmpDashUserC);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 779);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // EmpDashUserC
            // 
            EmpDashUserC.AutoSize = true;
            EmpDashUserC.BackColor = Color.FromArgb(214, 229, 250);
            EmpDashUserC.Dock = DockStyle.Fill;
            EmpDashUserC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDashUserC.Location = new Point(0, 0);
            EmpDashUserC.Margin = new Padding(4, 3, 4, 3);
            EmpDashUserC.Name = "EmpDashUserC";
            EmpDashUserC.Size = new Size(928, 779);
            EmpDashUserC.TabIndex = 4;
            EmpDashUserC.Visible = false;
            // 
            // EmpMForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 779);
            Controls.Add(panel1);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpMForm1";
            Palette = kryptonPalette1;
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpMForm1";
            Load += EmpMForm1_Load;
            ((System.ComponentModel.ISupportInitialize)sidebarPanel).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToggleSidebarButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel sidebarPanel;
        private System.Windows.Forms.Timer timer;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private PictureBox ToggleSidebarButton;
        private Panel panel1;
        private Label label1;
        private EmpDashUserC EmpDashUserC;
        private Button LeaveButton;
        private Button button1;
    }
}