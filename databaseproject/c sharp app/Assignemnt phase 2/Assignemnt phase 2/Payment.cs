using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Assignemnt_phase_2
{
    public partial class Payment : Form
    {
        static string sql_connection = "Data Source = DESKTOP-C71KKAH; Initial Catalog = besmallahfirstDB ; Integrated Security = True";
        SqlConnection alconnection = new SqlConnection(sql_connection);
        public Payment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = retrievealtable();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable retrievealtable()
        {
            DataTable Paymenttable = new DataTable();
            string gettable = "SELECT * FROM PAYMENT";
            alconnection.Open();
            SqlCommand dothis = new SqlCommand(gettable, alconnection);
            SqlDataAdapter filler = new SqlDataAdapter(dothis);
            filler.Fill(Paymenttable);
            alconnection.Close();
            return Paymenttable;
        }

        private int GetLastPaymentIdFromDatabase()
        {
            int lastpaymentId = 0; // Initialize to a default value
            alconnection.Open();
            string query = "SELECT MAX(PAYMENT_ID) FROM PAYMENT"; // Assuming the name of your user table is USERS
            using (SqlCommand command = new SqlCommand(query, alconnection))
            {
                // Execute the query and get the result
                object result = command.ExecuteScalar();
                if (result != DBNull.Value) // Check if the result is not null
                {
                    lastpaymentId = Convert.ToInt32(result);
                }
            }
            alconnection.Close();
            return lastpaymentId;
        }

        private int GetLastTransactionIdFromDatabase()
        {
            int lastTransactionId = 0; // Initialize to a default value
            alconnection.Open();
            string query = "SELECT MAX(TRANSACTION_ID) FROM PAYMENT"; // Assuming the name of your payment table is PAYMENT
            using (SqlCommand command = new SqlCommand(query, alconnection))
            {
                // Execute the query and get the result
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastTransactionId = Convert.ToInt32(result);
                }
            }
            alconnection.Close();
            return lastTransactionId;
        }

        private int GetUserIdByNAME(string NAME)
        {
            int userId = 123;
            string query = "SELECT USER_ID FROM [USER] WHERE NAME = @NAME";
            try
            {
                alconnection.Open();
                using (SqlCommand command = new SqlCommand(query, alconnection))
                {
                    command.Parameters.AddWithValue("@NAME", NAME);
                    // Execute the command to retrieve the user ID
                    object result = command.ExecuteScalar();
                    // Check if a result was returned
                    if (result != null)
                    {
                        // Parse the result to integer (assuming USER_ID is of integer type)
                        userId = Convert.ToInt32(result);
                    }
                }
                alconnection.Close();
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (alconnection.State == ConnectionState.Open)
                {
                    alconnection.Close();
                }
            }
            alconnection.Close();
            return userId;
        }


        private string GetUserNameByID(int userID)
        {
            string name = "lala";
            string query = "SELECT NAME FROM [USER] WHERE USER_ID = @USER_ID";
            try
            {
                alconnection.Open();
                using (SqlCommand command = new SqlCommand(query, alconnection))
                {
                    command.Parameters.AddWithValue("@USER_ID", userID);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        name = Convert.ToString(result) ?? "Unknown user id";
                    }
                }
                alconnection.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while deleting the payment: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (alconnection.State == ConnectionState.Open)
                {
                    alconnection.Close();
                }
            }
            alconnection.Close();
            return name;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            int lastPaymentId = GetLastPaymentIdFromDatabase();
            int lastTransactionId = GetLastTransactionIdFromDatabase();
            // Increment the IDs
            int newPaymentId = lastPaymentId + 1;
            int newTransactionId = lastTransactionId + 1;

            string name = namebox.Text; // Assuming you have a textbox for entering the username
            int userId = GetUserIdByNAME(name);
            string insertquery = "INSERT INTO PAYMENT VALUES (@PAYMENT_ID, @TRANSACTION_ID, @USER_ID, @AMOUNT, @METHOD, @CARD_NUMBER, @EXPIRY_DATE, @PAYMENT_STATUS, @TRANSACTION_DATE, @REFUND_DATE, @REFUND_AMOUNT)";
            SqlCommand dothis = new SqlCommand(insertquery, alconnection);
            float amount = float.Parse(amountbox.Text);
            dothis.Parameters.AddWithValue("@PAYMENT_ID", newPaymentId);
            dothis.Parameters.AddWithValue("@TRANSACTION_ID", newTransactionId);
            dothis.Parameters.AddWithValue("@USER_ID", userId);
            dothis.Parameters.AddWithValue("@AMOUNT", amountbox.Text);
            dothis.Parameters.AddWithValue("@METHOD", methodbox.Text);
            dothis.Parameters.AddWithValue("@CARD_NUMBER", cardnumbox.Text);
            dothis.Parameters.AddWithValue("@EXPIRY_DATE", expirydate.Value);
            dothis.Parameters.AddWithValue("@TRANSACTION_DATE", Transctiondate.Value);
            dothis.Parameters.AddWithValue("@PAYMENT_STATUS", "Successful");
            float refundam = amount * 0.2f;
            dothis.Parameters.AddWithValue("@REFUND_AMOUNT", refundam);
            // Get the selected transaction date from the DateTimePicker control
            DateTime transDate = Transctiondate.Value;
            DateTime refundDate = transDate.AddDays(15);
            dothis.Parameters.AddWithValue("@REFUND_DATE", refundDate);
            alconnection.Open();
            dothis.ExecuteNonQuery();
            alconnection.Close();
            MessageBox.Show("Your payemnt is done successfully");
            //refresh the databasetable
            dataGridView1.DataSource = retrievealtable();
        }


        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                alconnection.Open();
                string deleteQuery = "DELETE FROM PAYMENT WHERE PAYMENT_ID = @PaymentID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, alconnection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", dataGridView1.CurrentRow.Cells[0].Value);

                    // Execute the delete command
                    cmd.ExecuteNonQuery();
                    alconnection.Close();
                    MessageBox.Show("Payment deleted successfully.");
                    dataGridView1.DataSource = retrievealtable();
                }
                alconnection.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while deleting the payment: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection, even if an exception occurs
                alconnection.Close();
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                methodbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string togetname = dataGridView1.CurrentRow.Cells[2].Value.ToString() ?? "can not find it";
                int idtogetname = Convert.ToInt32(togetname);
                namebox.Text = GetUserNameByID(idtogetname);
                cardnumbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[6].Value.ToString(), out DateTime expiryDate))
                {
                    expirydate.Value = expiryDate;
                }
                amountbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[8].Value.ToString(), out DateTime transactionDate))
                {
                    Transctiondate.Value = transactionDate;
                }
            }
            else
            {
                // Clear all text boxes when no row is selected
                methodbox.Text = "";
                namebox.Text = "";
                cardnumbox.Text = "";
                expirydate.Value = DateTime.Now;
                amountbox.Text = "";
                Transctiondate.Value = DateTime.Now;
            }
        }


        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            alconnection.Open();
            string updatequery = "UPDATE PAYMENT SET AMOUNT=@AMOUNT, METHOD=@METHOD, CARD_NUMBER=@CARD_NUMBER, EXPIRY_DATE=@EXPIRY_DATE, TRANSACTION_DATE=@TRANSACTION_DATE WHERE PAYMENT_ID =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(updatequery, alconnection);
            cmd.Parameters.AddWithValue("@AMOUNT", amountbox.Text);
            cmd.Parameters.AddWithValue("@METHOD", methodbox.Text);
            cmd.Parameters.AddWithValue("@CARD_NUMBER", cardnumbox.Text);
            cmd.Parameters.AddWithValue("@EXPIRY_DATE", expirydate.Value);
            cmd.Parameters.AddWithValue("@TRANSACTION_DATE", Transctiondate.Value);
            cmd.ExecuteNonQuery();
            alconnection.Close();
            MessageBox.Show("Payment updated successfully.");
            dataGridView1.DataSource = retrievealtable();
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }
    }
}