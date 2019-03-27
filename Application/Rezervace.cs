using System;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Bul0056.Aggregates
{
    public class Rezervace
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Vytvoreni { get; set; }
        public Zbran Zbran { get; set; }
        public Zakaznik Zakaznik { get; set; }
        public Prostor Prostor { get; set; }
        static string conStr { get; set; }

        static Rezervace()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConnectionStringMsSql"].ConnectionString;
        }
        public Rezervace(int ID, DateTime s, DateTime v, Zbran zbran, Zakaznik zakaznik, Prostor prostor)
        {
            Id = ID;
            Start = s;
            Vytvoreni = v;
            Zbran = zbran;
            Zakaznik = zakaznik;
            Prostor = prostor;
        }

        public Rezervace ()
        {
            Id = 0;
            Zbran = new Zbran();
            Zakaznik = new Zakaznik();
            Prostor = new Prostor();
        }

        public static Rezervace getById(int id)
        {
            Rezervace rez = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Rezervace WHERE idRez=@id;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rez = new Rezervace(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), Zbran.getById(reader.GetInt32(3)), Zakaznik.getById(reader.GetInt32(4)), Prostor.getById(reader.GetInt32(5)));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return rez;
        }

        public static Collection<Rezervace> SelectAll()
        {
            Collection<Rezervace> Rezervace = new Collection<Rezervace>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Rezervace;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rezervace.Add(new Rezervace(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), Zbran.getById(reader.GetInt32(3)), Zakaznik.getById(reader.GetInt32(4)), Prostor.getById(reader.GetInt32(5))));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Rezervace;
        }

        public static int insert(Rezervace Rezervace)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "INSERT INTO Rezervace (datumVytvoreni, datumStrelby, Zakaznik_idZak, Prostor_idSpr, Zbran_idZbr) VALUES (@datumVytvoreni, @datumStrelby, @Zakaznik_idZak, @Prostor_idSpr, @Zbran_idZbr)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Rezervace);
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

        public static int update(Rezervace Rezervace)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    string sql = "UPDATE Rezervace SET datumVytvoreni=@datumVytvoreni, datumStrelby=@datumStrelby, Zakaznik_idZak=@Zakaznik_idZak, Prostor_idSpr=@Prostor_idSpr, Zbran_idZbr=@Zbran_idZbr WHERE idRez=@idRez";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        PrepareCommand(command, Rezervace);
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

        public static int delete(Rezervace Rezervace)
        {
            int ret = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    string sql = "DELETE FROM Rezervace Where idRez = @idRez";


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idRez", Rezervace.Id);
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


        private static void PrepareCommand(SqlCommand command, Rezervace rezervace)
        {
            command.Parameters.AddWithValue("@idRez", rezervace.Id);
            command.Parameters.AddWithValue("@datumVytvoreni", rezervace.Vytvoreni);
            command.Parameters.AddWithValue("@datumStrelby", rezervace.Start);
            command.Parameters.AddWithValue("@Zakaznik_idZak", rezervace.Zakaznik.Id);
            command.Parameters.AddWithValue("@Prostor_idSpr", rezervace.Prostor.Id);
            command.Parameters.AddWithValue("@Zbran_idZbr", rezervace.Zbran.Id);
        }


    }
}
