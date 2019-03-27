using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;
using System.Configuration;

namespace Bul0056.Aggregates
{
    public class Zamestnanec
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public DateTime Datum_narozeni { get; set; }

        static string conStr { get; set; }

        static Zamestnanec()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }

        public Zamestnanec(int i, string j, string p, string e, DateTime d)
        {
            Id = i;
            Jmeno = j;
            Prijmeni = p;
            Email = e;
            Datum_narozeni = d;
        }

        public Zamestnanec()
        {
            Id = 0;
        }

        public static void sXML()
        {
            XmlSerializer xSer = new XmlSerializer(typeof(Collection<Zamestnanec>));
            Collection<Zamestnanec> zamestnanci = Zamestnanec.SelectAll();

            using (var stream = File.OpenWrite("Zamestnanci.xml"))
            {
                xSer.Serialize(stream, zamestnanci);
            }        
        }

        public static Zamestnanec getById(int id)
        {
            Zamestnanec zam = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zamestnanec WHERE idZam=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                zam = new Zamestnanec(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return zam;
        }

        public static Collection<Zamestnanec> SelectAll()
        {
            Collection<Zamestnanec> Zamestnanci = new Collection<Zamestnanec>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zamestnanec;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Zamestnanci.Add(new Zamestnanec(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Zamestnanci;
        }

        public static int insert(Zamestnanec Zamestnanec)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Zamestnanec (Jmeno, Prijmeni, email, Datum_narozeni) VALUES (@Jmeno, @Prijmeni, @email, @Datum_narozeni)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zamestnanec);
                        ret = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ret;
        }

        public static int update(Zamestnanec Zamestnanec)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Zamestnanec SET Jmeno=@Jmeno, Prijmeni=@Prijmeni, email=@email, Datum_narozeni=@Datum_narozeni WHERE idZam=@idZam";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zamestnanec);
                        ret = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ret;
        }

        public static int delete(Zamestnanec Zamestnanec)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Zamestnanec Where idZam = @idZam";
                    string sql2 = "UPDATE Strelba SET Zamestnanec_idZam=null WHERE Zamestnanec_idZam=@idZam";

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@idZam", Zamestnanec.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idZam", Zamestnanec.Id);
                        ret = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ret;
        }


        private static void PrepareCommand(SqlCommand command, Zamestnanec Zamestnanec)
        {
            command.Parameters.AddWithValue("@idZam", Zamestnanec.Id);
            command.Parameters.AddWithValue("@Jmeno", Zamestnanec.Jmeno);
            command.Parameters.AddWithValue("@Prijmeni", Zamestnanec.Prijmeni);
            command.Parameters.AddWithValue("@email", Zamestnanec.Email);
            command.Parameters.AddWithValue("@Datum_narozeni", Zamestnanec.Datum_narozeni);
        }
    }
}
