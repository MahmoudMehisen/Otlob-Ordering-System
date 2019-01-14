using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace task_1
{
   
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
        // first name 
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Enter your first name")
                textBox1.Clear();
            textBox1.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }
        // last name
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Enter your last name")
                textBox2.Clear();
            textBox2.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }
        // user name
        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Enter your user name")
                textBox3.Clear();
            textBox3.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }
        // password 
        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "Enter your password")
                textBox4.Clear();
            textBox4.Font = new Font("Tahoma", 16, FontStyle.Bold);
            textBox4.PasswordChar = '*';
        }
        // Email
        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox6.Text == "Example :user@gmail.com")
                textBox6.Clear();
            textBox6.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //SignUp Button
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.s_up(ref textBox1, ref textBox2, ref textBox3, ref  textBox4, ref textBox6, ref textBox7);
        }
        //Phone number
        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox7.Text == "Enter your phone number")
                textBox7.Clear();
            textBox7.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }
        //Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
