using AssetsManagement.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.controller
{
    internal class AddItem
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(Asset_M model)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO asset " +
                    "(kode_barang,jenis,kategori," +
                    "model,status,tanggal) VALUES " +
                    $"('{model.Kode_barang}','{model.Jenis}','{model.Kategori}'," +
                    $"'{model.Model}','{model.Status}', '{model.Tanggal}')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Data gagal ditambahkan\n\n{ex.Message}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            return status;
        }
    }
}
