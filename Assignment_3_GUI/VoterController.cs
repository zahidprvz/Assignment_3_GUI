using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_GUI
{
    public class VoterController
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");
        private List<Voter> voters;

        public VoterController()
        {
            voters = new List<Voter>();
        }

        public void AddVoter(Voter voter)
        {
            voters.Add(voter);
            // Code to add voter to the database

            try
            {
                con.Open();

                MessageBox.Show("Connected to Database..!");


                string insertStatement = "INSERT INTO VoterTable (Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, phoneNumber, jobStatus) VALUES (@Name, @Age, @Address, @City, @DOB, @Religion, @Gender, @MaritalStatus, @Nationality, @Country, @Email, @phoneNumber, @jobStatus)";

                SqlCommand command = new SqlCommand(insertStatement, con);

                foreach (Voter voter1 in voters)
                {
                    
                    command.Parameters.AddWithValue("@Name", voter.Name);
                    command.Parameters.AddWithValue("@Age", voter.Age);
                    command.Parameters.AddWithValue("@Address", voter.Address);
                    command.Parameters.AddWithValue("@City", voter.City);
                    command.Parameters.AddWithValue("@DOB", voter.DOB);
                    command.Parameters.AddWithValue("@Religion", voter.Religion);
                    command.Parameters.AddWithValue("@Gender", voter.Gender);
                    command.Parameters.AddWithValue("@MaritalStatus", voter.MaritalStatus);
                    command.Parameters.AddWithValue("@Nationality", voter.Nationality);
                    command.Parameters.AddWithValue("@Country", voter.Country);
                    command.Parameters.AddWithValue("@Email", voter.Email);
                    command.Parameters.AddWithValue("@phoneNumber", voter.phoneNumber);
                    command.Parameters.AddWithValue("@jobStatus", voter.jobStatus);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                try
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("pervaizzahid55@gmail.com");
                    msg.To.Add(voter.Email);
                    msg.Subject = "Pakistan Election Commission";
                    msg.Body = "Hello " + voter.Name + "\n\nWelcome to PEC.\nYou have been registered as a Verified Voter!\nNow you can give your vote to any of the Political Party";

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "pervaizzahid55@gmail.com";
                    ntcd.Password = "qdnjjecciqgnscfa";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("\nYour Mail is sended");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("\n\nNew Voter Added in Database successfully...");
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteVoter(int id)
        {
            if (voters != null)
            {
                // Code to delete voter from the database

                try
                {
                    con.Open();

                    MessageBox.Show("Successfully connected to Database!");

                    string deleteStatement = "DELETE FROM VoterTable WHERE Id = " + id;

                    SqlCommand command = new SqlCommand(deleteStatement, con);

                    int rowsAffected = command.ExecuteNonQuery();




                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Voter Deleted Successfully..!");
            }
            else
            {
                MessageBox.Show("Voter not found...");
            }
        }
        

        public List<Voter> GetAllVoters()
        {
            // Code to retrieve all voters from the database
            try
            {
                con.Open();

                Console.Write("\nSuccessfully connected to Database!\n\n");

                string selectStatement = "SELECT Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, phoneNumber, jobStatus FROM VoterTable";

                SqlCommand command = new SqlCommand(selectStatement, con);


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Voter voter = new Voter();
                    voter.Id = Convert.ToInt32(reader["Id"]);
                    voter.Name = reader["Name"].ToString();
                    voter.Age = reader["Age"].ToString();
                    voter.Address = reader["Address"].ToString();
                    voter.City = reader["City"].ToString();
                    voter.DOB = reader["DOB"].ToString();
                    voter.Religion = reader["Religion"].ToString();
                    voter.Gender = reader["Gender"].ToString();
                    voter.MaritalStatus = reader["MaritalStatus"].ToString();
                    voter.Nationality = reader["Nationality"].ToString();
                    voter.Country = reader["Country"].ToString();
                    voter.Email = reader["Email"].ToString();
                    voter.phoneNumber = reader["phoneNumber"].ToString();
                    voter.jobStatus = reader["jobStatus"].ToString();

                    voters.Add(voter);
                }
                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return voters;
        }

        public Voter GetVoterById(int id)
        {
            // Code to retrieve voter from the database by id
            
            try
            {
                con.Open();

                

                string selectStatement = "SELECT Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, phoneNumber, jobStatus FROM VoterTable where Id = " + id;

                SqlCommand command = new SqlCommand(selectStatement, con);


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Voter voter = new Voter();
                    voter.Id = Convert.ToInt32(reader["Id"]);
                    voter.Name = reader["Name"].ToString();
                    voter.Age = reader["Age"].ToString();
                    voter.Address = reader["Address"].ToString();
                    voter.City = reader["City"].ToString();
                    voter.DOB = reader["DOB"].ToString();
                    voter.Religion = reader["Religion"].ToString();
                    voter.Gender = reader["Gender"].ToString();
                    voter.MaritalStatus = reader["MaritalStatus"].ToString();
                    voter.Nationality = reader["Nationality"].ToString();
                    voter.Country = reader["Country"].ToString();
                    voter.Email = reader["Email"].ToString();
                    voter.phoneNumber = reader["phoneNumber"].ToString();
                    voter.jobStatus = reader["jobStatus"].ToString();

                    voters.Add(voter);
                }
                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return voters.SingleOrDefault(v => v.Id == id);
        }
    }
}
