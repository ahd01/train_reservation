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

namespace Assignemnt_phase_2
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            string sourcee = "Data Source = DESKTOP-C71KKAH; Initial Catalog = besmallahfirstDB; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sourcee);

            try
            {
                conn.Open();
                string query = @"SELECT TRIP.TRIP_ID, TRIP.DURATION, TRIP.DEPARTURE_TIME, TRIP.ARRIVAL_TIME, TRIP.DISTANCE, TRIP.DESTINATION, TRAIN_SEATS.TRAIN_ID 
                                 FROM TRIP 
                                 INNER JOIN TRAIN_SEATS ON TRIP.TRAIN_ID = TRAIN_SEATS.TRAIN_ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // Ensure columns exist before setting headers
                if (dataGridView1.Columns.Count >= 7)
                {
                    dataGridView1.Columns[0].HeaderText = "Trip ID";
                    dataGridView1.Columns[1].HeaderText = "Duration";
                    dataGridView1.Columns[2].HeaderText = "Departure Time";
                    dataGridView1.Columns[3].HeaderText = "Arrival Time";
                    dataGridView1.Columns[4].HeaderText = "Distance";
                    dataGridView1.Columns[5].HeaderText = "Destination";
                    dataGridView1.Columns[6].HeaderText = "Train Number";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
