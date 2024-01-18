using _8HSGunlukOdevi.Db;
using _8HSGunlukOdevi.Modal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _8HSGunlukOdevi.Controller
{
    public class GunlukController
    {
        public static bool KayitEkle(Gunluk gunluk)
        {
            SqlConnection Conn = DB.Conn();
            SqlCommand cmd = new SqlCommand("INSERT INTO Gunluk (Name,DateCreated,DateModified,IsDeleted,IsActive) VALUES (@name,@datecreated,@datemodified,@isdeleted,@isactive) ", Conn);
            cmd.Parameters.AddWithValue("name", gunluk.Name);
            cmd.Parameters.AddWithValue("datecreated", gunluk.DateCreated);
            cmd.Parameters.AddWithValue("datemodified", gunluk.DateModified);
            cmd.Parameters.AddWithValue("isdeleted", gunluk.IsDeleted);
            cmd.Parameters.AddWithValue("isactive", gunluk.IsActive);
            Conn.Open();
            int AffectedRows=cmd.ExecuteNonQuery();
            Conn.Close();
            if(AffectedRows > 0)
            {
                return true;
            }
            else { return false; }

          }
        public static bool KayitSil()
        {
            SqlConnection conn = DB.Conn();
            SqlCommand cmd = new SqlCommand("DELETE FROM Gunluk", conn);
            conn.Open();
            int affecteddRows=cmd.ExecuteNonQuery();
            conn.Close();
            if(affecteddRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Gunluk> KayitListele() 
        {
            List<Gunluk> list = new List<Gunluk>();
            SqlConnection conn = DB.Conn();
            SqlCommand cmd = new SqlCommand("SELECT Id,Name,DateCreated FROM Gunluk", conn);
            conn.Open();
            SqlDataReader dr =cmd.ExecuteReader();
          

            while(dr.Read())
            {
                list.Add(new Gunluk
                    { Id = (int)dr["Id"],
                    Name = (string)dr["Name"],
                    DateCreated = (DateTime)dr["DateCreated"]
                });
            }
            dr.Close();
            conn.Close();
            return list;
        }
    }
}
