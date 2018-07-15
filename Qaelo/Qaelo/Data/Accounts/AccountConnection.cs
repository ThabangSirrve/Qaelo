using MySql.Data.MySqlClient;
using Qaelo.Models.AccommodationModel;
using Qaelo.Models.CompanyModel;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.ShopOwnerModel;
using Qaelo.Models.SocietyModel;
using Qaelo.Models.StudentModel;
using System;

namespace Qaelo.Data.Accounts
{
    public class AccountConnection :Connection
    {
        public bool adminAccess(string email, string password)
        {
            bool success = false;


            string query = "SELECT * FROM Admin WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        #region Student
        
        public bool registerStudent(Student student)
        {
            bool success = false;

            query = @"INSERT INTO Students(Campus, Description, Email, FirstName, Institution, LastName, Number, Password, ProfileImage, QualificationEnrolled, RegistrationDate, UserType, YearOfStudy)
                                  Values(@Campus, @Description, @Email, @FirstName, @Institution, @LastName, @Number, @Password, @ProfileImage, @QualificationEnrolled, @RegistrationDate, @UserType, @YearOfStudy)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Campus",student.Campus);
                command.Parameters.AddWithValue("@Description", student.Description);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@Institution", student.Institution);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Number", student.Number);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@ProfileImage", student.ProfileImage);
                command.Parameters.AddWithValue("@QualificationEnrolled", student.QualificationEnrolled);
                command.Parameters.AddWithValue("@RegistrationDate", student.RegistrationDate);
                command.Parameters.AddWithValue("@UserType", student.UserType);
                command.Parameters.AddWithValue("@YearOfStudy", student.YearOfStudy);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            //Activate Profile
            new StudentData.StudentConnection().uploadStudentProfile(student);

            return success;
        }

        public Student getStudent(int id)
        {
            Student student = null;

            query = "SELECT * FROM students WHERE Id = @id";

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
                            student = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return student;
        }

        public int getStudentId(string email)
        {
            int studentId = -1;

            query = "SELECT * FROM students WHERE Email = @Email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            studentId = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return studentId;
        }

        public int getIdByFacebookId(string facebookId)
        {
            int studentId = -1;

            query = "SELECT * FROM students WHERE Password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Password", facebookId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            studentId = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return studentId;
        }

        public Student loginStudent(string email,string password)
        {
            Student student = null;

            query = "SELECT * FROM students WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                          student = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return student;
        }

        public Student loginWithFacebook(string email, string password)
        {
            Student student = null;

            query = "SELECT * FROM students WHERE Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            student = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return student;
        }

        public bool correctStudent(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM students WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validStudent(string email)
        {
            bool valid = true;

            query = "SELECT * FROM students WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }


            return valid;
        }

        public bool validFacebookLogin(string password)
        {
            bool valid = false;

            query = "SELECT * FROM students WHERE Password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }


            return valid;
        }

        public void studentCreation(string email,string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifyStudent(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM students WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverified(string email,string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccount(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if(reader.Read())
                        {
                            if(!reader.GetBoolean(3))
                              exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerified(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if(reader.Read())
                        {
                            if(reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatus(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool updateStudentPassword(int Id, string newPassword, string oldPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE students SET Password = @Password WHERE Id = @Id AND Password = @OldPassword";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);
                command.Parameters.AddWithValue("@Id", Id);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }
        #endregion Student

        #region Shop Owner
        public bool registerShopOwner(ShopOwner shopOwner)
        {
            bool success = false;

            query = @"INSERT INTO shopowner(Email, FullName, Number, Password, RegistrationDate, UserType, Verified) Values(@Email, @FullName, @Number, @Password, @RegistrationDate, @UserType, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Email", shopOwner.Email);
                command.Parameters.AddWithValue("@FullName", shopOwner.FullName);
                command.Parameters.AddWithValue("@Number", shopOwner.Number);
                command.Parameters.AddWithValue("@Password", shopOwner.Password);
                command.Parameters.AddWithValue("@RegistrationDate", shopOwner.RegistrationDate);
                command.Parameters.AddWithValue("@UserType", shopOwner.UserType);
                command.Parameters.AddWithValue("@Verified", shopOwner.Verified);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public ShopOwner loginShopOwner(string email, string password)
        {
            ShopOwner shopOwner = null;

            string query = "SELECT * FROM shopowner WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            shopOwner = new ShopOwner(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6), reader.GetBoolean(7));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return shopOwner;
        }

        public bool correctShopOwner(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM shopowner WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validShopOwner(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM ShopOwner WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public void ShopOwnerCreation(string email, string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifyShopOwner(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM ShopOwner WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverifiedShopOwner(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccountShopOwner(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean(3))
                                exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerifiedShopOwner(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatusShopOwner(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        #endregion

        #region EventPoster
        public bool registerEventPoster(EventPoster EventPoster)
        {
            bool success = false;
            query = @"INSERT INTO eventposter(Email, FullName, Number, Password,ProfileImage, RegistrationDate, UserType, Verified) Values(@Email, @FullName, @Number, @Password,@ProfileImage, @RegistrationDate, @UserType, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Email", EventPoster.Email);
                command.Parameters.AddWithValue("@FullName", EventPoster.FullName);
                command.Parameters.AddWithValue("@Number", "");
                command.Parameters.AddWithValue("@Password", EventPoster.Password);
                command.Parameters.AddWithValue("@ProfileImage", "");
                command.Parameters.AddWithValue("@RegistrationDate", EventPoster.RegistrationDate);
                command.Parameters.AddWithValue("@UserType", EventPoster.UserType);
                command.Parameters.AddWithValue("@Verified", EventPoster.Verified);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }
        public bool updateEventPassword(int Id, string newPassword, string oldPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE eventposter SET Password = @Password WHERE Id = @Id AND Password = @OldPassword";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);
                command.Parameters.AddWithValue("@Id", Id);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public EventPoster loginEventPoster(string email, string password)
        {
            EventPoster EventPoster = null;

            string query = "SELECT * FROM EventPoster WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            EventPoster = new EventPoster(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetBoolean(8));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return EventPoster;
        }

        public bool correctEventPoster(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM eventposter WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validEventPoster(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM eventposter WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public void EventPosterCreation(string email, string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifyEventPoster(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM eventposter WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverifiedEventPoster(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccountEventPoster(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean(3))
                                exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerifiedEventPoster(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatusEventPoster(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        #endregion

        #region Society
        public bool registerSociety(Society society)
        {
            bool success = false;        //Campus, Description, Email, FacebookLink, MeetingDay, MeetingTime, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, University, UserType, Video, Verified
            query = @"INSERT INTO Society(Campus, Description, Email, FacebookLink,MeetingDay, MeetingTime, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType,University ,UserType, Video, Verified) 
                Values(@Campus, @Description, @Email, @FacebookLink,@MeetingDay, @MeetingTime, @Name, @Number, @Password, @ProfileImage, @RegistrationDate, @SocietyType,@University, @UserType, @Video, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Campus", society.Campus);
                command.Parameters.AddWithValue("@Description", society.Description);
                command.Parameters.AddWithValue("@Email", society.Email);
                command.Parameters.AddWithValue("@FacebookLink", society.FacebookLink);
                command.Parameters.AddWithValue("@MeetingDay", society.MeetingDay);
                command.Parameters.AddWithValue("@MeetingTime", society.MeetingTime);
                command.Parameters.AddWithValue("@Name", society.Name);
                command.Parameters.AddWithValue("@Number", society.Number);
                command.Parameters.AddWithValue("@Password", society.Password);
                command.Parameters.AddWithValue("@ProfileImage", society.ProfileImage);
                command.Parameters.AddWithValue("@RegistrationDate", society.RegistrationDate);
                command.Parameters.AddWithValue("@SocietyType", society.SocietyType);
                command.Parameters.AddWithValue("@University", society.University);
                command.Parameters.AddWithValue("@UserType", society.UserType);
                command.Parameters.AddWithValue("@Video", society.Video);
                command.Parameters.AddWithValue("@Verified", society.Verified);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Society loginSociety(string email, string password)
        {
            Society Society = null;

            string query = "SELECT * FROM Society WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            Society = new Society(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10),reader.GetDateTime(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetBoolean(16));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Society;
        }

        public bool correctSociety(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM society WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validSociety(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM Society WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public void SocietyCreation(string email, string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifySociety(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM Society WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverifiedSociety(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccountSociety(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean(3))
                                exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerifiedSociety(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatusSociety(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        //Password Change 
        public bool updatePassword(int Id, string newPassword,string oldPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE Society SET Password = @Password WHERE Id = @Id AND Password = @OldPassword";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);
                command.Parameters.AddWithValue("@Id", Id);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }
        #endregion

        #region Company
        public bool registerCompany(Company company)
        {
            bool success = false;
            query = @"INSERT INTO Company(CompanyType,Description,Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, UserType, Verified) Values(@CompanyType,@Description,@Email, @FacebookLink, @Name, @Number, @Password, @ProfileImage, @RegistrationDate, @UserType, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Email", company.Email);
                command.Parameters.AddWithValue("@Description", company.Description);
                command.Parameters.AddWithValue("@FacebookLink", company.FacebookLink);
                command.Parameters.AddWithValue("@Name", company.Name);
                command.Parameters.AddWithValue("@Number", company.Number);
                command.Parameters.AddWithValue("@Password", company.Password);
                command.Parameters.AddWithValue("@ProfileImage", company.ProfileImage);
                command.Parameters.AddWithValue("@RegistrationDate", company.RegistrationDate);
                command.Parameters.AddWithValue("@CompanyType", company.CompanyType);
                command.Parameters.AddWithValue("@UserType", company.UserType);
                command.Parameters.AddWithValue("@Verified", true);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Company loginCompany(string email, string password)
        {
            Company Company = null;

            string query = "SELECT * FROM Company WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            Company = new Company(reader.GetInt32(0),reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetString(10), reader.GetBoolean(11));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Company;
        }

        public bool correctCompany(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM Company WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validCompany(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM Company WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public void CompanyCreation(string email, string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifyCompany(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM Company WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverifiedCompany(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccountCompany(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean(3))
                                exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerifiedCompany(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatusCompany(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool updateCompanyPassword(int Id, string newPassword, string oldPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE Company SET Password = @Password WHERE Id = @Id AND Password = @OldPassword";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);
                command.Parameters.AddWithValue("@Id", Id);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        #endregion

        #region PropertyManager
        public bool registerPropertyManager(Manager manager)
        {
            bool success = false;
            query = @"INSERT INTO managers(Accredited, DescriptionOfProperty, Email, FacebookLink, FirstName, LastName, Number, Password, ProfileImage, PropertyName, RegistrationDate,UserType, Verified)
                    Values(@Accredited, @DescriptionOfProperty, @Email, @FacebookLink, @FirstName, @LastName, @Number, @Password, @ProfileImage, @PropertyName, @RegistrationDate,@UserType, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Accredited", manager.accredited);
                command.Parameters.AddWithValue("@DescriptionOfProperty", manager.descriptionOfProperty);
                command.Parameters.AddWithValue("@Email", manager.email);
                command.Parameters.AddWithValue("@FacebookLink", manager.facebookLink);
                command.Parameters.AddWithValue("@FirstName", manager.firstName);
                command.Parameters.AddWithValue("@LastName", manager.lastName);
                command.Parameters.AddWithValue("@Number", manager.number);
                command.Parameters.AddWithValue("@Password", manager.password);
                command.Parameters.AddWithValue("@ProfileImage", manager.profileImage);
                command.Parameters.AddWithValue("@PropertyName", manager.propertyName);
                command.Parameters.AddWithValue("@RegistrationDate", manager.registrationDate);
                command.Parameters.AddWithValue("@UserType", manager.userType);
                command.Parameters.AddWithValue("@Verified", manager.verified);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Manager loginPropertyManager(string email, string password)
        {
            Manager PropertyManager = null;

            string query = "SELECT * FROM managers WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {

                            PropertyManager = new Manager(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetBoolean(13));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return PropertyManager;
        }

        public bool correctPropertyManager(string email, string password)
        {
            bool success = false;

            string query = "SELECT * FROM Managers WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return success;
        }

        public bool validPropertyManager(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM managers WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public void PropertyManagerCreation(string email, string token)
        {
            //Store every newly created Account 
            //Id, Email, Status, Token
            query = @"INSERT INTO unconfirmedaccounts(Email, RegistrationDate, Status, Token) Values(@Email, @RegistrationDate, @Status, @Token)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Status", false);
                command.Parameters.AddWithValue("@Token", token);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool verifyPropertyManager(string email)
        {
            bool valid = true;

            string query = "SELECT * FROM managers WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        valid = false;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return valid;
        }

        public bool isverifiedPropertyManager(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            if (verifiedUser)
                changeStatus(email);

            return verifiedUser;
        }

        public bool unconfirmedAccountPropertyManager(string email)
        {
            bool exists = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean(3))
                                exists = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return exists;
        }

        public bool alreadyVerifiedPropertyManager(string email)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM unconfirmedaccounts WHERE Email = @email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (reader.GetBoolean(3))
                                verifiedUser = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verifiedUser;
        }

        private void changeStatusPropertyManager(string email)
        {
            query = @"UPDATE unconfirmedaccounts SET Status = @status";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@status", true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }
        #endregion

        //Validate Email
        public bool isValidUser(string email)
        {
            bool success = false;

            if(!verifyCompany(email))
                success = true;
            else if(!verifyShopOwner(email))
                success = true;
            else if(!verifySociety(email))
                success = true;
            else if(!verifyStudent(email))
                 success = true;
            else if(!verifyPropertyManager(email))
                 success = true;
            else if(!verifyEventPoster(email))
                 success = true;

            return success;
        }

        public string GetUserType(string email)
        {
            string userType = "";

            if (!verifyCompany(email))
                userType = "COMPANY";
            else if (!verifyShopOwner(email))
                userType = "SHOP";
            else if (!verifySociety(email))
                userType = "SOCIETY";
            else if (!verifyStudent(email))
                userType = "STUDENT";
            else if (!verifyPropertyManager(email))
                userType = "PROPERTY";
            else if (!verifyEventPoster(email))
                userType = "EVENTPOSTER";

            return userType;
        }

        //Password Recovery 
        public bool sendForgotPasswordLink(string email,string token)
        {
            bool success = false;
            //Check if email exists in the sytsem
            if(isValidUser(email))
            {
                query = @"INSERT INTO resetpassword (Date, Email, Status, Token) Values(@Date, @Email, @Status, @Token)";
                using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
                {
                    //General
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Status", false);
                    command.Parameters.AddWithValue("@Token", token);

                    command.Connection.Open();

                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                    success = true;
                }
            }
                return success;
        }

        public bool resetPasswordSociety(string email,string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE Society SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool resetPasswordCompany(string email, string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE Company SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool resetPasswordStudent(string email, string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE Students SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool resetPasswordEventPoster(string email, string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE EventPoster SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool resetPasswordShopOwner(string email, string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE ShopOwner SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool resetPasswordManagers(string email, string newPassword)
        {
            bool success = false;
            //Id, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, UserType, Video, Verified
            query = @"UPDATE managers SET Password = @Password WHERE Email = @email";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Email", email);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool correctPasswordReset(string email, string token)
        {
            bool verifiedUser = false;

            string query = "SELECT * FROM resetpassword WHERE Email = @email AND Token = @token";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@token", token);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        verifiedUser = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return verifiedUser;
        }

        public void deletePasswordResetLink(string email)
        {
            string query = "DELETE FROM resetpassword WHERE Email = @Email";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Email", email);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool loginNjabulo(string email, string password)
        {
            bool njabulo = false;

            query = "SELECT * FROM admin WHERE Email = @email AND Password = @password";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            njabulo = true;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return njabulo;
        }
    }
}