using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_zadatak.Models
{
    public class Zaposlenik_CIP_Repozitorij
    {
        public static Zaposlenik_CIP GetZaposlenik(int id)
        {
            Zaposlenik_CIP zaposlenik = null;
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        public static List<Zaposlenik_CIP> GetZaposlenik()
        {
            var zaposlenici = new List<Zaposlenik_CIP>();

            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zaposlenik_CIP zaposlenik = CreateObject(reader);
                zaposlenici.Add(zaposlenik);
            }

            reader.Close();
            DB.CloseConnection();

            return zaposlenici;
        }

        private static Zaposlenik_CIP CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();

            var zaposlenik = new Zaposlenik_CIP
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,

            };
            return zaposlenik;
        }
    }
}
