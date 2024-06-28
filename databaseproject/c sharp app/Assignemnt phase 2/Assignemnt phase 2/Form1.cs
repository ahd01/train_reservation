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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = DESKTOP-C71KKAH; Initial Catalog = besmallahfirstDB ; Integrated Security = True"))
                {
                    con.Open();

                    if (int.TryParse(textBox1.Text, out int TRAIN_ID) &&
                        int.TryParse(textBox2.Text, out int TRIP_ID) &&
                        int.TryParse(textBox3.Text, out int CAPACITY) &&
                        !string.IsNullOrEmpty(textBox4.Text))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO TRAIN (TRAIN_ID, TRIP_ID, CAPACITY, DEPARTUE_STATION) VALUES (@TrainId, @TripId, @Capacity, @DepartureStation)", con);
                        command.Parameters.AddWithValue("@TrainId", TRAIN_ID);
                        command.Parameters.AddWithValue("@TripId", TRIP_ID);
                        command.Parameters.AddWithValue("@Capacity", CAPACITY);
                        command.Parameters.AddWithValue("@DepartureStation", textBox4.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully inserted");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter valid values.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-C71KKAH; Initial Catalog = besmallahfirstDB ; Integrated Security = True");
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from TRAIN", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update TRAIN set TRIP_ID= '" + textBox2.Text + "', CAPACITY= '" + textBox3.Text + "', DEPARTUE_STATION= '" + textBox4.Text + "' WHERE TRAIN_ID = '" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete TRAIN where TRAIN_ID=@TRAIN_ID", con);
                command.Parameters.AddWithValue("@TRAIN_ID", dataGridView1.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                BindData();
            }
            else
            {
                MessageBox.Show("enter the train id");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();
        }
    }
}
