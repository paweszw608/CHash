using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace StudentDiary
{
    public partial class mainForm : Form
    {

        string connectionString;

        SqlConnection sqlConnection;

        public mainForm()
        {
            InitializeComponent();


            connectionString = ConfigurationManager.ConnectionStrings["StudentDiary.Properties.Settings.StudentDiaryConnectionString"].ConnectionString;


        }


        private void studentButton_Click(object sender, EventArgs e)
        {
            populateStudents();
        }
        private void populateStudents()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM STUDENTS ORDER BY STUDENTS.Name", sqlConnection))
                {


                    DataTable studentsTable = new DataTable();
                    sqlDataAdapter.Fill(studentsTable);

                    foreach (DataRow dr in studentsTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Name"].ToString());
                        item.SubItems.Add(dr["Surname"].ToString());

                        studentListView1.Items.Add(item);

                    }


                }
            }
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
