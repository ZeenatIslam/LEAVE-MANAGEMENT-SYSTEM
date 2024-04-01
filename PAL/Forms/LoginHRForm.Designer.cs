namespace Leave_Management_System.PAL.Forms
{
    partial class LoginHRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginHRForm));
            pictureBox1 = new PictureBox();
            kryptonLinkLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(83, 86, 255);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(629, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 732);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // kryptonLinkLabel1
            // 
            kryptonLinkLabel1.Location = new Point(314, 283);
            kryptonLinkLabel1.Margin = new Padding(4, 3, 4, 3);
            kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            kryptonLinkLabel1.Size = new Size(136, 24);
            kryptonLinkLabel1.TabIndex = 5;
            kryptonLinkLabel1.Values.Text = "Forget Password ?";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(82, 283);
            kryptonLabel1.Margin = new Padding(4, 3, 4, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(224, 24);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Invaalid Username or Password";
            // 
            // kryptonButton1
            // 
            kryptonButton1.AutoSize = true;
            kryptonButton1.Location = new Point(157, 346);
            kryptonButton1.Margin = new Padding(4, 3, 4, 3);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(212, 51);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 254);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(6, 142, 255);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(86, 86, 255);
            kryptonButton1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Width = 0;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.Text = "SignIn";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(77, 137);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 32);
            textBox3.TabIndex = 6;
            textBox3.Text = "Username";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(77, 210);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 32);
            textBox4.TabIndex = 7;
            textBox4.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(kryptonButton1);
            groupBox1.Controls.Add(kryptonLinkLabel1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(23, 46);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(557, 655);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login as Admin";
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Rounding = 20;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 20;
            // 
            // LoginHRForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1160, 732);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginHRForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginHRForm";
            Load += LoginHRForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}