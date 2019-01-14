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
    class City:SQL
    {

        public void Add(ref TextBox City_Name, ref ComboBox City_delete, ref ComboBox City_distict, ref ComboBox City_resturant)
        {
            try
            {
                cmd = new SqlCommand("insert into Cities (City) values ('" + City_Name.Text + "') ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");
                City_delete.Items.Add(City_Name.Text);
                City_distict.Items.Add(City_Name.Text);
                City_resturant.Items.Add(City_Name.Text);
                City_delete.Refresh();
                City_distict.Refresh();
                City_resturant.Refresh();
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                cn.Close();
            }
        }

        public void Delete(ref ComboBox City_delete, ref ComboBox City_distict, ref ComboBox City_resturant)
        {
            try
            {
                cmd = new SqlCommand("Delete from Cities where City='" + City_delete.SelectedItem + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Done.");
                City_distict.Items.Remove(City_delete.SelectedItem);
                City_resturant.Items.Remove(City_delete.SelectedItem);
                City_delete.Items.Remove(City_delete.SelectedItem);
                City_delete.Refresh();
                City_distict.Refresh();
                City_resturant.Refresh();

            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                cn.Close();
            }
        }
        public void Choose(ref ComboBox ChooseCity)
        {
            cmd = new SqlCommand("Select * from Cities", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChooseCity.Items.Add(dr["City"]);

            }
            dr.Close();
            cn.Close();
        }
    }
}
