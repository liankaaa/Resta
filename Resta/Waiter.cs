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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уведомление отправлено");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            this.Text = "Связь с официантами";
        }
    }
}
