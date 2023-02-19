using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_3_GUI
{
    public partial class VoterForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");
        private VoterController controller;
        
        public VoterForm()
        {
            InitializeComponent();
            controller = new VoterController();
        }

        private void btnAddVoter_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtAge.Text != "" && txtAddress.Text != "" && txtCity.Text != "" && txtDob.Text != ""  && txtReligion.Text !="" && txtGender.Text != "" && txtMaritalStatus.Text != "" && txtNationality.Text != "" && txtCountry.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtJobStatus.Text != "")
            {
                var voter = new Voter
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    DOB = txtDob.Text,
                    Religion = txtReligion.Text,
                    Gender = txtGender.Text,
                    MaritalStatus = txtMaritalStatus.Text,
                    Nationality = txtNationality.Text,
                    Country = txtCountry.Text,
                    phoneNumber = txtPhone.Text,
                    Email = txtEmail.Text,
                    jobStatus = txtJobStatus.Text,
                };
                controller.AddVoter(voter);
            }
            else
            {
                MessageBox.Show("Field(s) is/are missing, fill all and try again");
            }
            
        }

        private void btnDeleteVoter_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            controller.DeleteVoter(id);
        }

        private void btnGetVoterById_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                var id = int.Parse(txtId.Text);
                var voter = controller.GetVoterById(id);

                con.Open();

                string selectStatement = "SELECT Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, phoneNumber, jobStatus FROM VoterTable where Id = " + id;
                SqlCommand cmd = new SqlCommand(selectStatement, con);

                cmd.Parameters.AddWithValue("Id", int.Parse(txtId.Text));
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    txtId.Text = da.GetValue(0).ToString();
                    txtName.Text = da.GetValue(1).ToString();
                    txtAge.Text = da.GetValue(2).ToString();
                    txtAddress.Text = da.GetValue(3).ToString();
                    txtCity.Text = da.GetValue(4).ToString();
                    txtDob.Text = da.GetValue(5).ToString();
                    txtReligion.Text = da.GetValue(6).ToString();
                    txtGender.Text = da.GetValue(7).ToString();
                    txtMaritalStatus.Text = da.GetValue(8).ToString();
                    txtNationality.Text = da.GetValue(9).ToString();
                    txtCountry.Text = da.GetValue(10).ToString();
                    txtPhone.Text = da.GetValue(11).ToString();
                    txtEmail.Text = da.GetValue(12).ToString();
                    txtJobStatus.Text = da.GetValue(13).ToString();
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter a Valid ID to Search");
            }
        }

        private void btnGetAllVoters_Click_1(object sender, EventArgs e)
        {
            AllVotersList allVotersList = new AllVotersList();
            allVotersList.Show();

            var voters = controller.GetAllVoters();
            voters.Clear();
            
            foreach (var voter in voters)
            {
                voters.Add(voter);
            }
        }
    }
}
