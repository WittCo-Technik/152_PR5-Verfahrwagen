namespace EB_Erkennung
{
    partial class SPS
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
            btnVerbinden = new Button();
            btnSenden = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnVerbinden
            // 
            btnVerbinden.Location = new Point(83, 46);
            btnVerbinden.Name = "btnVerbinden";
            btnVerbinden.Size = new Size(164, 63);
            btnVerbinden.TabIndex = 0;
            btnVerbinden.Text = "Verbinden";
            btnVerbinden.UseVisualStyleBackColor = true;
            // 
            // btnSenden
            // 
            btnSenden.Location = new Point(450, 46);
            btnSenden.Name = "btnSenden";
            btnSenden.Size = new Size(176, 64);
            btnSenden.TabIndex = 1;
            btnSenden.Text = "Senden";
            btnSenden.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 3;
            // 
            // SPS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSenden);
            Controls.Add(btnVerbinden);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SPS";
            Text = "SPS";
            Load += SPS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerbinden;
        private Button btnSenden;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}