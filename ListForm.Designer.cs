namespace EB_Erkennung
{
    partial class ListForm
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
            ButtonXmlUpload = new Button();
            dataGridViewXML = new DataGridView();
            SearchButton = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewXML).BeginInit();
            SuspendLayout();
            // 
            // ButtonXmlUpload
            // 
            ButtonXmlUpload.Dock = DockStyle.Top;
            ButtonXmlUpload.Location = new Point(0, 0);
            ButtonXmlUpload.Name = "ButtonXmlUpload";
            ButtonXmlUpload.Size = new Size(1336, 73);
            ButtonXmlUpload.TabIndex = 0;
            ButtonXmlUpload.Text = "XML-Datei Hochladen";
            ButtonXmlUpload.UseVisualStyleBackColor = true;
            ButtonXmlUpload.Click += ButtonXmlUpload_Click;
            // 
            // dataGridViewXML
            // 
            dataGridViewXML.AllowUserToAddRows = false;
            dataGridViewXML.AllowUserToDeleteRows = false;
            dataGridViewXML.AllowUserToResizeColumns = false;
            dataGridViewXML.AllowUserToResizeRows = false;
            dataGridViewXML.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewXML.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewXML.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewXML.BackgroundColor = Color.White;
            dataGridViewXML.BorderStyle = BorderStyle.None;
            dataGridViewXML.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewXML.Location = new Point(0, 134);
            dataGridViewXML.Name = "dataGridViewXML";
            dataGridViewXML.ReadOnly = true;
            dataGridViewXML.RowHeadersWidth = 51;
            dataGridViewXML.RowTemplate.Height = 25;
            dataGridViewXML.Size = new Size(1336, 610);
            dataGridViewXML.TabIndex = 1;
            dataGridViewXML.VirtualMode = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(364, 79);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(191, 49);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Suchen";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(84, 90);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(248, 27);
            textBoxSearch.TabIndex = 3;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1336, 744);
            Controls.Add(textBoxSearch);
            Controls.Add(SearchButton);
            Controls.Add(dataGridViewXML);
            Controls.Add(ButtonXmlUpload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListForm";
            Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewXML).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonXmlUpload;
        private DataGridView dataGridViewXML;
        private Button SearchButton;
        private TextBox textBoxSearch;
    }
}