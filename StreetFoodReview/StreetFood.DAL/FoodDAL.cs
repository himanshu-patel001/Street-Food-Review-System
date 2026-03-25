using System.Data;
using System.Data.SqlClient;
using StreetFood.BLL;

namespace StreetFood.DAL
{
    public class FoodDAL
    {
        string conStr = @"Data Source=.;Initial Catalog=StreetFoodDB;Integrated Security=True";

        public void InsertReview(FoodReview f)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query = "INSERT INTO FoodReviews VALUES (@Name,@Food,@Location,@Rating,@Comment)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", f.Name);
            cmd.Parameters.AddWithValue("@Food", f.FoodItem);
            cmd.Parameters.AddWithValue("@Location", f.Location);
            cmd.Parameters.AddWithValue("@Rating", f.Rating);
            cmd.Parameters.AddWithValue("@Comment", f.Comment);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public DataTable GetAllReviews()
        {
            SqlConnection con = new SqlConnection(conStr);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FoodReviews", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
