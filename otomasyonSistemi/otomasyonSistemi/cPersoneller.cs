using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace otomasyonSistemi
{
    class cPersoneller
    {

        cGenel genel = new cGenel();
        private int PersonelId;
        private int PersonelGorevId;
        private string personelSoyad;
        private string PersonelAd; 
        private string PersonelParola;
        private string PersonelKullaniciAdi;
        private bool PersonelDurum;

        public int PersonelId1 { get => PersonelId; set => PersonelId = value; }
        public int PersonelGorevId1 { get => PersonelGorevId; set => PersonelGorevId = value; }
        public string PersonelAd1 { get => PersonelAd; set => PersonelAd = value; }
        public string PersonelParola1 { get => PersonelParola; set => PersonelParola = value; }
        public string PersonelKullaniciAdi1 { get => PersonelKullaniciAdi; set => PersonelKullaniciAdi = value; }
        public bool PersonelDurum1 { get => PersonelDurum; set => PersonelDurum = value; }



        public bool PersonelEntryControl(string password, int userId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(genel.conString);                 //eşitlemeler yapıldı sql ile
            SqlCommand cmd = new SqlCommand("Select * from Personeller where ID= @ID and Parola=@password", con);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = userId;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();                 //bağlantı açtık
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return result;
        }

        public void personelGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(genel.conString);                 //eşitlemeler yapıldı sql ile
            SqlCommand cmd = new SqlCommand("Select * from Personeller where ID= @ID and Parola=@password", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();                 //bağlantı açtık
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p.PersonelId = Convert.ToInt32(dr["Id"]);
                p.PersonelGorevId = Convert.ToInt32(dr["GorevId"]);
                p.PersonelAd = Convert.ToString(dr["Ad"]);
                p.PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAd"]);
                p.PersonelDurum = Convert.ToBoolean(dr["DURUM"]);

                cb.Items.Add(p);

            }
            dr.Close();
            con.Close();
        }

        public override string ToString()
        {
            return PersonelAd+ " "+ personelSoyad;
        }

    }
}
