namespace Leave_Management_System.PAL.Forms.AdminUserControlForms
{
    partial class DepartmentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            Name = new DataGridViewTextBoxColumn();
            Employee_ID = new DataGridViewTextBoxColumn();
            Joined_Date = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            B2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 80);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 28);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 3;
            label2.Text = "Home / Admin's Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 86, 255);
            label1.Location = new Point(43, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 34);
            label1.TabIndex = 2;
            label1.Text = "Department Section";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(22, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 659);
            panel2.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(878, 659);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(kryptonDataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(870, 626);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " Department List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(kryptonButton1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(870, 626);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Department";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Employee_ID, Joined_Date, DOB, Status });
            kryptonDataGridView1.Location = new Point(72, 347);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.ReadOnly = true;
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.Size = new Size(677, 212);
            kryptonDataGridView1.StateCommon.Background.Color1 = Color.White;
            kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(103, 198, 227);
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(83, 86, 255);
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(128, 255, 255);
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = Color.White;
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = Color.White;
            kryptonDataGridView1.TabIndex = 17;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Employee_ID
            // 
            Employee_ID.HeaderText = "Employee ID";
            Employee_ID.MinimumWidth = 6;
            Employee_ID.Name = "Employee_ID";
            Employee_ID.ReadOnly = true;
            Employee_ID.Width = 125;
            // 
            // Joined_Date
            // 
            Joined_Date.HeaderText = "Joined Date";
            Joined_Date.MinimumWidth = 6;
            Joined_Date.Name = "Joined_Date";
            Joined_Date.ReadOnly = true;
            Joined_Date.Width = 125;
            // 
            // DOB
            // 
            DOB.HeaderText = "Date of Birth";
            DOB.MinimumWidth = 6;
            DOB.Name = "DOB";
            DOB.ReadOnly = true;
            DOB.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(B2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(870, 626);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Department'";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            B2.AutoSize = true;
            B2.Location = new Point(592, 461);
            B2.Name = "B2";
            B2.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            B2.Size = new Size(195, 45);
            B2.StateCommon.Back.Color1 = Color.FromArgb(103, 198, 227);
            B2.StateCommon.Back.Color2 = Color.FromArgb(83, 86, 255);
            B2.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 254);
            B2.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            B2.StateCommon.Border.ColorAngle = 45F;
            B2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            B2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            B2.StateCommon.Border.Rounding = 20;
            B2.StateCommon.Border.Width = 1;
            B2.StateCommon.Content.ShortText.Color1 = Color.White;
            B2.StateCommon.Content.ShortText.Color2 = Color.White;
            B2.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B2.StatePressed.Back.Color1 = Color.FromArgb(83, 86, 225);
            B2.StatePressed.Back.Color2 = Color.FromArgb(86, 86, 225);
            B2.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            B2.StatePressed.Border.Width = 0;
            B2.StatePressed.Content.ShortText.Color1 = Color.White;
            B2.StatePressed.Content.ShortText.Color2 = Color.White;
            B2.TabIndex = 14;
            B2.Values.Text = "Add Department";
            // 
            // kryptonButton1
            // 
            kryptonButton1.AutoSize = true;
            kryptonButton1.Location = new Point(630, 494);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.Size = new Size(172, 45);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(103, 198, 227);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(83, 86, 255);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 254);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(83, 86, 225);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(86, 86, 225);
            kryptonButton1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Width = 0;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.TabIndex = 14;
            kryptonButton1.Values.Text = "Update";
            // 
            // DepartmentUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(161, 234, 251);
            Controls.Add(panel2);
            Controls.Add(panel1);
            //Name = "DepartmentUC";
            Size = new Size(926, 777);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Employee_ID;
        private DataGridViewTextBoxColumn Joined_Date;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Status;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private TabPage tabPage3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B2;
    }
}
