using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.Repositories
{
    public class DoktorRepository
        {
            public List<Doktor> GetDoktor()
            {
                List<Doktor> list = new List<Doktor>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string command = "Select * FROM Doktori";
                    SqlCommand com = new SqlCommand(command, con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new Doktor(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7)));
                    }
                }

                return list;
            }

            public int InsertDoktor(Doktor d)
            {
                int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string command = "Insert into Doktori(IdDoktora, Ime, Prezime, JMBG, Specijalnost, BrojTelefona, KorisnickoIme, Lozinka) VALUES(@IdDoktora, @Ime, @Prezime,@JMBG, @Specijalnost ,@BrojTelefona, @KorisnickoIme, @Lozinka)";
                    SqlCommand com = new SqlCommand(command, con);
                    com.Parameters.AddWithValue("@IdDoktora", d.IdDoktora);
                    com.Parameters.AddWithValue("@Ime", d.Ime);
                    com.Parameters.AddWithValue("@Prezime", d.Prezime);
                    com.Parameters.AddWithValue("@JMBG", d.JMBG);
                    com.Parameters.AddWithValue("@Specijalnost", d.Specijalnost);
                    com.Parameters.AddWithValue("@BrojTelefona", d.BrojTelefona);
                    com.Parameters.AddWithValue("@KorisnickoIme", d.KorisnickoIme);
                    com.Parameters.AddWithValue("@Lozinka", d.Lozinka);
                    result = com.ExecuteNonQuery();
                }

                return result;
            }

            public int UpdateDoktor(Doktor d)
            {
             int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string command = "Update Doktori SET Ime= @Ime, Prezime=@Prezime, JMBG = @JMBG, Specijalnost = @Specijalnost, BrojTelefona=@BrojTelefona, KorisnickoIme=@KorisnickoIme, Lozinka=@Lozinka where IdDoktora = @IdDoktora";
                    SqlCommand com = new SqlCommand(command, con);
                    com.Parameters.AddWithValue("@IdDoktora", d.IdDoktora);
                    com.Parameters.AddWithValue("@Ime", d.Ime);
                    com.Parameters.AddWithValue("@Prezime", d.Prezime);
                    com.Parameters.AddWithValue("@JMBG", d.JMBG);
                    com.Parameters.AddWithValue("@Specijalnost", d.Specijalnost);
                    com.Parameters.AddWithValue("@BrojTelefona", d.BrojTelefona);
                    com.Parameters.AddWithValue("@KorisnickoIme", d.KorisnickoIme);
                    com.Parameters.AddWithValue("@Lozinka", d.Lozinka);
                    result = com.ExecuteNonQuery();
                }

                return result;
            }

            public int DeleteDoktor(int did)
            {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string command = "Delete From Doktori where IdDoktora=@IdDoktora";
                    SqlCommand com = new SqlCommand(command, con);
                    com.Parameters.AddWithValue("@IdDoktora", did);
                    result = com.ExecuteNonQuery();
                }

                return result;
            }
        }
}
