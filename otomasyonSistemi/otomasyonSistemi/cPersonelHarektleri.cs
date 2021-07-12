using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace otomasyonSistemi
{
    class cPersonelHarektleri
    {
        private int PersonelId;
        private int PersonelGorevId;
        private string islem;
        private DateTime tarih;
        private bool durum;

        public int PersonelId1 { get => PersonelId; set => PersonelId = value; }
        public int PersonelGorevId1 { get => PersonelGorevId; set => PersonelGorevId = value; }
        public string Islem { get => islem; set => islem = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Durum { get => durum; set => durum = value; }

        cGenel gnl = new cGenel();

        private bool PersonelActionSave(cPersonelHarektleri ph)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("INSERT Into personelHareketleri(PERSONELID,Islem,TARIH)Values(@personelId,@islem,@tarih)", con);
            

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personelId", System.Data.SqlDbType.Int).Value =ph.PersonelId;
                cmd.Parameters.Add("@islem", System.Data.SqlDbType.VarChar).Value = ph.islem;
                cmd.Parameters.Add("@tarih", System.Data.SqlDbType.DateTime).Value = ph.tarih;

                result = Convert.ToBoolean( cmd.ExecuteNonQuery());
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
