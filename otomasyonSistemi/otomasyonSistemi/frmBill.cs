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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        frmPaketServis cs = new frmPaketServis();
        
        private void frmBill_Load(object sender, EventArgs e)
        {
            if (cGenel.servisTurNo == 1)   //masa 
            {
                //cs.
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            this.Close();
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış için emin misin?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
