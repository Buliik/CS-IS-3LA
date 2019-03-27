using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Configuration;

namespace Bul0056.Aggregates
{
    public class Prostor
    {
        public int Id { get; set; }
        public double Vzdalenost { get; set; }
        static string conStr { get; set; }

        static Prostor()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }
        public Prostor (int id, double vzdalenost)
        {
            Id = id;
            Vzdalenost = vzdalenost;
        }

        public Prostor()
        {
            Id = 0;
        }
        public static Prostor getById(int id)
        {
            Prostor spr = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Prostor WHERE idSpr=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                spr = new Prostor(reader.GetInt32(0), reader.GetDouble(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return spr;
        }

        public static Collection<Prostor> SelectAll()
        {
            Collection<Prostor> Prostory = new Collection<Prostor>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Prostor;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Prostory.Add(new Prostor(reader.GetInt32(0), reader.GetDouble(1)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Prostory;
        }

        public static Collection<Prostor> SelectAvailable(DateTime start, DateTime finish)
        {
            Collection<Prostor> Prostory = new Collection<Prostor>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "Select * from Prostor p "
                        + "Where not exists ( Select * from Rezervace r "
                        + "Where r.datumStrelby > @start and r.datumStrelby < @finish and r.Prostor_idSpr=p.idSpr )";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@start", start.ToString("yyyy-MM-dd HH:mm"));
                        command.Parameters.AddWithValue("@finish", finish.ToString("yyyy-MM-dd HH:mm"));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Prostory.Add(new Prostor(reader.GetInt32(0), reader.GetDouble(1)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Prostory;
        }

        public static int insert(Prostor Prostor)
        {
            int ret = 0;

            try
            {
                 using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Prostor (Vzdalenost) VALUES (@vzdalenost)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Prostor);
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

        public static int update(Prostor Prostor)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Prostor SET Vzdalenost=@vzdalenost WHERE idZbr=@idZbr";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Prostor);
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

        public static int delete(Prostor Prostor)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Prostor Where idSpr = @idSpr";
                    string sql1 = "UPDATE Rezervace SET Prostor_idSpr=null WHERE Prostor_idSpr=@idSpr";
                    string sql2 = "UPDATE Strelba SET Prostor_idSpr=null WHERE Prostor_idSpr=@idSpr";

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@idSpr", Prostor.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@idSpr", Prostor.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idSpr", Prostor.Id);
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


        private static void PrepareCommand(SqlCommand command, Prostor Prostor)
        {
            command.Parameters.AddWithValue("@idSpr", Prostor.Id);
            command.Parameters.AddWithValue("@vzdalenost", Prostor.Vzdalenost);
        }
    }
}
