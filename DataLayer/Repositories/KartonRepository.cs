using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer.Repositories
{
    public class KartonRepository
    {
        public List<Karton> GetKarton()
        {
            List<Karton> list = new List<Karton>();
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Select * FROM Kartoni";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Karton(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2),dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetDateTime(7)));
                }
            }

            return list;
        }

        public int InsertKarton(Karton k)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Insert into Kartoni(BrojKartona1, IdDoktora1, Recept, Bolest, Alergija, Simptom, Terapija, DatumPoslednjePosete) VALUES(@BrojKartona, @IdDoktora,@Recept, @Bolest, @Alergija,@Simptom, @Terapija ,@DatumPoslednjePosete)";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojKartona", k.BrojKartona);
                com.Parameters.AddWithValue("@IdDoktora", k.IdDoktora);
                com.Parameters.AddWithValue("@Recept", k.Recept);
                com.Parameters.AddWithValue("@Bolest", k.Bolest);
                com.Parameters.AddWithValue("@Alergija", k.Alergija);
                com.Parameters.AddWithValue("@Simptom", k.Simptom);
                com.Parameters.AddWithValue("@Terapija", k.Terapija);
                com.Parameters.AddWithValue("@DatumPoslednjePosete", k.DatumPoslednjePosete);
                result = com.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateKarton(Karton k)
        {
            int result;
            string cons = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BolnicaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string command = "Update Kartoni SET Recept= @Recept, Bolest=@Bolest, Alergija = @Alergija, Simptom = @Simptom, Terapija=@Terapija where BrojKartona1 = @BrojKartona and IdDoktora1 = @IdDoktora";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@BrojKartona", k.BrojKartona);
                com.Parameters.AddWithValue("@IdDoktora", k.IdDoktora);
                com.Parameters.AddWithValue("@Recept", k.Recept);
                com.Parameters.AddWithValue("@Bolest", k.Bolest);
                com.Parameters.AddWithValue("@Alergija", k.Alergija);
                com.Parameters.AddWithValue("@Simptom", k.Simptom);
                com.Parameters.AddWithValue("@Terapija", k.Terapija);
                com.Parameters.AddWithValue("@DatumPoslednjePosete", k.DatumPoslednjePosete);
                result = com.ExecuteNonQuery();
            }

            return result;
        }
       
    }
}
