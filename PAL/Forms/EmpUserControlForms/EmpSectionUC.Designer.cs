namespace Leave_Management_System.PAL.Forms.EmpUserControlForms
{
    partial class EmpSectionUC
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            Name = new DataGridViewTextBoxColumn();
            Employee_ID = new DataGridViewTextBoxColumn();
            Joined_Date = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            comboBox1 = new ComboBox();
            B2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
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
            panel1.Size = new Size(928, 80);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 26);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 23);
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
            label1.Size = new Size(260, 34);
            label1.TabIndex = 2;
            label1.Text = "Employee Section";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(kryptonDataGridView1);
            panel2.Controls.Add(kryptonBorderEdge1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(B2);
            panel2.Location = new Point(27, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 637);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 128);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 17;
            label3.Text = "Department";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Employee_ID, Joined_Date, DOB, Status });
            kryptonDataGridView1.Location = new Point(83, 247);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.Palette = kryptonPalette1;
            kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
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
            kryptonDataGridView1.TabIndex = 16;
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
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(83, 189);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(287, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 31);
            comboBox1.TabIndex = 14;
            // 
            // B2
            // 
            B2.AutoSize = true;
            B2.Location = new Point(588, 154);
            B2.Name = "B2";
            B2.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            B2.Size = new Size(172, 45);
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
            B2.TabIndex = 13;
            B2.Values.Text = "Add Employee";
            B2.Click += B2_Click;
            // 
            // EmpSectionUC
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 239, 255);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            //Name = "EmpSectionUC";
            Size = new Size(928, 779);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComboBox comboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Employee_ID;
        private DataGridViewTextBoxColumn Joined_Date;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Status;
        private Label label3;
    }
}
