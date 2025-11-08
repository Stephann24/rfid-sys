using RFIDAttendanceSystem.DataBase;
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

namespace RFIDAttendanceSystem.Dashboard
{
    public partial class AddUser : Form
    {
        public static DatabaseConnector connector = new DatabaseConnector();
        public string ConnectionString = connector.GetConnection();

        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SaveUserRecord()
        {
            try {
                using (SqlConnection conn = new SqlConnection(ConnectionString)) 
                using (SqlCommand command = new SqlCommand("SaveUserRecords", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("user_id", TBuserid.Text.ToString());
                    command.Parameters.AddWithValue("first_name", TBfirstname.Text.ToString());
                    command.Parameters.AddWithValue("middle_name", TBmiddlename.Text.ToString());
                    command.Parameters.AddWithValue("last_name", TBlastname.Text.ToString());

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User Record Save Successfully");
                }
            }
            catch 
            { 

            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveUserRecord();
        }
    }
}
