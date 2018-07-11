using MySql.Data.MySqlClient;
using Qaelo.Data.EventsData;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.StudentModel;
using System.Collections.Generic;
using Qaelo.Models.FreelancerModel;

namespace Qaelo.Data.StudentData
{
    public class StudentConnection :Connection
    {
        public bool updateStudent(Student student)
        {
            bool success = false;

            query = @"UPDATE Students SET Campus = @Campus, Description = @Description,FirstName = @FirstName, Institution = @Institution, LastName =@LastName, Number = @Number,ProfileImage  = @ProfileImage, QualificationEnrolled = @QualificationEnrolled, YearOfStudy = @YearOfStudy WHERE Id = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@Campus", student.Campus);
                command.Parameters.AddWithValue("@Description", student.Description);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@Institution", student.Institution);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Number", student.Number);
                command.Parameters.AddWithValue("@ProfileImage", student.ProfileImage);
                command.Parameters.AddWithValue("@QualificationEnrolled", student.QualificationEnrolled);
                command.Parameters.AddWithValue("@YearOfStudy", student.YearOfStudy);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        #region About student Profile 

        public void deleteStudentProfile(int id)
        {
            string query = "DELETE FROM studentsprofiles WHERE StudentId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
        }

        public void deleteStudent(int id)
        {
            string query = "DELETE FROM studentsprofiles WHERE StudentId = @Id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete student 
            query = "DELETE FROM students WHERE Id = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete All in Accommodation likes 

            query = "DELETE FROM accommodationjoined WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in events
            query = "DELETE FROM eventlikes WHERE UserId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in books
            query = "DELETE FROM books WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in freelancer
            query = "DELETE FROM freelancer WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in joblikes
            query = "DELETE FROM joblikes WHERE UserId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in reservation
            query = "DELETE FROM reservation WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in roomads
            query = "DELETE FROM roomads WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //Delete in shoplikes
            query = "DELETE FROM shoplikes WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //delete in societyjoined
            query = "DELETE FROM societyjoined WHERE StudentId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            //delete in societylikes
            query = "DELETE FROM societylikes WHERE UserId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }

            // freelance 

            query = "DELETE FROM portfolio WHERE FreelacnerId = @Id";
            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
            
        }

        public void deleteOtherProfiles(int studentId)
        {
            //Get Student 
            Student student = new StudentConnection().getStudent(studentId);

            //Get Books 
            List<Book> books = new StudentConnection().getAllStudentBoks(studentId);

            //delete All books
            foreach (Book book in books)
            {
                deleteBook(book.Id, student);
            }

            //delete all likes
            
        }

        public void uploadStudentProfile(Student student)
        {
            query = @"INSERT INTO studentsprofiles(StudentId,Campus, Description, Email, FirstName, Institution, LastName, Number, Password, ProfileImage, QualificationEnrolled, RegistrationDate, UserType, YearOfStudy)
                                  Values(@StudentId,@Campus, @Description, @Email, @FirstName, @Institution, @LastName, @Number, @Password, @ProfileImage, @QualificationEnrolled, @RegistrationDate, @UserType, @YearOfStudy)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Campus", student.Campus);
                command.Parameters.AddWithValue("@StudentId", student.Id);
                command.Parameters.AddWithValue("@Description", student.Description);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@Institution", student.Institution);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Number", student.Number);
                command.Parameters.AddWithValue("@Password", "");
                command.Parameters.AddWithValue("@ProfileImage", student.ProfileImage);
                command.Parameters.AddWithValue("@QualificationEnrolled", student.QualificationEnrolled);
                command.Parameters.AddWithValue("@RegistrationDate", student.RegistrationDate);
                command.Parameters.AddWithValue("@UserType", "");
                command.Parameters.AddWithValue("@YearOfStudy", student.YearOfStudy);

                command.Connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
        }
        
        public string getStudentUniversity(int id)
        {
            string university = "";

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
                            university = reader.GetString(5);
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return university;
        }

        public bool isProfilePublic(int id)
        {
            bool success = false;
            string query = "SELECT * FROM studentsprofiles WHERE studentId = @Id";

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

        public List<Student> getAllStudents()
        {
            List<Student> students = new List<Student>();

            query = "SELECT * FROM students";

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
                            students.Add( new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return students;
        }

        public List<Student> getAllStudents(string search)
        {
            List<Student> students = new List<Student>();

            query = "SELECT * FROM students WHERE " + search;

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //command.Parameters.AddWithValue("@search", search);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetDateTime(11), reader.GetString(12), reader.GetString(13)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }

            return students;
        }

        public bool postBook(Book book)
        {

            //if (!validRoomAd(room))
            //    return false;

            bool success = false;

            query = @"INSERT INTO books(StudentId, Description, Field, Image,Name, Price, YearOfStudy) values(@StudentId, @Description, @Field, @Image,@Name, @Price, @YearOfStudy)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@StudentId", book.StudentId);
                command.Parameters.AddWithValue("@Description", book.Description);
                command.Parameters.AddWithValue("@Field", book.Field);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Image", book.Image);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@YearOfStudy", book.YearOfStudy);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }
        public void deleteBook(int id, Student student)
        {
            string query = "DELETE FROM books WHERE Id = @Id AND StudentId = @StudentId";

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
        public List<Book> getAllBoks()
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books";

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
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }

        public List<Book> getAllBooks(string search)
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books WHERE @search";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@search", search);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }

        public Book getBookById(int id)
        {
            Book book = null;

            string query = "SELECT * FROM books Where Id = @Id";

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
                            book = new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return book;
        }

        public void editBook(Book book)
        {
            query = @"UPDATE books SET Description = @Description, Field = @Field, Name = @Name, Image = @Image, Price = @Price, YearOfStudy = @YearOfStudy WHERE Id = @Id AND StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General
                command.Parameters.AddWithValue("@Id", book.Id);
                command.Parameters.AddWithValue("@StudentId", book.StudentId);
                command.Parameters.AddWithValue("@Description", book.Description);
                command.Parameters.AddWithValue("@Field", book.Field);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Image", book.Image);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@YearOfStudy", book.YearOfStudy);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public List<Book> getAllBooksByField(string field)
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books WHERE Field = @Field ";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Field", field);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }
        public List<Book> getAllBooksByFieldAndYear(string field, string Year)
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books WHERE Field = @Field AND YearOfStudy = @Year";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Field", field);
                command.Parameters.AddWithValue("@Year", Year);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }
        public List<Book> getAllBooksByYear(string Year)
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books WHERE YearOfStudy = @Year";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Year", Year);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }
        public List<Book> getAllStudentBoks(int studentId)
        {
            List<Book> books = new List<Book>();

            string query = "SELECT * FROM books WHERE StudentId = @StudentId";

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
                            books.Add(new Book(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return books;
        }

        //search  freelancers
        public List<Freelancer> getAllFreelancersByWork(string work)
        {
            List<Freelancer> freelancer = new List<Freelancer>();

            string query = "SELECT * FROM freelancer WHERE Work = @Work";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Work", work);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            freelancer.Add(new Freelancer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }
        public List<Freelancer> getAllFreelancersByVarsity(string varsity)
        {
            List<Freelancer> freelancer = new List<Freelancer>();

            string query = "SELECT * FROM freelancer WHERE Work = @Work";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Work", varsity);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            freelancer.Add(new Freelancer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }
        public List<Freelancer> getAllFreelancersByVarsityAndWork(string varsity,string work)
        {
            List<Freelancer> freelancer = new List<Freelancer>();

            string query = "SELECT * FROM freelancer WHERE Work = @Work";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Connection.Open();
                command.Parameters.AddWithValue("@Work", work);
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            freelancer.Add(new Freelancer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }

        /* Freelancer*/
        public bool postWork(Freelancer freelancer)
        {

            //if (!validRoomAd(room))
            //    return false;

            bool success = false;

            query = @"INSERT INTO freelancer(StudentId, Description, Image, Price, Work) values(@StudentId, @Description, @Image, @Price, @Work)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@StudentId", freelancer.StudentId);
                command.Parameters.AddWithValue("@Description", freelancer.Description);
                command.Parameters.AddWithValue("@Image", freelancer.Image);
                command.Parameters.AddWithValue("@Price", freelancer.Price);
                command.Parameters.AddWithValue("@Work", freelancer.Work);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        public bool existingFreelancer(int freelanceId)
        {
            bool exists = false;

            string query = "SELECT * FROM portfolio  WHERE FreelacnerId = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@id", freelanceId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
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

        public PreviousWork getPortfolio(int freelanceId)
        {
            PreviousWork work = null;

            string query = "SELECT * FROM portfolio  WHERE FreelacnerId = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@id", freelanceId);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            work = new PreviousWork(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return work;
        }

        public void postPortfolio(PreviousWork freelancer)
        {
            //check if the frelancer has previously added work 

            if(existingFreelancer(freelancer.FreelacnerId))
            {
                //if record exist then update 
                updatetPortfolio(freelancer);
            }
            else
            {
                //if doesn't exist then insert
                insertPortfolio(freelancer);
            }
        }

        public void updatetPortfolio(PreviousWork freelancer)
        {
            query = @"UPDATE  portfolio Set Pictures = @Pictures, Videos = @Videos, Links = @Links WHERE FreelacnerId = @FreelacnerId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@Pictures", freelancer.Pictures);
                command.Parameters.AddWithValue("@Videos", freelancer.Videos);
                command.Parameters.AddWithValue("@Links", freelancer.Links);
                command.Parameters.AddWithValue("@FreelacnerId", freelancer.FreelacnerId);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
        }

        public void insertPortfolio(PreviousWork freelancer)
        {
            if (freelancer == null)
                return;

            query = @"INSERT INTO portfolio(FreelacnerId, Pictures, Videos, Links) values(@FreelacnerId, @Pictures, @Videos, @Links)";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@FreelacnerId", freelancer.FreelacnerId);
                command.Parameters.AddWithValue("@Pictures", freelancer.Pictures);
                command.Parameters.AddWithValue("@Videos", freelancer.Videos);
                command.Parameters.AddWithValue("@Links", freelancer.Links);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

            }

        }

        public PreviousWork previousWork(int id)
        {
            PreviousWork freelancer = null;

            string query = "SELECT * FROM portfolio  WHERE FreelacnerId = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            freelancer = new PreviousWork(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }

        public List<Freelancer> getAllFreelancers()
        {
            List<Freelancer> freelancer = new List<Freelancer>();

            string query = "SELECT * FROM freelancer";

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
                            freelancer.Add(new Freelancer(reader.GetInt32(0),reader.GetInt32(1),reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }

        public Freelancer Freelancer(int id)
        {
            Freelancer freelancer = null;

            string query = "SELECT * FROM freelancer WHERE StudentId = @id";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            freelancer = new Freelancer(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        }
                    }
                    reader.Close();
                }
                //Close Connection
                command.Connection.Close();
            }
            return freelancer;
        }

        /// <summary>
        /// Students are allowed to post if all fields in thier profile are non-empty
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        public bool isAllowedToPost(int id)
        {
            bool isAllowed = true;
            Student student = getStudent(id);

            ////Check all student fields 
            //if (student.FirstName == "")
            //    isAllowed = false;
            //else if (student.Institution == "")
            //    isAllowed = false;
            //else if (student.LastName == "")
            //    isAllowed = false;
            //else if (student.Campus == "")
            //    isAllowed = false;
            //else if (student.Number == "")
            //    isAllowed = false;

                return isAllowed;
        }

        public bool updateFreelancer(Freelancer freelancer)
        {
            bool success = false;

            query = @"UPDATE  freelancer Set Description = @Description, Price = @Price, Work = @Work WHERE  StudentId = @StudentId";

            using (MySqlCommand command = new MySqlCommand(query, new MySqlConnection(getConnectionString())))
            {
                //General 
                command.Parameters.AddWithValue("@StudentId", freelancer.StudentId);
                command.Parameters.AddWithValue("@Description", freelancer.Description);
                command.Parameters.AddWithValue("@Price", freelancer.Price);
                command.Parameters.AddWithValue("@Work", freelancer.Work);

                command.Connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                command.Connection.Close();

                success = true;
            }

            return success;
        }

        /* Searching **/
        //public List<T> search<T>()
        #endregion
    }
}