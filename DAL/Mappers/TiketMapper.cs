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
    public class TiketMapper
    {
        Database db;

        public static String SQL_INSERT = "INSERT INTO Tiket VALUES (@nazev, @popis, @priorita, @vytvoreno, @lhuta, @status, @uzav_pozn, @Zamestnanec_z_ID, @Kategorie_kat_ID, @Skupina_skup_ID)";
        public static String SQL_UPDATE = "UPDATE Tiket SET nazev=@nazev, popis=@popis, priorita=@priorita, vytvoreno=@vytvoreno, lhuta=@lhuta, status=@status, uzav_pozn=@uzav_pozn, Zamestnanec_z_ID=@Zamestnanec_z_ID, Kategorie_kat_ID=@Kategorie_kat_ID, Skupina_skup_ID=@Skupina_skup_ID WHERE t_ID=@t_ID";
        public static String SQL_SELECT_ID = "SELECT * FROM Tiket WHERE t_ID=@t_ID";
        public static String SQL_SELECT_PROSLE = "SELECT t.t_ID, t.nazev, t.popis, t.priorita, t.vytvoreno, t.lhuta, t.status, t.uzav_pozn, t.Zamestnanec_z_ID, t.Kategorie_kat_ID, t.Skupina_skup_ID From Tiket t WHERE t.lhuta <= GETDATE() AND t.status = 'Prirazen' ORDER BY t.lhuta DESC";
        public static String SQL_SELECT_NOVE = "SELECT t.t_ID, t.nazev, t.popis, t.priorita, t.vytvoreno, t.lhuta, t.status, t.uzav_pozn, t.Zamestnanec_z_ID, t.Kategorie_kat_ID, t.Skupina_skup_ID FROM Tiket t WHERE t.status = 'Novy'";

        public TiketMapper()
        {
            db = new Database();
            db.Connect();
        }

        public int insert(Tiket tiket)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommandInsert(command, tiket);
            return db.ExecuteNonQuery(command);
        }

        public int update(Tiket tiket)
        {
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommandUpdate(command, tiket);
            return db.ExecuteNonQuery(command);
        }

        public Tiket selectOne(int t_ID)
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@t_ID", SqlDbType.Int));
            command.Parameters["@t_ID"].Value = t_ID;
            SqlDataReader reader = db.Select(command);

            Collection<Tiket> tikety = Read(reader, "select_one");
            Tiket tiket = null;
            if (tikety.Count == 1)
            {
                tiket = tikety[0];
            }
            reader.Close();
            return tiket;
        }

        public Collection<Tiket> selectProsle()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_PROSLE);
            SqlDataReader reader = db.Select(command);

            Collection<Tiket> tikety = Read(reader, "select_prosle");
            reader.Close();
            return tikety;
        }

        public Collection<Tiket> selectNove()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_NOVE);
            SqlDataReader reader = db.Select(command);

            Collection<Tiket> tikety = Read(reader, "select_nove");
            reader.Close();
            return tikety;
        }

        private Collection<Tiket> Read(SqlDataReader reader, String fce)
        {
            Collection<Tiket> tikety = new Collection<Tiket>();

            if (fce == "select_one")
            {
                while (reader.Read())
                {
                    Tiket t = new Tiket();
                    t.t_ID = reader.GetInt32(0);
                    t.nazev = reader.GetString(1);
                    t.popis = reader.GetString(2);
                    t.priorita = reader.GetInt32(3);
                    t.vytvoreno = reader.GetDateTime(4);
                    t.lhuta = reader.GetDateTime(5);
                    t.status = reader.GetString(6);
                    if (!reader.IsDBNull(7))
                    {
                        t.uzav_pozn = reader.GetString(7);
                    }
                    t.Zamestnanec_z_ID = reader.GetInt32(8);
                    t.Kategorie_kat_ID = reader.GetInt32(9);
                    if (!reader.IsDBNull(10))
                    {
                        t.Skupina_skup_ID = reader.GetInt32(10);
                    }
                    tikety.Add(t);
                }
            }
            else if (fce == "select_nove" ||
                    fce == "select_prosle")
            {
                while (reader.Read())
                {
                    Tiket t = new Tiket();
                    t.t_ID = reader.GetInt32(0);
                    t.nazev = reader.GetString(1);
                    t.popis = reader.GetString(2);
                    t.priorita = reader.GetInt32(3);
                    t.vytvoreno = reader.GetDateTime(4);
                    t.lhuta = reader.GetDateTime(5);
                    t.status = reader.GetString(6);
                    if (!reader.IsDBNull(7))
                    {
                        t.uzav_pozn = reader.GetString(7);
                    }
                    t.Zamestnanec_z_ID = reader.GetInt32(8);
                    t.Kategorie_kat_ID = reader.GetInt32(9);
                    if (!reader.IsDBNull(10))
                    {
                        t.Skupina_skup_ID = reader.GetInt32(10);
                    }

                    tikety.Add(t);
                }
            }
            return tikety;
        }

        //insert
        private void PrepareCommandInsert(SqlCommand command, Tiket Tiket)
        {

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Tiket.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Tiket.nazev;

            command.Parameters.Add(new SqlParameter("@popis", SqlDbType.VarChar, Tiket.LEN_ATTR_popis));
            command.Parameters["@popis"].Value = Tiket.popis;

            command.Parameters.Add(new SqlParameter("@priorita", SqlDbType.Int));
            command.Parameters["@priorita"].Value = Tiket.priorita;

            command.Parameters.Add(new SqlParameter("@vytvoreno", SqlDbType.DateTime));
            command.Parameters["@vytvoreno"].Value = Tiket.vytvoreno;

            command.Parameters.Add(new SqlParameter("@lhuta", SqlDbType.DateTime));
            command.Parameters["@lhuta"].Value = Tiket.lhuta;

            command.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, Tiket.LEN_ATTR_status));
            command.Parameters["@status"].Value = Tiket.status;

            command.Parameters.Add(new SqlParameter("@uzav_pozn", SqlDbType.VarChar, Tiket.LEN_ATTR_uzav_pozn));
            command.Parameters["@uzav_pozn"].Value = Tiket.uzav_pozn;

            command.Parameters.Add(new SqlParameter("@Zamestnanec_z_ID", SqlDbType.Int));
            command.Parameters["@Zamestnanec_z_ID"].Value = Tiket.Zamestnanec_z_ID;

            command.Parameters.Add(new SqlParameter("@Kategorie_kat_ID", SqlDbType.Int));
            command.Parameters["@Kategorie_kat_ID"].Value = Tiket.Kategorie_kat_ID;

            command.Parameters.Add(new SqlParameter("@Skupina_skup_ID", SqlDbType.Int));
            command.Parameters["@Skupina_skup_ID"].Value = Tiket.Skupina_skup_ID;
        }

        //update
        private void PrepareCommandUpdate(SqlCommand command, Tiket Tiket)
        {

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Tiket.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Tiket.nazev;

            command.Parameters.Add(new SqlParameter("@popis", SqlDbType.VarChar, Tiket.LEN_ATTR_popis));
            command.Parameters["@popis"].Value = Tiket.popis;

            command.Parameters.Add(new SqlParameter("@priorita", SqlDbType.Int));
            command.Parameters["@priorita"].Value = Tiket.priorita;

            command.Parameters.Add(new SqlParameter("@vytvoreno", SqlDbType.DateTime));
            command.Parameters["@vytvoreno"].Value = Tiket.vytvoreno;

            command.Parameters.Add(new SqlParameter("@lhuta", SqlDbType.DateTime));
            command.Parameters["@lhuta"].Value = Tiket.lhuta;

            command.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar, Tiket.LEN_ATTR_status));
            command.Parameters["@status"].Value = Tiket.status;

            command.Parameters.Add(new SqlParameter("@uzav_pozn", SqlDbType.VarChar, Tiket.LEN_ATTR_uzav_pozn));
            command.Parameters["@uzav_pozn"].Value = Tiket.uzav_pozn;

            command.Parameters.Add(new SqlParameter("@Zamestnanec_z_ID", SqlDbType.Int));
            command.Parameters["@Zamestnanec_z_ID"].Value = Tiket.Zamestnanec_z_ID;

            command.Parameters.Add(new SqlParameter("@Kategorie_kat_ID", SqlDbType.Int));
            command.Parameters["@Kategorie_kat_ID"].Value = Tiket.Kategorie_kat_ID;

            command.Parameters.Add(new SqlParameter("@Skupina_skup_ID", SqlDbType.Int));
            command.Parameters["@Skupina_skup_ID"].Value = Tiket.Skupina_skup_ID;

            command.Parameters.Add(new SqlParameter("@t_ID", SqlDbType.Int));
            command.Parameters["@t_ID"].Value = Tiket.t_ID;
        }

    }
}
