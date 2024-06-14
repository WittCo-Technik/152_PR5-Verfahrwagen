using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EB_Erkennung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadForm(Form form)
        {
            if (panelDesktop.Controls.Count > 0)
                panelDesktop.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.Show();
        }
        private void iconButtonList_Click(object sender, EventArgs e)
        {
            LoadForm(new ListForm());
        }
        private void iconButtonImageUpload_Click_1(object sender, EventArgs e)
        {
            LoadForm(new ImageForm());
        }
        private void iconButtonCloud_Click_1(object sender, EventArgs e)
        {
            LoadForm(new CloudForm());
        }
        private void iconButtonSPS_Click(object sender, EventArgs e)
        {
            LoadForm(new SPS());
        }
    }
}
