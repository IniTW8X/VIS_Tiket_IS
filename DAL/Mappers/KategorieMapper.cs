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
    public class KategorieMapper
    {
        Database db;

        public static String SQL_SELECT = "SELECT * FROM Kategorie";
        public static String SQL_SELECT_ID = "SELECT * FROM Kategorie WHERE kat_ID=@kat_ID";

        public static String SQL_INSERT = "INSERT INTO Kategorie VALUES (@nazev, @popis, @aktivni)";
        public static String SQL_UPDATE = "UPDATE Kategorie SET nazev=@nazev, popis=@popis, aktivni=@aktivni WHERE kat_ID=@kat_ID";

        public KategorieMapper()
        {
            db = new Database();
            db.Connect();
        }

        public int insert(Kategorie Kategorie)
        {
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommandInsert(command, Kategorie);
            return db.ExecuteNonQuery(command);
        }

        public int update(Kategorie Kategorie)
        {
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommandUpdate(command, Kategorie);  
            return db.ExecuteNonQuery(command);
        }

        private void PrepareCommandInsert(SqlCommand command, Kategorie Kategorie)
        {
            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Kategorie.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Kategorie.nazev;

            command.Parameters.Add(new SqlParameter("@popis", SqlDbType.VarChar, Kategorie.LEN_ATTR_popis));
            command.Parameters["@popis"].Value = Kategorie.popis;

            command.Parameters.Add(new SqlParameter("@aktivni", SqlDbType.Int));
            command.Parameters["@aktivni"].Value = Kategorie.aktivni;
        }

        private void PrepareCommandUpdate(SqlCommand command, Kategorie Kategorie)
        {
            command.Parameters.Add(new SqlParameter("@kat_ID", SqlDbType.Int));
            command.Parameters["@kat_ID"].Value = Kategorie.kat_ID;

            command.Parameters.Add(new SqlParameter("@nazev", SqlDbType.VarChar, Kategorie.LEN_ATTR_nazev));
            command.Parameters["@nazev"].Value = Kategorie.nazev;

            command.Parameters.Add(new SqlParameter("@popis", SqlDbType.VarChar, Kategorie.LEN_ATTR_popis));
            command.Parameters["@popis"].Value = Kategorie.popis;

            command.Parameters.Add(new SqlParameter("@aktivni", SqlDbType.Int));
            command.Parameters["@aktivni"].Value = Kategorie.aktivni;
        }

        public Collection<Kategorie> selectAll()
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Kategorie> Categorys = Read(reader);
            reader.Close();
            return Categorys;
        }

        public Kategorie selectOne(int kat_ID)
        {
            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.Add(new SqlParameter("@kat_ID", SqlDbType.Int));
            command.Parameters["@kat_ID"].Value = kat_ID;
            SqlDataReader reader = db.Select(command);

            Collection<Kategorie> categories = Read(reader);
            Kategorie category = null;
            if (categories.Count == 1)
            {
                category = categories[0];
            }
            reader.Close();
            return category;
        }

        private Collection<Kategorie> Read(SqlDataReader reader)
        {
            Collection<Kategorie> categories = new Collection<Kategorie>();

            while (reader.Read())
            {
                Kategorie category = new Kategorie();
                category.kat_ID = reader.GetInt32(0);
                category.nazev = reader.GetString(1);
                if (!reader.IsDBNull(2))
                {
                    category.popis = reader.GetString(2);
                }
                category.aktivni = reader.GetInt32(3);
                categories.Add(category);
            }
            return categories;
        }

    }
}
