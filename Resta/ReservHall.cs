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
    public partial class ReservHall : Form
    {
        public ReservHall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter date1 = new StreamWriter("Data/data1.txt");
            date1.WriteLine(maskedTextBox1.Text, '\n');
            date1.WriteLine(maskedTextBox2.Text, '\n');
            date1.WriteLine(maskedTextBox3.Text, '\n');
            date1.WriteLine(comboBox1.Text, '\n');
            date1.WriteLine(maskedTextBox5.Text, '\n');
            date1.Close();
            MessageBox.Show("Записано!");
        }

        private void ReservHall_Load(object sender, EventArgs e)
        {
            this.Text = "Бронь зала";
        }
    }
}
