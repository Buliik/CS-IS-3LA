using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Configuration;

namespace Bul0056.Aggregates
{
    public class Strelba
    {
        public int Id { get; set; }
        public Prostor Prostor { get; set; }
        public Zakaznik Zakaznik { get; set; }
        public Zamestnanec Zamestnanec { get; set; }
        public Zbran Zbran { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        static string conStr { get; set; }

        static Strelba()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }

        public Strelba (int id, DateTime zacatek, DateTime konec, Zbran zbran, Zakaznik zakaznik, Prostor prostor, Zamestnanec zamestnanec)
        {
            Id = id;
            Prostor = prostor;
            Zakaznik = zakaznik;
            Zamestnanec = zamestnanec;
            Zbran = zbran;
            Zacatek = zacatek;
            Konec = konec;
        }

        public Strelba ()
        {
            Id = 0;
            Zbran = new Zbran();
            Zamestnanec = new Zamestnanec();
            Zakaznik = new Zakaznik();
            Prostor = new Prostor();
        }

        public static Strelba getById(int id)
        {
            Strelba str = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Strelba WHERE idStr=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {                               
                                str = new Strelba(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.IsDBNull(3) ? new Zbran() : Zbran.getById(reader.GetInt32(3)), 
                                    reader.IsDBNull(4) ? new Zakaznik() : Zakaznik.getById(reader.GetInt32(4)), reader.IsDBNull(5) ? new Prostor() : Prostor.getById(reader.GetInt32(5)), 
                                    reader.IsDBNull(6) ? new Zamestnanec() : Zamestnanec.getById(reader.GetInt32(5)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return str;
        }

        public static Collection<Strelba> SelectAll()
        {
            Collection<Strelba> Strelba = new Collection<Strelba>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Strelba;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Strelba.Add(new Strelba(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.IsDBNull(3) ? new Zbran() : Zbran.getById(reader.GetInt32(3)),
                                    reader.IsDBNull(4) ? new Zakaznik() : Zakaznik.getById(reader.GetInt32(4)), reader.IsDBNull(5) ? new Prostor() : Prostor.getById(reader.GetInt32(5)),
                                    reader.IsDBNull(6) ? new Zamestnanec() : Zamestnanec.getById(reader.GetInt32(5))));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Strelba;
        }

        public static int insert(Strelba Strelba)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Strelba (Zacatek, Konec, Zakaznik_idZak, Prostor_idSpr, Zbran_idZbr, Zamestnanec_idZam) VALUES (@Zacatek, @Konec, @Zakaznik_idZak, @Prostor_idSpr, @Zbran_idZbr, @Zamestnanec_idZam)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Strelba);
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

        public static int update(Strelba Strelba)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Strelba SET Zacatek=@Zacatek, Konec=@Konec, Zakaznik_idZak=@Zakaznik_idZak, Prostor_idSpr=@Prostor_idSpr, Zbran_idZbr=@Zbran_idZbr, Zamestnanec_idZam=@Zamestnanec_idZam WHERE idRez=@idRez";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Strelba);
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

        public static int delete(Strelba Strelba)
        {
            int ret = 0;

            try
            {
                 using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Strelba Where idStr = @idStr";


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idStr", Strelba.Id);
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


        private static void PrepareCommand(SqlCommand command, Strelba Strelba)
        {
            command.Parameters.AddWithValue("@idStr", Strelba.Id);
            command.Parameters.AddWithValue("@Zacatek", Strelba.Zacatek.ToString("yyyy-MM-dd HH:mm"));
            command.Parameters.AddWithValue("@Konec", Strelba.Konec.ToString("yyyy-MM-dd HH:mm"));
            command.Parameters.AddWithValue("@Zakaznik_idZak", Strelba.Zakaznik.Id);
            command.Parameters.AddWithValue("@Prostor_idSpr", Strelba.Prostor.Id);
            command.Parameters.AddWithValue("@Zbran_idZbr", Strelba.Zbran.Id);
            command.Parameters.AddWithValue("@Zamestnanec_idZam", Strelba.Zamestnanec.Id);
        }
    }
}
