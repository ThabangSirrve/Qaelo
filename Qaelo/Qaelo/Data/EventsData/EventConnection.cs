using MySql.Data.MySqlClient;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;

namespace Qaelo.Data.EventsData
{
    public class EventConnection : Connection
    {
        public bool postEvent(MyEvent myEvent)
        {
            bool success = false;

            query = @"INSERT INTO event(EventPosterId, Campus, Date, DatePosted, Description, EntryFee, Image, Location, Name, University)Values(@EventPosterId, @Campus, @Date, @DatePosted, @Description, @EntryFee, @Image, @Location, @Name, @University)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@EventPosterId", myEvent.EventPosterId);
                command.Parameters.AddWithValue("@Campus", myEvent.Campus );
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
            query = @"UPDATE eventposter SET Verified = @Verified , RegistrationDate = @RegistrationDate WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Verified", false);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Id", id);
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

            query = @"UPDATE event SET Campus = @Campus,
                      DatePosted = @DatePosted, Description = @Description, EntryFee = @EntryFee, 
                      Image = @Image, Location = @Location, Name = @Name, University = @University 
                      WHERE Id = @Id AND EventPosterId = @EventPosterId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", myEvent.Id);
                command.Parameters.AddWithValue("@EventPosterId", myEvent.EventPosterId);
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

        public bool updateEventPoster(EventPoster poster)
        {
            bool success = false;
            query = @"UPDATE eventposter SET FullName = @FullName, Number = @Number, ProfileImage = @ProfileImage
                    WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@FullName", poster.FullName);
                command.Parameters.AddWithValue("@Id", poster.Id);
                command.Parameters.AddWithValue("@Number", poster.Number);
                command.Parameters.AddWithValue("@ProfileImage", poster.ProfileImage);
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
            query = @"UPDATE eventposter SET Verified = @Verified , RegistrationDate = @RegistrationDate WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Verified", true);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Id", id);
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

            string query = "SELECT * FROM event";

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
                            events.Add(new MyEvent(reader.GetInt32(0), reader.GetInt32(1),reader.GetString(2), reader.GetDateTime(3),reader.GetDateTime(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10)));
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

            string query = "SELECT * FROM event WHERE Id = @Id";

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

            string query = "SELECT * FROM event WHERE EventPosterId = @EventPosterId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@EventPosterId",id);
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
            query = "SELECT * FROM eventlikes WHERE EventId = @EventId AND UserId = @UserId";

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

        public bool likeEvent(int eventID, int userId)
        {
            bool success = false;

            query = @"INSERT INTO eventLikes(EventId,UserId) values(@EventId,@UserId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@EventId", eventID);
                command.Parameters.AddWithValue("@UserId", userId);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void unlikeEvent(int eventId,int UserId)
        {
            string query = "DELETE FROM eventLikes WHERE EventId = @eventId AND UserId = @UserId";

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
            string query = "DELETE FROM event WHERE Id = @eventId AND EventPosterId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@EventId", id);
                command.Parameters.AddWithValue("@UserId", eventPosterId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            return success;
        }

        public bool deleteEventPoster(int eventPosterId)
        {
            bool success = false;
            string query = "DELETE FROM eventposter WHERE Id = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@UserId", eventPosterId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            //Delete From event 
            query = "DELETE FROM event WHERE EventPosterId = @UserId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@UserId", eventPosterId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }
            return success;
        }

        public List<int> getListOfStudentIds(int eventId)
        {
            List<int> ids = new List<int>();
                query = "SELECT * FROM eventLikes WHERE EventId = @EventId";

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
                                ids.Add(reader.GetInt32(2));
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

            query = "SELECT * FROM event WHERE EventPosterId = @EventPosterId";

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

        public List<MyEvent> getAllEventsByUniversity(string un)
        {
            List<MyEvent> events = new List<MyEvent>();

            string query = "SELECT * FROM event WHERE University = @un";

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

        public List<MyEvent> getAllSocietyEventsByUniversity(string un)
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

            string query = "SELECT * FROM event WHERE University = @cam";

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

        public List<EventPoster> getAllPosters()
        {
            List<EventPoster> EventPosters = new List<EventPoster>();

            string query = "SELECT * FROM EventPoster ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            EventPosters.Add( new EventPoster(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetBoolean(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return EventPosters;
        }

        public EventPoster getPoster(int id)
        {
            EventPoster eventPoster = null;

            string query = "SELECT * FROM EventPoster ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if(reader.Read())
                        {
                            eventPoster = new EventPoster(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetBoolean(8));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return eventPoster;
        }

        public bool isPosterVerified(int id)
        {
            bool verified = false;

            string query = "SELECT * FROM EventPoster ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            verified = reader.GetBoolean(8);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return verified;
        }

        public bool addticket(TicketModel ticket)
        {
            bool success = false;

            query = @"INSERT INTO ticket( EventId, AccountHolder, AccountNo, BankName, BranchCode, PriceDescription, Reference)Values( @EventId, @AccountHolder, @AccountNo, @BankName, @BranchCode, @PriceDescription, @Reference)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@EventId", ticket.EventId);
                command.Parameters.AddWithValue("@AccountHolder", ticket.AccountHolder);
                command.Parameters.AddWithValue("@AccountNo", ticket.AccountNo);
                command.Parameters.AddWithValue("@BankName", ticket.BankName);
                command.Parameters.AddWithValue("@BranchCode", ticket.BranchCode);
                command.Parameters.AddWithValue("@PriceDescription", ticket.PriceDescription);
                command.Parameters.AddWithValue("@Reference", ticket.reference);


                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public int getId(MyEvent myEvent)
        {
            int id = -1;

            query = @"SELECT * FROM Event WHERE Name = @Name AND EventPosterId = @EventPosterId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Name", myEvent.Name);
                command.Parameters.AddWithValue("@EventPosterId",myEvent.EventPosterId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return id;
        }

        public TicketModel getTicketById(int id)
        {

            TicketModel ticket = null;

            query = @"SELECT * FROM ticket WHERE EventId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            ticket = new TicketModel(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return ticket;
        }
    }
}