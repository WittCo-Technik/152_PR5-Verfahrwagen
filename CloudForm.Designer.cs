namespace EB_Erkennung
{
    partial class CloudForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            txtMatchCode = new TextBox();
            textBezeichnung = new TextBox();
            textBW = new TextBox();
            textWB = new TextBox();
            textNS = new TextBox();
            textWGU = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            textVer = new TextBox();
            textUN = new TextBox();
            PostCloudButton = new Button();
            textCloud = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBoxLangText = new TextBox();
            label11 = new Label();
            textBoxSelbsteinstufung = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(500, 0, 0, 0);
            label1.Size = new Size(719, 38);
            label1.TabIndex = 0;
            label1.Text = "CLOUD UPLOAD";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(332, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 3;
            // 
            // txtMatchCode
            // 
            txtMatchCode.Anchor = AnchorStyles.None;
            txtMatchCode.Location = new Point(332, 309);
            txtMatchCode.Name = "txtMatchCode";
            txtMatchCode.Size = new Size(227, 27);
            txtMatchCode.TabIndex = 4;
            // 
            // textBezeichnung
            // 
            textBezeichnung.Anchor = AnchorStyles.None;
            textBezeichnung.Location = new Point(327, 406);
            textBezeichnung.Name = "textBezeichnung";
            textBezeichnung.Size = new Size(227, 27);
            textBezeichnung.TabIndex = 5;
            // 
            // textBW
            // 
            textBW.Anchor = AnchorStyles.None;
            textBW.Location = new Point(332, 505);
            textBW.Name = "textBW";
            textBW.Size = new Size(227, 27);
            textBW.TabIndex = 6;
            // 
            // textWB
            // 
            textWB.Anchor = AnchorStyles.None;
            textWB.Location = new Point(332, 602);
            textWB.Name = "textWB";
            textWB.Size = new Size(227, 27);
            textWB.TabIndex = 7;
            // 
            // textNS
            // 
            textNS.Anchor = AnchorStyles.None;
            textNS.Location = new Point(332, 690);
            textNS.Name = "textNS";
            textNS.Size = new Size(227, 27);
            textNS.TabIndex = 8;
            // 
            // textWGU
            // 
            textWGU.Anchor = AnchorStyles.None;
            textWGU.AutoSize = true;
            textWGU.Location = new Point(369, 187);
            textWGU.Name = "textWGU";
            textWGU.Size = new Size(99, 20);
            textWGU.TabIndex = 9;
            textWGU.Text = "Warengruppe";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(351, 273);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 10;
            label2.Text = "MatchCode";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(351, 366);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 11;
            label3.Text = "Bezeichnung";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(351, 463);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 12;
            label4.Text = "K_Blasenwechsel";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(351, 561);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 13;
            label5.Text = "K_Waschbar";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(351, 653);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 14;
            label6.Text = "K_NeutralisationSperrlager";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(643, 273);
            label8.Name = "label8";
            label8.Size = new Size(211, 20);
            label8.TabIndex = 19;
            label8.Text = "K_VerschmutzungsgradProzent";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(643, 187);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 18;
            label9.Text = "K_UNNummer";
            // 
            // textVer
            // 
            textVer.Anchor = AnchorStyles.None;
            textVer.Location = new Point(627, 309);
            textVer.Name = "textVer";
            textVer.Size = new Size(227, 27);
            textVer.TabIndex = 16;
            // 
            // textUN
            // 
            textUN.Anchor = AnchorStyles.None;
            textUN.Location = new Point(627, 221);
            textUN.Name = "textUN";
            textUN.Size = new Size(227, 27);
            textUN.TabIndex = 15;
            // 
            // PostCloudButton
            // 
            PostCloudButton.Anchor = AnchorStyles.None;
            PostCloudButton.Location = new Point(886, 127);
            PostCloudButton.Name = "PostCloudButton";
            PostCloudButton.Size = new Size(383, 590);
            PostCloudButton.TabIndex = 21;
            PostCloudButton.Text = "POST";
            PostCloudButton.UseVisualStyleBackColor = true;
            PostCloudButton.Click += PostCloudButton_Click;
            // 
            // textCloud
            // 
            textCloud.Anchor = AnchorStyles.None;
            textCloud.Location = new Point(627, 460);
            textCloud.Multiline = true;
            textCloud.Name = "textCloud";
            textCloud.Size = new Size(227, 257);
            textCloud.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(375, 98);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 25;
            label7.Text = "ArtikelNummer";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(332, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 24;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(638, 366);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 27;
            label10.Text = "LangText";
            // 
            // textBoxLangText
            // 
            textBoxLangText.Anchor = AnchorStyles.None;
            textBoxLangText.Location = new Point(627, 406);
            textBoxLangText.Name = "textBoxLangText";
            textBoxLangText.Size = new Size(227, 27);
            textBoxLangText.TabIndex = 26;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(652, 98);
            label11.Name = "label11";
            label11.Size = new Size(133, 20);
            label11.TabIndex = 29;
            label11.Text = "K_Selbsteinstufung";
            // 
            // textBoxSelbsteinstufung
            // 
            textBoxSelbsteinstufung.Anchor = AnchorStyles.None;
            textBoxSelbsteinstufung.Location = new Point(627, 140);
            textBoxSelbsteinstufung.Name = "textBoxSelbsteinstufung";
            textBoxSelbsteinstufung.Size = new Size(227, 27);
            textBoxSelbsteinstufung.TabIndex = 28;
            // 
            // CloudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1301, 820);
            Controls.Add(label11);
            Controls.Add(textBoxSelbsteinstufung);
            Controls.Add(label10);
            Controls.Add(textBoxLangText);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textCloud);
            Controls.Add(PostCloudButton);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textVer);
            Controls.Add(textUN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textWGU);
            Controls.Add(textNS);
            Controls.Add(textWB);
            Controls.Add(textBW);
            Controls.Add(textBezeichnung);
            Controls.Add(txtMatchCode);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CloudForm";
            Text = "CloudForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtMatchCode;
        private TextBox textBezeichnung;
        private TextBox textBW;
        private TextBox textWB;
        private TextBox textNS;
        private Label textWGU;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox textVer;
        private TextBox textUN;
        private Button PostCloudButton;
        private TextBox textCloud;
        private Label label7;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBoxLangText;
        private Label label11;
        private TextBox textBoxSelbsteinstufung;
    }
}