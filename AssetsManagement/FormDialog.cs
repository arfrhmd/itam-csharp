using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace AssetsManagement
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnShowLicense_Click(object sender, EventArgs e)
        {
            if (cmbLibrary.Text == "SQLite")
            {
                string url = "https://www.sqlite.org/copyright.html";
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = url
                }).Dispose();
            }
            else if (cmbLibrary.Text == "QRCoder")
            {
                string url = "https://github.com/codebude/QRCoder/blob/master/LICENSE.txt";
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = url
                }).Dispose();
            }
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nama\t: Arif Rahmadi Wibowo\nNIM\t: 411221163\nProdi\t: Teknik Informatika", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
