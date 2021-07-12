using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace otomasyonSistemi
{
    class cUrunCesitleri
    {

        cGenel gnl = new cGenel();
        private int urunTurNo;
        private string katagoriAdi;
        private string aciklama;

        public int UrunTurNo { get => urunTurNo; set => urunTurNo = value; }
        public string KatagoriAdi { get => katagoriAdi; set => katagoriAdi = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }


        public void GetByProductTypes(ListView cesitler,Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select URUNAD,FIYAT,urunler.ID from kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KAEGORIID", conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                cesitler.Items.Add(dr["URUNAD"].ToString());
                cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                cesitler.Items[i].SubItems.Add(dr["UrunID"].ToString());
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
    }
}
