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
    public class SkupinaMapper
    {
        Database db;

        public static String SQL_SELECT = "SELECT * FROM Skupina";
        public static String SQL_INSERT = "INSERT INTO Skupina VALUES (@nazev, @datum_zalozeni)";
        public static String SQL_INSERT2 = "INSERT INTO je_prirazen VALUES (@Zamestnanec_z_ID, @Skupina_skup_ID)";

        public SkupinaMapper()
        {
            db = new Database();
            db.Connect();
        }

        public Collection<Skupina> selectAll()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Skupina> skups = Read(reader);
            reader.Close();
            return skups;
        }

        private Collection<Skupina> Read(SqlDataReader reader)
        {
            Collection<Skupina> skups = new Collection<Skupina>();

            while (reader.Read())
            {
                Skupina skup = new Skupina();
                skup.skup_ID = reader.GetInt32(0);
                skup.nazev = reader.GetString(1);
                skup.datum_zalozeni = reader.GetDateTime(2);
                skups.Add(skup);
            }
            return skups;
        }

        public int insert(Skupina  Skupina)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, Skupina);
            int ret = db.ExecuteNonQuery(command);

            foreach (Zamestnanec z in Skupina.zamestnanci)
            {
                SqlCommand command2 = db.CreateCommand(SQL_INSERT2);
                PrepareCommand2(command2, Skupina, z);
                ret = db.ExecuteNonQuery(command2);
            }
            return ret;
        }

        private static void PrepareCommand(SqlCommand command, Skupina Tym)
        {
            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Skupina.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Tym.nazev;

            command.Parameters.Add(new SqlParameter("@datum_zalozeni", SqlDbType.DateTime));
            command.Parameters["@datum_zalozeni"].Value = Tym.datum_zalozeni;
        }

        private static void PrepareCommand2(SqlCommand command, Skupina Tym, Zamestnanec z)
        {
            command.Parameters.Add(new SqlParameter("@Zamestnanec_z_ID", SqlDbType.Int));
            command.Parameters["@Zamestnanec_z_ID"].Value = z.z_ID;

            command.Parameters.Add(new SqlParameter("@Skupina_skup_ID", SqlDbType.Int));
            command.Parameters["@Skupina_skup_ID"].Value = Tym.skup_ID;
        }


    }
}
