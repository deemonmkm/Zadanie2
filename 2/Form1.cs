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
            public int ticket_cost;
            public decimal number_seats;
        };
        planes plane;

        public decimal Time_dest(decimal a, decimal b)
        {
            return a + b;
        }
        public decimal Proceeds(decimal a, decimal b)
        {
            return a * b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plane.n_flight = comboBox1.Text;
            plane.b_time = numericUpDown1.Value;
            plane.time_on_way = numericUpDown2.Value;
            plane.n_flight = comboBox1.Text;
            plane.dest = comboBox2.Text;
            plane.type_plane = comboBox3.Text;
            plane.ticket_cost = Int32.Parse(textBox1.Text);
            plane.number_seats = numericUpDown3.Value;
            MessageBox.Show(
                "Номер рейса: " + plane.n_flight + "\n" +
                "Конечный пункт: " + plane.dest + "\n" +
                "Тип самолета: " + plane.type_plane + "\n" +
                "Стоимость билета: " + plane.ticket_cost + "\n" +
                "Количество мест: " + plane.number_seats + "\n" +
                "Время прилета: " + Time_dest(plane.b_time, plane.time_on_way).ToString() + "\n" +
                "Выручка от рейса: " + Proceeds(plane.ticket_cost, plane.number_seats).ToString() + "\n"
                );
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
