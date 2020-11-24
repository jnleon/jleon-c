using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Items
{
    public class UserSqlDao : IUserDao
    {
        private readonly string connectionString;

        public UserSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from users", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.FirstName = Convert.ToString(reader["first_name"]);
                        user.LastName = Convert.ToString(reader["last_name"]);
                        user.Email = Convert.ToString(reader["email"]);
                        user.Role = Convert.ToString(reader["role"]);
                        user.Created = Convert.ToDateTime(reader["created"]);


                        list.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error getting users.");
                Console.WriteLine(e.Message);
                throw;
            }
            return list;
        }

        public void Save(User newUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO users(first_name,last_name,email,role,created)" +
                                                   " VALUES(@first_name,@last_name,@email,@role,@created)", conn);
                    
                    cmd.Parameters.AddWithValue("@first_name", newUser.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", newUser.LastName);
                    cmd.Parameters.AddWithValue("@email", newUser.Email);
                    cmd.Parameters.AddWithValue("@role", newUser.Role);
                    cmd.Parameters.AddWithValue("@created", newUser.Created) ;


                    int numRowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Number of rows affected: " + numRowsAffected);
                    cmd = new SqlCommand("SELECT MAX(id) FROM users;", conn);
                  
                    newUser.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error getting users.");
                Console.WriteLine(e.Message);
            }

        }
    }
    }
