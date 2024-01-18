using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8HSGunlukOdevi.Db
{
    public static class DB
    {
        public static SqlConnection Conn() => new SqlConnection("server=RECEP\\SQLEXPRESS;DataBase=GunlukDB;Integrated Security=True;TrustServerCertificate=Yes");
    }
}
