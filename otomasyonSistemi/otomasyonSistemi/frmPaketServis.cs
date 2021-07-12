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
    public partial class frmPaketServis : Form
    {
        public frmPaketServis()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış için emin misin?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            this.Close();
            frm.Show();
        }
        void islem(object sender, EventArgs e)     //hesap makinesi adet ekleme
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    textadett.Text += (1).ToString();
                    break;
                case "btn2":
                    textadett.Text += (2).ToString();
                    break;
                case "btn3":
                    textadett.Text += (3).ToString();
                    break;
                case "btn4":
                    textadett.Text += (4).ToString();
                    break;
                case "btn5":
                    textadett.Text += (5).ToString();
                    break;
                case "btn6":
                    textadett.Text += (6).ToString();
                    break;
                case "btn7":
                    textadett.Text += (7).ToString();
                    break;
                case "btn8":
                    textadett.Text += (8).ToString();
                    break;
                case "btn9":
                    textadett.Text += (9).ToString();
                    break;
                case "btn0":
                    textadett.Text += (0).ToString();
                    break;

                default:
                    MessageBox.Show("sayi gir");
                    break;

            }
        }
        private void frmPaketServis_Load(object sender, EventArgs e)
        {
            frmMasa ms = new frmMasa();
            int tableId = ms.TableGetbyNumber(cGenel.ButtonName);

            if(ms.Tablegetstate(tableId,2)==true|| ms.Tablegetstate(tableId, 4) == true)
            {
                //look
            }

            btn1.Click += new EventHandler(islem);         //hesap içinn
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }

        private void button1_Click(object sender, EventArgs e)       //anaYemek
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button1);
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)               //sol menu renkliler
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.GetByProductTypes(listView1, button6);
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        int sayac2 = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                sayac = listView1.Items.Count;
                listView2.Items.Add(listView1.SelectedItems[0].Text);
                listView2.Items[sayac].SubItems.Add("1");
                listView2.Items[sayac].SubItems.Add(listView1.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void button24_Click(object sender, EventArgs e)          //sipariş     yüzde75de yok...
        {
            
        }
    }


    
}
