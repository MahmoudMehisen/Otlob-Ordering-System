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
    class District:SQL
    {
        public void Add(ref TextBox District, ref ComboBox City)
        {
            try
            {
                cmd = new SqlCommand("insert into Districts (City,District) values ('" + City.SelectedItem + "' , '" + District.Text + "' ) ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");


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
        public void Delete(ref ComboBox District)
        {
            try
            {
                cmd = new SqlCommand("Delete from Districts where District='" + District.SelectedItem + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Done.");


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
        public void Choose(ref ComboBox ChooseDistrict, ref ComboBox ChooseCity)
        {
            cmd = new SqlCommand("Select District from Districts where City='" + ChooseCity.SelectedItem + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            ChooseDistrict.Items.Clear();
            while (dr.Read())
            {
                ChooseDistrict.Items.Add(dr["District"]);
            }
            dr.Close();
            cn.Close();
        }


    }
}
