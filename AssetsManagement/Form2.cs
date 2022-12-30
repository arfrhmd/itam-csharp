using AssetsManagement.controller;
using AssetsManagement.model;

namespace AssetsManagement
{
    public partial class Form2 : Form
    {
        Koneksi koneksi = new Koneksi();
        AddItem addItem = new AddItem();

        public string jenisBarang = "";
        public string katBarang = "";
        public string modelBarang = "";
        public string statusBarang = "";
        public string noUrut = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void generateKodeBarang(string kodeAwal)
        {
            int kode = 0;
            string lastKode = (string)koneksi.LastKodeBarang(kodeAwal);

            if (lastKode != null)
            {
                kode = int.Parse(lastKode.Substring(lastKode.Length - 3));
            }

            if (kode < 10)
            {
                this.noUrut = $"00{kode + 1}"; 
            } else if (kode < 100)
            {
                this.noUrut = $"0{kode + 1}";
            } else if (kode < 1000)
            {
                this.noUrut = $"{kode + 1}";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text == "" || cmbJenisBarang.Text == "" || dateTimePicker1.Text == "" ||
                txtModel.Text == "" || cmbStatus.Text == "")
            {
                if (!radioBekas.Checked && !radioRusak.Checked && !radioBaru.Checked)
                {
                    MessageBox.Show("Anda belum melengkapi keseluruhan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Anda belum melengkapi keseluruhan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Asset_M model = new Asset_M();
                model.Kode_barang = txtKodeBarang.Text;
                model.Jenis = cmbJenisBarang.Text;
                model.Kategori = int.Parse(this.katBarang);
                model.Model = txtModel.Text;
                model.Status = cmbStatus.Text;
                model.Tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm");

                // Execute
                addItem.Insert(model);

                // Hapus semua inputan
                txtKodeBarang.Text = "";
                cmbJenisBarang.Text = "";
                radioBaru.Checked = false;
                radioBekas.Checked = false;
                radioRusak.Checked = false;
                txtModel.Text = "";
                cmbStatus.Text = "";
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void cmbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbJenisBarang.Text)
            {
                case "Komputer":
                    this.jenisBarang = "A";
                    break;
                case "Monitor":
                    this.jenisBarang = "B";
                    break;
                case "Printer":
                    this.jenisBarang = "C";
                    break;
                case "Mouse":
                    this.jenisBarang = "D";
                    break;
                case "Keyboard":
                    this.jenisBarang = "E";
                    break;
            }
        }

        private void radioBaru_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBaru.Checked)
            {
                this.katBarang = "01";
            }
        }

        private void radioBekas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBekas.Checked)
            {
                this.katBarang = "02";
            }
        }

        private void radioRusak_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRusak.Checked)
            {
                this.katBarang = "03";
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStatus.Text)
            {
                case "In Use":
                    this.statusBarang = "01";
                    break;
                case "Archive":
                    this.statusBarang = "02";
                    break;
                case "Scrap":
                    this.statusBarang = "03";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (this.jenisBarang != "" && this.katBarang != "" && this.statusBarang != "")
            {
                generateKodeBarang(this.jenisBarang + this.katBarang + this.statusBarang);
                txtKodeBarang.Text = this.jenisBarang + this.katBarang +
                    this.modelBarang + this.statusBarang + this.noUrut;
            }
            else
            {
                MessageBox.Show("Harap isi informasi berikut sebelum melakukan generate:\n\n" +
                    "- Jenis barang\n- Kategori\n- Status", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
