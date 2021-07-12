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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)      
        {
            cPersoneller p = (cPersoneller)comboBox1.SelectedItem;
            genel.personeId = p.PersonelId1;
            genel.gorevId = p.PersonelGorevId1;
        }
        cGenel genel = new cGenel();

        private void Form1_Load(object sender,EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetByInformation(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)       //giriş butonu
        {
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEntryControl(textBox1.Text, genel.personeId);

            if (result)
            {

                cPersonelHarektleri ch = new cPersonelHarektleri();
                this.Hide();
                menu menuForm = new menu();
                menuForm.Show();
            }
            else
            {
                MessageBox.Show("Şifre Yanlış", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkış için emin misin?","uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
