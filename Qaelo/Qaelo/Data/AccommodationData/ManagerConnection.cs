using MySql.Data.MySqlClient;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;

namespace Qaelo.Data.AccommodationData
{
    public class ManagerConnection : Connection
    {
        //Post
        internal bool unverify(int id)
        {
            bool success = false;

            query = @"UPDATE managers SET RegistrationDate = @RegistrationDate,Verified = @Verified
                                          WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Verified", false);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command.Connection.Close();

                success = true;
            }

            return success;
        }

        internal bool addManager(Manager user)
        {
            bool success = false;

            query = @"INSERT INTO managers(Accredited,DescriptionOfProperty,Email,FacebookLink,FirstName,LastName,Number,Password,ProfileImage,PropertyName,Verified) 
                                    Values(@accredited,@descriptionOfProperty,@email,@facebookLink,@firstName,@lastName,@number,@password,@profileImage,@propertyName,@Verified)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@accredited", user.accredited);
                command.Parameters.AddWithValue("@descriptionOfProperty", user.descriptionOfProperty);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@facebookLink", user.facebookLink);
                command.Parameters.AddWithValue("@firstName", user.firstName);
                command.Parameters.AddWithValue("@lastName", user.lastName);
                command.Parameters.AddWithValue("@number", user.number);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@profileImage", user.profileImage);
                command.Parameters.AddWithValue("@propertyName", user.propertyName);
                command.Parameters.AddWithValue("@Verified", user.verified);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
            }

        //Get
        internal Manager getManager(int id)
        {
            Manager user = null;

            string query = "SELECT * FROM managers WHERE Id = @id";

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
                            user = new Manager(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetBoolean(13));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return user;
        }

        internal List<Manager> getAllManagers()
        {
            List<Manager> users = new List<Manager>();

            string query = "SELECT * FROM managers";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            users.Add( new Manager(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetBoolean(13)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return users;
        }
        //Update 
        internal bool updateManager(Manager user,int id)
        {
            bool success = false;

            query = @"UPDATE managers SET Accredited = @accredited, DescriptionOfProperty = @descriptionOfProperty,FacebookLink = @facebookLink,
                                          FirstName = @firstName,LastName = @lastName,Number = @number,ProfileImage = @profileImage,PropertyName = @propertyName
                                          WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@accredited", user.accredited);
                command.Parameters.AddWithValue("@descriptionOfProperty", user.descriptionOfProperty);
                command.Parameters.AddWithValue("@facebookLink", user.facebookLink);
                command.Parameters.AddWithValue("@firstName", user.firstName);
                command.Parameters.AddWithValue("@lastName", user.lastName);
                command.Parameters.AddWithValue("@number", user.number);
                command.Parameters.AddWithValue("@profileImage", user.profileImage);
                command.Parameters.AddWithValue("@propertyName", user.propertyName); 

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        internal bool verify(int id)
        {
            bool success = false;

            query = @"UPDATE managers SET RegistrationDate = @RegistrationDate,Verified = @Verified
                                          WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", id); 
                command.Parameters.AddWithValue("@Verified", true); 
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command.Connection.Close();

                success = true;
            }

            return success;
        }

        internal bool updateManagerPassword(int managerId, string newPassword,string oldPassword)
        {
            bool status = false;

            query = @"UPDATE managers SET Password = @password where Id = @Id AND Password = @oldPassword";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Id", managerId); 
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@oldPassword", oldPassword);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                //Close Connection
                command.Connection.Close();
                status = true;
            }

            return status;
        }

        //Delete
        public bool deletedManager(int managerId)
        {
            bool success = false;

            string query = "DELETE FROM managers WHERE  Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", managerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            //Delete accommodation
            query = "DELETE FROM accommodation WHERE  ManagerId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", managerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            //Delete accommodationjoined
            query = "DELETE FROM accommodationjoined WHERE  ManagerId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", managerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }


            return success;
        }

    }
}
 