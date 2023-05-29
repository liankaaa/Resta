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
    public partial class ReservTable : Form
    {
        public ReservTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter date = new StreamWriter("Data/data.txt");
            date.WriteLine(maskedTextBox1.Text, '\n');
            date.WriteLine(maskedTextBox2.Text, '\n');
            date.WriteLine(maskedTextBox3.Text, '\n');
            date.WriteLine(maskedTextBox4.Text, '\n');
            date.WriteLine(maskedTextBox5.Text, '\n');
            date.Close();
            MessageBox.Show("Записано!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReservTable_Load(object sender, EventArgs e)
        {
            this.Text = "Бронь стола";
        }
    }
}
