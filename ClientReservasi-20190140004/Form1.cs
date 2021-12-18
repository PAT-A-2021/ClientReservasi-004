using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140004
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
            TampilData();
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void Clear()
        {
            tbID.Clear();
            tbNama.Clear();
            tbNotlf.Clear();
            tbJumlah.Clear();
            tbIDLokasi.Clear();

            tbJumlah.Enabled = true;
            tbIDLokasi.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

            tbID.Enabled = true;
        }

        private void TampilData()
        {
            var List = service.Pemesanan1();
            dgPemesanan.DataSource = List;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCust = tbNama.Text;
            string NoTelp = tbNotlf.Text;
            int JumlahPemesanan = int.Parse(tbJumlah.Text);
            string IdLokasi = tbIDLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCust,NoTelp,JumlahPemesanan,IdLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = tbID.Text;
            string NamaCust = tbNama.Text;
            string NoTelp = tbNotlf.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCust, NoTelp);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[0].Value);
            tbNama.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[3].Value);
            tbNotlf.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[4].Value);
            tbJumlah.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[1].Value);
            tbIDLokasi.Text = Convert.ToString(dgPemesanan.Rows[e.RowIndex].Cells[2].Value);

            tbJumlah.Enabled = false;
            tbIDLokasi.Enabled = false;

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
            tbID.Enabled = false;
        }
    }
}
