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
   
    public partial class Form1 : Form
    {
        
        BindingSource bd = new BindingSource();
        BindingSource bd2 = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
           
            City choose_city = new City();
            choose_city.Choose(ref ChooseCity);
            Order o = new Order();
            o.Calculate_Price(ref TPrice);
            
            o.ClearOrders();
            o.ClearComingOreders();
            o.Grid_Oreders(ref myOrder1.ViewOrder);
            
            
        }
        // uesrName TextBox
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (UserName.Text == "Enter your user name")
                UserName.Clear();
            UserName.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        // Password TextBox
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (Password.Text == "Enter your password")
                Password.Clear();

            Password.Font = new Font("Tahoma", 10, FontStyle.Bold);
            Password.PasswordChar = '*';
        }
        // sign_in button
        private void button1_Click(object sender, EventArgs e)
        {
            Sign_In sign = new Sign_In();
            sign.Sign_in(ref UserNameControl,ref UserName, ref Password, ref groupBox1, ref UserNameHi );
        }
        // sign up link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form2 f = new Form2();
            f.Show();
        }
        // City ComboBox.........
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            District ch = new District();
            ch.Choose(ref ChooseDistrict, ref ChooseCity);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {

            Rest.Visible = true;
            
            Show Go = new Show();
            Load PIC = new Load();
            Go.Resturant(ref RestName, ref RestPic, ref ChooseDistrict,ref bd );
            PIC.Resturant(ref RestPic, ref RestName);
            Go.Meal(ref ChooseDistrict, ref RestName, ref Meal_Name, ref Meal_Price, ref Details, ref Meal_Pic, ref bd2);
            PIC.Meal(ref Meal_Pic, ref Meal_Name);
        }


        //..........................................................
        //.............................................................
        //.............................................................
        private void Rest_Paint(object sender, PaintEventArgs e)
        {

        }
        //rest_Right click
        private void button3_Click(object sender, EventArgs e)
        {
            Show swap = new Show();
            Load PIC = new Load();
            swap.inc(ref bd , ref RestPic,ref RestName);
            PIC.Resturant(ref RestPic, ref RestName);
            swap.Meal(ref  ChooseDistrict, ref  RestName, ref  Meal_Name,  ref  Meal_Price, ref  Details, ref  Meal_Pic, ref  bd2);
            PIC.Meal(ref Meal_Pic, ref Meal_Name);

        }

        private void Left_rest_Click(object sender, EventArgs e)
        {
            Show swap = new Show();
            Load PIC = new Load();
            swap.dec(ref bd, ref RestPic, ref RestName);
            PIC.Resturant(ref RestPic, ref RestName);
            swap.Meal(ref ChooseDistrict, ref RestName, ref Meal_Name,  ref Meal_Price, ref Details, ref Meal_Pic, ref  bd2);
            PIC.Meal(ref Meal_Pic, ref Meal_Name);
        }
        // cancel order
        private void button2_Click(object sender, EventArgs e)
        {
            //
            DialogResult result = MessageBox.Show("Do You Need To Cancel Order .", "Cancel Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Order o = new Order();
                o.ClearOrders();
                o.Grid_Oreders(ref myOrder1.ViewOrder);
                Rest.Visible = false;
            }
           
        }
        //Otlop Click
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                MessageBox.Show("Please Sign In To Complete Order .");
            }
            

            else
            {
                if (AdressBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Adress To Complete Order .");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do You Need To Confirm Order .", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        IDictionary<string, int> list = new Dictionary<string, int>();
                        Order o = new Order();
                        o.Otlob();
                        o.Otlob_MyOrder(ref list);
                        Form5 f = new Form5();
                        f.Show();
                        o.ClearOrders();
                        o.Grid_Oreders(ref myOrder1.ViewOrder);
                        Rest.Visible = false;
                    }
                }
            }
           
        }
        //Meal_Left click
        private void button3_Click_1(object sender, EventArgs e)
        {
            Show swap = new Show();
            swap.dec(ref  bd2, ref  Meal_Pic, ref  Meal_Name);
            Load PIC = new Load();
            PIC.Meal(ref Meal_Pic, ref Meal_Name);


        }
        //Meal_Right_Click
        private void Right_Click(object sender, EventArgs e)
        {
            Show swap = new Show();
            swap.inc(ref  bd2, ref  Meal_Pic, ref  Meal_Name);
            Load PIC = new Load();
            PIC.Meal(ref Meal_Pic, ref Meal_Name);
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.AddOrders(ref Meal_Name, ref Meal_Number, ref Meal_Price, ref RestName , ref UserName);
            o.Grid_Oreders(ref myOrder1.ViewOrder);
            o.Calculate_Price(ref TPrice);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.DeleteOrders(ref ID_Delete);
            o.Grid_Oreders(ref myOrder1.ViewOrder);
            o.Calculate_Price(ref TPrice);
        }

        private void UserNameSet_Load(object sender, EventArgs e)
        {
            
        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void OldOrders_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(UserName);
            
            
            f.Show();
        }

        private void myOrder1_Load(object sender, EventArgs e)
        {

        }

        private void UserNameControl_Enter(object sender, EventArgs e)
        {

        }

        private void MyOrders_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }
    }
}