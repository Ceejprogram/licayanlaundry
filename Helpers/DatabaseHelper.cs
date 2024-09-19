using licayanlaundry;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }

    public void RegisterUser(string fullname, DateTime dateOfBirth, string gender, string address, string contactNo, string email, string profilePicturePath, string username, string password, string confirmPassword)
    {
        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            using (MySqlCommand command = new MySqlCommand("INSERT INTO users (fullname, date_of_birth, gender, address, contact_no, email, profile_picture, username, password, confirm_password) VALUES (@fullname, @dateOfBirth, @gender, @address, @contactNo, @email, @profilePicture, @username, @password, @confirmPassword)", connection))
            {
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contactNo", contactNo);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@profilePicture", profilePicturePath);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@confirmPassword", confirmPassword);

                command.ExecuteNonQuery();
            }
        }
    }

    public bool LoginUser(string username, string password)
    {
        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            using (MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }

    public User GetUserInformation(string username)
    {
        User user = null;

        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            using (MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            FullName = reader["fullname"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
                            Gender = reader["gender"].ToString(),
                            Address = reader["address"].ToString(),
                            ContactNo = reader["contact_no"].ToString(),
                            Email = reader["email"].ToString(),
                            ProfilePicturePath = reader["profile_picture"].ToString(),
                            Username = reader["username"].ToString()
                        };
                    }
                }
            }
        }

        return user;
    }


}
