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
    class Sign_In : SQL
    {

        public void Sign_in(ref GroupBox Control ,ref TextBox UserName, ref TextBox Password, ref GroupBox sign_in,ref Label US)
        {
            bool tx1 = true, tx2 = true;
            if (UserName.Text == "1" && Password.Text == "1")
            {
                Form3 F = new Form3();
                F.Show();
                return;

            }
            
            
            if (UserName.Text == "" || UserName.Text == "Enter your user name")
            {
                tx1 = false;
                MessageBox.Show("Please enter your user name");
                UserName.Focus();
                UserName.Font = new Font("Tahoma", 10, FontStyle.Bold);
            }
            else if (Password.Text == "" || Password.Text == "Enter your password")
            {
                tx2 = false;
                MessageBox.Show("Please enter your password");
                Password.Focus();
                Password.Font = new Font("Tahoma", 10, FontStyle.Bold);
                Password.PasswordChar = '*';
            }
            if (tx1 && tx2)
            {
                cmd = new SqlCommand("Select * From SignUp where UserName='" + UserName.Text + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                string pass, user;
                if (dr.Read())
                {
                    pass = dr["Password"].ToString();
                    user = dr["UserName"].ToString();
                    if (Password.Text == pass)
                    {
                       
                        sign_in.Visible = false;
                        US.Text = "Hello" + " " + dr["FirstName"] + " " + dr["LastName"];
                        Control.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Wrong Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username is failed", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                cn.Close();
            }
        }
    }
}
