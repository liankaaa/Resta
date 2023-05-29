using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resta
{
    public partial class MainPage : Form
    {

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Text = "Главная страница";
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Personal pers = new Personal();
            pers.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservTable table = new ReservTable();
            table.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("Data/data.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservHall hall = new ReservHall();
            hall.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Waiter waiter = new Waiter();
            waiter.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shipment ship = new Shipment();
            ship.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = File.ReadAllText("Data/data1.txt");
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        public Waiter Waiter
        {
            get => default;
            set
            {
            }
        }

        public ReservTable ReservTable
        {
            get => default;
            set
            {
            }
        }

        public Personal Personal
        {
            get => default;
            set
            {
            }
        }

        public Shipment Shipment
        {
            get => default;
            set
            {
            }
        }

        public ReservHall ReservHall
        {
            get => default;
            set
            {
            }
        }
    }
}
