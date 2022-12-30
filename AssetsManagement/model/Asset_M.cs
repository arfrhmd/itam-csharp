using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.model
{
    internal class Asset_M
    {
        private string tanggal;
        private string kode_barang;
        private string jenis;
        private int kategori;
        private string model;
        private string status;

        public Asset_M() { }

        public Asset_M (string kode_barang, string jenis, int kategori, string model, string status, string tanggal)
        {
            this.Kode_barang = kode_barang;
            this.Jenis = jenis;
            this.Kategori = kategori;
            this.Model = model;
            this.Status = status;
            this.Tanggal = tanggal;
        }

        public string Kode_barang { get => kode_barang; set => kode_barang = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public int Kategori { get => kategori; set => kategori = value; }
        public string Model { get => model; set => model = value; }
        public string Status { get => status; set => status = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
