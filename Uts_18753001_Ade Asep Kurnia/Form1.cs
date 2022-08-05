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
    public partial class Form1 : Form
    {
        public string username = "admin";
        public string password = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string nama = txtname.Text;
            string pass = txtpassword.Text;
            Form2 mainfrom = new Form2();
            
            if (nama == username && pass == password) 
            {
                MessageBox.Show("Anda Berhasil");
                mainfrom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username password salah");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
