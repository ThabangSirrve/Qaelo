using MySql.Data.MySqlClient;
using Qaelo.Models.AccommodationModel;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;

namespace Qaelo.Data.AccommodationData
{
    public class AccommodationConnection : Connection
    {
        ///Post 
        ///
        /**** Update code with database fields ***/
        public bool addRoom(Accommodation room)
        {
            bool success = false;

            query = @"INSERT INTO accommodation(Accredited,AccomodationType,Address,Arrangement,Campus,DatePosted,Description,Distance,Gender,Images,ManagerId,Price,University,Visible)
                                          values(@Accredited,@AccomodationType,@Address,@Arrangement,@Campus,@DatePosted,@Description,@Distance,@Gender,@Images,@ManagerId,@Price,@University,@Visible)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                    //General 
                    command.Parameters.AddWithValue("@Accredited", room.accredited);
                    command.Parameters.AddWithValue("@DatePosted", room.datePosted);
                    command.Parameters.AddWithValue("@AccomodationType", room.accomodationType);
                    command.Parameters.AddWithValue("@Address", room.address);
                    command.Parameters.AddWithValue("@Arrangement", room.arrangement);
                    command.Parameters.AddWithValue("@Campus", room.campus);
                    command.Parameters.AddWithValue("@Description", room.description);
                    command.Parameters.AddWithValue("@Distance", room.distanceFromCampus);
                    command.Parameters.AddWithValue("@Gender", room.gender);
                    command.Parameters.AddWithValue("@Images", room.images);
                    command.Parameters.AddWithValue("@ManagerId", room.managerId);
                    command.Parameters.AddWithValue("@Price", room.price);
                    command.Parameters.AddWithValue("@University", room.university); 
                    command.Parameters.AddWithValue("@Visible", true); 
                    command.Connection.Open();

                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();

                    command.Connection.Close();

                success = true;
            }

            return success;
        }

        ///Get 
        public Accommodation getRoom(int roomId)
        {
            Accommodation room = null;
            
            string query = "SELECT * FROM accommodation WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@id",roomId );
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            room = new Accommodation(reader.GetInt32(0),reader.GetBoolean(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7),reader.GetString(8), reader.GetString(9), reader.GetString(10),reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return room;
        }

        public DateTime getDatePosted(int roomId)
        {
            DateTime date = DateTime.Now;

            string query = "SELECT * FROM accommodation WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@id", roomId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            date = reader.GetDateTime(6);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return date;
        }

        public List<Accommodation> getRooms(int managerId)
        {
            List<Accommodation> rooms = new List<Accommodation>();

            string query = "SELECT * FROM accommodation WHERE ManagerId = @managerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@managerId", managerId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Accommodation(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return rooms;
        }

        public List<Accommodation> getAllRooms()
        {
            List<Accommodation> rooms = new List<Accommodation>();

            string query = "SELECT * FROM accommodation";

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
                            rooms.Add(new Accommodation(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return rooms;
        }

        public List<Accommodation> getAllMyRooms(int managerId)
        {
            List<Accommodation> rooms = new List<Accommodation>();

            string query = "SELECT * FROM accommodation WHERE ManagerId = @ManagerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@ManagerId", managerId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Accommodation(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return rooms;
        }
        ///Update
        public bool updateRoom(Accommodation room,int  Id)
        {
            bool success = false;

            query = @"UPDATE accommodation SET Accredited = @Accredited,AccomodationType = @AccomodationType,Address = @Address,Arrangement = @Arrangement,Campus = @Campus,DatePosted = @DatePosted,Description = @Description,Distance = @Distance,Gender = @Gender,Images = @Images,ManagerId = @ManagerId,Price = @Price,University = @University 
                    WHERE ManagerId = @managerId AND Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Accredited", room.accredited);
                command.Parameters.AddWithValue("@AccomodationType", room.accomodationType);
                command.Parameters.AddWithValue("@Address", room.address);
                command.Parameters.AddWithValue("@Arrangement", room.arrangement);
                command.Parameters.AddWithValue("@Campus", room.campus);
                command.Parameters.AddWithValue("@Description", room.description); 
                command.Parameters.AddWithValue("@DatePosted", room.datePosted);
                command.Parameters.AddWithValue("@Distance", room.distanceFromCampus);
                command.Parameters.AddWithValue("@Gender", room.gender);
                command.Parameters.AddWithValue("@Images", room.images);
                command.Parameters.AddWithValue("@Id", room.id);
                command.Parameters.AddWithValue("@ManagerId", Id);
                command.Parameters.AddWithValue("@Price", room.price);
                command.Parameters.AddWithValue("@University", room.university);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        ///Delete
        public bool deletedRoom(int id, int managerId)
        {
            bool success = false;

            string query = "DELETE FROM accommodation WHERE  Id = @Id AND ManagerId = @ManagerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@ManagerId", managerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        ///update availability status  
        public void availableStatus(Accommodation room, bool status)
        {
            //Visible

            query = @"UPDATE accommodation SET Visible = @Visible WHERE ManagerId = @managerId AND Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@ManagerId", room.managerId);
                command.Parameters.AddWithValue("@Id", room.id);
                command.Parameters.AddWithValue("@Visible", status);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool isRoomAvailable(int id)
        {
            return isRoomAvailable(id);
        }

        #region Students 
        public bool propertyJoinedByUser(int rooomId, int studentId)
        {
            bool Joined = false;
            //id, ManagerId, RoomId, StudentId
            query = "SELECT * FROM accommodationjoined WHERE RoomId = @RoomId AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@RoomId", rooomId);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Joined = true;
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return Joined;
        }

        public bool joinPropery(int managerId,int rooomId, int studentId)
        {
            bool Joined = false;
            //id, ManagerId, RoomId, StudentId
            query = "INSERT INTO accommodationjoined (ManagerId, RoomId, StudentId) values(@ManagerId, @RoomId, @StudentId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@RoomId", rooomId);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@ManagerId", managerId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                //Close Connection
                command.Connection.Close();

                Joined = true;
            }
            return Joined;
        }

        public bool unjoinProperty(int roomId, int studentId)
        {
            bool success = false;

            string query = "DELETE FROM accommodationjoined WHERE  RoomId = @RoomId AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@StudentId", studentId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public List<int> getAllJoinedUsers(int roomId,int managerId)
        {
            List<int> ids = new List<int>();

            query = "SELECT * FROM accommodationjoined WHERE  ManagerId = @ManagerId AND RoomId = @RoomId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@ManagerId", managerId);
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

        public List<Accommodation> getAllMyRoomsByUniversity(string university)
        {
            List<Accommodation> rooms = new List<Accommodation>();

            string query = "SELECT * FROM accommodation WHERE University = @University ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@University", university);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Accommodation(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return rooms;
        }

        public List<Accommodation> getAllMyRoomsByCampus(string campus)
        {
            List<Accommodation> rooms = new List<Accommodation>();

            string query = "SELECT * FROM accommodation WHERE Campus = @campus ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@campus", campus);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Accommodation(reader.GetInt32(0), reader.GetBoolean(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetInt32(11), reader.GetDouble(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return rooms;
        }

        public bool postRoomAd(RoomAd room)
        {

            if (!validRoomAd(room))
                return false;
            bool success = false;

            query = @"INSERT INTO roomads(StudentId, Arrangement, DatePosted, Gender, Number, PaymentType, RentAmount) Values(@StudentId, @Arrangement, @DatePosted, @Gender, @Number, @PaymentType, @RentAmount)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Arrangement", room.Arrangement);
                command.Parameters.AddWithValue("@DatePosted", room.DatePosted);
                command.Parameters.AddWithValue("@Gender", room.Gender);
                command.Parameters.AddWithValue("@Number", room.Number);
                command.Parameters.AddWithValue("@PaymentType", room.PaymentType);
                command.Parameters.AddWithValue("@RentAmount", room.RentAmount);
                command.Parameters.AddWithValue("@StudentId", room.StudentId);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void deleteRoomAd(int id, Student student)
        {
            string query = "DELETE FROM roomads WHERE Id = @Id AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@StudentId", student.Id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public bool validRoomAd(RoomAd room)
        {

            bool status = true;
            string query = "SELECT * FROM roomads WHERE StudentId = @StudentId AND Arrangement = @Arrangement AND PaymentType = @PaymentType AND  RentAmount = @RentAmount";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Arrangement", room.Arrangement);
                command.Parameters.AddWithValue("@PaymentType", room.PaymentType);
                command.Parameters.AddWithValue("@RentAmount", room.RentAmount);
                command.Parameters.AddWithValue("@StudentId", room.StudentId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            status = false;
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return status;
        }

        public List<RoomAd> getRoomAds(int studentId)
        {
            List<RoomAd> ads = new List<RoomAd>();

            string query = "SELECT * FROM roomads WHERE StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ads.Add(new RoomAd(reader.GetInt32(0),reader.GetInt32(1),reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetDouble(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return ads;
        }

        public List<RoomAd> getAllRoomAds()
        {
            List<RoomAd> ads = new List<RoomAd>();

            string query = "SELECT * FROM roomads";

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
                            ads.Add(new RoomAd(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetDouble(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return ads;
        }

        public bool reserveRoom(Reservation room)
        {

            //if (!validRoomAd(room))
            //    return false;

            bool success = false;

            query = @"INSERT INTO reservation(StudentId, BankStatement, Email, FullName, HomeAddress, GuardianID, Number, 
                   MonthOfStay, RoomAvailable, RoomNo, SalaryAdvice, Sponsor, StudentIdentity, ViewedRoom) values(@StudentId, @BankStatement, @Email, @FullName, @HomeAddress, @GuardianID, @Number, @MonthOfStay, @RoomAvailable, @RoomNo, @SalaryAdvice, @Sponsor, @StudentIdentity, @ViewedRoom)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@StudentId", room.StudentId);
                command.Parameters.AddWithValue("@BankStatement", room.BankStatement);
                command.Parameters.AddWithValue("@Email", room.Email);
                command.Parameters.AddWithValue("@FullName", room.FullName);
                command.Parameters.AddWithValue("@HomeAddress", room.HomeAddress);
                command.Parameters.AddWithValue("@GuardianID", room.GuardianID);
                command.Parameters.AddWithValue("@Number", room.Number);
                command.Parameters.AddWithValue("@MonthOfStay", room.MonthOfStay);
                command.Parameters.AddWithValue("@RoomAvailable", room.RoomAvailable);
                command.Parameters.AddWithValue("@RoomNo", room.RoomNo);
                command.Parameters.AddWithValue("@SalaryAdvice", room.SalaryAdvice);
                command.Parameters.AddWithValue("@Sponsor", room.Sponsor);
                command.Parameters.AddWithValue("@StudentIdentity", room.StudentIdentity);
                command.Parameters.AddWithValue("@ViewedRoom", room.ViewedRoom);
                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public List<Reservation> getAllReservations()
        {
            List<Reservation> ads = new List<Reservation>();

            string query = "SELECT * FROM reservation";

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
                            ads.Add( new Reservation(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7),reader.GetDateTime(8),reader.GetBoolean(9), reader.GetInt32(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetBoolean(14)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return ads;
        }

        public bool deletedReservation(int id)
        {
            bool success = false;

            string query = "DELETE FROM reservation WHERE  Id = @Id ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public Reservation getReservation(int id)
        {
            Reservation ad = null;

            string query = "SELECT * FROM reservation WHERE Id = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if(reader.Read())
                        {
                            ad =  new Reservation(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetDateTime(8), reader.GetBoolean(9), reader.GetInt32(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetBoolean(14));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return ad;
        }

        #endregion
    }


    //For Rooms avaible or not available We didn't include fields on the classes and thus i'ts  direct interaction from database

}