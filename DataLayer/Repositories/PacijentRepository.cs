using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.Repositories
{
    public class PacijentRepository
    {
        public List<Pacijent> GetPacijent()
        {
            List<Pacijent> list = new List<Pacijent>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Select * FROM Pacijenti";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Pacijent(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5)));
                }
            }

            return list;
        }

        public int InsertPacijent(Pacijent p)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string command = "Insert into Pacijenti(Ime, Prezime, JMBG, Adresa, BrojTelefona) VALUES(@Ime, @Prezime,@JMBG, @Adresa ,@BrojTelefona)";
                    SqlCommand com = new SqlCommand(command, con);
                    
                    com.Parameters.AddWithValue("@Ime", p.Ime);
                    com.Parameters.AddWithValue("@Prezime", p.Prezime);
                    com.Parameters.AddWithValue("@JMBG", p.JMBG);
                    com.Parameters.AddWithValue("@Adresa", p.Adresa);
                    com.Parameters.AddWithValue("@BrojTelefona", p.BrojTelefona);
                    result = com.ExecuteNonQuery();
                }

            return result;
        }

        public int UpdatePacijent(Pacijent p)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Update Pacijenti SET Ime= @Ime, Prezime=@Prezime, JMBG = @JMBG, Adresa = @Adresa, BrojTelefona=@BrojTelefona where BrojKartona = @BrojKartona";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojKartona", p.BrojKartona);
                com.Parameters.AddWithValue("@Ime", p.Ime);
                com.Parameters.AddWithValue("@Prezime", p.Prezime);
                com.Parameters.AddWithValue("@JMBG", p.JMBG);
                com.Parameters.AddWithValue("@Adresa", p.Adresa);
                com.Parameters.AddWithValue("@BrojTelefona", p.BrojTelefona);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int DeletePacijent(int pid)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Delete From Pacijenti where BrojKartona=@BrojKartona";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojKartona", pid);
                result = com.ExecuteNonQuery();
            }

            return result;
        }
    }
}
