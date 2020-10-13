using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        struct planes
        {
            public string n_flight;
            public string dest;
            public decimal b_time;
            public decimal time_on_way;
            public string type_plane;
            public string ticket_cost;
            public string number_seats;
        };
        planes plane;

        public decimal Time_dest(decimal a, decimal b)
        {
            return a+b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plane.n_flight = comboBox1.Text;
            plane.b_time = numericUpDown1.Value;
            plane.time_on_way = numericUpDown2.Value;
            MessageBox.Show(Time_dest(plane.b_time, plane.time_on_way).ToString());
        }
    }
}
