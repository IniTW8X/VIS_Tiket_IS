using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public class NotifikaceMapper
    {
        Database db;

        public static String SQL_SELECT = "SELECT * FROM Notifikace";
        public static String SQL_INSERT = "INSERT INTO Notifikace VALUES (@text, @Zamestnanec_z_ID, @Tiket_t_ID)";

        public NotifikaceMapper()
        {
            db = new Database();
            db.Connect();
        }

        public int insert(Notifikace Notifikace)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommandInsert(command, Notifikace);
            return db.ExecuteNonQuery(command);
        }

        private void PrepareCommandInsert(SqlCommand command, Notifikace Notifikace)
        {
            command.Parameters.Add(new SqlParameter("@text", SqlDbType.VarChar, Notifikace.LEN_ATTR_text));
            command.Parameters["@text"].Value = Notifikace.text;

            command.Parameters.Add(new SqlParameter("@Zamestnanec_z_ID", SqlDbType.Int));
            command.Parameters["@Zamestnanec_z_ID"].Value = Notifikace.Zamestnanec_z_ID;

            command.Parameters.Add(new SqlParameter("@Tiket_t_ID", SqlDbType.Int));
            command.Parameters["@Tiket_t_ID"].Value = Notifikace.Tiket_t_ID;
        }

        public Collection<Notifikace> selectAll()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Notifikace> nots = Read(reader);
            reader.Close();
            return nots;
        }

        private Collection<Notifikace> Read(SqlDataReader reader)
        {
            Collection<Notifikace> nots = new Collection<Notifikace>();

            while (reader.Read())
            {
                Notifikace not = new Notifikace();
                not.n_ID = reader.GetInt32(0);
                not.text = reader.GetString(1);
                not.Zamestnanec_z_ID = reader.GetInt32(2);
                not.Tiket_t_ID = reader.GetInt32(3);
                nots.Add(not);
            }
            return nots;
        }

    }
}
