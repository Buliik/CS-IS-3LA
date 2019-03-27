using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Configuration;

namespace Bul0056.Aggregates
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Email { get; set; }
        public DateTime Datum_narozeni { get; set; }

        static string conStr { get; set; }

        static Zakaznik()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }

        public Zakaznik (int i, string j, string p, string e, DateTime d)
        {
            Id = i;
            Jmeno = j;
            Prijmeni = p;
            Email = e;
            Datum_narozeni = d;
        }

        public Zakaznik ()
        {
            Id = 0;
        }

        public void DelRequest()
        {
            try
            {
                bool ins = false;

                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "Select * from Zadost WHERE Zakaznik_idZak = @id;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                ins = true;
                            }

                        }
                    }

                    if (ins)
                    {
                        sql = "INSERT INTO Zadost (Datum_zadosti, Zakaznik_idZak) VALUES(@Date, @id);";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", Id);
                            command.Parameters.AddWithValue("@Date", DateTime.Now);
                            int ret = command.ExecuteNonQuery();

                        }
                    }


                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static Collection<Zakaznik> Requests()
        {
            Collection<Zakaznik> zakaznici = new Collection<Zakaznik>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "Select * from Zakaznik zak Join Zadost z on z.Zakaznik_idZak = zak.idZak";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                zakaznici.Add(new Zakaznik(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return zakaznici;
        }

        public static Zakaznik getById(int id)
        {
            Zakaznik zak = null;
            try
            {
  
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zakaznik WHERE idZak=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                zak = new Zakaznik(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return zak;
        }

        public static Collection<Zakaznik> SelectAll()
        {
            Collection<Zakaznik> Zakaznici = new Collection<Zakaznik>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Zakaznik;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Zakaznici.Add(new Zakaznik(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Zakaznici;
        }

        public static int insert(Zakaznik Zakaznik)
        {
            int ret = 0;

            try
            {
                 using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Zakaznik (Jmeno, Prijmeni, email, Datum_narozeni) VALUES (@Jmeno, @Prijmeni, @email, @Datum_narozeni)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zakaznik);
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

        public static int update(Zakaznik Zakaznik)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Zakaznik SET Jmeno=@Jmeno, Prijmeni=@Prijmeni, email=@email, Datum_narozeni=@Datum_narozeni WHERE idZak=@idZak";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Zakaznik);
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

        public static int delete(Zakaznik Zakaznik)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Zakaznik Where idZak = @idZak";
                    string sql1 = "UPDATE Rezervace SET Zakaznik_idZak=null WHERE Zakaznik_idZak=@idZak";
                    string sql2 = "UPDATE Strelba SET Zakaznik_idZak=null WHERE Zakaznik_idZak=@idZak";
                    string sql3 = "DELETE FROM Zadost where Zakaznik_idZak=@idZak";

                    using (SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        command.Parameters.AddWithValue("@idZak", Zakaznik.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        command.Parameters.AddWithValue("@idZak", Zakaznik.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql3, connection))
                    {
                        command.Parameters.AddWithValue("@idZak", Zakaznik.Id);
                        ret = command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idZak", Zakaznik.Id);
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


        private static void PrepareCommand(SqlCommand command, Zakaznik Zakaznik)
        {
            command.Parameters.AddWithValue("@idZak", Zakaznik.Id);
            command.Parameters.AddWithValue("@Jmeno", Zakaznik.Jmeno);
            command.Parameters.AddWithValue("@Prijmeni", Zakaznik.Prijmeni);
            command.Parameters.AddWithValue("@email", Zakaznik.Email);
            command.Parameters.AddWithValue("@Datum_narozeni", Zakaznik.Datum_narozeni);
        }


    }
}
