using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Npgsql;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;
using System.Data;


namespace Book_ticket
{
    public partial class Form1 : Form
    {
        private string connString = String.Format("Server=localhost; port=5433; Database=postgres; User Id=postgres; Password=123");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pesan_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0)
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                try
                {
                    int d = Convert.ToInt32(jml_pengunjung.Text);
                    int a = Convert.ToInt32(pengunjung_ank.Text);
                    DateTime t = Convert.ToDateTime(tgl_kunjungan.Text);
                    harga.Text = $"{(d * 10000) + (a * 7500)}";
                    int ha = Convert.ToInt32(harga.Text);
                    conn.Open();
                    string sql = "INSERT INTO pemesanan (user_name, pengunjung_dws, pengunjung_ank, tanggal_booking, harga) " +
                        "VALUES(@user_name, @pengunjung_dws, @pengunjung_ank, @tanggal_booking, @harga);";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("user_name", nama.Text);
                    cmd.Parameters.AddWithValue("pengunjung_dws", d);
                    cmd.Parameters.AddWithValue("pengunjung_ank", a);
                    cmd.Parameters.AddWithValue("tanggal_booking", t);
                    cmd.Parameters.AddWithValue("harga", ha);
                    cmd.ExecuteScalar();
                    conn.Close();
                    MessageBox.Show("Inserted Successfully");
                    harga.Text = $"Total harga: {(d * 10000) + (a * 7500)}";
                    Select();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Insert Fail. Error: " + ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void jml_pengunjung_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_Click(object sender, EventArgs e)
        {

        }
    }
}