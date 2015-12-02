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
    public class OddeleniMapper
    {
        Database db;

        public static String SQL_SELECT = "SELECT * FROM Oddeleni";
        public static String SQL_SELECT_ID = "SELECT * FROM Oddeleni WHERE o_ID=@o_ID";
        public static String SQL_INSERT = "INSERT INTO Oddeleni VALUES (@nazev, @pocet_zamestnancu, @poznamka)";
        public static String SQL_UPDATE = "UPDATE Oddeleni SET nazev=@nazev, pocet_zamestnancu=@pocet_zamestnancu, poznamka=@poznamka WHERE o_ID=@o_ID";

        public OddeleniMapper()
        {
            db = new Database();
            db.Connect();
        }

        public int insert(Oddeleni Oddeleni)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommandInsert(command, Oddeleni);
            return db.ExecuteNonQuery(command);
        }

        public int update(Oddeleni Oddeleni)
        {
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommandUpdate(command, Oddeleni);
            return db.ExecuteNonQuery(command);
        }

        private void PrepareCommandUpdate(SqlCommand command, Oddeleni Oddeleni)
        {
            command.Parameters.Add(new SqlParameter("@o_ID", SqlDbType.Int));
            command.Parameters["@o_ID"].Value = Oddeleni.o_ID;

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Oddeleni.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Oddeleni.nazev;

            command.Parameters.Add(new SqlParameter("@pocet_zamestnancu", SqlDbType.Int));
            command.Parameters["@pocet_zamestnancu"].Value = Oddeleni.pocet_zamestnancu;

            command.Parameters.Add(new SqlParameter("@poznamka", SqlDbType.VarChar, Oddeleni.LEN_ATTR_poznamka));
            command.Parameters["@poznamka"].Value = Oddeleni.poznamka;
        }

        private void PrepareCommandInsert(SqlCommand command, Oddeleni Oddeleni)
        {
            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Oddeleni.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Oddeleni.nazev;

            command.Parameters.Add(new SqlParameter("@pocet_zamestnancu", SqlDbType.Int));
            command.Parameters["@pocet_zamestnancu"].Value = Oddeleni.pocet_zamestnancu;

            command.Parameters.Add(new SqlParameter("@poznamka", SqlDbType.VarChar, Oddeleni.LEN_ATTR_poznamka));
            command.Parameters["@poznamka"].Value = Oddeleni.poznamka;
        }

        public Collection<Oddeleni> selectAll()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Oddeleni> Oddeleni = Read(reader);
            reader.Close();
            return Oddeleni;
        }

        public Oddeleni selectOne(int o_ID)
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@o_ID", SqlDbType.Int));
            command.Parameters["@o_ID"].Value = o_ID;
            SqlDataReader reader = db.Select(command);

            Collection<Oddeleni> oddelenis = Read(reader);
            Oddeleni oddeleni = null;
            if (oddelenis.Count == 1)
            {
                oddeleni = oddelenis[0];
            }
            reader.Close();
            return oddeleni;
        }

        private static Collection<Oddeleni> Read(SqlDataReader reader)
        {
            Collection<Oddeleni> oddelenis = new Collection<Oddeleni>();

            while (reader.Read())
            {
                Oddeleni o = new Oddeleni();
                o.o_ID = reader.GetInt32(0);
                o.nazev = reader.GetString(1);
                o.pocet_zamestnancu = reader.GetInt32(2);
                if (!reader.IsDBNull(3))
                {
                    o.poznamka = reader.GetString(3);
                }
                oddelenis.Add(o);
            }
            return oddelenis;
        }
    }
}
