namespace Leave_Management_System.PAL.Forms.AdminUserControlForms
{
    partial class LeaveTypeUC
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
            B2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            Leave_Type = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 26);
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
            label1.Size = new Size(278, 34);
            label1.TabIndex = 2;
            label1.Text = "Leave Type Section";
            // 
            // B2
            // 
            B2.AutoSize = true;
            B2.Location = new Point(588, 154);
            B2.Name = "B2";
            B2.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            B2.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            B2.Size = new Size(187, 45);
            B2.StateCommon.Back.Color1 = Color.FromArgb(83, 86, 255);
            B2.StateCommon.Back.Color2 = Color.FromArgb(150, 239, 255);
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
            B2.Values.Text = "Add Leave Type";
            B2.Click += B2_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(83, 189);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(287, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Leave_Type, Description, Created });
            kryptonDataGridView1.Location = new Point(83, 242);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.ReadOnly = true;
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.Size = new Size(655, 328);
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
            kryptonDataGridView1.CellContentClick += kryptonDataGridView1_CellContentClick;
            // 
            // Leave_Type
            // 
            Leave_Type.HeaderText = "Leave Tpye";
            Leave_Type.MinimumWidth = 6;
            Leave_Type.Name = "Leave_Type";
            Leave_Type.ReadOnly = true;
            Leave_Type.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 125;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(kryptonDataGridView1);
            panel2.Controls.Add(kryptonBorderEdge1);
            panel2.Controls.Add(B2);
            panel2.Location = new Point(26, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 637);
            panel2.TabIndex = 10;
            // 
            // LeaveTypeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 229, 250);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LeaveTypeUC";
            Size = new Size(926, 777);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton B2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private DataGridViewTextBoxColumn Leave_Type;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Created;
        private Panel panel2;
    }
}
