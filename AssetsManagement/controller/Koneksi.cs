using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace AssetsManagement.controller
{
    internal class Koneksi
    {
        string ConnectionString = @"Data Source=./asset.db;Version=3";
        public SQLiteConnection conn;

        public void OpenConnection()
        {
            conn = new SQLiteConnection(ConnectionString);
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void ExecuteQuery(string query)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ada kesalahan\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object ShowInDataGrid(string query)
        {
            try
            {
                SQLiteDataAdapter dr = new SQLiteDataAdapter(query, ConnectionString);
                DataSet ds = new DataSet();

                // Isi dataset
                dr.Fill(ds);

                // Return object data
                object data = ds.Tables[0];
                return data;
            }
            catch (SQLiteException ex)
            {
                return ex;
            }
        }

        public object LastKodeBarang(string kodeAwal)
        {
            object lastKodeBarang = null;
            OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT kode_barang FROM asset " +
                $"WHERE kode_barang LIKE '{kodeAwal}___' ORDER BY kode_barang DESC LIMIT 0,1", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lastKodeBarang = reader.GetString(reader.GetOrdinal("kode_barang"));
            }

            CloseConnection();

            return lastKodeBarang;
        }

        public void CreateDB()
        {
            try
            {
                SQLiteConnection.CreateFile("./asset.db");
                OpenConnection();
                string table = "CREATE TABLE asset (" +
                    "kode_barang VARCHAR(15) NOT NULL PRIMARY KEY," +
                    "jenis VARCHAR(20) NOT NULL," +
                    "kategori INT," +
                    "model VARCHAR(255)," +
                    "status VARCHAR(20) NOT NULL," +
                    "tanggal DATETIME )";
                ExecuteQuery(table);
                CloseConnection();
                MessageBox.Show("Database berhasil dibuat", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database gagal dibuat\n\n{ex.Message}", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
