using MySql.Data.MySqlClient;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.SocietyModel;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Data.SocietyData
{
    public class SocietyConnection : Connection
    {
        //Society likes are like event likes and joined society is when society is joined
        public bool postEvent(MyEvent myEvent)
        {
            bool success = false;

            query = @"INSERT INTO societyevent(SocietyId, Campus, Date, DatePosted, Description, EntryFee, Image, Location, Name, University)Values(@SocietyId, @Campus, @Date, @DatePosted, @Description, @EntryFee, @Image, @Location, @Name, @University)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@SocietyId", myEvent.EventPosterId);
                command.Parameters.AddWithValue("@Campus", myEvent.Campus);
                command.Parameters.AddWithValue("@Date", myEvent.Date);
                command.Parameters.AddWithValue("@DatePosted", myEvent.DatePosted);
                command.Parameters.AddWithValue("@Description", myEvent.Description);
                command.Parameters.AddWithValue("@EntryFee", myEvent.EntryFee);
                command.Parameters.AddWithValue("@Image", myEvent.Image);
                command.Parameters.AddWithValue("@Location", myEvent.Location);
                command.Parameters.AddWithValue("@Name", myEvent.Name);
                command.Parameters.AddWithValue("@University", myEvent.University);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool unverify(int id)
        {
            bool success = false;

            query = @"UPDATE society Set RegistrationDate = @RegistrationDate, Verified = @Verified WHERE Id = @SocietyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@SocietyId", id);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Verified", false);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool updateEvent(MyEvent myEvent)
        {
            bool success = false;

            query = @"UPDATE societyevent SET Campus = @Campus, Date = @Date, 
                      DatePosted = @DatePosted, Description = @Description, EntryFee = @EntryFee, 
                      Image = @Image, Location = @Location, Name = @Name, University = @University
                      WHERE Id = @eventId AND SocietyId = @SocietyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@eventId", myEvent.Id);
                command.Parameters.AddWithValue("@SocietyId", myEvent.EventPosterId);
                command.Parameters.AddWithValue("@Campus", myEvent.Campus);
                command.Parameters.AddWithValue("@Date", myEvent.Date);
                command.Parameters.AddWithValue("@DatePosted", myEvent.DatePosted);
                command.Parameters.AddWithValue("@Description", myEvent.Description);
                command.Parameters.AddWithValue("@EntryFee", myEvent.EntryFee);
                command.Parameters.AddWithValue("@Image", myEvent.Image);
                command.Parameters.AddWithValue("@Location", myEvent.Location);
                command.Parameters.AddWithValue("@Name", myEvent.Name);
                command.Parameters.AddWithValue("@University", myEvent.University);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool verify(int id)
        {
            bool success = false;

            query = @"UPDATE society Set RegistrationDate = @RegistrationDate, Verified = @Verified WHERE Id = @SocietyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@SocietyId", id);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Verified",true);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public List<MyEvent> getAllEvents()
        {
            List<MyEvent> events = new List<MyEvent>();

            string query = "SELECT * FROM societyevent";

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
                            events.Add(new MyEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return events;
        }

        public MyEvent getEventById(int id)
        {
            MyEvent myEvent = null;

            string query = "SELECT * FROM societyevent WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            myEvent = new MyEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return myEvent;
        }

        public List<MyEvent> getAllMyEvents(int id)
        {
            List<MyEvent> events = new List<MyEvent>();

            string query = "SELECT * FROM societyevent WHERE SocietyId = @SocietyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@SocietyId", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            events.Add(new MyEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return events;
        }

        public bool eventLikedByUser(int eventId, int userId)
        {
            bool liked = false;
            query = "SELECT * FROM societylikes WHERE EventId = @EventId AND UserId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@EventId", eventId);
                command.Parameters.AddWithValue("@UserId", userId);
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

        public bool likeEvent(int eventID,int societyId, int userId)
        {
            bool success = false;

            query = @"INSERT INTO societylikes(EventId,SocietyId,UserId) values(@EventId,@SocietyId,@UserId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@EventId", eventID);
                command.Parameters.AddWithValue("@SocietyId", societyId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void unlikeEvent(int eventId, int UserId)
        {
            string query = "DELETE FROM societylikes WHERE EventId = @eventId AND UserId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@EventId", eventId);
                command.Parameters.AddWithValue("@UserId", UserId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool deleteEvent(int id, int eventPosterId)
        {
            bool success = false;
            string query = "DELETE FROM societyevent WHERE Id = @eventId AND SocietyId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@EventId", id);
                command.Parameters.AddWithValue("@SocietyId", eventPosterId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            return success;
        }

        public List<int> getListOfStudentIds(int eventId,int societyId)
        {
            List<int> ids = new List<int>();
            query = "SELECT * FROM societylikes WHERE EventId = @EventId AND SocietyId = @SocietyId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@EventId", eventId);
                command.Parameters.AddWithValue("@SocietyId", societyId);
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

        public List<int> getListOfStudentIds(int eventId)
        {
            List<int> ids = new List<int>();
            query = "SELECT * FROM societylikes WHERE EventId = @EventId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@EventId", eventId);
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

        public List<int> getListOfEventIds(int eventPosterId)
        {
            List<int> ids = new List<int>();

            query = "SELECT * FROM societyevent WHERE SocietyId = @EventPosterId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@EventPosterId", eventPosterId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return ids;
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

        public List<Society> getAllSocieties()
        {
            List<Society> society = new List<Society>();

            string query = "SELECT * FROM society";

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
                            society.Add( new Society(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetBoolean(16)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return society;
        }

        public List<Society> getAllSocietiesByVarsity(string un)
        {
            List<Society> society = new List<Society>();

            string query = "SELECT * FROM societiesprofile WHERE University = @un";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@un", un);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            society.Add(new Society(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetBoolean(17)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return society;
        }

        public List<Society> getAllSocietiesByCampus(string campus)
        {
            List<Society> society = new List<Society>();

            string query = "SELECT * FROM societiesprofile WHERE Campus = @cam";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@cam", campus);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            society.Add(new Society(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetDateTime(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetBoolean(17)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return society;
        }

        public List<MyEvent> getAllEventsByUniversity(string un)
        {
            List<MyEvent> events = new List<MyEvent>();

            string query = "SELECT * FROM societyevent WHERE University = @un";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@un", un);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            events.Add(new MyEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return events;
        }

        public List<MyEvent> getAllEventsByCampus(string campus)
        {
            List<MyEvent> events = new List<MyEvent>();

            string query = "SELECT * FROM societyevent WHERE University = @cam";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@cam", campus);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            events.Add(new MyEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return events;
        }

        #region About Society Profile 

        public bool updateProfile(Society society,int id)
        {
            bool success = false;

            query = @"UPDATE society SET  Campus = @Campus, Description = @Description, Email = @Email, FacebookLink = @FacebookLink, MeetingDay = @MeetingDay, MeetingTime = @MeetingTime, Name = @Name, Number = @Number, ProfileImage = @ProfileImage, SocietyType = @SocietyType, University = @University,Video = @Video WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Campus", society.Campus);
                command.Parameters.AddWithValue("@Description", society.Description);
                command.Parameters.AddWithValue("@Email", society.Email);
                command.Parameters.AddWithValue("@FacebookLink", society.FacebookLink);
                command.Parameters.AddWithValue("@MeetingDay", society.MeetingDay);
                command.Parameters.AddWithValue("@MeetingTime", society.MeetingTime);
                command.Parameters.AddWithValue("@Name", society.Name);
                command.Parameters.AddWithValue("@Number", society.Number);
                command.Parameters.AddWithValue("@ProfileImage", society.ProfileImage);
                command.Parameters.AddWithValue("@SocietyType", society.SocietyType);
                command.Parameters.AddWithValue("@University", society.University);
                command.Parameters.AddWithValue("@Video", society.Video);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Society getSociety(int id)
        {
           Society society = null;

            string query = "SELECT * FROM society WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            society = new Society(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetBoolean(16));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return society;
        }

        public Society getSocietyByUniversity(string University)
        {
            Society society = null;

            string query = "SELECT * FROM societiesprofile WHERE University = @University";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@University", University);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            society = new Society(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetBoolean(16));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return society;
        }
        public void deleteSocietiesProfile(int id)
        {
            string query = "DELETE FROM societiesprofile WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public void deleteProfile(int id)
        {
            string query = "DELETE FROM society WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete societiesprofile
            query = "DELETE FROM societiesprofile WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            // Delete society event 
            query = "DELETE FROM societyevent WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete societyjoined
            query = "DELETE FROM societyjoined WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete societylikes
            query = "DELETE FROM societylikes WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public void uploadSocietiesProfile(Society society)
        {
            query = @"INSERT INTO societiesprofile(SocietyId,Campus, Description, Email, FacebookLink, MeetingDay, MeetingTime, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, University, UserType, Video, Verified) 
                    Values(@SocietyId,@Campus, @Description, @Email, @FacebookLink, @MeetingDay, @MeetingTime, @Name, @Number, @Password, @ProfileImage, @RegistrationDate, @SocietyType, @University, @UserType, @Video, @Verified)";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General SocietyId
                command.Parameters.AddWithValue("@SocietyId", society.Id);
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

            }
        }

        public bool isProfilePublic(int id)
        {
            bool success = false;
            string query = "SELECT * FROM societiesprofile WHERE SocietyId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Connection.Open();
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

        public bool societyJoinedByUser(int societyId, int userId)
        {
            bool liked = false;
            query = "SELECT * FROM societyjoined WHERE SocietyId = @id AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@id", societyId);
                command.Parameters.AddWithValue("@StudentId", userId);
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

        public bool joinSociety(int societyId, int userId)
        {
            bool success = false;

            query = @"INSERT INTO societyjoined(SocietyId,StudentId) values(@SocietyId,@StudentId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@StudentId", userId);
                command.Parameters.AddWithValue("@SocietyId", societyId);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void unJoinSociety(int societyId, int UserId)
        {
            string query = "DELETE FROM societyjoined WHERE SocietyId = @SocietyId AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@SocietyId", societyId);
                command.Parameters.AddWithValue("@StudentId", UserId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }
        #endregion
    }
}