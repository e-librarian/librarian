using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Reflection.Metadata.BlobBuilder;

namespace login_register
{
    public class Review
    {
        public int id;
        public string username;
        public string isbn;
        public string text;
        public int stars;
        public DateTime time;

        public Review(int id, string username, string isbn, string text, int stars)
        {
            this.id = id;
            this.username = username;
            this.isbn = isbn;
            this.text = text;
            this.stars = stars;
            this.time = time;
        }

        public static List<Review> GetReviews(string query)
        {
            List<Review> Reviews = new List<Review>();
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = query;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {              
                while (reader.Read())
                {
                    //DateTime timestamp = reader.GetDateTime(reader.GetOrdinal("5"));
                    Review review = new Review(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    Reviews.Add(review);
                }        
            }
            else
            {
                //No books were found
                
            }
            reader.Close();
            DBHandler.CloseConnection(connection, command);
            return Reviews;
        }

    }

}
