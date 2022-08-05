using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uts_18753001_Ade_Asep_Kurnia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            int baris = 0;
            dataGridView1.Rows.Add();
            baris = dataGridView1.Rows.Count - 2;
                string jk;
                if (rdblaki.Checked == true)
                {
                    jk = "Laki-laki";
                }
                else
                {
                    jk = " perempuan";
                }
                dataGridView1[0, baris].Value = dataGridView1.Rows.Count - 1;
                dataGridView1[1, baris].Value = txtnama.Text;
                dataGridView1[0, baris].Value = jk;
                dataGridView1[1, baris].Value = txtnama.Text;
                dataGridView1[0, baris].Value = txtnomor.Text;
                dataGridView1[1, baris].Value = txtemail.Text;
                dataGridView1[1, baris].Value = txtalamat.Text;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void dgvmahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            Form3 Info = new Form3();
            Info.TopMost = true;
            Info.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            HELP Info = new HELP();
            Info.TopMost = true;
            Info.Show();
        }
    }
}
