using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt_phase_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            trip.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservation reserv = new Reservation();
            reserv.Show();
        }
    }
}
