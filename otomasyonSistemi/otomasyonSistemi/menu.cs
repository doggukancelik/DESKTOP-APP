using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyonSistemi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            this.Close();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKasaIslem frm = new frmKasaIslem();
            this.Close();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLock frm = new frmLock();
            this.Close();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış için emin misin?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
