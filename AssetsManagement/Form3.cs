using AssetsManagement.controller;

namespace AssetsManagement
{
    public partial class Form3 : Form
    {
        Koneksi koneksi = new Koneksi();

        public string kodeBarang, jenis, kategori, model,
            status, tanggal;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            try
            {
                tableData.DataSource = koneksi.ShowInDataGrid("SELECT * FROM asset");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada kesalahan\n\n" + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TampilData();
            tableData.ReadOnly = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "" && txtKodeBarang.TextLength == 8)
            {
                string kode = txtKodeBarang.Text;
                tableData.DataSource = koneksi.ShowInDataGrid($"SELECT * FROM asset WHERE kode_barang='{kode}'");
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kode barang belum dimasukkan atau belum lengkap", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text != "")
            {
                DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pesan == DialogResult.Yes)
                {
                    string kode = txtKodeBarang.Text;
                    koneksi.OpenConnection();
                    koneksi.ExecuteQuery($"DELETE FROM asset WHERE kode_barang='{kode}'");
                    koneksi.CloseConnection();
                    TampilData();
                    MessageBox.Show($"Data dengan kode barang \"{kode}\" berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TampilData();
                    txtKodeBarang.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kode barang belum dimasukkan atau belum lengkap", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tableData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            this.kodeBarang = tableData.Rows[e.RowIndex].Cells["kode_barang"].Value.ToString();
            this.jenis = tableData.Rows[e.RowIndex].Cells["jenis"].Value.ToString();
            this.kategori = tableData.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            this.model = tableData.Rows[e.RowIndex].Cells["model"].Value.ToString();
            this.status = tableData.Rows[e.RowIndex].Cells["status"].Value.ToString();
            this.tanggal = tableData.Rows[e.RowIndex].Cells["tanggal"].Value.ToString();

            txtKodeBarang.Text = this.kodeBarang;
            txtJenis.Text = this.jenis;
            txtKategori.Text = this.kategori;
            txtModel.Text = this.model;
            txtStatus.Text = this.status;
            txtTanggal.Text = this.tanggal;
        }
    }
}
