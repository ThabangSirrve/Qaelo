using MySql.Data.MySqlClient;
using Qaelo.Models.ShopOwnerModel;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Data.ShopData
{
    public class ShopConnection : Connection
    {

        public bool postShop(Shop shop)
        {
            bool success = false;

            query = @"INSERT INTO shopspecials(ShopOwnerId, Campus, Description, Image, Name, TradingHours, ShopNo, University)Values(@ShopOwnerId, @Campus, @Description, @Image, @Name, @TradingHours, @ShopNo, @University)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@ShopOwnerId", shop.ShopOwnerId);
                command.Parameters.AddWithValue("@Campus", shop.Campus);
                command.Parameters.AddWithValue("@Description", shop.Description);
                command.Parameters.AddWithValue("@Image", shop.Image);
                command.Parameters.AddWithValue("@Name", shop.Name);
                command.Parameters.AddWithValue("@TradingHours", shop.TradingHours);
                command.Parameters.AddWithValue("@ShopNo", shop.Address);
                command.Parameters.AddWithValue("@University", shop.University);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            //query = @"INSERT INTO shopcategory(ShopOwnerId, CategoryName)Values(@ShopOwnerId, @CategoryName)";

            //using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            //{
            //    //General
            //    command.Parameters.AddWithValue("@ShopOwnerId", shop.ShopOwnerId);
            //    command.Parameters.AddWithValue("@CategoryName", "");

            //    command.Connection.Open();

            //    command.CommandType = System.Data.CommandType.Text;
            //    command.ExecuteNonQuery();

            //    command.Connection.Close();

            //    success = true;
            //}

            return success;
        } // List your shop

        public bool postSpecial(Shop shop)
        {
            bool success = false;

            query = @"INSERT INTO shopads (ShopOwnerId, Campus, Description, Image, Name, TradingHours, ShopNo, University, SpecialStartDate, SpecialEndDate, OrderID, Status)Values(@ShopOwnerId, @Campus, @Description, @Image, @Name, @TradingHours, @ShopNo, @University, @SpecialStartDate, @SpecialEndDate, @OrderID, @Status)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@ShopOwnerId", shop.ShopOwnerId);
                command.Parameters.AddWithValue("@Campus", shop.Campus);
                command.Parameters.AddWithValue("@Description", shop.Description);
                command.Parameters.AddWithValue("@Image", shop.Image);
                command.Parameters.AddWithValue("@Name", shop.Name);
                command.Parameters.AddWithValue("@TradingHours", shop.TradingHours);
                command.Parameters.AddWithValue("@University", shop.University);
                command.Parameters.AddWithValue("@ShopNo", shop.Address);
                command.Parameters.AddWithValue("@SpecialStartDate", DateTime.Now);
                command.Parameters.AddWithValue("@SpecialEndDate", DateTime.Now);
                command.Parameters.AddWithValue("@OrderID", 0);
                command.Parameters.AddWithValue("@Status", "ACTIVE");

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }// Post a special

        public bool updateShop(Shop Shop,int ownerId)
        {
            bool success = false;

            query = @"UPDATE shopspecials SET  Campus = @Campus , Description = @Description, Image = @Image, Name = @Name, TradingHours = @TradingHours, ShopNo = @ShopNo, University = @University WHERE Id = @Id AND ShopOwnerId =@ShopOwnerId ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id", Shop.Id);
                command.Parameters.AddWithValue("@ShopOwnerId", ownerId);
                command.Parameters.AddWithValue("@Campus", Shop.Campus);
                command.Parameters.AddWithValue("@Description", Shop.Description);
                command.Parameters.AddWithValue("@Image", Shop.Image);
                command.Parameters.AddWithValue("@Name", Shop.Name);
                command.Parameters.AddWithValue("@TradingHours", Shop.TradingHours);
                command.Parameters.AddWithValue("@ShopNo", Shop.Address);
                command.Parameters.AddWithValue("@University", Shop.University);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool updateSpecial(Shop Shop, int ownerId)
        {
            bool success = false;

            query = @"UPDATE shopads SET  Campus = @Campus , Description = @Description, Image = @Image, Name = @Name, TradingHours = @TradingHours, ShopNo = @ShopNo, University = @University WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id", Shop.Id);
                command.Parameters.AddWithValue("@ShopOwnerId", ownerId);
                command.Parameters.AddWithValue("@Campus", Shop.Campus);
                command.Parameters.AddWithValue("@Description", Shop.Description);
                command.Parameters.AddWithValue("@Image", Shop.Image);
                command.Parameters.AddWithValue("@Name", Shop.Name);
                command.Parameters.AddWithValue("@TradingHours", Shop.TradingHours);
                command.Parameters.AddWithValue("@ShopNo", Shop.Address);
                command.Parameters.AddWithValue("@University", Shop.University);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool updateShopCategory(string Category, int ownerId)
        {
            bool success = false;

            query = @"UPDATE shopcategory SET  CategoryName = @CategoryName WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@ShopOwnerId", ownerId);
                command.Parameters.AddWithValue("@CategoryName", Category);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public List<Shop> getAllShops()
        {
            List<Shop> Shops = new List<Shop>();

            string query = "SELECT * FROM shopspecials";

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
                            Shops.Add(new Shop(reader.GetInt32(0), reader.GetInt32(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public List<ShopAds> getAllSpecials()
        {
            List<ShopAds> Shops = new List<ShopAds>();

            string query = "SELECT * FROM shopads";

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
                            Shops.Add(new ShopAds(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8),reader.GetDateTime(9), reader.GetDateTime(9),"","ACTIVE"));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public List<ShopAds> getAllSpecialsByManagerId(int id)
        {
            List<ShopAds> Shops = new List<ShopAds>();

            string query = "SELECT * FROM shopads WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("ShopOwnerId",id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Shops.Add(new ShopAds(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetDateTime(9), "", "ACTIVE"));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public ShopAds getSpecialsById(int id)
        {
            ShopAds Shops = null;

            string query = "SELECT * FROM shopads WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("Id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            Shops = new ShopAds(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetDateTime(9), "", "ACTIVE");
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public Shop getShopById(int id)
        {
            Shop Shop = null;

            string query = "SELECT * FROM shopspecials WHERE Id = @Id";

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
                            Shop = new Shop(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shop;
        }

        public List<Shop> getAllMyShops(int id)
        {
            List<Shop> Shops = new List<Shop>();

            string query = "SELECT * FROM shopspecials WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@ShopOwnerId", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Shops.Add(new Shop(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }
        //getAllShopsBySearch

        public List<Shop> getAllShopsByUniversity(string univ)
        {
            List<Shop> Shops = new List<Shop>();

            string query = "SELECT * FROM shopspecials WHERE University = @univ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@univ", univ);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Shops.Add(new Shop(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public List<Shop> getAllShopsBySearch(string univ, string type)
        {
            List<Shop> Shops = new List<Shop>();

            string query = "SELECT * FROM shopspecials WHERE University = @location AND Campus = @type";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@location", univ);
                command.Parameters.AddWithValue("@type", type);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Shops.Add(new Shop(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        public List<Shop> getAllShopsByCampus(string campus)
        {
            List<Shop> Shops = new List<Shop>();

            string query = "SELECT * FROM shopspecials WHERE Campus = @campus";

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
                            Shops.Add(new Shop(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return Shops;
        }

        //shopads
        public bool deleteshop(int id, int ownerId)
        {
            bool success = false;
            string query = "DELETE FROM shopspecials WHERE Id = @Id AND ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@ShopOwnerId", ownerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            return success;
        }

        public bool deleteSpecial(int id, int ownerId)
        {
            bool success = false;
            string query = "DELETE FROM shopads WHERE Id = @Id AND ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@ShopOwnerId", ownerId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
                success = true;
            }

            return success;
        }

        public void deleteShoProfile(int id)
        {
            string query = "DELETE FROM Shopowner WHERE Id = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@ShopOwnerId", id);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }


            //Delete shopspecials
            query = "DELETE FROM shopspecials WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@ShopOwnerId", id);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete shoplikes
            query = "DELETE FROM shoplikes WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@ShopOwnerId", id);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //delete shopCategory 
            query = "DELETE FROM shopcategory WHERE ShopOwnerId = @ShopOwnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@ShopOwnerId", id);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }

        }

        public bool shopLikedByUser(int ShopId, int userId)
        {
            bool liked = false;
            query = "SELECT * FROM shoplikes WHERE ShopId = @ShopId AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@ShopId", ShopId);
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

        public bool likeshop(int shopID,int shopOwnerId, int userId)
        {
            bool success = false;
            //Id, ShopId, ShopOwnerId, StudentId
            query = @"INSERT INTO shopLikes(shopID,ShopOwnerId,StudentId) values(@shopID,@ShopOwnerId,@StudentId)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@shopID", shopID);
                command.Parameters.AddWithValue("@ShopOwnerId", shopOwnerId);
                command.Parameters.AddWithValue("@StudentId", userId);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public void unlikeshop(int shopId, int StudentId)
        {
            string query = "DELETE FROM shopLikes WHERE ShopId = @ShopId AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@ShopId", shopId);
                command.Parameters.AddWithValue("@StudentId", StudentId);

                command.CommandType = System.Data.CommandType.Text;

                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public List<int> getAllLikedUsers(int shopId, int owner)
        {
            List<int> ids = new List<int>();

            query = "SELECT * FROM shoplikes WHERE  ShopOwnerId = @ShopOwnerId AND ShopId = @ShopId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@ShopId", shopId);
                command.Parameters.AddWithValue("@ShopOwnerId", owner);
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

        public ShopOwner getShopOwner(int ownerId)
        {
            ShopOwner shopOwner = null;

            string query = "SELECT * FROM shopowner WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", ownerId);
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

        public List<ShopOwner> getAllShopOwners()
        {
            List<ShopOwner> shopOwners = new List<ShopOwner>();

            string query = "SELECT * FROM shopowner";

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
                            shopOwners.Add( new ShopOwner(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6), reader.GetBoolean(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return shopOwners;
        }

        public bool updateShopOwner(ShopOwner owner)
        {
            bool success = false;

            query = @"UPDATE shopowner SET  Email = @Email, FullName = @FullName, Number = @Number WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id",owner.Id );
                command.Parameters.AddWithValue("@Email", owner.Email);
                command.Parameters.AddWithValue("@FullName", owner.FullName);
                command.Parameters.AddWithValue("@Number", owner.Number);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool updatePassword(int id, string newPassword,string oldPassword)
        {
            bool success = false;

            query = @"UPDATE shopowner SET  Password = @Password  WHERE Id = @Id AND Password = @oldPassword";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id",id );
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@oldPassword", oldPassword);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool verifyShopowner(int id)
        {
            bool success = false;

            query = @"UPDATE shopowner SET  Verified = @Verify, RegistrationDate = @RegistrationDate  WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@Verify", true);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool unVerifyShopowner(int id)
        {
            bool success = false;

            query = @"UPDATE shopowner SET  Verified = @Verify  WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Verify", false);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

    }
}