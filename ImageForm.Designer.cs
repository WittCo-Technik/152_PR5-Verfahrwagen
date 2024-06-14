namespace EB_Erkennung
{
    partial class ImageForm
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            buttonQR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(450, 100);
            button1.Name = "button1";
            button1.Size = new Size(722, 74);
            button1.TabIndex = 0;
            button1.Text = "Bild Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(453, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(716, 578);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(450, 174);
            button2.Name = "button2";
            button2.Size = new Size(722, 74);
            button2.TabIndex = 2;
            button2.Text = "OCR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonQR
            // 
            buttonQR.Anchor = AnchorStyles.None;
            buttonQR.Location = new Point(1215, 103);
            buttonQR.Name = "buttonQR";
            buttonQR.Size = new Size(175, 74);
            buttonQR.TabIndex = 3;
            buttonQR.Text = "QR";
            buttonQR.UseVisualStyleBackColor = true;
            buttonQR.Click += buttonQR_Click;
            // 
            // ImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1622, 943);
            ControlBox = false;
            Controls.Add(buttonQR);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ImageForm";
            Padding = new Padding(450, 100, 450, 100);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button buttonQR;
    }
}