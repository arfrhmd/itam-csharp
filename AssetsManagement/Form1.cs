using AssetsManagement.controller;

namespace AssetsManagement
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./asset.db"))
            {
                DialogResult pesan = MessageBox.Show("Database belum dibuat.\nApakah anda ingin membuatnya?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pesan == DialogResult.Yes)
                {
                    koneksi.CreateDB();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Anda tidak bisa menggunakan fitur ini karena belum ada database",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./asset.db"))
            {
                DialogResult pesan = MessageBox.Show("Database belum dibuat.\nApakah anda ingin membuatnya?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pesan == DialogResult.Yes)
                {
                    koneksi.CreateDB();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Anda tidak bisa menggunakan fitur ini karena belum ada database",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void btnPrintQR_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./asset.db"))
            {
                DialogResult pesan = MessageBox.Show("Database belum dibuat.\nApakah anda ingin membuatnya?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pesan == DialogResult.Yes)
                {
                    koneksi.CreateDB();
                    Form4 form4 = new Form4();
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("Anda tidak bisa menggunakan fitur ini karena belum ada database",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void btnTentang_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            formDialog.Show();
        }
    }
}