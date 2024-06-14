using EB_Erkennung.Properties;

namespace EB_Erkennung
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            iconButtonSPS = new FontAwesome.Sharp.IconButton();
            iconButtonCloud = new FontAwesome.Sharp.IconButton();
            iconButtonImageUpload = new FontAwesome.Sharp.IconButton();
            iconButtonList = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DeepSkyBlue;
            panelMenu.Controls.Add(iconButtonSPS);
            panelMenu.Controls.Add(iconButtonCloud);
            panelMenu.Controls.Add(iconButtonImageUpload);
            panelMenu.Controls.Add(iconButtonList);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(222, 703);
            panelMenu.TabIndex = 0;
            // 
            // iconButtonSPS
            // 
            iconButtonSPS.Dock = DockStyle.Top;
            iconButtonSPS.FlatAppearance.BorderSize = 0;
            iconButtonSPS.FlatStyle = FlatStyle.Flat;
            iconButtonSPS.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonSPS.ForeColor = Color.MidnightBlue;
            iconButtonSPS.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButtonSPS.IconColor = Color.Blue;
            iconButtonSPS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSPS.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSPS.Location = new Point(0, 299);
            iconButtonSPS.Name = "iconButtonSPS";
            iconButtonSPS.Padding = new Padding(9, 0, 0, 0);
            iconButtonSPS.Size = new Size(222, 58);
            iconButtonSPS.TabIndex = 6;
            iconButtonSPS.Tag = "Cloud";
            iconButtonSPS.Text = "  SPS";
            iconButtonSPS.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSPS.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSPS.UseVisualStyleBackColor = false;
            iconButtonSPS.Click += iconButtonSPS_Click;
            // 
            // iconButtonCloud
            // 
            iconButtonCloud.Dock = DockStyle.Top;
            iconButtonCloud.FlatAppearance.BorderSize = 0;
            iconButtonCloud.FlatStyle = FlatStyle.Flat;
            iconButtonCloud.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonCloud.ForeColor = Color.MidnightBlue;
            iconButtonCloud.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            iconButtonCloud.IconColor = Color.Blue;
            iconButtonCloud.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCloud.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCloud.Location = new Point(0, 241);
            iconButtonCloud.Name = "iconButtonCloud";
            iconButtonCloud.Padding = new Padding(9, 0, 0, 0);
            iconButtonCloud.Size = new Size(222, 58);
            iconButtonCloud.TabIndex = 5;
            iconButtonCloud.Tag = "Cloud";
            iconButtonCloud.Text = "  Cloud Posting";
            iconButtonCloud.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonCloud.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonCloud.UseVisualStyleBackColor = false;
            iconButtonCloud.Click += iconButtonCloud_Click_1;
            // 
            // iconButtonImageUpload
            // 
            iconButtonImageUpload.Dock = DockStyle.Top;
            iconButtonImageUpload.FlatAppearance.BorderSize = 0;
            iconButtonImageUpload.FlatStyle = FlatStyle.Flat;
            iconButtonImageUpload.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonImageUpload.ForeColor = Color.MidnightBlue;
            iconButtonImageUpload.IconChar = FontAwesome.Sharp.IconChar.Images;
            iconButtonImageUpload.IconColor = Color.Blue;
            iconButtonImageUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonImageUpload.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonImageUpload.Location = new Point(0, 177);
            iconButtonImageUpload.Name = "iconButtonImageUpload";
            iconButtonImageUpload.Padding = new Padding(9, 0, 0, 0);
            iconButtonImageUpload.Size = new Size(222, 64);
            iconButtonImageUpload.TabIndex = 4;
            iconButtonImageUpload.Tag = "ImgUpload";
            iconButtonImageUpload.Text = "  Foto Hochladen";
            iconButtonImageUpload.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonImageUpload.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonImageUpload.UseVisualStyleBackColor = true;
            iconButtonImageUpload.Click += iconButtonImageUpload_Click_1;
            // 
            // iconButtonList
            // 
            iconButtonList.Dock = DockStyle.Top;
            iconButtonList.FlatAppearance.BorderSize = 0;
            iconButtonList.FlatStyle = FlatStyle.Flat;
            iconButtonList.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonList.ForeColor = Color.MidnightBlue;
            iconButtonList.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconButtonList.IconColor = Color.Blue;
            iconButtonList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonList.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonList.Location = new Point(0, 119);
            iconButtonList.Name = "iconButtonList";
            iconButtonList.Padding = new Padding(9, 0, 0, 0);
            iconButtonList.Size = new Size(222, 58);
            iconButtonList.TabIndex = 3;
            iconButtonList.Tag = "Liste";
            iconButtonList.Text = "  IBC Liste ";
            iconButtonList.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonList.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonList.UseVisualStyleBackColor = true;
            iconButtonList.Click += iconButtonList_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(222, 119);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.LightSkyBlue;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(222, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(971, 703);
            panelDesktop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 703);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ID_Erkennung";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDesktop;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonList;
        private object resources;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonCloud;
        private FontAwesome.Sharp.IconButton iconButtonImageUpload;
        private FontAwesome.Sharp.IconButton iconButtonSPS;
    }
}
