using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt_phase_2
{
    public partial class Trip : Form
    {

        string sql = "Data Source = DESKTOP-C71KKAH; Initial Catalog = besmallahfirstDB ; Integrated Security = True ";
        private SqlConnection con;

        // Constructor
        public Trip()
        {
            InitializeComponent();
            con = new SqlConnection(sql);
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Loadusertable();
        }

        public DataTable Loadusertable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TRIP";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string updatequery = "UPDATE TRIP SET DURATION=@DURATION, DEPARTURE_TIME=@DEPARTURE_TIME, ARRIVAL_TIME=@ARRIVAL_TIME, DISTANCE=@DISTANCE, DESTINATION=@DESTINATION WHERE TRIP_ID =" + dataGridView.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(updatequery, con);
            cmd.Parameters.AddWithValue("@DURATION", txtduration.Text);
            cmd.Parameters.AddWithValue("@DEPARTURE_TIME", deptime.Value);
            cmd.Parameters.AddWithValue("@ARRIVAL_TIME", arrivaltime.Value);
            cmd.Parameters.AddWithValue("@DISTANCE", txtdistance.Text);
            cmd.Parameters.AddWithValue("@DESTINATION", txtDetination.Text);
            //cmd.Parameters.AddWithValue("@DEPARTURE_STATION", DEPSTATION.Text); 
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payment updated successfully.");
            dataGridView.DataSource = Loadusertable();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetLastTripIdFromDatabase()
        {
            int lastTripId = 0; // Initialize to a default value
            con.Open();
            string query = "SELECT MAX(TRIP_ID) FROM TRIP"; // Assuming the name of your user table is USERS
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Execute the query and get the result
                object result = command.ExecuteScalar();
                if (result != DBNull.Value) // Check if the result is not null
                {
                    lastTripId = Convert.ToInt32(result);
                }
            }
            con.Close();
            return lastTripId;
        }

        private int GetTrainIdByDepartureStation(string DS)
        {
            int TrainId = 123;
            string query = "SELECT TRAIN_ID FROM [TRAIN] WHERE TRIP_ID = @TRIP_ID";
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@TRIP_ID", DS);
                    // Execute the command to retrieve the user ID
                    object result = command.ExecuteScalar();
                    // Check if a result was returned
                    if (result != null)
                    {
                        // Parse the result to integer (assuming USER_ID is of integer type)
                        TrainId = Convert.ToInt32(result);
                    }
                }
                con.Close();
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            con.Close();
            return TrainId;
        }


        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            int lastTripId = GetLastTripIdFromDatabase();
            // Increment the IDs
            int newTripId = lastTripId + 1;
            string Departurestation = DEPSTATION.Text; // Assuming you have a textbox for entering the username
            int trainID = GetTrainIdByDepartureStation(Departurestation);
            string query = "INSERT INTO TRIP(TRIP_ID, TRAIN_ID,DURATION, DEPARTURE_TIME, ARRIVAL_TIME, DISTANCE, DESTINATION) VALUES (@TRIP_ID, @TRAIN_ID, @DURATION, @DEPARTURE_TIME, @ARRIVAL_TIME, @DISTANCE, @DESTINATION)";
            SqlCommand dothis = new SqlCommand(query, con);
            dothis.Parameters.AddWithValue("@TRIP_ID", newTripId);
            dothis.Parameters.AddWithValue("@TRAIN_ID", trainID);
            dothis.Parameters.AddWithValue("@DURATION", txtduration.Text);
            dothis.Parameters.AddWithValue("@DEPARTURE_TIME", deptime.Value);
            dothis.Parameters.AddWithValue("@ARRIVAL_TIME", arrivaltime.Value);
            dothis.Parameters.AddWithValue("@DISTANCE", txtdistance.Text);
            dothis.Parameters.AddWithValue("@DESTINATION", txtDetination.Text);
            con.Open();
            dothis.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Trip is added successfully");
            //refresh the databasetable
            dataGridView.DataSource = Loadusertable();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtArrivalTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDestination_Click(object sender, EventArgs e)
        {

        }

        private void labelDeparturetime_Click(object sender, EventArgs e)
        {

        }

        private void labeltrainno_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelArrivaltime_Click(object sender, EventArgs e)
        {

        }

        private void txtdeptime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click_1(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string deleteQuery = "DELETE FROM TRIP WHERE TRIP_ID = @TripID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@TripID", dataGridView.CurrentRow.Cells[0].Value);

                    // Execute the delete command
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Trip deleted successfully.");
                    dataGridView.DataSource = Loadusertable();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while deleting the trip: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection, even if an exception occurs
                con.Close();
            }
        }

        private string GetDeparturestationbytrainid(int TRAINID)
        {
            string DEPstation = "lala";
            string query = "SELECT TRIP_ID FROM [TRAIN] WHERE TRAIN_ID = @TRAIN_ID";
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@TRAIN_ID", TRAINID);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        DEPstation = Convert.ToString(result) ?? "Unknown Train id";
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while deleting the payment: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            con.Close();
            return DEPstation;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && !dataGridView.CurrentRow.IsNewRow)
            {
                txtDetination.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
                txtdistance.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                txtduration.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

                string trainidtogetdpst = dataGridView.CurrentRow.Cells[1].Value.ToString() ?? "can not find it";
                int idtogetdeparturest = Convert.ToInt32(trainidtogetdpst);
                DEPSTATION.Text = GetDeparturestationbytrainid(idtogetdeparturest);
                if (DateTime.TryParse(dataGridView.CurrentRow.Cells[3].Value.ToString(), out DateTime expiryDate))
                {
                    deptime.Value = expiryDate;
                }
                if (DateTime.TryParse(dataGridView.CurrentRow.Cells[4].Value.ToString(), out DateTime transactionDate))
                {
                    arrivaltime.Value = transactionDate;
                }
            }
            else
            {
                // Clear all text boxes when no row is selected
                txtduration.Text = "";
                txtdistance.Text = "";
                txtDetination.Text = "";
                arrivaltime.Value = DateTime.Now;
                deptime.Value = DateTime.Now;
                DEPSTATION.Text = "";
            }
        }
    }


}
