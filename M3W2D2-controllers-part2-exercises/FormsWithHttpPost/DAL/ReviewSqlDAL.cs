using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        string connectionString;
        string getReviews = "SELECT * FROM reviews";
        string SQLSaveReview = "INSERT INTO reviews VALUES(@username, @rating, @review_title, @review_text, getdate());";

        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Review> GetAllReviews()
        {
            List<Review> theseReviews = new List<Review>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = getReviews;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Review myReview = new Review();
                        myReview.Id = Convert.ToInt32(reader["review_id"]);
                        myReview.Title = Convert.ToString(reader["review_title"]);
                        myReview.Username = Convert.ToString(reader["username"]);
                        myReview.ReviewDate = Convert.ToDateTime(reader["review_date"]);
                        myReview.Rating = Convert.ToInt32(reader["rating"]);
                        myReview.Message = Convert.ToString(reader["review_text"]);
                        theseReviews.Add(myReview);
                    }
                }
                return theseReviews;
            }
            catch (SqlException e)
            {
                throw new NotImplementedException();
            }
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQLSaveReview;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.Title);
                    cmd.Parameters.AddWithValue("@review_text", newReview.Message);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException e)
            {
                throw new NotImplementedException();
            }
        }
    }
}