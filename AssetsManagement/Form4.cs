using AssetsManagement.controller;
using QRCoder;
using System.Data.SQLite;
using System.Drawing.Imaging;

namespace AssetsManagement
{
    public partial class Form4 : Form
    {
        Koneksi koneksi = new Koneksi();

        public Form4()
        {
            InitializeComponent();
        }

        private void ReadDataForQR(string option, string kode_barang)
        {
            string jenis = "", model = "", status = "", tanggal = "", kategori_str = "";
            int kategori = 0;

            koneksi.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM asset WHERE kode_barang='{kode_barang}'", koneksi.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                kode_barang = reader.GetString(reader.GetOrdinal("kode_barang"));
                jenis = reader.GetString(reader.GetOrdinal("jenis"));
                kategori = reader.GetInt32(reader.GetOrdinal("kategori"));
                if (kategori == 1)
                {
                    kategori_str = "In Use";
                }
                else if (kategori == 2)
                {
                    kategori_str = "Archive";
                }
                else if (kategori == 3)
                {
                    kategori_str = "Broken";
                }
                model = reader.GetString(reader.GetOrdinal("model"));
                status = reader.GetString(reader.GetOrdinal("status"));
                tanggal = reader.GetString(reader.GetOrdinal("tanggal"));
            }

            if (jenis == "" || kategori_str == "" || status == "")
            {
                MessageBox.Show("Data tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string formatText = $"Kode : {kode_barang}\n" +
                $"Jenis : {jenis}\n" +
                $"Kategori : {kategori_str}\n" +
                $"Model : {model}\n" +
                $"Status : {status}\n" +
                $"Tanggal : {tanggal}\n\n" +
                $"Powered by QRCoder";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(formatText, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                if (option == "show")
                {
                    qrCodeBox.Image = qrCodeImage;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                }
                else if (option == "save")
                {
                    saveFileDialog1.Filter = "PNG|*.png";
                    saveFileDialog1.Title = "Simpan QRCode";
                    saveFileDialog1.ShowDialog();

                    using (Bitmap bitmap = qrCode.GetGraphic(20))
                    {
                        bitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                ReadDataForQR("show", txtKodeBarang.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ada kesalahan\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ReadDataForQR("save", txtKodeBarang.Text);
                MessageBox.Show("QRCode berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Gagal menyimpan\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            qrCodeBox.Image = null;
            txtKodeBarang.Text = null;
        }
    }
}
