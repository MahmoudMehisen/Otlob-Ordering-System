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
    class Show:SQL
    {
        public void Resturant(ref Label RestName, ref PictureBox RestPic, ref ComboBox ChooseDistrict, ref BindingSource bd)
        {

            Da = new SqlDataAdapter("Select * From Restaurants where District='" + ChooseDistrict.SelectedItem + "' ORDER BY Rate DESC", cn);
            Dt = new DataTable();
            ds = new DataSet();

            Da.Fill(ds);
            bd.DataSource = ds.Tables[0];

            RestName.DataBindings.Clear();
            RestName.DataBindings.Add("Text", bd, "Restaurant");
            


            RestPic.Image = null;
            


        }
        

        public void Meal(ref ComboBox ChooseDistrict, ref Label RestName, ref Label Meal_Name, ref Label Meal_Price, ref TextBox Details, ref PictureBox Meal_Pic, ref BindingSource bd2)
        {
            try
            {

                Da = new SqlDataAdapter("select * from Meals where District='" + ChooseDistrict.SelectedItem + "'and Restaurant='" + RestName.Text + "'", cn);
                ds = new DataSet();
                Da.Fill(ds);

                bd2.DataSource = ds.Tables[0];
                Meal_Name.DataBindings.Clear();
                Meal_Name.DataBindings.Add("Text", bd2, "Name");
                
                Meal_Price.DataBindings.Clear();
                Meal_Price.DataBindings.Add("Text", bd2, "Price");
                Details.DataBindings.Clear();
                Details.DataBindings.Add("Text", bd2, "Details");

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            Meal_Pic.Image = null;
            



        }

        public void inc(ref BindingSource bd2, ref PictureBox Meal_Pic, ref Label Meal_Name)
        {
            bd2.MoveNext();
            Meal_Pic.Image = null;
            
        }
        public void dec(ref BindingSource bd2, ref PictureBox Meal_Pic, ref Label Meal_Name)
        {
            bd2.MovePrevious();
            Meal_Pic.Image = null;
            
        }
        public void ShowOldOrder(ref DataGridView view, ref TextBox Name)
        {
            Da = new SqlDataAdapter("select ID,Resturant,Meal,Price,Meals_Number  from UserOrders where UserName='" + Name.Text + "' ", cn);
            Dt = new DataTable();
            Da.Fill(Dt);
            view.DataSource = Dt;
        }
    }
}

