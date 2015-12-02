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
    public class ZamestnanecMapper
    {
        Database db;

        public static String SQL_SELECT_ALL = "SELECT * FROM Zamestnanec";
        public static String SQL_SELECT_ID = "SELECT * FROM Zamestnanec WHERE z_ID=@z_ID";
        public static String SQL_INSERT = "INSERT INTO Zamestnanec VALUES (@jmeno, @prijmeni, @datum_narozeni, @pozice, @platova_trida, @oddeleni_o_ID, @poznamka)";
        public static String SQL_UPDATE = "UPDATE Zamestnanec SET jmeno=@jmeno, prijmeni=@prijmeni, datum_narozeni=@datum_narozeni, pozice=@pozice, platova_trida=@platova_trida, oddeleni_o_ID=@oddeleni_o_ID, poznamka=@poznamka WHERE z_ID=@z_ID";

        public ZamestnanecMapper()
        {
            db = new Database();
            db.Connect();
        }

        public int insert(Zamestnanec Zamestnanec)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommandInsert(command, Zamestnanec);
            return db.ExecuteNonQuery(command);
        }

        public int update(Zamestnanec Zamestnanec)
        {
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommandUpdate(command, Zamestnanec);
            
            return db.ExecuteNonQuery(command);
        }

        private void PrepareCommandInsert(SqlCommand command, Zamestnanec Zamestnanec)
        {
            command.Parameters.Add(new SqlParameter("@jmeno", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_jmeno));
            command.Parameters["@jmeno"].Value = Zamestnanec.jmeno;

            command.Parameters.Add(new SqlParameter("@prijmeni", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_prijmeni));
            command.Parameters["@prijmeni"].Value = Zamestnanec.prijmeni;

            command.Parameters.Add(new SqlParameter("@datum_narozeni", SqlDbType.DateTime));
            command.Parameters["@datum_narozeni"].Value = Zamestnanec.datum_narozeni;

            command.Parameters.Add(new SqlParameter("@pozice", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_pozice));
            command.Parameters["@pozice"].Value = Zamestnanec.pozice;

            command.Parameters.Add(new SqlParameter("@platova_trida", SqlDbType.Int));
            command.Parameters["@platova_trida"].Value = Zamestnanec.platova_trida;

            command.Parameters.Add(new SqlParameter("@oddeleni_o_ID", SqlDbType.Int));
            command.Parameters["@oddeleni_o_ID"].Value = Zamestnanec.Oddeleni_o_ID;

            command.Parameters.Add(new SqlParameter("@poznamka", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_poznamka));
            command.Parameters["@poznamka"].Value = Zamestnanec.poznamka;
        }

        private void PrepareCommandUpdate(SqlCommand command, Zamestnanec Zamestnanec)
        {
            command.Parameters.Add(new SqlParameter("@z_ID", SqlDbType.Int));
            command.Parameters["@z_ID"].Value = Zamestnanec.z_ID;

            command.Parameters.Add(new SqlParameter("@jmeno", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_jmeno));
            command.Parameters["@jmeno"].Value = Zamestnanec.jmeno;

            command.Parameters.Add(new SqlParameter("@prijmeni", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_prijmeni));
            command.Parameters["@prijmeni"].Value = Zamestnanec.prijmeni;

            command.Parameters.Add(new SqlParameter("@datum_narozeni", SqlDbType.DateTime));
            command.Parameters["@datum_narozeni"].Value = Zamestnanec.datum_narozeni;

            command.Parameters.Add(new SqlParameter("@pozice", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_pozice));
            command.Parameters["@pozice"].Value = Zamestnanec.pozice;

            command.Parameters.Add(new SqlParameter("@platova_trida", SqlDbType.Int));
            command.Parameters["@platova_trida"].Value = Zamestnanec.platova_trida;

            command.Parameters.Add(new SqlParameter("@oddeleni_o_ID", SqlDbType.Int));
            command.Parameters["@oddeleni_o_ID"].Value = Zamestnanec.Oddeleni_o_ID;

            command.Parameters.Add(new SqlParameter("@poznamka", SqlDbType.VarChar, Zamestnanec.LEN_ATTR_poznamka));
            command.Parameters["@poznamka"].Value = Zamestnanec.poznamka;
        }

        public Zamestnanec selectOne(int z_ID)
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@z_ID", SqlDbType.Int));
            command.Parameters["@z_ID"].Value = z_ID;
            SqlDataReader reader = db.Select(command);

            Collection<Zamestnanec> zamestnanci = Read(reader);
            Zamestnanec zam = null;
            if (zamestnanci.Count == 1)
            {
                zam = zamestnanci[0];
            }
            reader.Close();
            return zam;
        }

        public Collection<Zamestnanec> selectAll()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Zamestnanec> zams = Read(reader);
            reader.Close();
            return zams;
        }

        private static Collection<Zamestnanec> Read(SqlDataReader reader)
        {
            Collection<Zamestnanec> zams = new Collection<Zamestnanec>();

            while (reader.Read())
            {
                Zamestnanec z = new Zamestnanec();
                z.z_ID = reader.GetInt32(0);
                z.jmeno = reader.GetString(1);
                z.prijmeni = reader.GetString(2);
                z.datum_narozeni = reader.GetDateTime(3);
                z.pozice = reader.GetString(4);
                z.platova_trida = reader.GetInt32(5);
                z.Oddeleni_o_ID = reader.GetInt32(6);
                if (!reader.IsDBNull(7))
                {
                    z.poznamka = reader.GetString(7);
                }
                zams.Add(z);
            }
            return zams;
        }
    }
}
