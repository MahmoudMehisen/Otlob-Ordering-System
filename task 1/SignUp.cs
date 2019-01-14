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
using System.IO;
using System.Drawing.Imaging;
namespace task_1
{
    class SignUp:SQL
    {
        public void s_up(ref TextBox FirstName, ref TextBox LastName, ref TextBox UserName, ref TextBox Password, ref TextBox Email, ref TextBox PhoneNumber)
        {
            bool status = true;
            if (FirstName.Text == "" || FirstName.Text == "Enter your first name" || LastName.Text == "" || LastName.Text == "Enter your last name" || UserName.Text == "" || UserName.Text == "Enter your user name" || Password.Text == "" || Password.Text == "Enter your password" || Email.Text == "" || Email.Text == "Example :user@gmail.com" || PhoneNumber.Text == "Enter your phone number")
            {
                MessageBox.Show("something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
            cmd = new SqlCommand("Select * From SignUp where UserName='" + UserName.Text + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("The Username is used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;

            }
            cn.Close();
            if (status)
            {
                cmd = new SqlCommand("insert into SignUp (FirstName,LastName,UserName,Password,Email,PhoneNumber) values('" + FirstName.Text + "','" + LastName.Text + "','" + UserName.Text + "','" + Password.Text + "','" + Email.Text + "','" + PhoneNumber.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("successful .");
            }
        }
    }
}
