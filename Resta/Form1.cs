namespace Resta
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Авторизация";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "admin")
            {
                MainPage main = new MainPage();
                main.Show();
                this.Hide();
            }
            else if (textBox1.Text != "Admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text != "Admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
        }


    }
}