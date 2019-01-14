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
    class Order : SQL
    {

        
        public void AddOrders(ref Label MealName, ref TextBox Number, ref Label Price, ref Label Resturant , ref TextBox Name)
        {
            int num = Int32.Parse(Number.Text);
            int pri = Int32.Parse(Price.Text);
            try
            {
                cmd = new SqlCommand("insert into Orders (Resturant,Meal,Price,Meals_Number,UserName)values('" + Resturant.Text + "','" + MealName.Text + "','" + pri + "','" + num + "','"+Name.Text+"')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Grid_Oreders(ref DataGridView view)
        {
            Da = new SqlDataAdapter("select ID,Resturant,Meal,Price,Meals_Number  from Orders ", cn);
            Dt = new DataTable();
            Da.Fill(Dt);
            view.DataSource = Dt;
        }
        public void DeleteOrders(ref TextBox ID)
        {

            int id = Int32.Parse(ID.Text);

            try
            {
                cmd = new SqlCommand("delete from Orders where ID = '" + id + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Calculate_Price(ref Label Price)
        {
            cmd = new SqlCommand("Select * from Orders", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            int sumPrice = 0;
            while (dr.Read())
            {
                int x = Int32.Parse(dr["Price"].ToString());
                int y = Int32.Parse(dr["Meals_Number"].ToString());
                sumPrice += (x * y);

            }
            Price.Text = sumPrice.ToString();
            dr.Close();
            cn.Close();
        }
        
            
        public void Otlob ()
        {
            cmd = new SqlCommand(" insert UserOrders select * from Orders ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        
        public void ClearOrders()
        {
            cmd = new SqlCommand("delete from Orders",cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void ClearComingOreders()
        {
            cmd = new SqlCommand("delete from ComingOrder", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Read_MyOrder(ref IDictionary<string, int> Rest)
        {
            cmd = new SqlCommand("select * from Orders", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int x;
                int price = (convert(dr["Price"].ToString()) * convert(dr["Meals_Number"].ToString()));
                if (Rest.TryGetValue(dr["Resturant"].ToString(), out x))
                {
                    Rest[dr["Resturant"].ToString()] += price;
                }
                else
                {
                    Rest.Add(dr["Resturant"].ToString(), price);
                }
            }
            dr.Close();
            cn.Close();

        }

        public void Delete_MyOrder(int id)
        {
            cmd = new SqlCommand("delete from ComingOrder where ID = '"+id+"'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Show_MyOrder( ref ListView list, ref ImageList img)
        {
            int size = sizeOfTable();

            cmd = new SqlCommand("select * from ComingOrder ", cn);
            cn.Open();
            dr = cmd.ExecuteReader();


            list.SmallImageList = img;
            int CNT = 0;
            int timenow = 0;
            DateTime time;
            time = DateTime.Now;
            timenow = (time.Hour * 60 ) + (time.Minute ) ;
            string min = " Minutes ";
           
            string[] rest = new string[size];
            string[] st = new string[size];
            string[] end = new string[size];
            string[] price = new string[size];
            int[] id = new int[size];
             int i = 0;
            while(dr.Read())
            {
                rest[i] = dr["Resturant"].ToString();
                st[i] = dr["StartTime"].ToString();
                end[i] = dr["EndTime"].ToString();
                price[i] = dr["Price"].ToString();
                id[i] = convert(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            cn.Close();
            Load picture = new Load();

            for (i = 0; i < size; i++)
            {
                int rem = 0;
                int startTime = convert(st[i]);
                if (startTime > timenow)
                    timenow += (24 * 60 * 60);
                int endTime = convert(end[i]);
                if(timenow>=endTime)
                {
                    MessageBox.Show("There is Order has been deliveried.");
                    Delete_MyOrder(id[i]);
                    continue;
                }
                rem = endTime - timenow;
                picture.Load_img_myorder(ref img, rest[i]);
                
                list.Items.Add(rest[i], CNT);
                list.Items[CNT].SubItems.Add(price[i]);
                list.Items[CNT].SubItems.Add(rem.ToString() + min);
                CNT++;
                
            }


        }
        public void Otlob_MyOrder(ref IDictionary<string, int> Rest)
        {
            Read_MyOrder(ref Rest);
            
            Random rnd = new Random();
            int timebymin = 0;
            DateTime time;
            time = DateTime.Now;
            timebymin = (time.Hour * 60 ) + (time.Minute ) ;

            foreach (KeyValuePair<string, int> item in Rest)
            {
                cmd = new SqlCommand("insert into ComingOrder (Resturant , Price , StartTime ,EndTime ) values ('"+item.Key+"','"+item.Value+"','"+timebymin+"','"+rnd.Next(timebymin+5,timebymin+61)+"')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }


        }


    }

    
}
