using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonSistemi
{
    public partial class frmMasa : Form
    {
        public frmMasa()
        {
            InitializeComponent();
        }

        public int TableGetbyNumber(string TableValue)     //masa bilgisi tutulur
        {
            string aa = TableValue;
            int length = aa.Length;
            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış için emin misin?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button11_Click(object sender, EventArgs e)   //geri
        {
            menu frm = new menu();
            this.Close();
            frm.Show();
        }

        public bool Tablegetstate(int buttonName,int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);          //bağlantı
            SqlCommand cmd = new SqlCommand("Select durum From Maslar Where Id=@TableId and Durum=@state", con);

            cmd.Parameters.AddWithValue("@TableId", SqlDbType.Int).Value = buttonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            catch(SqlException ex)
            {
                string hata = ex.Message;
            }

            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button1.Text.Length;
            cGenel.ButtonValue = button1.Text.Substring(uzunluk-6,6);
            cGenel.ButtonName = button1.Name;

            this.Close();
            frm.ShowDialog();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button5.Text.Length;
            cGenel.ButtonValue = button5.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button5.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button4.Text.Length;
            cGenel.ButtonValue = button4.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button4.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button3.Text.Length;
            cGenel.ButtonValue = button3.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button3.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button2.Text.Length;
            cGenel.ButtonValue = button2.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button2.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button10.Text.Length;
            cGenel.ButtonValue = button10.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button10.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button6.Text.Length;
            cGenel.ButtonValue = button6.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button6.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button7.Text.Length;
            cGenel.ButtonValue = button7.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button7.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button8.Text.Length;
            cGenel.ButtonValue = button8.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button8.Name;

            this.Close();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            int uzunluk = button9.Text.Length;
            cGenel.ButtonValue = button9.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = button9.Name;

            this.Close();
            frm.ShowDialog();
        }
        cGenel gnl = new cGenel();
        private void frmMasa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Durum, ID from Masalar", con);
            SqlDataReader dr = null;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read()){
                foreach (Control item in this.Controls)
                {
                    if(item is Button)
                    {
                        if(item.Name=="button"+dr["ID"].ToString()&& dr["DURUM"].ToString() == "1")
                        {
                            //item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bos);
                        }
                           // item.Text = String.Format(("{0}{1}{2}"));
                        }
                    }
                }
            }
        }
    
}
