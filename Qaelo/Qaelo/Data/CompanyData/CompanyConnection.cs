using MySql.Data.MySqlClient;
using Qaelo.Models.CompanyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Data.CompanyData
{
    public class CompanyConnection: Connection
    {
        public bool updateCompany(Company company)
        {
            bool success = false;

            query = @"UPDATE company  SET CompanyType = @CompanyType, Description = @Description,FacebookLink = @FacebookLink, Name = @Name, Number = @Number,ProfileImage = @ProfileImage WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", company.Id);
                command.Parameters.AddWithValue("@CompanyType", company.CompanyType);
                command.Parameters.AddWithValue("@Description", company.Description);
                command.Parameters.AddWithValue("@FacebookLink", company.FacebookLink);
                command.Parameters.AddWithValue("@Name", company.Name);
                command.Parameters.AddWithValue("@Number", company.Number);
                command.Parameters.AddWithValue("@ProfileImage", company.ProfileImage);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }
            return success;
        }

        public Company getCompanyById(int id)
        {
            Company company = null;

            string query = "SELECT * FROM Company WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            company = new Company(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetString(10), reader.GetBoolean(11));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return company;
        }

        public bool createPost(Job job)
        {
            bool success = false;

            query = @"INSERT INTO jobs(CompanyId, ClosingDate, ContactInfo, DatePosted, Description, Title, Type) values(@CompanyId, @ClosingDate, @ContactInfo, @DatePosted, @Description, @Title, @Type)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@CompanyId", job.CompanyId);
                command.Parameters.AddWithValue("@ClosingDate", job.ClosingDate);
                command.Parameters.AddWithValue("@ContactInfo", job.ContactInfo);
                command.Parameters.AddWithValue("@DatePosted", job.DatePosted);
                command.Parameters.AddWithValue("@Description",job.Description);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Type", job.Type);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool updatePost(Job job)
        {
            bool success = false;

            query = @"UPDATE jobs SET ContactInfo = @ContactInfo, Description = @Description, Title = @Title
                      WHERE CompanyId = @CompanyId AND Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@CompanyId", job.CompanyId);
                command.Parameters.AddWithValue("@ContactInfo", job.ContactInfo);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Id", job.Id);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Job getPostById(int id)
        {
            Job job = null;

            query = "SELECT * FROM jobs WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            job = new Job(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2),reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return job;
        }

        public List<Job> getAllPosts()
        {
            List<Job> jobs = new List<Job>();

            query = "SELECT * FROM jobs";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                //command.Parameters.AddWithValue("@id", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            jobs.Add(new Job(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return jobs;
        }

        public List<Job> getAllPostByCompanyId(int id)
        {
            List<Job> jobs = new List<Job>();

            query = "SELECT * FROM jobs WHERE CompanyId = @CompanyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@CompanyId", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            jobs.Add(new Job(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return jobs;
        }

        public bool deletePost(int id, int CompanyId)
        {
            bool success = false;
            string query = "DELETE FROM jobs WHERE Id = @Id AND CompanyId = @CompanyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@CompanyId", CompanyId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            return success;
        }

        public bool postLikedByUser(int jobId, int userId)
        {
            bool liked = false;
            query = "SELECT * FROM joblikes WHERE JobId = @JobId AND UserId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@JobId", jobId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        liked = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return liked;
        }

        public List<int> getAllLikedUsers(int jobId, int companyId)
        {
            List<int> ids = new List<int>();

            query = "SELECT * FROM joblikes WHERE  JobId = @JobId AND CompanyId = @CompanyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@JobId", jobId);
                command.Parameters.AddWithValue("@CompanyId", companyId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(3));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return ids;
        }

        public bool likePost(int jobId, int CompanyId, int userId)
        {
            bool success = false;
            query = @"INSERT INTO jobLikes(JobId,CompanyId,UserId) values(@JobId,@CompanyId,@UserId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@JobId", jobId);
                command.Parameters.AddWithValue("@CompanyId", CompanyId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void unlikePost(int JobId, int userId)
        {
            string query = "DELETE FROM JobLikes WHERE JobId = @JobId AND UserId = @userId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@JobId", JobId);
                command.Parameters.AddWithValue("@userId", userId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }
    }
}