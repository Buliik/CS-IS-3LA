using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Bul0056.Aggregates
{
    public class Zbran
    {


        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Typ { get; set; }
        public double Raze { get; set; }
        public int Rok_vyroby { get; set; }
        static string conStr {get; set;}

        static Zbran()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }
        public Zbran (int ID, string n, string t, double r, int rv)
        {
            Id = ID;
            Nazev = n;
            Typ = t;
            Raze = r;
            Rok_vyroby = rv;
        }

        public Zbran()
        {
            Id = 0;
        }

        public static Zbran getById (int id)
        {
            Zbran zbr = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zbran WHERE idZbr=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                zbr = new Zbran(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return zbr;
        }

        public static Collection<Zbran> SelectAll()
        {
            Collection<Zbran> Zbrane = new Collection<Zbran>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zbran;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Zbrane.Add(new Zbran(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Zbrane;
        }

        public static Collection<Zbran> SelectAvailable(DateTime start, DateTime finish)
        {
            Collection<Zbran> Zbrane = new Collection<Zbran>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "Select * from Zbran z "
                        + "Where not exists ( Select * from Rezervace r "
                        + "Where r.datumStrelby > @start and r.datumStrelby < @finish and r.Zbran_idZbr=z.idZbr )";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@start", start.ToString("yyyy-MM-dd HH:mm"));
                        command.Parameters.AddWithValue("@finish", finish.ToString("yyyy-MM-dd HH:mm"));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Zbrane.Add(new Zbran(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetInt32(4)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Zbrane;
        }

        public static int insert(Zbran Zbran)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Zbran (Nazev, Typ_Zbrane, Raze, Rok_Vyroby) VALUES (@Nazev, @Typ_zbrane, @Raze, @Rok_vyroby)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zbran);
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

        public static int update(Zbran Zbran)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Zbran SET Nazev=@Nazev, Typ_zbrane=@Typ_zbrane, Raze=@Raze, Rok_vyroby=@Rok_vyroby WHERE idZbr=@idZbr";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zbran);
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

        public static int delete(Zbran Zbran)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Zbran Where idZbr = @idZbr";
                    string sql1 = "UPDATE Rezervace SET Zbran_idZbr=null WHERE Zbran_idZbr=@idZbr";
                    string sql2 = "UPDATE Strelba SET Zbran_idZbr=null WHERE Zbran_idZbr=@idZbr";

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@idZbr", Zbran.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@idZbr", Zbran.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idZbr", Zbran.Id);
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


        private static void PrepareCommand(SqlCommand command, Zbran Zbran)
        {
            command.Parameters.AddWithValue("@idZbr", Zbran.Id);
            command.Parameters.AddWithValue("@Nazev", Zbran.Nazev);
            command.Parameters.AddWithValue("@Typ_zbrane", Zbran.Typ);
            command.Parameters.AddWithValue("@Raze", Zbran.Raze);
            command.Parameters.AddWithValue("@Rok_vyroby", Zbran.Rok_vyroby);
        }
    } 
}
