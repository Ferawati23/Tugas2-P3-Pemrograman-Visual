using System;
using System.Windows.Forms;

namespace SepatuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSepatu.Columns.Add("Merk", "Merk");
            dgvSepatu.Columns.Add("Warna", "Warna");
            dgvSepatu.Columns.Add("Ukuran", "Ukuran");
            dgvSepatu.Columns.Add("Stok", "Stok");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtMerk.Text == "" || txtWarna.Text == "" || txtUkuran.Text == "" || txtStok.Text == "")
            {
                MessageBox.Show("Harap lengkapi semua data!");
                return;
            }

            dgvSepatu.Rows.Add(txtMerk.Text, txtWarna.Text, txtUkuran.Text, txtStok.Text);
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSepatu.CurrentRow != null)
            {
                dgvSepatu.CurrentRow.Cells[0].Value = txtMerk.Text;
                dgvSepatu.CurrentRow.Cells[1].Value = txtWarna.Text;
                dgvSepatu.CurrentRow.Cells[2].Value = txtUkuran.Text;
                dgvSepatu.CurrentRow.Cells[3].Value = txtStok.Text;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diedit.");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvSepatu.CurrentRow != null)
            {
                dgvSepatu.Rows.RemoveAt(dgvSepatu.CurrentRow.Index);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.");
            }
        }

        private void dgvSepatu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMerk.Text = dgvSepatu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtWarna.Text = dgvSepatu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUkuran.Text = dgvSepatu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStok.Text = dgvSepatu.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtMerk.Text = "";
            txtWarna.Text = "";
            txtUkuran.Text = "";
            txtStok.Text = "";
        }
    }
}
