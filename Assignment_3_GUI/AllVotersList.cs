using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_3_GUI
{
    public partial class AllVotersList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public AllVotersList()
        {
            InitializeComponent();

        }

        private void listBoxAllVoters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllVotersList_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from VoterTable", con);
            DataTable dataTable= new DataTable();
            sqlDA.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
